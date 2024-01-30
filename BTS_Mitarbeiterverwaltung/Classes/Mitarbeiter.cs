using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BTS_Mitarbeiterverwaltung.Classes
{
    internal class Mitarbeiter
    {
        #region Properties

        public int ID { get; set; }
        public string Vorname { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }
        public string Telefon { get; set; }
        public string EMail { get; set; }
        public string Position { get; set; }
        public DateTime DatumEintritt { get; set; }
        public string Gehalt { get; set; }
        public DateTime DatumRentenBeginn { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public int Alter { get; set; }

        #endregion

        /// <summary>
        /// Get all Mitarbeiter as DataTable
        /// </summary>
        /// <returns></returns>
        public static DataTable getAllMitarbeiter()
        {
            SqlCommand commandStart = new SqlCommand("Select * from mitarbeiter", SqlVariable.connection);
            SqlVariable.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(commandStart);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlVariable.connection.Close();
            return table;
        }

        public void updateMitarbeiter()
        {
            if (this.ID == 0)
            {
                SqlCommand commandUpdate = new SqlCommand("Insert into mitarbeiter (Vorname, Name, Adresse, Telefon, [E-Mail], Position, EintrittDatum, Gehalt, Rentenbeginn, Geburtsdatum) values (@Vorname, @Name, @Adresse, @Telefon, @EMail, @Position, @EintrittDatum, @Gehalt, @Rentenbeginn, @Geburtsdatum)", SqlVariable.connection);
                SqlVariable.connection.Open();
                commandUpdate.Parameters.AddWithValue("@Vorname", this.Vorname);
                commandUpdate.Parameters.AddWithValue("@Name", this.Name);
                commandUpdate.Parameters.AddWithValue("@Adresse", this.Adresse);
                commandUpdate.Parameters.AddWithValue("@Telefon", this.Telefon);
                commandUpdate.Parameters.AddWithValue("@EMail", this.EMail);
                commandUpdate.Parameters.AddWithValue("@Position", this.Position);
                commandUpdate.Parameters.AddWithValue("@Eintrittdatum", this.DatumEintritt);
                commandUpdate.Parameters.AddWithValue("@Gehalt", this.Gehalt);
                commandUpdate.Parameters.AddWithValue("@Rentenbeginn", this.DatumRentenBeginn);
                commandUpdate.Parameters.AddWithValue("@Geburtsdatum", this.Geburtsdatum);
                commandUpdate.ExecuteNonQuery();
                SqlVariable.connection.Close();
            }

            
        }





        #region test
        public void Topla(int a, int b)
        {
            _ = a + b;
        }

        public static void topla2(int a, int b)
        {
            _ = a - b;
        }

        public int topla3(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public static int topla4(int a, int b)
        {
            int c = a + b;
            return c;
        }
        #endregion
    }
}
