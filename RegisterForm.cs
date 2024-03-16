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

            txtPasswort.UseSystemPasswordChar = true; // Passwort maskieren
            txtVerify.UseSystemPasswordChar = true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPasswort.UseSystemPasswordChar = !ckShowPasswort.Checked;
            txtVerify.UseSystemPasswordChar = !ckShowPasswort.Checked;
        }
        private void btnCreateUser_Click_1(object sender, EventArgs e)
        {
            SqlVariable.connection.Open();
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
