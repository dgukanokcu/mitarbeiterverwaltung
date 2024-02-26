namespace BTS_Mitarbeiterverwaltung
{
    partial class UpdateForm
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxTelefon = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxAdress = new System.Windows.Forms.TextBox();
            this.txtBoxPosition = new System.Windows.Forms.TextBox();
            this.txtBoxSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerEntry = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRetirement = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxName.Location = new System.Drawing.Point(19, 33);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(159, 22);
            this.txtBoxName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(411, 239);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 47);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(19, 90);
            this.txtBoxSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(159, 22);
            this.txtBoxSurname.TabIndex = 1;
            // 
            // txtBoxTelefon
            // 
            this.txtBoxTelefon.Location = new System.Drawing.Point(219, 86);
            this.txtBoxTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTelefon.Name = "txtBoxTelefon";
            this.txtBoxTelefon.Size = new System.Drawing.Size(159, 22);
            this.txtBoxTelefon.TabIndex = 5;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(19, 197);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(159, 22);
            this.txtBoxEmail.TabIndex = 4;
            // 
            // txtBoxAdress
            // 
            this.txtBoxAdress.Location = new System.Drawing.Point(19, 143);
            this.txtBoxAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxAdress.Name = "txtBoxAdress";
            this.txtBoxAdress.Size = new System.Drawing.Size(159, 22);
            this.txtBoxAdress.TabIndex = 3;
            // 
            // txtBoxPosition
            // 
            this.txtBoxPosition.Location = new System.Drawing.Point(219, 139);
            this.txtBoxPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPosition.Name = "txtBoxPosition";
            this.txtBoxPosition.Size = new System.Drawing.Size(159, 22);
            this.txtBoxPosition.TabIndex = 6;
            // 
            // txtBoxSalary
            // 
            this.txtBoxSalary.Location = new System.Drawing.Point(411, 139);
            this.txtBoxSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSalary.Name = "txtBoxSalary";
            this.txtBoxSalary.Size = new System.Drawing.Size(159, 22);
            this.txtBoxSalary.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vorname";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(15, 68);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 16);
            this.Name.TabIndex = 12;
            this.Name.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Eintritt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Gehalt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Rentenbeginn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Geburtsdatum";
            // 
            // dateTimePickerEntry
            // 
            this.dateTimePickerEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEntry.Location = new System.Drawing.Point(411, 30);
            this.dateTimePickerEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEntry.Name = "dateTimePickerEntry";
            this.dateTimePickerEntry.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerEntry.TabIndex = 7;
            // 
            // dateTimePickerRetirement
            // 
            this.dateTimePickerRetirement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRetirement.Location = new System.Drawing.Point(411, 82);
            this.dateTimePickerRetirement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerRetirement.Name = "dateTimePickerRetirement";
            this.dateTimePickerRetirement.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerRetirement.TabIndex = 9;
            // 
            // dateTimePickerBirthdate
            // 
            this.dateTimePickerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(219, 30);
            this.dateTimePickerBirthdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerBirthdate.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Geschlecht";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Weiblich\t",
            "Männlich"});
            this.comboBoxGender.Location = new System.Drawing.Point(219, 197);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(159, 24);
            this.comboBoxGender.TabIndex = 26;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 309);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.dateTimePickerBirthdate);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePickerRetirement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxTelefon);
            this.Controls.Add(this.txtBoxPosition);
            this.Controls.Add(this.dateTimePickerEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxSalary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxTelefon;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxAdress;
        private System.Windows.Forms.TextBox txtBoxPosition;
        private System.Windows.Forms.TextBox txtBoxSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntry;
        private System.Windows.Forms.DateTimePicker dateTimePickerRetirement;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGender;
    }
}