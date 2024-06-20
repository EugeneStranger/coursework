namespace Car_Service
{
    partial class AddWork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxWork = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelDateBegin = new System.Windows.Forms.Label();
            this.labelFinalDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxWork
            // 
            this.comboBoxWork.FormattingEnabled = true;
            this.comboBoxWork.Location = new System.Drawing.Point(13, 13);
            this.comboBoxWork.Name = "comboBoxWork";
            this.comboBoxWork.Size = new System.Drawing.Size(277, 21);
            this.comboBoxWork.TabIndex = 0;
            this.comboBoxWork.Text = "Вид работы";
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Location = new System.Drawing.Point(13, 61);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(277, 20);
            this.dateTimePickerBegin.TabIndex = 1;
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Location = new System.Drawing.Point(12, 115);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(277, 20);
            this.dateTimePickerFinal.TabIndex = 2;
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.Location = new System.Drawing.Point(12, 141);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new System.Drawing.Size(277, 21);
            this.comboBoxCar.TabIndex = 3;
            this.comboBoxCar.Text = "Выберите автомобиль";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(323, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(8, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(12, 169);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(277, 21);
            this.comboBoxWorker.TabIndex = 5;
            this.comboBoxWorker.Text = "Выберите работника";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 197);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(277, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить заказ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelDateBegin
            // 
            this.labelDateBegin.AutoSize = true;
            this.labelDateBegin.Location = new System.Drawing.Point(13, 41);
            this.labelDateBegin.Name = "labelDateBegin";
            this.labelDateBegin.Size = new System.Drawing.Size(166, 13);
            this.labelDateBegin.TabIndex = 7;
            this.labelDateBegin.Text = "Введите дату принятия заказа:";
            // 
            // labelFinalDate
            // 
            this.labelFinalDate.AutoSize = true;
            this.labelFinalDate.Location = new System.Drawing.Point(13, 99);
            this.labelFinalDate.Name = "labelFinalDate";
            this.labelFinalDate.Size = new System.Drawing.Size(136, 13);
            this.labelFinalDate.TabIndex = 8;
            this.labelFinalDate.Text = "Срок выполнения заказа";
            // 
            // AddWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 230);
            this.Controls.Add(this.labelFinalDate);
            this.Controls.Add(this.labelDateBegin);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxWorker);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxCar);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.dateTimePickerBegin);
            this.Controls.Add(this.comboBoxWork);
            this.Name = "AddWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWork;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelDateBegin;
        private System.Windows.Forms.Label labelFinalDate;
    }
}