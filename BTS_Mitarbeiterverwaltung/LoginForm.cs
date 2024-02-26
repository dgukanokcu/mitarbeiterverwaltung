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

            this.txtBoxPassword.UseSystemPasswordChar = true;

            // Setze Hintergrundfarbe auf Blau
            // Schrift: Fett
            label4.ForeColor = Color.Blue;
            label4.Font = new Font(label4.Font, FontStyle.Bold);
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
            //string benutzername = txtBoxUsername.Text;
            //string passwort = txtBoxPassword.Text;

            //if (Function.Validation(benutzername, passwort))
            //{
            //    MainForm mainForm = new MainForm();
            //    this.Hide();
            //    mainForm.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Login fehlgeschlagen. Überprüfen Sie Benutzername und Passwort.");
            //}
        }
        private void label4_Click(object sender, EventArgs e)
        {
            using (RegisterForm createUserForm = new RegisterForm())
            {
                // Legen Sie die Startposition der CreateUserForm manuell auf dem Bildschirmzentrum fest
                createUserForm.StartPosition = FormStartPosition.Manual;
                createUserForm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - createUserForm.Width) / 2,
                                                    (Screen.PrimaryScreen.Bounds.Height - createUserForm.Height) / 2);

                if (createUserForm.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }
    }
}
