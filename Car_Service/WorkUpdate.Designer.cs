namespace Car_Service
{
    partial class WorkUpdate
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
            this.dateTimePickerDateEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxWorkerUpdate = new System.Windows.Forms.ComboBox();
            this.buttonWorksUpdate = new System.Windows.Forms.Button();
            this.labelWorkUpdate = new System.Windows.Forms.Label();
            this.radioButtonDateEnd = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dateTimePickerDateEnd
            // 
            this.dateTimePickerDateEnd.Location = new System.Drawing.Point(12, 64);
            this.dateTimePickerDateEnd.Name = "dateTimePickerDateEnd";
            this.dateTimePickerDateEnd.Size = new System.Drawing.Size(261, 20);
            this.dateTimePickerDateEnd.TabIndex = 0;
            // 
            // comboBoxWorkerUpdate
            // 
            this.comboBoxWorkerUpdate.FormattingEnabled = true;
            this.comboBoxWorkerUpdate.Location = new System.Drawing.Point(12, 90);
            this.comboBoxWorkerUpdate.Name = "comboBoxWorkerUpdate";
            this.comboBoxWorkerUpdate.Size = new System.Drawing.Size(261, 21);
            this.comboBoxWorkerUpdate.TabIndex = 1;
            this.comboBoxWorkerUpdate.Text = "Выберите работника";
            // 
            // buttonWorksUpdate
            // 
            this.buttonWorksUpdate.Location = new System.Drawing.Point(12, 117);
            this.buttonWorksUpdate.Name = "buttonWorksUpdate";
            this.buttonWorksUpdate.Size = new System.Drawing.Size(261, 23);
            this.buttonWorksUpdate.TabIndex = 2;
            this.buttonWorksUpdate.Text = "Изменить";
            this.buttonWorksUpdate.UseVisualStyleBackColor = true;
            this.buttonWorksUpdate.Click += new System.EventHandler(this.buttonWorksUpdate_Click);
            // 
            // labelWorkUpdate
            // 
            this.labelWorkUpdate.AutoSize = true;
            this.labelWorkUpdate.Location = new System.Drawing.Point(10, 9);
            this.labelWorkUpdate.Name = "labelWorkUpdate";
            this.labelWorkUpdate.Size = new System.Drawing.Size(144, 13);
            this.labelWorkUpdate.TabIndex = 4;
            this.labelWorkUpdate.Text = "Редактирование заказа №";
            // 
            // radioButtonDateEnd
            // 
            this.radioButtonDateEnd.AutoSize = true;
            this.radioButtonDateEnd.Location = new System.Drawing.Point(13, 41);
            this.radioButtonDateEnd.Name = "radioButtonDateEnd";
            this.radioButtonDateEnd.Size = new System.Drawing.Size(205, 17);
            this.radioButtonDateEnd.TabIndex = 5;
            this.radioButtonDateEnd.TabStop = true;
            this.radioButtonDateEnd.Text = "Изменить дату выполнения заказа";
            this.radioButtonDateEnd.UseVisualStyleBackColor = true;
            // 
            // WorkUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 150);
            this.Controls.Add(this.radioButtonDateEnd);
            this.Controls.Add(this.labelWorkUpdate);
            this.Controls.Add(this.buttonWorksUpdate);
            this.Controls.Add(this.comboBoxWorkerUpdate);
            this.Controls.Add(this.dateTimePickerDateEnd);
            this.Name = "WorkUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDateEnd;
        private System.Windows.Forms.ComboBox comboBoxWorkerUpdate;
        private System.Windows.Forms.Button buttonWorksUpdate;
        private System.Windows.Forms.Label labelWorkUpdate;
        private System.Windows.Forms.RadioButton radioButtonDateEnd;
    }
}