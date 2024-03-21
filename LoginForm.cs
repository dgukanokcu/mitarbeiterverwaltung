using BTS_Mitarbeiterverwaltung.Classes;
using System;
using System.Drawing;
using System.Threading;
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

        // Event-Handler, der beim Laden des Login-Formulars aufgerufen wird.
        // Überprüft den Zustand der SQL-Verbindung.
        // Öffnet die Verbindung, wenn sie nicht bereits geöffnet ist.
        // Wenn ein Fehler beim Öffnen der Verbindung auftritt, wird ein Timer erstellt, um die Anwendung korrekt zu beenden
        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!SqlVariable.connection.State.Equals(System.Data.ConnectionState.Open))
            {
                try
                {
                    SqlVariable.connection.Open();
                }
                catch
                {
                    System.Threading.Timer timer = new System.Threading.Timer(TimerCallback, null, 2000, Timeout.Infinite);
                    return;
                }
            }
        }

        internal void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        static void TimerCallback(object state)
        {
            MessageBox.Show("Keine Verbindung. Data Source überprüfen.");
            Environment.Exit(0);
        }

        // Event-Handler, der aufgerufen wird, wenn der Anmelde-Button geklickt wird.
        // Extrahiert Benutzername und Passwort aus den entsprechenden Textfeldern.
        // Überprüft die Anmeldeinformationen mithilfe der Validierungsmethode des Account-Objekts.
        // Bei erfolgreicher Validierung öffnet das Hauptformular und versteckt das aktuelle Anmeldeformular.
        // Bei fehlgeschlagener Validierung wird eine Fehlermeldung angezeigt.
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

        // Event-Handler, der aufgerufen wird, wenn auf das Label für die Benutzerregistrierung geklickt wird.
        // Öffnet das Registrierungsformular für die Benutzererstellung.
        // Setzt die Startposition des Registrierungsformulars auf die Bildschirmmitte.
        // Wartet, bis das Registrierungsformular geschlossen wird.
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
