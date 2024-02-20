using BTS_Mitarbeiterverwaltung.Classes;
using BTS_Mitarbeiterverwaltung.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BTS_Mitarbeiterverwaltung
{

    public class Function
    {
        private DataTable temporaryDataTable; // DataTable zum Zwischenspeichern der importierten Daten

        public Function()
        {
            // Initialisiere die DataTable
            temporaryDataTable = new DataTable();

            // Füge die erforderlichen Spalten hinzu, entsprechend der Struktur deiner Datenbanktabelle
            temporaryDataTable.Columns.Add("Vorname", typeof(string));
            temporaryDataTable.Columns.Add("Nachname", typeof(string));
            temporaryDataTable.Columns.Add("Adresse", typeof(string));
            temporaryDataTable.Columns.Add("Telefon", typeof(int));
            temporaryDataTable.Columns.Add("Email", typeof(string));
            temporaryDataTable.Columns.Add("Position", typeof(string));
            temporaryDataTable.Columns.Add("Eintrittsdatum", typeof(DateTime));
            temporaryDataTable.Columns.Add("Gehalt", typeof(int));
            temporaryDataTable.Columns.Add("Rentenbeginn", typeof(DateTime));
            temporaryDataTable.Columns.Add("Geburtsdatum", typeof(DateTime));
            temporaryDataTable.Columns.Add("Alter", typeof(int));
        }

        public void FileImport()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Selected file path
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                // Split the line into fields (assuming comma-separated values)
                                string[] fields = line.Split(',');

                                // Add the fields to the temporaryDataTable
                                DataRow newRow = temporaryDataTable.NewRow();
                                for (int i = 0; i < fields.Length; i++)
                                {
                                    // Assuming that the fields are in the format "Attribute: Value"
                                    string[] parts = fields[i].Split(':');
                                    if (parts.Length == 2)
                                    {
                                        string attribute = parts[0].Trim();
                                        string value = parts[1].Trim();
                                        newRow[attribute] = value;
                                    }
                                }
                                temporaryDataTable.Rows.Add(newRow);
                            }
                        }

                        MessageBox.Show("Daten erfolgreich importiert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fehler beim Importieren der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void ToCSV(string filePath)
        {
            DataTable dataTableCSV = null; // Deklaration außerhalb des try-Blocks

            try
            {
                // Öffnen Sie die Verbindung, wenn sie nicht geöffnet ist
                if (SqlVariable.connection.State != ConnectionState.Open)
                {
                    SqlVariable.connection.Open();
                }

                // SQL-Abfrage zum Abrufen aller Spalten und Zeilen
                string query = "SELECT * FROM dbo.Mitarbeiter";

                using (SqlCommand command = new SqlCommand(query, SqlVariable.connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Erstellen Sie ein DataSet, um die Daten zu speichern
                        dataTableCSV = new DataTable(); // Instanz für CSV erstellen
                        adapter.Fill(dataTableCSV);
                    }
                }

                // Exportieren Sie die Daten in die CSV-Datei
                ExportDataTableToCSV(dataTableCSV, filePath);
            }
            catch (Exception ex)
            {
                // Behandeln Sie Ausnahmen entsprechend Ihrer Anwendungslogik
                Console.WriteLine($"Fehler beim Exportieren der Daten nach CSV: {ex.Message}");
            }
            finally
            {
                // Stellen Sie sicher, dass die Verbindung geschlossen wird
                if (SqlVariable.connection.State == ConnectionState.Open)
                {
                    SqlVariable.connection.Close();
                }
            }
        }


        public void ToTXT(string filePath)
        {
            DataTable dataTableTXT = null; // Deklaration außerhalb des try-Blocks

            try
            {
                // Öffnen Sie die Verbindung, wenn sie nicht geöffnet ist
                if (SqlVariable.connection.State != ConnectionState.Open)
                {
                    SqlVariable.connection.Open();
                }

                // SQL-Abfrage zum Abrufen aller Spalten und Zeilen
                string query = "SELECT * FROM dbo.Mitarbeiter";

                using (SqlCommand command = new SqlCommand(query, SqlVariable.connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Erstellen Sie ein DataSet, um die Daten zu speichern
                        dataTableTXT = new DataTable(); // Instanz für TXT erstellen
                        adapter.Fill(dataTableTXT);
                    }
                }

                // Exportieren Sie die Daten in die TXT-Datei
                ExportDataTableToTXT(dataTableTXT, filePath);
            }
            catch (Exception ex)
            {
                // Behandeln Sie Ausnahmen entsprechend Ihrer Anwendungslogik
                Console.WriteLine($"Fehler beim Exportieren der Daten nach TXT: {ex.Message}");
            }
            finally
            {
                // Stellen Sie sicher, dass die Verbindung geschlossen wird
                if (SqlVariable.connection.State == ConnectionState.Open)
                {
                    SqlVariable.connection.Close();
                }
            }
        }

        public void ExportDataTableToCSV(DataTable dataTable, string filePath)
        {
            // Implementierung der CSV-Exportlogik
            // Verwende StreamWriter, um die Daten in die CSV-Datei zu schreiben
            // Beachte dabei die Trennzeichen und die Formatierung der Daten

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Schreiben Sie die Headerzeile in tabellarischer Struktur
                writer.WriteLine(string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName)));

                // Schreiben Sie die Datenzeilen in tabellarischer Struktur
                foreach (DataRow row in dataTable.Rows)
                {
                    // Schreiben Sie die Werte in tabellarischer Struktur
                    writer.WriteLine(string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(column => row[column])));
                }
            }
        }

        public void ExportDataTableToTXT(DataTable dataTable, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Schreibe Headerzeile mit Strichen
                string headerLine = string.Join(" | ", dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName));
                writer.WriteLine(headerLine);

                // Schreibe Trennlinie mit Strichen
                string separatorLine = new string('-', headerLine.Length);
                writer.WriteLine(separatorLine);

                // Schreibe Datenzeilen
                foreach (DataRow row in dataTable.Rows)
                {
                    string dataLine = string.Join(" | ", row.ItemArray);
                    writer.WriteLine(dataLine);
                }
            }
        }

        public static void TryExport(Function function)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    // Fordere den Benutzer auf, das Zielverzeichnis auszuwählen
                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        string targetFolder = folderBrowserDialog.SelectedPath;

                        // Erzeuge die vollständigen Dateinamen mit dem ausgewählten Zielverzeichnis
                        string csvFilePath = Path.Combine(targetFolder, "Mitarbeiterliste.csv");
                        string txtFilePath = Path.Combine(targetFolder, "Mitarbeiterliste.txt");

                        // Überprüfe, ob die Dateien bereits existieren
                        if (File.Exists(csvFilePath) || File.Exists(txtFilePath))
                        {
                            // Dateien existieren bereits, frage nach Bestätigung
                            DialogResult overwriteResult = MessageBox.Show("Die Dateien 'Mitarbeiterliste.csv' und/oder 'Mitarbeiterliste.txt' existieren bereits. Möchten Sie die Dateien überschreiben?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (overwriteResult == DialogResult.No)
                            {
                                // Benutzer hat die Aktion abgebrochen
                                return;
                            }
                        }

                        // Exportiere die Daten
                        function.ToCSV(csvFilePath);
                        function.ToTXT(txtFilePath);

                        MessageBox.Show("Daten erfolgreich exportiert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Exportieren der Daten: {ex.Message}");
            }
        }

        public void LoadDataGridView(DataGridView dataGridView)
        {
            try
            {
                // Die Verbindung sollte bereits geöffnet sein (von außen oder vorherigen Aufrufen)
                // Wenn nicht, öffnen Sie die Verbindung
                if (SqlVariable.connection.State != ConnectionState.Open)
                {
                    SqlVariable.connection.Open();
                }

                // SQL-Abfrage: Abrufen der Inhalte der Tabelle dbo.Mitarbeiter
                string query = "SELECT * FROM dbo.Mitarbeiter";

                using (SqlCommand command = new SqlCommand(query, SqlVariable.connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Datasource hinzufügen, um die Daten in der DataGridView anzeigen zu lassen
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Abrufen der Mitarbeiterdaten: {ex.Message}");
            }
            finally
            {
                // Schließen Sie die Verbindung nur, wenn Sie sie vorher geöffnet haben
                if (SqlVariable.connection.State == ConnectionState.Open)
                {
                    SqlVariable.connection.Close();
                }
            }
        }

        public static bool Validation(string benutzername, string passwort)
        {
            try
            {
                // Verwende parameterisierte Abfragen
                string query = "SELECT Benutzername, PasswortHash, Salt FROM Benutzer WHERE Benutzername = @Benutzername";

                using (SqlCommand command = new SqlCommand(query, SqlVariable.connection))
                {
                    command.Parameters.AddWithValue("@Benutzername", benutzername);

                    // Öffne Verbindung, wenn geschlossen
                    if (SqlVariable.connection.State != ConnectionState.Open)
                    {
                        SqlVariable.connection.Open();
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Benutzer gefunden, überprüfe das Passwort
                            string storedPasswortHash = reader["PasswortHash"].ToString();
                            string salt = reader["Salt"].ToString();

                            // Verwende HashPasswort-Methode aus der PasswortUtility
                            string inputPasswortHash = PasswortUtility.HashPasswort(passwort, salt);

                            // Login erfolgreich, wenn Hash übereinstimmt
                            return storedPasswortHash == inputPasswortHash;
                        }
                    }
                }

                // Benutzername nicht gefunden
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Überprüfen des Logins: {ex.Message}");
                return false;
            }
            finally
            {
                if (SqlVariable.connection.State == ConnectionState.Open)
                {
                    SqlVariable.connection.Close();
                }
            }
        }
    }
}
