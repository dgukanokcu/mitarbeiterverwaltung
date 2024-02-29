using BTS_Mitarbeiterverwaltung.Classes;
using System;
using System.Windows.Forms;

namespace BTS_Mitarbeiterverwaltung
{
    public partial class RegisterForm : Form
    {
        public string Benutzername { get; private set; }
        public string Passwort { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();

            // Eigenschaft auf true UseSystemPasswordChar-Eigenschaft, um Passwort zu maskieren
            txtPasswort.UseSystemPasswordChar = true;
            txtVerify.UseSystemPasswordChar = true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPasswort.UseSystemPasswordChar = !chkShowPasswort.Checked;
            txtVerify.UseSystemPasswordChar = !chkShowPasswort.Checked;
        }
        private void btnCreateUser_Click_1(object sender, EventArgs e)
        {
            SqlVariable.connection.Open();
            try
            {
                Account.CreateUser(txtBenutzername.Text, txtPasswort.Text, txtVerify.Text);

                Benutzername = txtBenutzername.Text;
                Passwort = txtPasswort.Text;

                // Registerformular schließen
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                // Ausnahmebehandlung
                MessageBox.Show($"{ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlVariable.connection.Close();
        }

    }
}
