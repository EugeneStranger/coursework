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
    public partial class MainForm : Form
    {
        string connectionString;
        SqlConnection connection;
        DataTable table;
        SqlDataReader reader;
        SqlCommand command;
        //int id { get; set; }
        public MainForm()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadWorks();
            dateTimePickerBegin.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
            LoadCars();
            dataGridViewCars.Columns[0].Visible = false;
            LoadOwners();
            dataGridViewOwners.Columns[0].Visible = false;
            LoadWorkers();
            dataGridViewWorker.Columns[0].Visible = false;
        }

        void LoadWorks(string condition = null)
        {
            connection.Open();
            string cmd = $@"
SELECT
        [Номер заказа]                      = works_id,
        [Работа]                            = work_description,
        [Автомобиль]                        = FORMATMESSAGE('%s %s %s', manufacturer, model, registration_number),
        [Дата заказа]                       = FORMAT(date_begin, 'dd.MM.yyyy'),
        [Срок выполнения заказа]            = FORMAT(final_date, 'dd.MM.yyyy'),
        [Дата Выполнения]                   = FORMAT(date_end, 'dd.MM.yyyy'),
        [Работник]                          = FORMATMESSAGE('%s %s %s', Workers.last_name, Workers.first_name, Workers.middle_name),
        [Стоимость работы]                  = WorksList.Price * Cars.coef,
        [Расходные материалы]               = consumables,
        [Стоимость расходных материалов]    = consumables_price,
        [Общая стоимость работ]             = WorksList.Price * Cars.coef+consumables_price
FROM    Works, WorksList, Cars, Workers
WHERE   Works.[work] = WorksList.work_id
AND     Works.worker = Workers.worker_id
AND     Works.car    = Cars.car_id
            ";
            if (condition != null)
            {
                cmd += $" AND {condition}";
            }
            SqlCommand command = new SqlCommand(cmd, connection);
            reader = command.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));
            }
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                table.Rows.Add(row);
            }
            dataGridViewWorks.DataSource = table;
            connection.Close();
        }

        void LoadCars(string condition = null)
        {
            connection.Open();
            string cmd = $@"
SELECT
        [id]                         = car_id,
        [Марка]                      = manufacturer,
        [Модель]                     = model,
        [Номер автомобиля]           = registration_number,
        [Владелец]                   = FORMATMESSAGE('%s %s %s', Owners.last_name, Owners.first_name, Owners.middle_name),
        [Год выпуска]                = FORMAT(date_of_issue, 'dd.MM.yyyy')
FROM    Cars, Owners
WHERE   Cars.Owner = Owners.owner_id
            ";
            if (condition != null)
            {
                cmd += $" AND {condition}";
            }
            SqlCommand command = new SqlCommand(cmd, connection);
            reader = command.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));
            }
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                table.Rows.Add(row);
            }
            dataGridViewCars.DataSource = table;
            connection.Close();
        }
        void LoadOwners(string condition = null)
        {
            connection.Open();
            string cmd = $@"
SELECT
        [id]            = owner_id,
        [Фамилия]       = last_name,
        [Имя]           = first_name,
        [Отчество]      = middle_name
FROM    Owners
            ";
            if (condition != null)
            {
                cmd += $" AND {condition}";
            }
            SqlCommand command = new SqlCommand(cmd, connection);
            reader = command.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));
            }
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                table.Rows.Add(row);
            }
            dataGridViewOwners.DataSource = table;
            connection.Close();
        }
        void LoadWorkers(string condition = null)
        {
            connection.Open();
            string cmd = $@"
SELECT
        [id]            = worker_id,
        [Фамилия]       = last_name,
        [Имя]           = first_name,
        [Отчество]      = middle_name
FROM    Workers
            ";
            if (condition != null)
            {
                cmd += $" AND {condition}";
            }
            SqlCommand command = new SqlCommand(cmd, connection);
            reader = command.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));
            }
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                table.Rows.Add(row);
            }
            dataGridViewWorker.DataSource = table;
            connection.Close();
        }
        public void LoadDataToComboBox
            (
            System.Windows.Forms.ComboBox comboBox,
            string sourceTable,
            string sourceColumn,
            string invite = "Выберите значение",
            string condition = null
            )
        {
            string commandLine = $@"SELECT {sourceColumn} FROM {sourceTable} ";
            if (condition != null) commandLine += condition;
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            if (invite != "") comboBox.Items.Add(invite);
            while (reader.Read())
            {
                comboBox.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
            comboBox.SelectedItem = invite;
        }
        public void LoadFIOToComboBox
            (
            System.Windows.Forms.ComboBox comboBox,
            string sourceTable,
            string sourceLN,
            string sourceFN,
            string sourceMN,
            string invite = "Выберите значение",
            string condition = null
            )
        {
            string commandLine = $@"SELECT FORMATMESSAGE('%s %s %s', {sourceLN}, {sourceFN}, {sourceMN}) FROM {sourceTable} ";
            if (condition != null) commandLine += condition;
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            if (invite != "") comboBox.Items.Add(invite);
            while (reader.Read())
            {
                comboBox.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
            comboBox.SelectedItem = invite;
        }

        private void buttonInWork_Click(object sender, EventArgs e)
        {
            LoadWorks("Works.date_end IS NULL");
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            LoadWorks("Works.date_end < GETDATE()");
        }

        private void buttonOverdue_Click(object sender, EventArgs e)
        {
            LoadWorks("(Works.date_end > Works.final_date OR (Works.date_end IS NULL AND Works.final_date < GETDATE()-1))");
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            if (dateTimePickerBegin.Value <= dateTimePickerEnd.Value)
            {
                String date_begin = dateTimePickerBegin.Value.ToString();
                String date_end = dateTimePickerEnd.Value.ToString();
                LoadWorks($"Works.date_begin >= CONVERT(date,'{date_begin}',104) AND Works.date_begin <= CONVERT(date,'{date_end}',104)");  
            }
        }

        private void dataGridViewWorks_DataSourceChanged(object sender, EventArgs e)
        {
            Double sum = 0;
            for (int i = 0; i < dataGridViewWorks.RowCount; i++)
                sum += Convert.ToDouble(dataGridViewWorks[7,i].Value)+ Convert.ToDouble(dataGridViewWorks[9, i].Value);
            toolStripStatusSum.Text = "Стоимость выбранных заказов: " + sum.ToString();
            toolStripStatusLabelCount.Text = $"Количество выбранных заказов: {dataGridViewWorks.RowCount - 1}";
        }

        private void buttonAddWork_Click(object sender, EventArgs e)
        {
            AddWork add_work = new AddWork(this);
            DialogResult result = add_work.ShowDialog();
            LoadWorks();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            //if (dataGridViewWorks.SelectedRows != 0)
            int id = Convert.ToInt32(dataGridViewWorks.SelectedCells[0].Value);
            WorkUpdate work_update = new WorkUpdate(this, id);
            DialogResult result = work_update.ShowDialog();
            LoadWorks();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            LoadWorks();
        }

        private void buttonDeleteWork_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewWorks.SelectedCells[0].Value);

            DialogResult dialogResult = MessageBox.Show(this,"Удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string cmd = $@"
DELETE Works
WHERE  works_id = '{id}'
                ";
                connection.Open();
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                connection.Close();
                LoadWorks();
            }

        }

        private void buttonFindCar_Click(object sender, EventArgs e)
        {
            LoadCars($"Cars.registration_number = '{textBoxRegistrationNumber.Text}'");
        }

        private void buttonAllCars_Click(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void buttonCarChange_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewCars.SelectedCells[0].Value);
            CarUpdate car_update = new CarUpdate(this, id);
            DialogResult result = car_update.ShowDialog();
            LoadCars();
        }

        private void buttonCarAdd_Click(object sender, EventArgs e)
        {
            AddCar add_car = new AddCar();
            DialogResult result = add_car.ShowDialog();
            LoadWorks();
        }

        private void dataGridViewOwners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
