using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTS_Mitarbeiterverwaltung
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtBoxPassword.UseSystemPasswordChar = true;

            label4.ForeColor = Color.Blue;                          // Setze Hintergrundfarbe auf Blau
            label4.Font = new Font(label4.Font, FontStyle.Bold);    // Schrift: Fett
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {}
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string benutzername = txtBoxUsername.Text;
            string passwort = txtBoxPassword.Text;

            if (Account.Validation(benutzername, passwort))
            {
                MainForm mainForm = new MainForm();
                Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Login fehlgeschlagen. Überprüfen Sie Benutzername und Passwort.");
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            using (RegisterForm createUserForm = new RegisterForm())
            {
                createUserForm.StartPosition = FormStartPosition.Manual;     // Startposition manuell auf zentriert
                createUserForm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - createUserForm.Width) / 2,
                                                    (Screen.PrimaryScreen.Bounds.Height - createUserForm.Height) / 2);
                if (createUserForm.ShowDialog() == DialogResult.OK)
                {}
            }
        }
    }
}
