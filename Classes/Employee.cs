using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTS_Mitarbeiterverwaltung.Classes
{
    internal class Employee
    {
        #region Properties

        internal int ID { get; private set; }
        internal string Vorname { get; private set; }
        internal string Nachname { get; private set; }
        internal string Strasse { get; private set; }
        internal string Nr { get; private set; }
        internal string PLZ { get; private set; }
        internal string Ort { get; private set; }
        internal string Telefon { get; private set; }
        internal string EMail { get; private set; }
        internal string Position { get; private set; }
        internal DateTime DatumEintritt { get; private set; }
        internal string Gehalt { get; private set; }
        internal DateTime DatumRentenBeginn { get; private set; }
        internal DateTime Geburtsdatum { get; set; }
        internal string Geschlecht { get; private set; }

        internal static int TotalRowCount { get; private set; }

        #endregion

        internal void SetData(int id, string vorname, string nachname, string strasse, string nr, string plz, string ort, string telefon, string email, string position, DateTime datumEintritt, string gehalt, DateTime geburtsdatum, string geschlecht)
        {
            ID = id;
            Vorname = vorname;
            Nachname = nachname;
            Strasse = strasse;
            Nr = nr;
            PLZ = plz;
            Ort = ort;
            Telefon = telefon;
            EMail = email;
            Position = position;
            DatumEintritt = datumEintritt;
            Gehalt = gehalt;
            Geburtsdatum = geburtsdatum;
            Geschlecht = geschlecht;
        }

        internal void SetDataNewEmployee(string vorname, string nachname, string strasse, string nr, string plz, string ort, string telefon, string email, string position, DateTime datumEintritt, string gehalt, DateTime geburtsdatum, string geschlecht)
        {
            Vorname = vorname;
            Nachname = nachname;
            Strasse = strasse;
            Nr = nr;
            PLZ = plz;
            Ort = ort;
            Telefon = telefon;
            EMail = email;
            Position = position;
            DatumEintritt = datumEintritt;
            Gehalt = gehalt;
            Geburtsdatum = geburtsdatum;
            Geschlecht = geschlecht;
        }

        internal static void AllowOnlyNumbersAndControlCharacters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        internal static void AllowOnlyLettersAndControlCharacters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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

                string query = "SELECT ID, Vorname, Nachname, Strasse, Nr, PLZ, Ort, Telefon, [E-Mail], Position, EintrittDatum, Gehalt, Rentenbeginn, Geburtsdatum, [Alter], Geschlecht FROM mitarbeiter";

                using (SqlCommand commandStart = new SqlCommand(query, SqlVariable.connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(commandStart))
                    {
                        adapter.Fill(table);
                    }
                }
                TotalRowCount = table.Rows.Count;
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
        internal static Employee GetEmployeeById(int id)
        {
            Employee employee = null;
            string query = "SELECT * FROM mitarbeiter WHERE ID = @id";

            try
            {
                using (SqlCommand command = new SqlCommand(query, SqlVariable.connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    SqlVariable.connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        employee = new Employee
                        {
                            ID = (int)reader["ID"],
                            Vorname = reader["Vorname"].ToString(),
                            Nachname = reader["Nachname"].ToString(),
                            Position = reader["Position"].ToString(),
                            DatumEintritt = (DateTime)reader["EintrittDatum"],
                            DatumRentenBeginn = (DateTime)reader["Rentenbeginn"],
                            EMail = reader["E-Mail"].ToString(),
                            Gehalt = reader["Gehalt"].ToString(),
                            Geburtsdatum = (DateTime)reader["Geburtsdatum"],
                            Telefon = reader["Telefon"].ToString(),
                            Geschlecht = reader["Geschlecht"].ToString(),
                            Strasse = reader["Strasse"].ToString(),
                            Nr = reader["Nr"].ToString(),
                            PLZ = reader["PLZ"].ToString(),
                            Ort = reader["Ort"].ToString(),
                        };
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler: " + ex.Message);
            }
            finally
            {
                if (SqlVariable.connection.State == ConnectionState.Open)
                {
                    SqlVariable.connection.Close();
                }
            }
            return employee;
        }
        internal void UpdateEmployee()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SqlVariable.connection.ConnectionString))
                {
                    connection.Open();

                    string query;
                    List<string> updatedColumns = new List<string>();

                    if (ID == 0)
                    {
                        query = "INSERT INTO mitarbeiter (Vorname, Nachname, Telefon, [E-Mail], Position, EintrittDatum, Gehalt, Geburtsdatum, Geschlecht, Strasse, Nr, PLZ, Ort) " +
                                "VALUES (@Vorname, @Nachname, @Telefon, @EMail, @Position, @EintrittDatum, @Gehalt, @Geburtsdatum, @Geschlecht, @Strasse, @Nr, @PLZ, @Ort)";
                        updatedColumns.AddRange(new[] { "Vorname", "Nachname", "Telefon", "EMail", "Position", "EintrittDatum", "Gehalt", "Geburtsdatum", "Geschlecht", "Strasse", "Nr", "PLZ", "Ort" });
                    }
                    else
                    {
                        query = "UPDATE mitarbeiter SET ";

                        Employee originalEmployee = GetEmployeeById(ID);

                        if (!string.IsNullOrEmpty(Vorname))
                        {
                            query += "Vorname = @Vorname, ";
                            updatedColumns.Add("Vorname");
                        }

                        if (!string.IsNullOrEmpty(Nachname))
                        {
                            query += "Nachname = @Nachname, ";
                            updatedColumns.Add("Nachname");
                        }

                        if (!string.IsNullOrEmpty(Strasse))
                        {
                            query += "Strasse = @Strasse, ";
                            updatedColumns.Add("Strasse");
                        }

                        if (!string.IsNullOrEmpty(Nr))
                        {
                            query += "Nr = @Nr, ";
                            updatedColumns.Add("Nr");
                        }

                        if (!string.IsNullOrEmpty(PLZ))
                        {
                            query += "PLZ = @PLZ, ";
                            updatedColumns.Add("PLZ");
                        }

                        if (!string.IsNullOrEmpty(Ort))
                        {
                            query += "Ort = @Ort, ";
                            updatedColumns.Add("Ort");
                        }

                        if (!string.IsNullOrEmpty(Telefon))
                        {
                            query += "Telefon = @Telefon, ";
                            updatedColumns.Add("Telefon");
                        }

                        if (!string.IsNullOrEmpty(EMail))
                        {
                            query += "[E-Mail] = @EMail, ";
                            updatedColumns.Add("EMail");
                        }

                        if (!string.IsNullOrEmpty(Position))
                        {
                            query += "Position = @Position, ";
                            updatedColumns.Add("Position");
                        }

                        if (DatumEintritt != DateTime.MinValue)
                        {
                            query += "EintrittDatum = @EintrittDatum, ";
                            updatedColumns.Add("EintrittDatum");
                        }

                        if (!string.IsNullOrEmpty(Gehalt))
                        {
                            query += "Gehalt = @Gehalt, ";
                            updatedColumns.Add("Gehalt");
                        }

                        if (Geburtsdatum != DateTime.MinValue)
                        {
                            query += "Geburtsdatum = @Geburtsdatum, ";
                            updatedColumns.Add("Geburtsdatum");
                        }

                        if (!string.IsNullOrEmpty(Geschlecht))
                        {
                            query += "Geschlecht = @Geschlecht, ";
                            updatedColumns.Add("Geschlecht");
                        }

                        // Entferne das letzte Komma und Leerzeichen
                        query = query.TrimEnd(',', ' ');

                        // Füge die Bedingung für die WHERE-Klausel hinzu
                        query += " WHERE ID = @ID";

                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        if (!string.IsNullOrEmpty(Vorname))
                        {
                            command.Parameters.AddWithValue("@Vorname", Vorname);
                        }
                        if (!string.IsNullOrEmpty(Nachname))
                        {
                            command.Parameters.AddWithValue("@Nachname", Nachname);
                        }
                        if (!string.IsNullOrEmpty(Strasse))
                        {
                            command.Parameters.AddWithValue("@Strasse", Strasse);
                        }
                        if (!string.IsNullOrEmpty(Nr))
                        {
                            command.Parameters.AddWithValue("@Nr", Nr);
                        }
                        if (!string.IsNullOrEmpty(PLZ))
                        {
                            command.Parameters.AddWithValue("@PLZ", PLZ);
                        }
                        if (!string.IsNullOrEmpty(Ort))
                        {
                            command.Parameters.AddWithValue("@Ort", Ort);
                        }
                        if (!string.IsNullOrEmpty(Telefon))
                        {
                            command.Parameters.AddWithValue("@Telefon", Telefon);
                        }
                        if (!string.IsNullOrEmpty(EMail))
                        {
                            command.Parameters.AddWithValue("@EMail", EMail);
                        }
                        if (!string.IsNullOrEmpty(Position))
                        {
                            command.Parameters.AddWithValue("@Position", Position);
                        }
                        if (DatumEintritt != DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@EintrittDatum", DatumEintritt);
                        }
                        if (!string.IsNullOrEmpty(Gehalt))
                        {
                            command.Parameters.AddWithValue("@Gehalt", Gehalt);
                        }
                        if (Geburtsdatum != DateTime.MinValue)
                        {
                            command.Parameters.AddWithValue("@Geburtsdatum", Geburtsdatum);
                        }
                        if (!string.IsNullOrEmpty(Geschlecht))
                        {
                            command.Parameters.AddWithValue("@Geschlecht", Geschlecht);
                        }

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler beim Aktualisieren des Mitarbeiters: " + ex.Message);
                throw; // optional: Fehler weiter nach oben werfen
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
            if (string.IsNullOrWhiteSpace(m.Nachname) ||
                string.IsNullOrWhiteSpace(m.Vorname) ||
                string.IsNullOrWhiteSpace(m.EMail) ||
                string.IsNullOrWhiteSpace(m.Geschlecht) ||
                string.IsNullOrWhiteSpace(m.Position) ||
                string.IsNullOrWhiteSpace(m.Gehalt) ||
                string.IsNullOrWhiteSpace(m.Telefon) ||
                string.IsNullOrWhiteSpace(m.Strasse) ||
                string.IsNullOrWhiteSpace(m.Nr) ||
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
    }
}
