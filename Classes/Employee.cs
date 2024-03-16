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
        public string Nachname { get; set; }
        internal string Adresse { get; set; }

        internal string Strasse { get; set; }
        internal string Nr { get; set; }
        internal string PLZ { get; set; }
        internal string Ort { get; set; }
        internal string Telefon { get; set; }
        internal string EMail { get; set; }
        internal string Position { get; set; }
        internal DateTime DatumEintritt { get; set; }
        internal string Gehalt { get; set; }
        internal DateTime DatumRentenBeginn { get; set; }
        internal DateTime Geburtsdatum { get; set; }
        internal string Geschlecht { get; set; }
        internal static int TotalRowCount { get; private set; }

        #endregion

        // nur Buchstaben, Leerzeichen und Steuerzeichen erlaubt
        public static void AllowOnlyNumbersAndControlCharacters(object sender, KeyPressEventArgs e)
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

                using (SqlCommand commandStart = new SqlCommand("SELECT * FROM mitarbeiter", SqlVariable.connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(commandStart))
                    {
                        adapter.Fill(table);
                    }
                }
                using (SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM mitarbeiter", SqlVariable.connection))
                {
                    TotalRowCount = (int)countCommand.ExecuteScalar();
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
                        Nachname = reader["Nachname"].ToString(),
                        Position = reader["Position"].ToString(),
                        DatumEintritt = Convert.ToDateTime(reader["EintrittDatum"]),
                        DatumRentenBeginn = Convert.ToDateTime(reader["Rentenbeginn"]),
                        EMail = reader["E-Mail"].ToString(),
                        Gehalt = reader["Gehalt"].ToString(),
                        Geburtsdatum = Convert.ToDateTime(reader["Geburtsdatum"]),
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
                SqlCommand commandUpdate = new SqlCommand("Insert into mitarbeiter (Vorname, Nachname, Telefon, [E-Mail], Position, EintrittDatum, Gehalt, Geburtsdatum, Geschlecht, Strasse, Nr, PLZ, Ort) values (@Vorname, @Nachname, @Telefon, @EMail, @Position, @EintrittDatum, @Gehalt, @Geburtsdatum, @Geschlecht, @Strasse, @Nr, @PLZ, @Ort)", SqlVariable.connection);
                SqlVariable.connection.Open();
                commandUpdate.Parameters.AddWithValue("@Vorname", this.Vorname);
                commandUpdate.Parameters.AddWithValue("@Nachname", this.Nachname);
                commandUpdate.Parameters.AddWithValue("@Telefon", this.Telefon);
                commandUpdate.Parameters.AddWithValue("@EMail", this.EMail);
                commandUpdate.Parameters.AddWithValue("@Position", this.Position);
                commandUpdate.Parameters.AddWithValue("@Eintrittdatum", this.DatumEintritt);
                commandUpdate.Parameters.AddWithValue("@Gehalt", this.Gehalt);
                commandUpdate.Parameters.AddWithValue("@Geburtsdatum", this.Geburtsdatum);
                commandUpdate.Parameters.AddWithValue("@Geschlecht", this.Geschlecht);
                commandUpdate.Parameters.AddWithValue("@Strasse", this.Strasse);
                commandUpdate.Parameters.AddWithValue("@Nr", this.Nr);
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
                    "Nachname = @Nachname, " +
                    "Telefon = @Telefon, " +
                    "[E-Mail] = @EMail, " +
                    "Position = @Position, " +
                    "EintrittDatum = @EintrittDatum, " +
                    "Gehalt = @Gehalt, " +
                    "Geburtsdatum = @Geburtsdatum, " +
                    "Geschlecht = @Geschlecht, " +
                    "Strasse = @Strasse, " +
                    "Nr = @Nr, " +
                    "PLZ = @PLZ, " +
                    "Ort = @Ort " +
                    "WHERE ID = @id",
                    SqlVariable.connection);
                SqlVariable.connection.Open();
                commandUpdate.Parameters.AddWithValue("@id", this.ID);
                commandUpdate.Parameters.AddWithValue("@Vorname", this.Vorname);
                commandUpdate.Parameters.AddWithValue("@Nachname", this.Nachname);
                commandUpdate.Parameters.AddWithValue("@Telefon", this.Telefon);
                commandUpdate.Parameters.AddWithValue("@EMail", this.EMail);
                commandUpdate.Parameters.AddWithValue("@Position", this.Position);
                commandUpdate.Parameters.AddWithValue("@Eintrittdatum", this.DatumEintritt);
                commandUpdate.Parameters.AddWithValue("@Gehalt", this.Gehalt);
                commandUpdate.Parameters.AddWithValue("@Geburtsdatum", this.Geburtsdatum);
                commandUpdate.Parameters.AddWithValue("@Strasse", this.Strasse);
                commandUpdate.Parameters.AddWithValue("@Nr", this.Nr);
                commandUpdate.Parameters.AddWithValue("@PLZ", this.PLZ);
                commandUpdate.Parameters.AddWithValue("@Ort", this.Ort);
                commandUpdate.Parameters.AddWithValue("@Geschlecht", this.Geschlecht);
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
