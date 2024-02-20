using BTS_Mitarbeiterverwaltung.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            //MessageBox.Show("Mitarbeiter wurde erfolgreich hinzugefügt!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);               

            Mitarbeiter m = new Mitarbeiter();
            if (id != 0) { m.ID = id; }
            m.Vorname = txtBoxVorname.Text;
            m.Name = txtBoxName.Text;
            m.Position = txtBoxPosition.Text;
            m.DatumEintritt = dateTimePickerEintritt.Value;
            m.DatumRentenBeginn = dateTimePickerRente.Value;
            m.EMail = txtBoxEmailadresse.Text;
            m.Gehalt = txtBoxGehalt.Text;
            m.Geburtsdatum = dateTimePickerGeburtsdatum.Value;
            m.Adresse = txtBoxAdresse.Text;
            m.Telefon = txtBoxTelefon.Text;

            if (Mitarbeiter.validation(m))
            {
                m.updateMitarbeiter();
                this.Close();
                MessageBox.Show("Mitarbeiter wurde erfolgreich aktualisiert!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable table = Mitarbeiter.getAllMitarbeiter();
                mainForm.dataGridView1.DataSource = table;
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
                Mitarbeiter m = Mitarbeiter.getMitarbeiterById(id);
                txtBoxVorname.Text = m.Vorname;
                txtBoxName.Text = m.Name;
                txtBoxPosition.Text = m.Position;
                dateTimePickerEintritt.Value = m.DatumEintritt;
                dateTimePickerRente.Value = m.DatumRentenBeginn;
                txtBoxEmailadresse.Text = m.EMail;
                txtBoxGehalt.Text = m.Gehalt;
                dateTimePickerGeburtsdatum.Value = m.Geburtsdatum;
                txtBoxAdresse.Text = m.Adresse;
                txtBoxTelefon.Text = m.Telefon;
            }
        }
    }
}
