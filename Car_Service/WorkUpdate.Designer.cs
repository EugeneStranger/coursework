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
            this.richTextBoxConsumables = new System.Windows.Forms.RichTextBox();
            this.labelConsumPrice = new System.Windows.Forms.Label();
            this.textBoxConsumPrice = new System.Windows.Forms.TextBox();
            this.checkBoxDateEnd = new System.Windows.Forms.CheckBox();
            this.checkBoxConsumables = new System.Windows.Forms.CheckBox();
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
            this.buttonWorksUpdate.Location = new System.Drawing.Point(12, 257);
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
            // richTextBoxConsumables
            // 
            this.richTextBoxConsumables.Location = new System.Drawing.Point(12, 144);
            this.richTextBoxConsumables.Name = "richTextBoxConsumables";
            this.richTextBoxConsumables.Size = new System.Drawing.Size(261, 58);
            this.richTextBoxConsumables.TabIndex = 6;
            this.richTextBoxConsumables.Text = "";
            // 
            // labelConsumPrice
            // 
            this.labelConsumPrice.AutoSize = true;
            this.labelConsumPrice.Location = new System.Drawing.Point(12, 209);
            this.labelConsumPrice.Name = "labelConsumPrice";
            this.labelConsumPrice.Size = new System.Drawing.Size(183, 13);
            this.labelConsumPrice.TabIndex = 8;
            this.labelConsumPrice.Text = "Стоимость расходных материалов";
            // 
            // textBoxConsumPrice
            // 
            this.textBoxConsumPrice.Location = new System.Drawing.Point(12, 226);
            this.textBoxConsumPrice.Name = "textBoxConsumPrice";
            this.textBoxConsumPrice.Size = new System.Drawing.Size(261, 20);
            this.textBoxConsumPrice.TabIndex = 9;
            // 
            // checkBoxDateEnd
            // 
            this.checkBoxDateEnd.AutoSize = true;
            this.checkBoxDateEnd.Location = new System.Drawing.Point(12, 41);
            this.checkBoxDateEnd.Name = "checkBoxDateEnd";
            this.checkBoxDateEnd.Size = new System.Drawing.Size(206, 17);
            this.checkBoxDateEnd.TabIndex = 10;
            this.checkBoxDateEnd.Text = "Изменить дату выполнения заказа";
            this.checkBoxDateEnd.UseVisualStyleBackColor = true;
            // 
            // checkBoxConsumables
            // 
            this.checkBoxConsumables.AutoSize = true;
            this.checkBoxConsumables.Location = new System.Drawing.Point(12, 121);
            this.checkBoxConsumables.Name = "checkBoxConsumables";
            this.checkBoxConsumables.Size = new System.Drawing.Size(237, 17);
            this.checkBoxConsumables.TabIndex = 11;
            this.checkBoxConsumables.Text = "Изменить список расходных материалов";
            this.checkBoxConsumables.UseVisualStyleBackColor = true;
            // 
            // WorkUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 292);
            this.Controls.Add(this.checkBoxConsumables);
            this.Controls.Add(this.checkBoxDateEnd);
            this.Controls.Add(this.textBoxConsumPrice);
            this.Controls.Add(this.labelConsumPrice);
            this.Controls.Add(this.richTextBoxConsumables);
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
        private System.Windows.Forms.RichTextBox richTextBoxConsumables;
        private System.Windows.Forms.Label labelConsumPrice;
        private System.Windows.Forms.TextBox textBoxConsumPrice;
        private System.Windows.Forms.CheckBox checkBoxDateEnd;
        private System.Windows.Forms.CheckBox checkBoxConsumables;
    }
}