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
            this.Name = new System.Windows.Forms.Label();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errName = new System.Windows.Forms.Label();
            this.errMail = new System.Windows.Forms.Label();
            this.errSurname = new System.Windows.Forms.Label();
            this.errBrthdy = new System.Windows.Forms.Label();
            this.errCty = new System.Windows.Forms.Label();
            this.errHausNmbr = new System.Windows.Forms.Label();
            this.errZip = new System.Windows.Forms.Label();
            this.errStrt = new System.Windows.Forms.Label();
            this.errGndr = new System.Windows.Forms.Label();
            this.errTlfn = new System.Windows.Forms.Label();
            this.errPstn = new System.Windows.Forms.Label();
            this.errEntry = new System.Windows.Forms.Label();
            this.errSlry = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxName.Location = new System.Drawing.Point(6, 48);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(120, 20);
            this.txtBoxName.TabIndex = 0;
            this.txtBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxName_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(726, 223);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 38);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(6, 94);
            this.txtBoxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(120, 20);
            this.txtBoxSurname.TabIndex = 1;
            this.txtBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSurname_KeyPress);
            // 
            // txtBoxTelefon
            // 
            this.txtBoxTelefon.Location = new System.Drawing.Point(151, 95);
            this.txtBoxTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTelefon.Name = "txtBoxTelefon";
            this.txtBoxTelefon.Size = new System.Drawing.Size(120, 20);
            this.txtBoxTelefon.TabIndex = 5;
            this.txtBoxTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTelefon_KeyPress);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(6, 138);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(120, 20);
            this.txtBoxEmail.TabIndex = 2;
            // 
            // txtBoxSalary
            // 
            this.txtBoxSalary.Location = new System.Drawing.Point(19, 137);
            this.txtBoxSalary.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSalary.Name = "txtBoxSalary";
            this.txtBoxSalary.Size = new System.Drawing.Size(120, 20);
            this.txtBoxSalary.TabIndex = 9;
            this.txtBoxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSalary_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vorname";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(11, 76);
            this.Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 12;
            this.Name.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "E-Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Eintritt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Gehalt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Geburtsdatum";
            // 
            // dateTimePickerEntry
            // 
            this.dateTimePickerEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEntry.Location = new System.Drawing.Point(19, 48);
            this.dateTimePickerEntry.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerEntry.Name = "dateTimePickerEntry";
            this.dateTimePickerEntry.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerEntry.TabIndex = 7;
            // 
            // dateTimePickerBirthdate
            // 
            this.dateTimePickerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(151, 49);
            this.dateTimePickerBirthdate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerBirthdate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Geschlecht";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Weiblich\t",
            "Männlich"});
            this.comboBoxGender.Location = new System.Drawing.Point(151, 139);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(120, 21);
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
            this.comboBoxPosition.Location = new System.Drawing.Point(19, 92);
            this.comboBoxPosition.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(120, 21);
            this.comboBoxPosition.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(155, 78);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Ort";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(155, 93);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(120, 20);
            this.textBoxCity.TabIndex = 20;
            this.textBoxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCity_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 78);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "PLZ";
            // 
            // textBoxZIP
            // 
            this.textBoxZIP.Location = new System.Drawing.Point(18, 93);
            this.textBoxZIP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxZIP.Name = "textBoxZIP";
            this.textBoxZIP.Size = new System.Drawing.Size(120, 20);
            this.textBoxZIP.TabIndex = 18;
            this.textBoxZIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxZIP_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(152, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Hausnummer";
            // 
            // textBoxHouseNmbr
            // 
            this.textBoxHouseNmbr.Location = new System.Drawing.Point(155, 48);
            this.textBoxHouseNmbr.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHouseNmbr.Name = "textBoxHouseNmbr";
            this.textBoxHouseNmbr.Size = new System.Drawing.Size(120, 20);
            this.textBoxHouseNmbr.TabIndex = 16;
            this.textBoxHouseNmbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHouseNmbr_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Strasse";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(15, 48);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(120, 20);
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
            this.groupBox1.Controls.Add(this.Name);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 183);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persönlich";
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
            this.groupBox2.Location = new System.Drawing.Point(343, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 183);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adresse";
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
            this.groupBox3.Location = new System.Drawing.Point(662, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 183);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "???";
            // 
            // errName
            // 
            this.errName.AutoSize = true;
            this.errName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errName.ForeColor = System.Drawing.Color.Red;
            this.errName.Location = new System.Drawing.Point(131, 49);
            this.errName.Name = "errName";
            this.errName.Size = new System.Drawing.Size(15, 20);
            this.errName.TabIndex = 26;
            this.errName.Text = "!";
            this.errName.Visible = false;
            // 
            // errMail
            // 
            this.errMail.AutoSize = true;
            this.errMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMail.ForeColor = System.Drawing.Color.Red;
            this.errMail.Location = new System.Drawing.Point(131, 139);
            this.errMail.Name = "errMail";
            this.errMail.Size = new System.Drawing.Size(15, 20);
            this.errMail.TabIndex = 29;
            this.errMail.Text = "!";
            this.errMail.Visible = false;
            // 
            // errSurname
            // 
            this.errSurname.AutoSize = true;
            this.errSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSurname.ForeColor = System.Drawing.Color.Red;
            this.errSurname.Location = new System.Drawing.Point(131, 94);
            this.errSurname.Name = "errSurname";
            this.errSurname.Size = new System.Drawing.Size(15, 20);
            this.errSurname.TabIndex = 30;
            this.errSurname.Text = "!";
            this.errSurname.Visible = false;
            // 
            // errBrthdy
            // 
            this.errBrthdy.AutoSize = true;
            this.errBrthdy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errBrthdy.ForeColor = System.Drawing.Color.Red;
            this.errBrthdy.Location = new System.Drawing.Point(276, 48);
            this.errBrthdy.Name = "errBrthdy";
            this.errBrthdy.Size = new System.Drawing.Size(15, 20);
            this.errBrthdy.TabIndex = 31;
            this.errBrthdy.Text = "!";
            this.errBrthdy.Visible = false;
            // 
            // errCty
            // 
            this.errCty.AutoSize = true;
            this.errCty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errCty.ForeColor = System.Drawing.Color.Red;
            this.errCty.Location = new System.Drawing.Point(277, 94);
            this.errCty.Name = "errCty";
            this.errCty.Size = new System.Drawing.Size(15, 20);
            this.errCty.TabIndex = 32;
            this.errCty.Text = "!";
            this.errCty.Visible = false;
            // 
            // errHausNmbr
            // 
            this.errHausNmbr.AutoSize = true;
            this.errHausNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errHausNmbr.ForeColor = System.Drawing.Color.Red;
            this.errHausNmbr.Location = new System.Drawing.Point(277, 48);
            this.errHausNmbr.Name = "errHausNmbr";
            this.errHausNmbr.Size = new System.Drawing.Size(15, 20);
            this.errHausNmbr.TabIndex = 33;
            this.errHausNmbr.Text = "!";
            this.errHausNmbr.Visible = false;
            // 
            // errZip
            // 
            this.errZip.AutoSize = true;
            this.errZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errZip.ForeColor = System.Drawing.Color.Red;
            this.errZip.Location = new System.Drawing.Point(135, 95);
            this.errZip.Name = "errZip";
            this.errZip.Size = new System.Drawing.Size(15, 20);
            this.errZip.TabIndex = 34;
            this.errZip.Text = "!";
            this.errZip.Visible = false;
            // 
            // errStrt
            // 
            this.errStrt.AutoSize = true;
            this.errStrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errStrt.ForeColor = System.Drawing.Color.Red;
            this.errStrt.Location = new System.Drawing.Point(135, 50);
            this.errStrt.Name = "errStrt";
            this.errStrt.Size = new System.Drawing.Size(15, 20);
            this.errStrt.TabIndex = 35;
            this.errStrt.Text = "!";
            this.errStrt.Visible = false;
            // 
            // errGndr
            // 
            this.errGndr.AutoSize = true;
            this.errGndr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errGndr.ForeColor = System.Drawing.Color.Red;
            this.errGndr.Location = new System.Drawing.Point(276, 140);
            this.errGndr.Name = "errGndr";
            this.errGndr.Size = new System.Drawing.Size(15, 20);
            this.errGndr.TabIndex = 36;
            this.errGndr.Text = "!";
            this.errGndr.Visible = false;
            // 
            // errTlfn
            // 
            this.errTlfn.AutoSize = true;
            this.errTlfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errTlfn.ForeColor = System.Drawing.Color.Red;
            this.errTlfn.Location = new System.Drawing.Point(276, 95);
            this.errTlfn.Name = "errTlfn";
            this.errTlfn.Size = new System.Drawing.Size(15, 20);
            this.errTlfn.TabIndex = 37;
            this.errTlfn.Text = "!";
            this.errTlfn.Visible = false;
            // 
            // errPstn
            // 
            this.errPstn.AutoSize = true;
            this.errPstn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errPstn.ForeColor = System.Drawing.Color.Red;
            this.errPstn.Location = new System.Drawing.Point(144, 94);
            this.errPstn.Name = "errPstn";
            this.errPstn.Size = new System.Drawing.Size(15, 20);
            this.errPstn.TabIndex = 38;
            this.errPstn.Text = "!";
            this.errPstn.Visible = false;
            // 
            // errEntry
            // 
            this.errEntry.AutoSize = true;
            this.errEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errEntry.ForeColor = System.Drawing.Color.Red;
            this.errEntry.Location = new System.Drawing.Point(144, 48);
            this.errEntry.Name = "errEntry";
            this.errEntry.Size = new System.Drawing.Size(15, 20);
            this.errEntry.TabIndex = 39;
            this.errEntry.Text = "!";
            this.errEntry.Visible = false;
            // 
            // errSlry
            // 
            this.errSlry.AutoSize = true;
            this.errSlry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errSlry.ForeColor = System.Drawing.Color.Red;
            this.errSlry.Location = new System.Drawing.Point(144, 138);
            this.errSlry.Name = "errSlry";
            this.errSlry.Size = new System.Drawing.Size(15, 20);
            this.errSlry.TabIndex = 40;
            this.errSlry.Text = "!";
            this.errSlry.Visible = false;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 280);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
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
        private System.Windows.Forms.Label Name;
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