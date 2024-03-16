using BTS_Mitarbeiterverwaltung.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace BTS_Mitarbeiterverwaltung
{

    public partial class UpdateForm : Form
    {
        private MainForm mainForm;
        private readonly int id;

        public UpdateForm(MainForm mainForm, int ID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            id = ID;
        }
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            Employee m = new Employee();
            if (id != 0) { m.SetData(id, txtBoxName.Text, txtBoxSurname.Text, textBoxStreet.Text, textBoxHouseNmbr.Text, textBoxZIP.Text, textBoxCity.Text, txtBoxTelefon.Text, txtBoxEmail.Text, comboBoxPosition.Text, dateTimePickerEntry.Value, txtBoxSalary.Text, dateTimePickerBirthdate.Value, DateTime.MinValue, comboBoxGender.Text); }

            if (Employee.validation(m))
            {
                m.UpdateEmployee();
                this.Close();
                MessageBox.Show(m.ID == 0 ? "Mitarbeiter erfolgreich hinzugefügt!" : "Mitarbeiter erfolgreich aktualisiert!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable table = Employee.GetAllEmployees();
                mainForm.dataGridViewEmployee.DataSource = table;
                mainForm.UpdateRowCount();
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
                Employee m = Employee.GetEmployeeById(id);
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
                textBoxHouseNmbr.Text = m.Nr;
                textBoxZIP.Text = m.PLZ;
                textBoxCity.Text = m.Ort;
            }
        }

        #region validation

        private void txtBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            Employee.AllowOnlyNumbersAndControlCharacters(sender, e);
        }

        private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Employee.AllowOnlyNumbersAndControlCharacters(sender, e);
        }

        private void textBoxStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            Employee.AllowOnlyNumbersAndControlCharacters(sender, e);
        }

        private void textBoxZIP_KeyPress(object sender, KeyPressEventArgs e)
        {}

        private void textBoxHouseNmbr_KeyPress(object sender, KeyPressEventArgs e)
        {}

        private void txtBoxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {}

        private void txtBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {}
        #endregion

        private void groupBox2_Enter(object sender, EventArgs e)
        {}
        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
        }
        private void dateTimePickerBirthdate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBoxHouseNmbr_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
