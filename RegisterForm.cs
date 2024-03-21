using BTS_Mitarbeiterverwaltung.Classes;
using System;
using System.Windows.Forms;

namespace BTS_Mitarbeiterverwaltung
{
    internal partial class RegisterForm : Form
    {
        internal string Benutzername { get; private set; }
        internal string Passwort { get; private set; }

        internal RegisterForm()
        {
            InitializeComponent();

            txtPasswort.UseSystemPasswordChar = true;
            txtVerify.UseSystemPasswordChar = true;
        }

        // Event-Handler, der aufgerufen wird, wenn der "Passwort anzeigen" CheckBox-Zustand geändert wird.
        // Ändert den Zeichensatz des Passwortfelds und des Passwortüberprüfungsfelds basierend auf dem Zustand der CheckBox.
        // Wenn die CheckBox deaktiviert ist, wird das Passwort nicht maskiert
        // Wenn die CheckBox aktiviert ist, wird das Passwort verborgen.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPasswort.UseSystemPasswordChar = !ckShowPasswort.Checked;
            txtVerify.UseSystemPasswordChar = !ckShowPasswort.Checked;
        }

        // Event-Handler, der aufgerufen wird, wenn der "Benutzer erstellen" Button geklickt wird.
        // Versucht, einen neuen Benutzer zu erstellen, indem die eingegebenen Benutzerdaten validiert und in die Datenbank eingefügt werden.
        // Setzt Benutzername und Passwort auf die eingegebenen Werte.
        // Schließt das Registrierungsformular und gibt DialogResult.OK zurück, wenn die Benutzererstellung erfolgreich ist.
        // Zeigt eine Fehlermeldung an, falls ein Fehler auftritt.
        // Schließt die SQL-Verbindung.
        private void btnCreateUser_Click_1(object sender, EventArgs e)
        {
            try
            {
                Account.CreateUser(txtBenutzername.Text, txtPasswort.Text, txtVerify.Text);

                Benutzername = txtBenutzername.Text;
                Passwort = txtPasswort.Text;
                
                DialogResult = DialogResult.OK; // Registerformular schließen
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlVariable.connection.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {}
        private void txtBenutzername_TextChanged(object sender, EventArgs e)
        {}
    }
}
