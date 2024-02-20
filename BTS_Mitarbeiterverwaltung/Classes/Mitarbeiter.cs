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
        public static DataTable getMitarbeiterByName(string vorname, string name)
        {
            SqlCommand commandStart = new SqlCommand("SELECT * FROM mitarbeiter WHERE Vorname LIKE @Vorname OR Name LIKE @Name", SqlVariable.connection);
            commandStart.Parameters.AddWithValue("@Vorname", "%" + vorname + "%");
            commandStart.Parameters.AddWithValue("@Name", "%" + name + "%");

            SqlVariable.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(commandStart);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlVariable.connection.Close();

            return table;
        }
        public static Mitarbeiter getMitarbeiterById(int id)
        {
            Mitarbeiter employee = null;
            SqlCommand commandStart = new SqlCommand("SELECT * FROM mitarbeiter WHERE ID = @id", SqlVariable.connection);
            commandStart.Parameters.AddWithValue("@id", id);
            try
            {
                SqlVariable.connection.Open();
                SqlDataReader reader = commandStart.ExecuteReader();

                if (reader.Read())
                {
                    employee = new Mitarbeiter
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Vorname = reader["Vorname"].ToString(),
                        Name = reader["Name"].ToString(),
                        Position = reader["Position"].ToString(),
                        DatumEintritt = Convert.ToDateTime(reader["EintrittDatum"]),
                        DatumRentenBeginn = Convert.ToDateTime(reader["Rentenbeginn"]),
                        EMail = reader["E-Mail"].ToString(),
                        Gehalt = reader["Gehalt"].ToString(),
                        Geburtsdatum = Convert.ToDateTime(reader["Geburtsdatum"]),
                        Adresse = reader["Adresse"].ToString(),
                        Telefon = reader["Telefon"].ToString()
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                SqlVariable.connection.Close();
            }
            return employee;
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
            else
            {
                SqlCommand commandUpdate = new SqlCommand(
    "UPDATE mitarbeiter " +
    "SET " +
    "Vorname = @Vorname, " +
    "Name = @Name, " +
    "Adresse = @Adresse, " +
    "Telefon = @Telefon, " +
    "[E-Mail] = @EMail, " +
    "Position = @Position, " +
    "EintrittDatum = @EintrittDatum, " +
    "Gehalt = @Gehalt, " +
    "Rentenbeginn = @Rentenbeginn, " +
    "Geburtsdatum = @Geburtsdatum " +
    "WHERE ID = @id",
    SqlVariable.connection);
                SqlVariable.connection.Open();
                commandUpdate.Parameters.AddWithValue("@id", this.ID);
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
        public static void deleteMitarbeiter(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete from mitarbeiter where id=@id", SqlVariable.connection);
            SqlVariable.connection.Open();
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();
            SqlVariable.connection.Close();
        }

        public static bool validation(Mitarbeiter m)
        {
            if (string.IsNullOrWhiteSpace(m.Name) || string.IsNullOrWhiteSpace(m.Vorname)) 
            {
                return false;
            }
            else
            {
                return true;
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
