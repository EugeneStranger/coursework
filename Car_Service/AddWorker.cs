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
    public partial class AddWorker : Form
    {
        private string connectionString;
        SqlConnection connection;
        public AddWorker()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            string cmd;
            bool check = false;
            if(textBoxFirstName.Text != "" & textBoxLastName.Text != "" & maskedTextBoxNumber.Text !="") check = true;
            if (check)
            {
                cmd = $@"
                 IF NOT EXISTS (SELECT Workers.worker_id FROM Workers 
                 WHERE last_name = '{textBoxLastName.Text}'
                 AND first_name = '{textBoxFirstName.Text}'
                 AND middle_name = '{textBoxMiddleName.Text}'
                 AND passport_number = '{maskedTextBoxNumber.Text}')
                 BEGIN
                    INSERT INTO 
                    Workers (last_name, first_name, middle_name, passport_number)
                    VALUES ('{textBoxLastName.Text}', '{textBoxFirstName.Text}', '{textBoxMiddleName.Text}', '{maskedTextBoxNumber.Text}')
                END
";
                connection.Open();
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
         
            }
        }

        private void AddWorker_Load(object sender, EventArgs e)
        {

        }
    }
}
