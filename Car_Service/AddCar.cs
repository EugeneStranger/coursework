using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Service
{
    public partial class AddCar : Form
    {
        MainForm mainForm;
        private string connectionString;
        SqlConnection connection;
        public AddCar()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string cmd;
            cmd = $@"
                 IF NOT EXISTS (SELECT owner_id FROM Owners 
                 WHERE last_name = '{textBoxLastName.Text}'
                 AND first_name = '{textBoxFirstName.Text}'
                 AND middle_name = '{textBoxMiddleName.Text}'
                 AND phone       = '{maskedTextBoxPhone.Text}')
                 BEGIN
                    INSERT INTO 
                    Owners (last_name, first_name, middle_name, phone)
                    VALUES ('{textBoxLastName.Text}', '{textBoxFirstName.Text}', '{textBoxMiddleName.Text}', '{maskedTextBoxPhone.Text}')
                END
";
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
            cmd = $@"
                IF NOT EXISTS
                (SELECT car_id FROM Cars 
                 WHERE registration_number = '{maskedTextBoxNumber.Text}')
                BEGIN
                DECLARE @owner INT = (SELECT owner_id FROM Owners
                                  WHERE last_name = '{textBoxLastName.Text}'
                                  AND   first_name = '{textBoxFirstName.Text}'
                                  AND   middle_name = '{textBoxMiddleName.Text}'
                                  AND   phone       = '{maskedTextBoxPhone.Text}')
                INSERT INTO 
                    Cars (manufacturer, model, registration_number, owner, date_of_issue, coef)
                    VALUES ('{textBoxManufacture.Text}',
                            '{textBoxModel.Text}',
                            '{maskedTextBoxNumber.Text}',
                            @owner,
                            CONVERT(date,'{dateTimePickerIssue.Value}',104),
                            CONVERT(float,'{textBoxCoef.Text}')
                    )
                END
                ";
            connection.Open();
            command = new SqlCommand(cmd, connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {

        }
    }
}
