using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Car_Service
{
    public partial class CarUpdate : Form
    {
        MainForm mainForm;
        private string connectionString;
        SqlConnection connection;
        int car_id;
        public CarUpdate(MainForm mainForm, int id)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            car_id = id;
        }

        private void buttonChangeCar_Click(object sender, EventArgs e)
        {
            string cmd;
            if (radioButtonNumber.Checked == true)
            {
                cmd = $@"
                UPDATE  Cars
                SET     Cars.registration_number = '{textBoxNumber.Text}'
                WHERE   car_id = {car_id}
                ";
                connection.Open();
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            if (radioButtonOwner.Checked == true)
            {
                cmd = $@"
                 IF NOT EXISTS (SELECT owner_id FROM Owners 
                 WHERE last_name = '{textBoxLastName.Text}'
                 AND first_name = '{textBoxFirstName.Text}'
                 AND middle_name = '{textBoxMiddleName.Text}')
                 BEGIN
                    INSERT INTO 
                    Owners (last_name, first_name, middle_name)
                    VALUES ('{textBoxLastName.Text}', '{textBoxFirstName.Text}', '{textBoxMiddleName.Text}')
                END
                DECLARE @owner INT = (SELECT owner_id FROM Owners
                                  WHERE last_name = '{textBoxLastName.Text}'
                                  AND   first_name = '{textBoxFirstName.Text}'
                                  AND   middle_name = '{textBoxMiddleName.Text}')
                UPDATE  Cars
                SET     Cars.owner = @owner
                WHERE   car_id = {car_id}
                ";
                connection.Open();
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            this.Close();
        }
    }
}
