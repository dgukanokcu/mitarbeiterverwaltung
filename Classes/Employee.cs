using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTS_Mitarbeiterverwaltung.Classes
{
    internal class Employee
    {
        #region Properties

        internal int ID { get; set; }
        internal string Vorname { get; set; }
        internal string Nachname { get; set; }
        internal string Adresse { get; set; }
        internal string Telefon { get; set; }
        internal string EMail { get; set; }
        internal string Position { get; set; }
        internal DateTime DatumEintritt { get; set; }
        internal string Gehalt { get; set; }
        internal DateTime DatumRentenBeginn { get; set; }
        internal DateTime Geburtsdatum { get; set; }
        internal int Alter { get; set; }
        internal string Geschlecht { get; set; }

        #endregion

        /// <summary>
        /// Get all Mitarbeiter as DataTable
        /// </summary>
        /// <returns></returns>
        internal static DataTable GetAllEmployees()
        {
            DataTable table = new DataTable();

            try
            {
                if (SqlVariable.connection.State != ConnectionState.Open)
                {
                    SqlVariable.connection.Open();
                }

                using (SqlCommand commandStart = new SqlCommand("SELECT * FROM mitarbeiter", SqlVariable.connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(commandStart))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            finally
            {
                if (SqlVariable.connection.State == ConnectionState.Open)
                {
                    SqlVariable.connection.Close();
                }
            }

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
            if (ID == 0)
            {
                SqlCommand commandUpdate = new SqlCommand("INSERT INTO mitarbeiter (Vorname, Nachname, Adresse, Telefon, [E-Mail], Position, " +
                    "EintrittDatum, Gehalt, Geburtsdatum, Geschlecht) values (@Vorname, @Nachname, @Adresse, @Telefon, @EMail, @Position, " +
                    "@EintrittDatum, @Gehalt, @Geburtsdatum, @Geschlecht)", SqlVariable.connection);

                SqlVariable.connection.Open();

                commandUpdate.Parameters.AddWithValue("@Vorname", Vorname);
                commandUpdate.Parameters.AddWithValue("@Nachname", Nachname);
                commandUpdate.Parameters.AddWithValue("@Adresse", Adresse);
                commandUpdate.Parameters.AddWithValue("@Telefon", Telefon);
                commandUpdate.Parameters.AddWithValue("@EMail", EMail);
                commandUpdate.Parameters.AddWithValue("@Position", Position);
                commandUpdate.Parameters.Add("@EintrittDatum", SqlDbType.DateTime).Value = DatumEintritt;
                commandUpdate.Parameters.AddWithValue("@Gehalt", Gehalt);
                commandUpdate.Parameters.Add("@Rentenbeginn", SqlDbType.DateTime).Value = DatumRentenBeginn;
                commandUpdate.Parameters.Add("@Geburtsdatum", SqlDbType.DateTime).Value = Geburtsdatum;
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
                    commandUpdate.Parameters.Add("@EintrittDatum", SqlDbType.DateTime).Value = DatumEintritt;
                    commandUpdate.Parameters.AddWithValue("@Gehalt", Gehalt);
                    commandUpdate.Parameters.Add("@Rentenbeginn", SqlDbType.DateTime).Value = DatumRentenBeginn;
                    commandUpdate.Parameters.Add("@Geburtsdatum", SqlDbType.DateTime).Value = Geburtsdatum;
                    commandUpdate.Parameters.AddWithValue("@Geschlecht", Geschlecht);


                commandUpdate.ExecuteNonQuery();

                    SqlVariable.connection.Close();
            }          
        }
        internal static void deleteEmployee(int id)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM mitarbeiter WHERE id=@id", SqlVariable.connection);
                SqlVariable.connection.Open();
                sqlCommand.Parameters.AddWithValue("@id", id);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Mitarbeiter mit ID " + id + " nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Löschen des Mitarbeiters: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SqlVariable.connection.State == ConnectionState.Open)
                {
                    SqlVariable.connection.Close();
                }
            }
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
