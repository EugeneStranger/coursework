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
    public partial class AddWork : Form
    {
        MainForm mainForm;
        private string connectionString;
        SqlConnection connection;
        public System.Windows.Forms.ComboBox CBWork { get => comboBoxWork; }
        public System.Windows.Forms.ComboBox CBCar { get => comboBoxCar; }
        public System.Windows.Forms.ComboBox CBWorker { get => comboBoxWorker; }
        public AddWork(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            //GetDataFromBase();
            mainForm.LoadDataToComboBox(comboBoxWork, "WorksList", "work_description", "Выберите вид работ");
            mainForm.LoadDataToComboBox(comboBoxCar, "Cars", "registration_number", "Выберите автомобиль по номеру");
            mainForm.LoadFIOToComboBox(comboBoxWorker, "Workers", "last_name", "first_name", "middle_name", "Выберите работника");
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
                        SqlCommand command = new SqlCommand(cmd,connection);
                        id = (int)command.ExecuteScalar();
            connection.Close();
        return id;
        }
        public int GetCarID(string number)
        {
            int id = 0;
            connection.Open();
            string cmd = $@"
            SELECT car_id FROM  Cars
            WHERE registration_number = '{number}'  
                        ";
            SqlCommand command = new SqlCommand(cmd, connection);
            id = (int)command.ExecuteScalar();
            connection.Close();
            return id;
        }
        void GetDataFromBase()
        {
            //try
            //{
            //    set = new DataSet();
            //    string cmd = $@"SELECT * FROM WorksList";
            //    adapter = new SqlDataAdapter(cmd, connection);
            //    builder = new SqlCommandBuilder(adapter);
            //    adapter.Fill(set, "WorkList");

            //    adapter.SelectCommand.CommandText = $@"SELECT * FROM Cars";
            //    builder.DataAdapter = adapter;
            //    adapter.Fill(set, "Cars");

            //    adapter.SelectCommand.CommandText = $@"SELECT * FROM Workers";
            //    builder.DataAdapter = adapter;
            //    adapter.Fill(set, "Workers");
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(this, e.Message);
            //}
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (comboBoxWork.SelectedIndex == 0 || comboBoxCar.SelectedIndex == 0 || comboBoxWorker.SelectedIndex == 0) 
                check = false;
            if (check)
            {
                string cmd = $@"
                INSERT INTO 
                    Works (work, date_begin, final_date, car, worker)
                    VALUES ((SELECT work_id FROM WorksList WHERE work_description = '{comboBoxWork.Text}'),
                            CONVERT(date,'{dateTimePickerBegin.Value}',104),
                            CONVERT(date,'{dateTimePickerFinal.Value}',104),
                            '{GetCarID(comboBoxCar.Text)}',
                            '{GetIDWorker(comboBoxWorker.Text)}')
                ";
                connection.Open();
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
        }
    }
}
