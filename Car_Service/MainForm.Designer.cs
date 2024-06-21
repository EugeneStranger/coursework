namespace Car_Service
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageWorks = new System.Windows.Forms.TabPage();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonDeleteWork = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonAddWork = new System.Windows.Forms.Button();
            this.buttonPeriod = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.buttonOverdue = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonInWork = new System.Windows.Forms.Button();
            this.dataGridViewWorks = new System.Windows.Forms.DataGridView();
            this.tabPageCars = new System.Windows.Forms.TabPage();
            this.buttoncSelectedCar = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.buttonCarAdd = new System.Windows.Forms.Button();
            this.buttonCarChange = new System.Windows.Forms.Button();
            this.buttonAllCars = new System.Windows.Forms.Button();
            this.buttonFindCar = new System.Windows.Forms.Button();
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.tabPageOwners = new System.Windows.Forms.TabPage();
            this.buttonAllOwners = new System.Windows.Forms.Button();
            this.buttonOwnerCars = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonFindOwner = new System.Windows.Forms.Button();
            this.dataGridViewOwners = new System.Windows.Forms.DataGridView();
            this.tabPageWorker = new System.Windows.Forms.TabPage();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.buttonWorkerWorks = new System.Windows.Forms.Button();
            this.dataGridViewWorker = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPageWorks.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorks)).BeginInit();
            this.tabPageCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.tabPageOwners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwners)).BeginInit();
            this.tabPageWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageWorks);
            this.tabControl.Controls.Add(this.tabPageCars);
            this.tabControl.Controls.Add(this.tabPageOwners);
            this.tabControl.Controls.Add(this.tabPageWorker);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(939, 527);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageWorks
            // 
            this.tabPageWorks.Controls.Add(this.buttonAll);
            this.tabPageWorks.Controls.Add(this.buttonDeleteWork);
            this.tabPageWorks.Controls.Add(this.buttonChange);
            this.tabPageWorks.Controls.Add(this.statusStrip);
            this.tabPageWorks.Controls.Add(this.buttonAddWork);
            this.tabPageWorks.Controls.Add(this.buttonPeriod);
            this.tabPageWorks.Controls.Add(this.dateTimePickerEnd);
            this.tabPageWorks.Controls.Add(this.dateTimePickerBegin);
            this.tabPageWorks.Controls.Add(this.buttonOverdue);
            this.tabPageWorks.Controls.Add(this.buttonFinish);
            this.tabPageWorks.Controls.Add(this.buttonInWork);
            this.tabPageWorks.Controls.Add(this.dataGridViewWorks);
            this.tabPageWorks.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorks.Name = "tabPageWorks";
            this.tabPageWorks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorks.Size = new System.Drawing.Size(931, 501);
            this.tabPageWorks.TabIndex = 0;
            this.tabPageWorks.Text = "Заказы";
            this.tabPageWorks.UseVisualStyleBackColor = true;
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(315, 67);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(288, 23);
            this.buttonAll.TabIndex = 13;
            this.buttonAll.Text = "Показать все заказы";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonDeleteWork
            // 
            this.buttonDeleteWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteWork.Location = new System.Drawing.Point(668, 66);
            this.buttonDeleteWork.Name = "buttonDeleteWork";
            this.buttonDeleteWork.Size = new System.Drawing.Size(257, 23);
            this.buttonDeleteWork.TabIndex = 12;
            this.buttonDeleteWork.Text = "Удалить заказ";
            this.buttonDeleteWork.UseVisualStyleBackColor = true;
            this.buttonDeleteWork.Click += new System.EventHandler(this.buttonDeleteWork_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChange.Location = new System.Drawing.Point(668, 36);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(257, 23);
            this.buttonChange.TabIndex = 10;
            this.buttonChange.Text = "Редактировать заказ";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusSum,
            this.toolStripStatusLabelCount});
            this.statusStrip.Location = new System.Drawing.Point(3, 476);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(925, 22);
            this.statusStrip.TabIndex = 9;
            // 
            // toolStripStatusSum
            // 
            this.toolStripStatusSum.Name = "toolStripStatusSum";
            this.toolStripStatusSum.Size = new System.Drawing.Size(184, 17);
            this.toolStripStatusSum.Text = "Стоимость выбранных заказов: ";
            // 
            // toolStripStatusLabelCount
            // 
            this.toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            this.toolStripStatusLabelCount.Size = new System.Drawing.Size(186, 17);
            this.toolStripStatusLabelCount.Text = "Количество выбранных заказов:";
            // 
            // buttonAddWork
            // 
            this.buttonAddWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddWork.Location = new System.Drawing.Point(668, 6);
            this.buttonAddWork.Name = "buttonAddWork";
            this.buttonAddWork.Size = new System.Drawing.Size(257, 23);
            this.buttonAddWork.TabIndex = 8;
            this.buttonAddWork.Text = "Добавить заказ";
            this.buttonAddWork.UseVisualStyleBackColor = true;
            this.buttonAddWork.Click += new System.EventHandler(this.buttonAddWork_Click);
            // 
            // buttonPeriod
            // 
            this.buttonPeriod.Location = new System.Drawing.Point(315, 7);
            this.buttonPeriod.Name = "buttonPeriod";
            this.buttonPeriod.Size = new System.Drawing.Size(288, 23);
            this.buttonPeriod.TabIndex = 7;
            this.buttonPeriod.Text = "Показать все заказы за период";
            this.buttonPeriod.UseVisualStyleBackColor = true;
            this.buttonPeriod.Click += new System.EventHandler(this.buttonPeriod_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(315, 39);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerEnd.TabIndex = 6;
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Location = new System.Drawing.Point(462, 39);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerBegin.TabIndex = 5;
            // 
            // buttonOverdue
            // 
            this.buttonOverdue.Location = new System.Drawing.Point(7, 67);
            this.buttonOverdue.Name = "buttonOverdue";
            this.buttonOverdue.Size = new System.Drawing.Size(205, 23);
            this.buttonOverdue.TabIndex = 3;
            this.buttonOverdue.Text = "Просроченные заказы";
            this.buttonOverdue.UseVisualStyleBackColor = true;
            this.buttonOverdue.Click += new System.EventHandler(this.buttonOverdue_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(7, 37);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(205, 23);
            this.buttonFinish.TabIndex = 2;
            this.buttonFinish.Text = "Выполненные заказы";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonInWork
            // 
            this.buttonInWork.Location = new System.Drawing.Point(7, 7);
            this.buttonInWork.Name = "buttonInWork";
            this.buttonInWork.Size = new System.Drawing.Size(205, 23);
            this.buttonInWork.TabIndex = 1;
            this.buttonInWork.Text = "Заказы в работе";
            this.buttonInWork.UseVisualStyleBackColor = true;
            this.buttonInWork.Click += new System.EventHandler(this.buttonInWork_Click);
            // 
            // dataGridViewWorks
            // 
            this.dataGridViewWorks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewWorks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorks.Location = new System.Drawing.Point(6, 96);
            this.dataGridViewWorks.Name = "dataGridViewWorks";
            this.dataGridViewWorks.Size = new System.Drawing.Size(919, 370);
            this.dataGridViewWorks.TabIndex = 0;
            this.dataGridViewWorks.DataSourceChanged += new System.EventHandler(this.dataGridViewWorks_DataSourceChanged);
            // 
            // tabPageCars
            // 
            this.tabPageCars.Controls.Add(this.buttoncSelectedCar);
            this.tabPageCars.Controls.Add(this.maskedTextBoxNumber);
            this.tabPageCars.Controls.Add(this.buttonCarAdd);
            this.tabPageCars.Controls.Add(this.buttonCarChange);
            this.tabPageCars.Controls.Add(this.buttonAllCars);
            this.tabPageCars.Controls.Add(this.buttonFindCar);
            this.tabPageCars.Controls.Add(this.dataGridViewCars);
            this.tabPageCars.Location = new System.Drawing.Point(4, 22);
            this.tabPageCars.Name = "tabPageCars";
            this.tabPageCars.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCars.Size = new System.Drawing.Size(931, 501);
            this.tabPageCars.TabIndex = 1;
            this.tabPageCars.Text = "Автомобили";
            this.tabPageCars.UseVisualStyleBackColor = true;
            // 
            // buttoncSelectedCar
            // 
            this.buttoncSelectedCar.Location = new System.Drawing.Point(7, 34);
            this.buttoncSelectedCar.Name = "buttoncSelectedCar";
            this.buttoncSelectedCar.Size = new System.Drawing.Size(252, 23);
            this.buttoncSelectedCar.TabIndex = 7;
            this.buttoncSelectedCar.Text = "Показать заказы на выбранный автомобиль";
            this.buttoncSelectedCar.UseVisualStyleBackColor = true;
            this.buttoncSelectedCar.Click += new System.EventHandler(this.buttoncSelectedCar_Click);
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(357, 35);
            this.maskedTextBoxNumber.Mask = "L000LL009";
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(168, 20);
            this.maskedTextBoxNumber.TabIndex = 6;
            // 
            // buttonCarAdd
            // 
            this.buttonCarAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCarAdd.Location = new System.Drawing.Point(627, 31);
            this.buttonCarAdd.Name = "buttonCarAdd";
            this.buttonCarAdd.Size = new System.Drawing.Size(298, 23);
            this.buttonCarAdd.TabIndex = 5;
            this.buttonCarAdd.Text = "Добавить Автомобиль";
            this.buttonCarAdd.UseVisualStyleBackColor = true;
            this.buttonCarAdd.Click += new System.EventHandler(this.buttonCarAdd_Click);
            // 
            // buttonCarChange
            // 
            this.buttonCarChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCarChange.Location = new System.Drawing.Point(627, 6);
            this.buttonCarChange.Name = "buttonCarChange";
            this.buttonCarChange.Size = new System.Drawing.Size(298, 23);
            this.buttonCarChange.TabIndex = 4;
            this.buttonCarChange.Text = "Изменить данные об автомобиле";
            this.buttonCarChange.UseVisualStyleBackColor = true;
            this.buttonCarChange.Click += new System.EventHandler(this.buttonCarChange_Click);
            // 
            // buttonAllCars
            // 
            this.buttonAllCars.Location = new System.Drawing.Point(7, 7);
            this.buttonAllCars.Name = "buttonAllCars";
            this.buttonAllCars.Size = new System.Drawing.Size(252, 23);
            this.buttonAllCars.TabIndex = 3;
            this.buttonAllCars.Text = "Показать все автомобили";
            this.buttonAllCars.UseVisualStyleBackColor = true;
            this.buttonAllCars.Click += new System.EventHandler(this.buttonAllCars_Click);
            // 
            // buttonFindCar
            // 
            this.buttonFindCar.Location = new System.Drawing.Point(357, 7);
            this.buttonFindCar.Name = "buttonFindCar";
            this.buttonFindCar.Size = new System.Drawing.Size(168, 23);
            this.buttonFindCar.TabIndex = 1;
            this.buttonFindCar.Text = "Поиск автомобиля по номеру";
            this.buttonFindCar.UseVisualStyleBackColor = true;
            this.buttonFindCar.Click += new System.EventHandler(this.buttonFindCar_Click);
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(4, 60);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.Size = new System.Drawing.Size(924, 435);
            this.dataGridViewCars.TabIndex = 0;
            // 
            // tabPageOwners
            // 
            this.tabPageOwners.Controls.Add(this.buttonAllOwners);
            this.tabPageOwners.Controls.Add(this.buttonOwnerCars);
            this.tabPageOwners.Controls.Add(this.textBoxLastName);
            this.tabPageOwners.Controls.Add(this.buttonFindOwner);
            this.tabPageOwners.Controls.Add(this.dataGridViewOwners);
            this.tabPageOwners.Location = new System.Drawing.Point(4, 22);
            this.tabPageOwners.Name = "tabPageOwners";
            this.tabPageOwners.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOwners.Size = new System.Drawing.Size(931, 501);
            this.tabPageOwners.TabIndex = 2;
            this.tabPageOwners.Text = "Владельцы";
            this.tabPageOwners.UseVisualStyleBackColor = true;
            // 
            // buttonAllOwners
            // 
            this.buttonAllOwners.Location = new System.Drawing.Point(7, 35);
            this.buttonAllOwners.Name = "buttonAllOwners";
            this.buttonAllOwners.Size = new System.Drawing.Size(259, 23);
            this.buttonAllOwners.TabIndex = 5;
            this.buttonAllOwners.Text = "Показать всех владельцев";
            this.buttonAllOwners.UseVisualStyleBackColor = true;
            this.buttonAllOwners.Click += new System.EventHandler(this.buttonAllOwners_Click);
            // 
            // buttonOwnerCars
            // 
            this.buttonOwnerCars.Location = new System.Drawing.Point(7, 6);
            this.buttonOwnerCars.Name = "buttonOwnerCars";
            this.buttonOwnerCars.Size = new System.Drawing.Size(259, 23);
            this.buttonOwnerCars.TabIndex = 3;
            this.buttonOwnerCars.Text = "Показать автомобили выбранного владельца";
            this.buttonOwnerCars.UseVisualStyleBackColor = true;
            this.buttonOwnerCars.Click += new System.EventHandler(this.buttonOwnerCars_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLastName.Location = new System.Drawing.Point(657, 35);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(268, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // buttonFindOwner
            // 
            this.buttonFindOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindOwner.Location = new System.Drawing.Point(657, 6);
            this.buttonFindOwner.Name = "buttonFindOwner";
            this.buttonFindOwner.Size = new System.Drawing.Size(268, 23);
            this.buttonFindOwner.TabIndex = 1;
            this.buttonFindOwner.Text = "Найти владельца по фамилии";
            this.buttonFindOwner.UseVisualStyleBackColor = true;
            this.buttonFindOwner.Click += new System.EventHandler(this.buttonFindOwner_Click);
            // 
            // dataGridViewOwners
            // 
            this.dataGridViewOwners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOwners.Location = new System.Drawing.Point(7, 63);
            this.dataGridViewOwners.Name = "dataGridViewOwners";
            this.dataGridViewOwners.Size = new System.Drawing.Size(918, 432);
            this.dataGridViewOwners.TabIndex = 0;
            this.dataGridViewOwners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOwners_CellContentClick);
            // 
            // tabPageWorker
            // 
            this.tabPageWorker.Controls.Add(this.buttonAddWorker);
            this.tabPageWorker.Controls.Add(this.buttonWorkerWorks);
            this.tabPageWorker.Controls.Add(this.dataGridViewWorker);
            this.tabPageWorker.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorker.Name = "tabPageWorker";
            this.tabPageWorker.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorker.Size = new System.Drawing.Size(931, 501);
            this.tabPageWorker.TabIndex = 3;
            this.tabPageWorker.Text = "Работники";
            this.tabPageWorker.UseVisualStyleBackColor = true;
            // 
            // buttonAddWorker
            // 
            this.buttonAddWorker.Location = new System.Drawing.Point(689, 6);
            this.buttonAddWorker.Name = "buttonAddWorker";
            this.buttonAddWorker.Size = new System.Drawing.Size(236, 23);
            this.buttonAddWorker.TabIndex = 2;
            this.buttonAddWorker.Text = "Добавить работника";
            this.buttonAddWorker.UseVisualStyleBackColor = true;
            this.buttonAddWorker.Click += new System.EventHandler(this.buttonAddWorker_Click);
            // 
            // buttonWorkerWorks
            // 
            this.buttonWorkerWorks.Location = new System.Drawing.Point(6, 6);
            this.buttonWorkerWorks.Name = "buttonWorkerWorks";
            this.buttonWorkerWorks.Size = new System.Drawing.Size(236, 23);
            this.buttonWorkerWorks.TabIndex = 1;
            this.buttonWorkerWorks.Text = "Показать заказы выбранного работника";
            this.buttonWorkerWorks.UseVisualStyleBackColor = true;
            this.buttonWorkerWorks.Click += new System.EventHandler(this.buttonWorkerWorks_Click);
            // 
            // dataGridViewWorker
            // 
            this.dataGridViewWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorker.Location = new System.Drawing.Point(4, 35);
            this.dataGridViewWorker.Name = "dataGridViewWorker";
            this.dataGridViewWorker.Size = new System.Drawing.Size(924, 447);
            this.dataGridViewWorker.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 552);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авто Сервис";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageWorks.ResumeLayout(false);
            this.tabPageWorks.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorks)).EndInit();
            this.tabPageCars.ResumeLayout(false);
            this.tabPageCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.tabPageOwners.ResumeLayout(false);
            this.tabPageOwners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwners)).EndInit();
            this.tabPageWorker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageWorks;
        private System.Windows.Forms.TabPage tabPageCars;
        private System.Windows.Forms.DataGridView dataGridViewWorks;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.Button buttonOverdue;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonInWork;
        private System.Windows.Forms.Button buttonAddWork;
        private System.Windows.Forms.Button buttonPeriod;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSum;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDeleteWork;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.Button buttonFindCar;
        private System.Windows.Forms.Button buttonAllCars;
        private System.Windows.Forms.Button buttonCarAdd;
        private System.Windows.Forms.Button buttonCarChange;
        private System.Windows.Forms.TabPage tabPageOwners;
        private System.Windows.Forms.DataGridView dataGridViewOwners;
        private System.Windows.Forms.TabPage tabPageWorker;
        private System.Windows.Forms.DataGridView dataGridViewWorker;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Button buttoncSelectedCar;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button buttonFindOwner;
        private System.Windows.Forms.Button buttonOwnerCars;
        private System.Windows.Forms.Button buttonAllOwners;
        private System.Windows.Forms.Button buttonWorkerWorks;
        private System.Windows.Forms.Button buttonAddWorker;
    }
}

