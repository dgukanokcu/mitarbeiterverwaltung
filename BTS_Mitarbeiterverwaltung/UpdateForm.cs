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
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            Mitarbeiter m = new Mitarbeiter();
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
            m.updateMitarbeiter();
            this.Close();
            //test
        }

    }
}
