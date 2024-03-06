using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTS_Mitarbeiterverwaltung.Classes
{
    internal class Employee
    {
        #region Properties

        public int ID { get; set; }
        public string Vorname { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }
        public string Telefon { get; set; }
        public string EMail { get; set; }
        public string Position { get; set; }
        public DateTime DatumEintritt { get; set; }
        public string Gehalt { get; set; }
        public DateTime DatumRentenBeginn { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public int Alter { get; set; }
        public string Geschlecht { get; set; }

        #endregion

        /// <summary>
        /// Get all Mitarbeiter as DataTable
        /// </summary>
        /// <returns></returns>
        public static DataTable getAllEmployees()
        {
            SqlCommand commandStart = new SqlCommand("SELECT * from mitarbeiter", SqlVariable.connection);
            SqlVariable.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(commandStart);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlVariable.connection.Close();
            return table;
        }

        public static DataTable getEmployeeByName(string vorname, string name)
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

        public static Employee getEmployeeById(int id)
        {
            Employee employee = null;
            SqlCommand commandStart = new SqlCommand("SELECT * FROM mitarbeiter WHERE ID = @id", SqlVariable.connection);
            commandStart.Parameters.AddWithValue("@id", id);
            try
            {
                SqlVariable.connection.Open();
                SqlDataReader reader = commandStart.ExecuteReader();

                if (reader.Read())
                {
                    employee = new Employee
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
                        Telefon = reader["Telefon"].ToString(),
                        Geschlecht = reader["Geschlecht"].ToString(),
                        Strasse = reader["Strasse"].ToString(),
                        Hausnummer = reader["Hausnummer"].ToString(),
                        PLZ = reader["PLZ"].ToString(),
                        Ort = reader["Ort"].ToString(),
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

        public void updateEmployee()
        {
            if (this.ID == 0)
            {
                SqlCommand commandUpdate = new SqlCommand("Insert into mitarbeiter (Vorname, Name, Telefon, [E-Mail], Position, EintrittDatum, Gehalt, Geburtsdatum, Geschlecht, Strasse, Hausnummer, PLZ, Ort) values (@Vorname, @Name, @Telefon, @EMail, @Position, @EintrittDatum, @Gehalt, @Geburtsdatum, @Geschlecht, @Strasse, @Hausnummer, @PLZ, @Ort)", SqlVariable.connection);
                SqlVariable.connection.Open();
                commandUpdate.Parameters.AddWithValue("@Vorname", this.Vorname);
                commandUpdate.Parameters.AddWithValue("@Name", this.Name);
                commandUpdate.Parameters.AddWithValue("@Telefon", this.Telefon);
                commandUpdate.Parameters.AddWithValue("@EMail", this.EMail);
                commandUpdate.Parameters.AddWithValue("@Position", this.Position);
                commandUpdate.Parameters.AddWithValue("@Eintrittdatum", this.DatumEintritt);
                commandUpdate.Parameters.AddWithValue("@Gehalt", this.Gehalt);
                commandUpdate.Parameters.AddWithValue("@Geburtsdatum", this.Geburtsdatum);
                commandUpdate.Parameters.AddWithValue("@Geschlecht", this.Geschlecht);
                commandUpdate.Parameters.AddWithValue("@Strasse", this.Strasse);
                commandUpdate.Parameters.AddWithValue("@Hausnummer", this.Hausnummer);
                commandUpdate.Parameters.AddWithValue("@PLZ", this.PLZ);
                commandUpdate.Parameters.AddWithValue("@Ort", this.Ort);
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
                    "Geburtsdatum = @Geburtsdatum, " +
                    "Geschlecht = @Geschlecht, " +
                    "Strasse = @Strasse, " +
                    "Hausnummer = @Hausnummer, " +
                    "PLZ = @PLZ, " +
                    "Ort = @Ort " +
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
                commandUpdate.Parameters.AddWithValue("@Geburtsdatum", this.Geburtsdatum);
                commandUpdate.Parameters.AddWithValue("@Strasse", this.Strasse);
                commandUpdate.Parameters.AddWithValue("@Hausnummer", this.Hausnummer);
                commandUpdate.Parameters.AddWithValue("@PLZ", this.PLZ);
                commandUpdate.Parameters.AddWithValue("@Ort", this.Ort);
                commandUpdate.Parameters.AddWithValue("@Geschlecht", this.Geschlecht);
                commandUpdate.ExecuteNonQuery();
                SqlVariable.connection.Close();
            }          
        }    

        public static void deleteEmployee(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete from mitarbeiter where id=@id", SqlVariable.connection);
            SqlVariable.connection.Open();
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();
            SqlVariable.connection.Close();
        }

        public static bool validation(Employee m)
        {
            if (string.IsNullOrWhiteSpace(m.Name) || 
                string.IsNullOrWhiteSpace(m.Vorname) || 
                string.IsNullOrWhiteSpace(m.EMail) || 
                string.IsNullOrWhiteSpace(m.Geschlecht) ||
                string.IsNullOrWhiteSpace(m.Position) ||
                string.IsNullOrWhiteSpace(m.Gehalt) ||
                string.IsNullOrWhiteSpace(m.Telefon) ||
                string.IsNullOrWhiteSpace(m.Strasse) ||
                string.IsNullOrWhiteSpace(m.Hausnummer) ||
                string.IsNullOrWhiteSpace(m.PLZ) ||
                string.IsNullOrWhiteSpace(m.Ort))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void AllowOnlyLettersAndControlCharacters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

    }
}
