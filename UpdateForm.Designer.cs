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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxTelefon = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nachname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerEntry = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxZIP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxHouseNmbr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errGndr = new System.Windows.Forms.Label();
            this.errTlfn = new System.Windows.Forms.Label();
            this.errBrthdy = new System.Windows.Forms.Label();
            this.errMail = new System.Windows.Forms.Label();
            this.errSurname = new System.Windows.Forms.Label();
            this.errName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errCty = new System.Windows.Forms.Label();
            this.errHausNmbr = new System.Windows.Forms.Label();
            this.errZip = new System.Windows.Forms.Label();
            this.errStrt = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errEntry = new System.Windows.Forms.Label();
            this.errSlry = new System.Windows.Forms.Label();
            this.errPstn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.AllowDrop = true;
            this.txtBoxName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxName.Location = new System.Drawing.Point(8, 59);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(159, 22);
            this.txtBoxName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(968, 274);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 47);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(8, 116);
            this.txtBoxSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(159, 22);
            this.txtBoxSurname.TabIndex = 1;
            this.txtBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSurname_KeyPress);
            // 
            // txtBoxTelefon
            // 
            this.txtBoxTelefon.Location = new System.Drawing.Point(201, 117);
            this.txtBoxTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTelefon.Name = "txtBoxTelefon";
            this.txtBoxTelefon.Size = new System.Drawing.Size(159, 22);
            this.txtBoxTelefon.TabIndex = 5;
            this.txtBoxTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTelefon_KeyPress);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(8, 170);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(159, 22);
            this.txtBoxEmail.TabIndex = 2;
            // 
            // txtBoxSalary
            // 
            this.txtBoxSalary.Location = new System.Drawing.Point(25, 169);
            this.txtBoxSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSalary.Name = "txtBoxSalary";
            this.txtBoxSalary.Size = new System.Drawing.Size(159, 22);
            this.txtBoxSalary.TabIndex = 9;
            this.txtBoxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSalary_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vorname";
            // 
            // Nachname
            // 
            this.Nachname.AutoSize = true;
            this.Nachname.Location = new System.Drawing.Point(15, 94);
            this.Nachname.Name = "Nachname";
            this.Nachname.Size = new System.Drawing.Size(73, 16);
            this.Nachname.TabIndex = 12;
            this.Nachname.Text = "Nachname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Eintritt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Gehalt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Geburtsdatum";
            // 
            // dateTimePickerEntry
            // 
            this.dateTimePickerEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEntry.Location = new System.Drawing.Point(25, 59);
            this.dateTimePickerEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEntry.Name = "dateTimePickerEntry";
            this.dateTimePickerEntry.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerEntry.TabIndex = 7;
            // 
            // dateTimePickerBirthdate
            // 
            this.dateTimePickerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(201, 60);
            this.dateTimePickerBirthdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBirthdate.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(159, 22);
            this.dateTimePickerBirthdate.TabIndex = 4;
            this.dateTimePickerBirthdate.Value = new System.DateTime(1996, 6, 9, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Geschlecht";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Weiblich\t",
            "Männlich",
            "Divers"});
            this.comboBoxGender.Location = new System.Drawing.Point(201, 171);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(159, 24);
            this.comboBoxGender.TabIndex = 6;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Abteilungsleiter\t\t",
            "Mitarbeiter",
            "Auszubildende"});
            this.comboBoxPosition.Location = new System.Drawing.Point(25, 113);
            this.comboBoxPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(159, 24);
            this.comboBoxPosition.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(207, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Ort";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(207, 114);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(159, 22);
            this.textBoxCity.TabIndex = 20;
            this.textBoxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCity_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "PLZ";
            // 
            // textBoxZIP
            // 
            this.textBoxZIP.Location = new System.Drawing.Point(24, 114);
            this.textBoxZIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxZIP.Name = "textBoxZIP";
            this.textBoxZIP.Size = new System.Drawing.Size(159, 22);
            this.textBoxZIP.TabIndex = 18;
            this.textBoxZIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxZIP_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Hausnummer";
            // 
            // textBoxHouseNmbr
            // 
            this.textBoxHouseNmbr.Location = new System.Drawing.Point(207, 59);
            this.textBoxHouseNmbr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHouseNmbr.Name = "textBoxHouseNmbr";
            this.textBoxHouseNmbr.Size = new System.Drawing.Size(159, 22);
            this.textBoxHouseNmbr.TabIndex = 16;
            this.textBoxHouseNmbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHouseNmbr_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Strasse";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(20, 59);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(159, 22);
            this.textBoxStreet.TabIndex = 14;
            this.textBoxStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStreet_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.errGndr);
            this.groupBox1.Controls.Add(this.errTlfn);
            this.groupBox1.Controls.Add(this.txtBoxTelefon);
            this.groupBox1.Controls.Add(this.Nachname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxSurname);
            this.groupBox1.Controls.Add(this.comboBoxGender);
            this.groupBox1.Controls.Add(this.txtBoxEmail);
            this.groupBox1.Controls.Add(this.errBrthdy);
            this.groupBox1.Controls.Add(this.dateTimePickerBirthdate);
            this.groupBox1.Controls.Add(this.errMail);
            this.groupBox1.Controls.Add(this.errSurname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.errName);
            this.groupBox1.Location = new System.Drawing.Point(16, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(411, 225);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persönlich";
            // 
            // errGndr
            // 
            this.errGndr.AutoSize = true;
            this.errGndr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errGndr.ForeColor = System.Drawing.Color.Red;
            this.errGndr.Location = new System.Drawing.Point(368, 172);
            this.errGndr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errGndr.Name = "errGndr";
            this.errGndr.Size = new System.Drawing.Size(19, 26);
            this.errGndr.TabIndex = 36;
            this.errGndr.Text = "!";
            this.errGndr.Visible = false;
            // 
            // errTlfn
            // 
            this.errTlfn.AutoSize = true;
            this.errTlfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errTlfn.ForeColor = System.Drawing.Color.Red;
            this.errTlfn.Location = new System.Drawing.Point(368, 117);
            this.errTlfn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errTlfn.Name = "errTlfn";
            this.errTlfn.Size = new System.Drawing.Size(19, 26);
            this.errTlfn.TabIndex = 37;
            this.errTlfn.Text = "!";
            this.errTlfn.Visible = false;
            // 
            // errBrthdy
            // 
            this.errBrthdy.AutoSize = true;
            this.errBrthdy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errBrthdy.ForeColor = System.Drawing.Color.Red;
            this.errBrthdy.Location = new System.Drawing.Point(368, 59);
            this.errBrthdy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errBrthdy.Name = "errBrthdy";
            this.errBrthdy.Size = new System.Drawing.Size(19, 26);
            this.errBrthdy.TabIndex = 31;
            this.errBrthdy.Text = "!";
            this.errBrthdy.Visible = false;
            // 
            // errMail
            // 
            this.errMail.AutoSize = true;
            this.errMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMail.ForeColor = System.Drawing.Color.Red;
            this.errMail.Location = new System.Drawing.Point(175, 171);
            this.errMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errMail.Name = "errMail";
            this.errMail.Size = new System.Drawing.Size(19, 26);
            this.errMail.TabIndex = 29;
            this.errMail.Text = "!";
            this.errMail.Visible = false;
            // 
            // errSurname
            // 
            this.errSurname.AutoSize = true;
            this.errSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSurname.ForeColor = System.Drawing.Color.Red;
            this.errSurname.Location = new System.Drawing.Point(175, 116);
            this.errSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errSurname.Name = "errSurname";
            this.errSurname.Size = new System.Drawing.Size(19, 26);
            this.errSurname.TabIndex = 30;
            this.errSurname.Text = "!";
            this.errSurname.Visible = false;
            // 
            // errName
            // 
            this.errName.AutoSize = true;
            this.errName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errName.ForeColor = System.Drawing.Color.Red;
            this.errName.Location = new System.Drawing.Point(175, 60);
            this.errName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errName.Name = "errName";
            this.errName.Size = new System.Drawing.Size(19, 26);
            this.errName.TabIndex = 26;
            this.errName.Text = "!";
            this.errName.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxStreet);
            this.groupBox2.Controls.Add(this.textBoxHouseNmbr);
            this.groupBox2.Controls.Add(this.errCty);
            this.groupBox2.Controls.Add(this.errHausNmbr);
            this.groupBox2.Controls.Add(this.errZip);
            this.groupBox2.Controls.Add(this.errStrt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxZIP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxCity);
            this.groupBox2.Location = new System.Drawing.Point(457, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(397, 225);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adresse";
            // 
            // errCty
            // 
            this.errCty.AutoSize = true;
            this.errCty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errCty.ForeColor = System.Drawing.Color.Red;
            this.errCty.Location = new System.Drawing.Point(369, 116);
            this.errCty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errCty.Name = "errCty";
            this.errCty.Size = new System.Drawing.Size(19, 26);
            this.errCty.TabIndex = 32;
            this.errCty.Text = "!";
            this.errCty.Visible = false;
            // 
            // errHausNmbr
            // 
            this.errHausNmbr.AutoSize = true;
            this.errHausNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errHausNmbr.ForeColor = System.Drawing.Color.Red;
            this.errHausNmbr.Location = new System.Drawing.Point(369, 59);
            this.errHausNmbr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errHausNmbr.Name = "errHausNmbr";
            this.errHausNmbr.Size = new System.Drawing.Size(19, 26);
            this.errHausNmbr.TabIndex = 33;
            this.errHausNmbr.Text = "!";
            this.errHausNmbr.Visible = false;
            // 
            // errZip
            // 
            this.errZip.AutoSize = true;
            this.errZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errZip.ForeColor = System.Drawing.Color.Red;
            this.errZip.Location = new System.Drawing.Point(180, 117);
            this.errZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errZip.Name = "errZip";
            this.errZip.Size = new System.Drawing.Size(19, 26);
            this.errZip.TabIndex = 34;
            this.errZip.Text = "!";
            this.errZip.Visible = false;
            // 
            // errStrt
            // 
            this.errStrt.AutoSize = true;
            this.errStrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errStrt.ForeColor = System.Drawing.Color.Red;
            this.errStrt.Location = new System.Drawing.Point(180, 62);
            this.errStrt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errStrt.Name = "errStrt";
            this.errStrt.Size = new System.Drawing.Size(19, 26);
            this.errStrt.TabIndex = 35;
            this.errStrt.Text = "!";
            this.errStrt.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.errEntry);
            this.groupBox3.Controls.Add(this.errSlry);
            this.groupBox3.Controls.Add(this.errPstn);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBoxSalary);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dateTimePickerEntry);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBoxPosition);
            this.groupBox3.Location = new System.Drawing.Point(883, 43);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(245, 225);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "???";
            // 
            // errEntry
            // 
            this.errEntry.AutoSize = true;
            this.errEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errEntry.ForeColor = System.Drawing.Color.Red;
            this.errEntry.Location = new System.Drawing.Point(192, 59);
            this.errEntry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errEntry.Name = "errEntry";
            this.errEntry.Size = new System.Drawing.Size(19, 26);
            this.errEntry.TabIndex = 39;
            this.errEntry.Text = "!";
            this.errEntry.Visible = false;
            // 
            // errSlry
            // 
            this.errSlry.AutoSize = true;
            this.errSlry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSlry.ForeColor = System.Drawing.Color.Red;
            this.errSlry.Location = new System.Drawing.Point(192, 170);
            this.errSlry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errSlry.Name = "errSlry";
            this.errSlry.Size = new System.Drawing.Size(19, 26);
            this.errSlry.TabIndex = 40;
            this.errSlry.Text = "!";
            this.errSlry.Visible = false;
            // 
            // errPstn
            // 
            this.errPstn.AutoSize = true;
            this.errPstn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPstn.ForeColor = System.Drawing.Color.Red;
            this.errPstn.Location = new System.Drawing.Point(192, 116);
            this.errPstn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errPstn.Name = "errPstn";
            this.errPstn.Size = new System.Drawing.Size(19, 26);
            this.errPstn.TabIndex = 38;
            this.errPstn.Text = "!";
            this.errPstn.Visible = false;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 345);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil bearbeiten";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxTelefon;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nachname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntry;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxZIP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxHouseNmbr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label errName;
        private System.Windows.Forms.Label errMail;
        private System.Windows.Forms.Label errSurname;
        private System.Windows.Forms.Label errBrthdy;
        private System.Windows.Forms.Label errCty;
        private System.Windows.Forms.Label errHausNmbr;
        private System.Windows.Forms.Label errZip;
        private System.Windows.Forms.Label errStrt;
        private System.Windows.Forms.Label errGndr;
        private System.Windows.Forms.Label errTlfn;
        private System.Windows.Forms.Label errPstn;
        private System.Windows.Forms.Label errEntry;
        private System.Windows.Forms.Label errSlry;
    }
}