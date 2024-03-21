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

        /// <summary>
        /// Set the employee informations 
        /// </summary>
        /// <param name="vorname"></param>
        /// <param name="nachname"></param>
        /// <param name="strasse"></param>
        /// <param name="nr"></param>
        /// <param name="plz"></param>
        /// <param name="ort"></param>
        /// <param name="telefon"></param>
        /// <param name="email"></param>
        /// <param name="position"></param>
        /// <param name="datumEintritt"></param>
        /// <param name="gehalt"></param>
        /// <param name="geburtsdatum"></param>
        /// <param name="geschlecht"></param>
        /// Autor: Okcu, Dogukan
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
        /// <summary>
        /// Allows only the number and control characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Autor: Okcu, Dogukan
        internal static void AllowOnlyNumbersAndControlCharacters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Allows only the letter and control characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Autor: Okcu, Dogukan
        internal static void AllowOnlyLettersAndControlCharacters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Get all Employees as DataTable
        /// </summary>
        /// <returns></returns>
        /// Autor: Okcu, Dogukan
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

        /// <summary>
        /// Search employee by name
        /// </summary>
        /// <param name="vorname"></param>
        /// <param name="nachname"></param>
        /// Autor: Okcu, Dogukan
        /// <returns></returns>
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

        /// <summary>
        /// Get employee by ID
        /// </summary>
        /// <param name="id"></param>
        /// Autor: Okcu, Dogukan
        /// <returns></returns>
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

        /// <summary>
        /// Update the employee
        /// </summary>
        /// Autor: Okcu, Dogukan
        /// <param name="oldValue"></param>
        internal void UpdateEmployee(Employee oldValue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SqlVariable.connection.ConnectionString))
                {
                    connection.Open();

                    string query;

                    if (ID == 0)
                    {
                        query = "INSERT INTO mitarbeiter (Vorname, Nachname, Telefon, [E-Mail], Position, EintrittDatum, Gehalt, Geburtsdatum, Geschlecht, Strasse, Nr, PLZ, Ort) " +
                                "VALUES (@Vorname, @Nachname, @Telefon, @EMail, @Position, @EintrittDatum, @Gehalt, @Geburtsdatum, @Geschlecht, @Strasse, @Nr, @PLZ, @Ort)";
                    }
                    else
                    {
                        query = "UPDATE mitarbeiter SET ";


                        if (oldValue.Vorname != Vorname)
                        {
                            query += "Vorname = @Vorname, ";
                        }

                        if (oldValue.Nachname != Nachname)
                        {
                            query += "Nachname = @Nachname, ";
                        }

                        if (oldValue.Strasse != Strasse)
                        {
                            query += "Strasse = @Strasse, ";
                        }

                        if (oldValue.Nr != Nr)
                        {
                            query += "Nr = @Nr, ";
                        }

                        if (oldValue.PLZ != PLZ)
                        {
                            query += "PLZ = @PLZ, ";
                        }

                        if (oldValue.Ort != Ort)
                        {
                            query += "Ort = @Ort, ";
                        }

                        if (oldValue.Telefon != Telefon)
                        {
                            query += "Telefon = @Telefon, ";
                        }

                        if (oldValue.EMail != EMail)
                        {
                            query += "[E-Mail] = @EMail, ";
                        }

                        if (oldValue.Position != Position)
                        {
                            query += "Position = @Position, ";
                        }

                        if (oldValue.DatumEintritt != DatumEintritt)
                        {
                            query += "EintrittDatum = @EintrittDatum, ";
                        }

                        if (oldValue.Gehalt != Gehalt)
                        {
                            query += "Gehalt = @Gehalt, ";
                        }

                        if (oldValue.Geburtsdatum != Geburtsdatum)
                        {
                            query += "Geburtsdatum = @Geburtsdatum, ";
                        }

                        if (oldValue.Geschlecht != Geschlecht)
                        {
                            query += "Geschlecht = @Geschlecht, ";
                        }

                        // Entferne das letzte Komma und Leerzeichen
                        query = query.TrimEnd(',', ' ');

                        // Füge die Bedingung für die WHERE-Klausel hinzu
                        query += " WHERE ID = @ID";

                    }

                    if (query != "UPDATE mitarbeiter SET WHERE ID = @ID")
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID", ID);

                            command.Parameters.AddWithValue("@Vorname", Vorname);

                            command.Parameters.AddWithValue("@Nachname", Nachname);

                            command.Parameters.AddWithValue("@Strasse", Strasse);

                            command.Parameters.AddWithValue("@Nr", Nr);

                            command.Parameters.AddWithValue("@PLZ", PLZ);

                            command.Parameters.AddWithValue("@Ort", Ort);

                            command.Parameters.AddWithValue("@Telefon", Telefon);

                            command.Parameters.AddWithValue("@EMail", EMail);

                            command.Parameters.AddWithValue("@Position", Position);

                            command.Parameters.AddWithValue("@EintrittDatum", DatumEintritt);

                            command.Parameters.AddWithValue("@Gehalt", Gehalt);

                            command.Parameters.AddWithValue("@Geburtsdatum", Geburtsdatum);

                            command.Parameters.AddWithValue("@Geschlecht", Geschlecht);

                            command.ExecuteNonQuery();
                        }
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
        /// <summary>
        /// Validate the informations if they are empty
        /// </summary>
        /// <param name="m"></param>
        /// Autor: Okcu, Dogukan
        /// <returns></returns>
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
