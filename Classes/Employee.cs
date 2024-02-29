using System;
using System.Data;
using System.Data.SqlClient;

namespace BTS_Mitarbeiterverwaltung.Classes
{
    internal class Employee
    {
        #region Properties

        public int ID { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Adresse { get; set; }
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
        internal static DataTable getAllEmployees()
        {
            SqlCommand commandStart = new SqlCommand("SELECT * from mitarbeiter", SqlVariable.connection);
            SqlVariable.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(commandStart);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlVariable.connection.Close();
            return table;
        }
        internal static DataTable getEmployeeByName(string vorname, string nachname)
        {
            SqlCommand commandStart = new SqlCommand("SELECT * FROM mitarbeiter WHERE Vorname LIKE @Vorname OR Nachname LIKE @Nachname", SqlVariable.connection);
            commandStart.Parameters.AddWithValue("@Vorname", "%" + vorname + "%");
            commandStart.Parameters.AddWithValue("@Nachname", "%" + nachname + "%");

            SqlVariable.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(commandStart);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlVariable.connection.Close();

            return table;
        }
        internal static Employee getEmployeeById(int id)
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
                        Nachname = reader["Nachname"].ToString(),
                        Position = reader["Position"].ToString(),
                        DatumEintritt = Convert.ToDateTime(reader["EintrittDatum"]),
                        DatumRentenBeginn = Convert.ToDateTime(reader["Rentenbeginn"]),
                        EMail = reader["E-Mail"].ToString(),
                        Gehalt = reader["Gehalt"].ToString(),
                        Geburtsdatum = Convert.ToDateTime(reader["Geburtsdatum"]),
                        Adresse = reader["Adresse"].ToString(),
                        Telefon = reader["Telefon"].ToString(),
                        Geschlecht = reader["Geschlecht"].ToString()
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
        internal void updateEmployee()
        {
            if (this.ID == 0)
            {
                SqlCommand commandUpdate = new SqlCommand("INSERT INTO mitarbeiter (Vorname, Nachname, Adresse, Telefon, [E-Mail], Position, EintrittDatum, Gehalt, Geburtsdatum, Geschlecht) values (@Vorname, @Nachname, @Adresse, @Telefon, @EMail, @Position, @EintrittDatum, @Gehalt, @Geburtsdatum, @Geschlecht)", SqlVariable.connection);
                SqlVariable.connection.Open();
                commandUpdate.Parameters.AddWithValue("@Vorname", Vorname);
                commandUpdate.Parameters.AddWithValue("@Nachname", Nachname);
                commandUpdate.Parameters.AddWithValue("@Adresse", Adresse);
                commandUpdate.Parameters.AddWithValue("@Telefon", Telefon);
                commandUpdate.Parameters.AddWithValue("@EMail", EMail);
                commandUpdate.Parameters.AddWithValue("@Position", Position);
                commandUpdate.Parameters.AddWithValue("@Eintrittdatum", DatumEintritt);
                commandUpdate.Parameters.AddWithValue("@Gehalt", Gehalt);
                commandUpdate.Parameters.AddWithValue("@Geburtsdatum", Geburtsdatum);
                commandUpdate.Parameters.AddWithValue("@Geschlecht", Geschlecht);
                commandUpdate.ExecuteNonQuery();
                SqlVariable.connection.Close();
            }
            else
            {
                SqlCommand commandUpdate = new SqlCommand(
                    
                            "UPDATE mitarbeiter " +
                            "SET " +
                            "Vorname = @Vorname, " +
                            "Nachname = @Nachname, " +
                            "Adresse = @Adresse, " +
                            "Telefon = @Telefon, " +
                            "[E-Mail] = @EMail, " +
                            "Position = @Position, " +
                            "EintrittDatum = @EintrittDatum, " +
                            "Gehalt = @Gehalt, " +
                            "Rentenbeginn = @Rentenbeginn, " +
                            "Geburtsdatum = @Geburtsdatum, " +
                            "Geschlecht = @Geschlecht " +
                            "WHERE ID = @id",

                        SqlVariable.connection);

                    SqlVariable.connection.Open();

                    commandUpdate.Parameters.AddWithValue("@id", ID);
                    commandUpdate.Parameters.AddWithValue("@Vorname", Vorname);
                    commandUpdate.Parameters.AddWithValue("@Nachname", Nachname);
                    commandUpdate.Parameters.AddWithValue("@Adresse", Adresse);
                    commandUpdate.Parameters.AddWithValue("@Telefon", Telefon);
                    commandUpdate.Parameters.AddWithValue("@EMail", EMail);
                    commandUpdate.Parameters.AddWithValue("@Position", Position);
                    commandUpdate.Parameters.AddWithValue("@Eintrittdatum", DatumEintritt);
                    commandUpdate.Parameters.AddWithValue("@Gehalt", Gehalt);
                    commandUpdate.Parameters.AddWithValue("@Rentenbeginn", DatumRentenBeginn);
                    commandUpdate.Parameters.AddWithValue("@Geburtsdatum", Geburtsdatum);
                    commandUpdate.Parameters.AddWithValue("@Geschlecht", Geschlecht);

                    commandUpdate.ExecuteNonQuery();

                    SqlVariable.connection.Close();
            }          
        }    
        internal static void deleteEmployee(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM mitarbeiter where id=@id", SqlVariable.connection);
            SqlVariable.connection.Open();
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();
            SqlVariable.connection.Close();
        }

        internal static bool validation(Employee m)
        {
            if (string.IsNullOrWhiteSpace(m.Nachname) || string.IsNullOrWhiteSpace(m.Vorname)) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
