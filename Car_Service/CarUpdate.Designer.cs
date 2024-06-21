namespace Car_Service
{
    partial class CarUpdate
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
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.buttonChangeCar = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.checkBoxOwner = new System.Windows.Forms.CheckBox();
            this.checkBoxNumber = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(12, 84);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(201, 20);
            this.textBoxLastName.TabIndex = 4;
            this.textBoxLastName.Text = "Введите фамилию";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(12, 111);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(201, 20);
            this.textBoxFirstName.TabIndex = 5;
            this.textBoxFirstName.Text = "Введите имя";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(12, 138);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(201, 20);
            this.textBoxMiddleName.TabIndex = 6;
            this.textBoxMiddleName.Text = "Отчество";
            // 
            // buttonChangeCar
            // 
            this.buttonChangeCar.Location = new System.Drawing.Point(12, 207);
            this.buttonChangeCar.Name = "buttonChangeCar";
            this.buttonChangeCar.Size = new System.Drawing.Size(201, 23);
            this.buttonChangeCar.TabIndex = 7;
            this.buttonChangeCar.Text = "Принять изменения";
            this.buttonChangeCar.UseVisualStyleBackColor = true;
            this.buttonChangeCar.Click += new System.EventHandler(this.buttonChangeCar_Click);
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(12, 35);
            this.maskedTextBoxNumber.Mask = "L000LL009";
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxNumber.TabIndex = 8;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(12, 181);
            this.maskedTextBoxPhone.Mask = "+7(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxPhone.TabIndex = 10;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 162);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(155, 13);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "Введите телефон владельца:";
            // 
            // checkBoxOwner
            // 
            this.checkBoxOwner.AutoSize = true;
            this.checkBoxOwner.Location = new System.Drawing.Point(12, 61);
            this.checkBoxOwner.Name = "checkBoxOwner";
            this.checkBoxOwner.Size = new System.Drawing.Size(166, 17);
            this.checkBoxOwner.TabIndex = 9;
            this.checkBoxOwner.Text = "Введите данные владельца";
            this.checkBoxOwner.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumber
            // 
            this.checkBoxNumber.AutoSize = true;
            this.checkBoxNumber.Location = new System.Drawing.Point(12, 12);
            this.checkBoxNumber.Name = "checkBoxNumber";
            this.checkBoxNumber.Size = new System.Drawing.Size(202, 17);
            this.checkBoxNumber.TabIndex = 12;
            this.checkBoxNumber.Text = "Введите новый номер автомобиля";
            this.checkBoxNumber.UseVisualStyleBackColor = true;
            // 
            // CarUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 243);
            this.Controls.Add(this.checkBoxNumber);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.checkBoxOwner);
            this.Controls.Add(this.maskedTextBoxNumber);
            this.Controls.Add(this.buttonChangeCar);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Name = "CarUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить данные об автомобиле";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Button buttonChangeCar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.CheckBox checkBoxOwner;
        private System.Windows.Forms.CheckBox checkBoxNumber;
    }
}