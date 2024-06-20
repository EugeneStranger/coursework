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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Car_Service
{

    public partial class WorkUpdate : Form
    {
        MainForm mainForm;
        private string connectionString;
        SqlConnection connection;
        int work_id;
        public WorkUpdate(MainForm mainForm, int id)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.Text = $"Заказ {id}";
            labelWorkUpdate.Text = $"Редактирование заказа номер {id}";
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            mainForm.LoadFIOToComboBox(comboBoxWorkerUpdate, "Workers", "last_name", "first_name", "middle_name", "Выберите работника");
            work_id = id;
        }
        public int GetIDWorker(string full_name)
        {
            int id = 0;
            string[] fullname = full_name.Split(' ');

            connection.Open();
            string cmd = $@"
            SELECT worker_id FROM  Workers
            WHERE last_name = '{fullname[0]}'  
            AND   first_name = '{fullname[1]}'
            AND   middle_name = '{fullname[2]}'
                        ";
            SqlCommand command = new SqlCommand(cmd, connection);
            id = (int)command.ExecuteScalar();
            connection.Close();
            return id;
        }

        private void buttonWorksUpdate_Click(object sender, EventArgs e)
        {
            string cmd;
            if (radioButtonDateEnd.Checked == true)
            {
                cmd = $@"
UPDATE  Works
SET     date_end = CONVERT(date,'{dateTimePickerDateEnd.Value}',104)
WHERE   works_id = {work_id}
                ";
                connection.Open();
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            if (comboBoxWorkerUpdate.SelectedIndex != 0)
            {
                cmd = $@"
UPDATE  Works
SET     worker = {GetIDWorker(comboBoxWorkerUpdate.Text)}
WHERE   works_id = {work_id}
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
