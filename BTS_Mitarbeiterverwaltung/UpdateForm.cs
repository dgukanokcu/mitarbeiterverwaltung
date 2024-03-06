﻿using BTS_Mitarbeiterverwaltung.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace BTS_Mitarbeiterverwaltung
{

    public partial class UpdateForm : Form
    {
        private MainForm mainForm;
        private int id;
        public UpdateForm(MainForm mainForm, int ID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.id = ID;
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {           
            Employee m = new Employee();
            if (id != 0) { m.ID = id; }
            m.Vorname = txtBoxName.Text;
            m.Name = txtBoxSurname.Text;
            m.Position = comboBoxPosition.Text;
            m.DatumEintritt = dateTimePickerEntry.Value;
            m.EMail = txtBoxEmail.Text;
            m.Gehalt = txtBoxSalary.Text;
            m.Geburtsdatum = dateTimePickerBirthdate.Value;
            m.Telefon = txtBoxTelefon.Text;
            m.Geschlecht = comboBoxGender.Text;
            m.Strasse = textBoxStreet.Text;
            m.Hausnummer = textBoxHouseNmbr.Text;
            m.PLZ = textBoxZIP.Text;
            m.Ort = textBoxCity.Text;    

            if (Employee.validation(m))
            {
                m.updateEmployee();
                this.Close();
                if (m.ID == 0)
                {
                    MessageBox.Show("Mitarbeiter wurde erfolgreich hinzugefügt!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Mitarbeiter wurde erfolgreich aktualisiert!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }             
                DataTable table = Employee.getAllEmployees();
                mainForm.dataGridViewEmployee.DataSource = table;
            }
            else 
            {
                MessageBox.Show("Überprüfen Sie bitte Ihre Angaben!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {


            if (id != 0)
            {
                Employee m = Employee.getEmployeeById(id);
                txtBoxName.Text = m.Vorname;
                txtBoxSurname.Text = m.Name;
                comboBoxPosition.Text = m.Position;
                dateTimePickerEntry.Value = m.DatumEintritt;
                txtBoxEmail.Text = m.EMail;
                txtBoxSalary.Text = m.Gehalt;
                dateTimePickerBirthdate.Value = m.Geburtsdatum;
                txtBoxTelefon.Text = m.Telefon;
                comboBoxGender.Text = m.Geschlecht;
                textBoxStreet.Text = m.Strasse;
                textBoxHouseNmbr.Text = m.Hausnummer;
                textBoxZIP.Text = m.PLZ;
                textBoxCity.Text = m.Ort;

            }
        }

        private void txtBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Employee.AllowOnlyLettersAndControlCharacters(sender, e);
        }

        private void txtBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            Employee.AllowOnlyLettersAndControlCharacters(sender, e);
        }
    }
}
