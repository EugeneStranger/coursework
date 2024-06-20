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
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.radioButtonNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonOwner = new System.Windows.Forms.RadioButton();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.buttonChangeCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(16, 36);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(201, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // radioButtonNumber
            // 
            this.radioButtonNumber.AutoSize = true;
            this.radioButtonNumber.Location = new System.Drawing.Point(16, 13);
            this.radioButtonNumber.Name = "radioButtonNumber";
            this.radioButtonNumber.Size = new System.Drawing.Size(201, 17);
            this.radioButtonNumber.TabIndex = 2;
            this.radioButtonNumber.TabStop = true;
            this.radioButtonNumber.Text = "Введите новый номер автомобиля";
            this.radioButtonNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonOwner
            // 
            this.radioButtonOwner.AutoSize = true;
            this.radioButtonOwner.Location = new System.Drawing.Point(16, 76);
            this.radioButtonOwner.Name = "radioButtonOwner";
            this.radioButtonOwner.Size = new System.Drawing.Size(203, 17);
            this.radioButtonOwner.TabIndex = 3;
            this.radioButtonOwner.TabStop = true;
            this.radioButtonOwner.Text = "Введите данные нового владельца";
            this.radioButtonOwner.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(16, 110);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(201, 20);
            this.textBoxLastName.TabIndex = 4;
            this.textBoxLastName.Text = "Введите фамилию";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(16, 137);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(201, 20);
            this.textBoxFirstName.TabIndex = 5;
            this.textBoxFirstName.Text = "Введите имя";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(16, 164);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(201, 20);
            this.textBoxMiddleName.TabIndex = 6;
            this.textBoxMiddleName.Text = "Отчество";
            // 
            // buttonChangeCar
            // 
            this.buttonChangeCar.Location = new System.Drawing.Point(16, 204);
            this.buttonChangeCar.Name = "buttonChangeCar";
            this.buttonChangeCar.Size = new System.Drawing.Size(201, 23);
            this.buttonChangeCar.TabIndex = 7;
            this.buttonChangeCar.Text = "Принять изменения";
            this.buttonChangeCar.UseVisualStyleBackColor = true;
            this.buttonChangeCar.Click += new System.EventHandler(this.buttonChangeCar_Click);
            // 
            // CarUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 248);
            this.Controls.Add(this.buttonChangeCar);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.radioButtonOwner);
            this.Controls.Add(this.radioButtonNumber);
            this.Controls.Add(this.textBoxNumber);
            this.Name = "CarUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить данные об автомобиле";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.RadioButton radioButtonNumber;
        private System.Windows.Forms.RadioButton radioButtonOwner;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Button buttonChangeCar;
    }
}