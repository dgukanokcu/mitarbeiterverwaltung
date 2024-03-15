using BTS_Mitarbeiterverwaltung.Classes;
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
            m.Nachname = txtBoxSurname.Text;
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
                errName.Visible = string.IsNullOrWhiteSpace(m.Vorname);
                errSurname.Visible = string.IsNullOrWhiteSpace(m.Nachname);
                errMail.Visible = string.IsNullOrWhiteSpace(m.EMail);
                errGndr.Visible = string.IsNullOrWhiteSpace(m.Geschlecht);
                errPstn.Visible = string.IsNullOrWhiteSpace(m.Position);
                errSlry.Visible = string.IsNullOrWhiteSpace(m.Gehalt);
                errTlfn.Visible = string.IsNullOrWhiteSpace(m.Telefon);
                errStrt.Visible = string.IsNullOrWhiteSpace(m.Strasse);
                errHausNmbr.Visible = string.IsNullOrWhiteSpace(m.Hausnummer);
                errZip.Visible = string.IsNullOrWhiteSpace(m.PLZ);
                errCty.Visible = string.IsNullOrWhiteSpace(m.Ort);
                MessageBox.Show("Überprüfen Sie bitte Ihre Angaben!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                Employee m = Employee.getEmployeeById(id);
                txtBoxName.Text = m.Vorname;
                txtBoxSurname.Text = m.Nachname;
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

        #region validation
        
        private void txtBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Employee.AllowOnlyLettersAndControlCharacters(sender, e);
        }

        private void txtBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            Employee.AllowOnlyLettersAndControlCharacters(sender, e);
        }

        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Employee.AllowOnlyLettersAndControlCharacters(sender, e);
        }

        private void textBoxStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            Employee.AllowOnlyLettersAndControlCharacters(sender, e);
        }

        private void textBoxZIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Employee.AllowOnlyNumbersAndControlCharacters(sender, e);
        }

        private void textBoxHouseNmbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            Employee.AllowOnlyNumbersAndControlCharacters(sender, e);
        }

        private void txtBoxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Employee.AllowOnlyNumbersAndControlCharacters(sender, e);
        }

        private void txtBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Employee.AllowOnlyNumbersAndControlCharacters(sender, e);
        }
        #endregion
    }

}
