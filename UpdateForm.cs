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
            id = ID;
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            Employee m = new Employee();

            // Wenn eine ID vorhanden ist, setze sie für das Mitarbeiterobjekt
            if (id != 0)
            {
                m.ID = id;
            }

            // Setze die anderen Eigenschaften basierend auf den Benutzereingaben
            m.Vorname = txtBoxName.Text;
            m.Nachname = txtBoxSurname.Text;
            m.Position = comboBoxPosition.Text;
            m.DatumEintritt = dateTimePickerEntry.Value;
            m.EMail = txtBoxEmail.Text;
            m.Gehalt = txtBoxSalary.Text;
            //m.Geburtsdatum = dateTimePickerBirthdate.Value;
            m.Adresse = txtBoxAdress.Text;
            //m.Telefon = txtBoxTelefon.Text;
            m.Geschlecht = comboBoxGender.Text;

            // Validiere die Mitarbeiterdaten
            if (Employee.validation(m))
            {
                // Führe die Aktualisierung oder Einfügung in die Datenbank durch
                m.updateEmployee();

                // Schließe das Formular
                this.Close();

                // Zeige eine entsprechende Erfolgsmeldung an
                if (m.ID == 0)
                {
                    MessageBox.Show("Mitarbeiter wurde erfolgreich hinzugefügt!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable table = Employee.GetAllEmployees();
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
                txtBoxSurname.Text = m.Nachname;
                comboBoxPosition.Text = m.Position;
                dateTimePickerEntry.Value = m.DatumEintritt;
                txtBoxEmail.Text = m.EMail;
                txtBoxSalary.Text = m.Gehalt;
                //dateTimePickerBirthdate.Value = m.Geburtsdatum;
                txtBoxAdress.Text = m.Adresse;
                //txtBoxTelefon.Text = m.Telefon;
                comboBoxGender.Text = m.Geschlecht;
            }
        }
    }
}
