using BTS_Mitarbeiterverwaltung.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BTS_Mitarbeiterverwaltung
{

    internal class Tools
    {
        private DataTable temporaryDataTable; // DataTable zum Zwischenspeichern der importierten Daten

        internal Tools()
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

        internal void FileImport()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
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

        internal void ToCSV(string filePath)
        {
            DataTable dataTableCSV = null;

            try
            {
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
                        dataTableCSV = new DataTable();
                        adapter.Fill(dataTableCSV);
                    }
                }

                // Exportiere die Daten in .csv
                ExportDataTableToCSV(dataTableCSV, filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Exportieren der Daten nach CSV: {ex.Message}");
            }
            finally
            {
                if (SqlVariable.connection.State == ConnectionState.Open)
                {
                    SqlVariable.connection.Close();
                }
            }
        }

        internal void ToTXT(string filePath)
        {
            DataTable dataTableTXT = null; // Deklaration außerhalb des try-Blocks

            try
            {
                if (SqlVariable.connection.State != ConnectionState.Open)
                {
                    SqlVariable.connection.Open();
                }

                string query = "SELECT * FROM dbo.Mitarbeiter";

                using (SqlCommand command = new SqlCommand(query, SqlVariable.connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // DataSet, um die Daten zu speichern
                        dataTableTXT = new DataTable();
                        adapter.Fill(dataTableTXT);
                    }
                }

                ExportDataTableToTXT(dataTableTXT, filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Exportieren der Daten nach TXT: {ex.Message}");
            }
            finally
            {
                if (SqlVariable.connection.State == ConnectionState.Open)
                {
                    SqlVariable.connection.Close();
                }
            }
        }

        internal void ExportDataTableToCSV(DataTable dataTable, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Schreibe Header-Zeile mit Spaltenüberschriften
                writer.WriteLine(string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName)));

                // Schreibe Datenzeilen
                foreach (DataRow row in dataTable.Rows)
                {
                    // Schreibe die Werte der aktuellen Zeile
                    string formattedRow = string.Join(",", row.ItemArray);
                    writer.WriteLine(formattedRow);
                }
            }
        }

        internal void ExportDataTableToTXT(DataTable dataTable, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Ermittle maximale Breite für jede Spalte
                Dictionary<string, int> columnWidths = new Dictionary<string, int>();
                foreach (DataColumn column in dataTable.Columns)
                {
                    int maxLength = Math.Max(column.ColumnName.Length, dataTable.AsEnumerable().Select(r => r[column].ToString().Length).Max());
                    columnWidths[column.ColumnName] = maxLength;
                }

                //Headerzeile mit Strichen
                string headerLine = string.Join(" | ", dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName.PadRight(columnWidths[column.ColumnName])));
                writer.WriteLine(headerLine);

                //Trennlinie mit Strichen
                string separatorLine = new string('-', columnWidths.Values.Sum() + (dataTable.Columns.Count - 1) * 3); // 3 = Länge des Trennzeichens " | "
                writer.WriteLine(separatorLine);

                // Schreibe Datenzeilen
                foreach (DataRow row in dataTable.Rows)
                {
                    string dataLine = string.Join(" | ", dataTable.Columns.Cast<DataColumn>().Select(column => row[column].ToString().PadRight(columnWidths[column.ColumnName])));
                    writer.WriteLine(dataLine);

                    // waagerechte Trennlinie zum Trennen der Datensätze
                    writer.WriteLine(separatorLine);
                }
            }
        }

        internal static void TryExport(Tools function)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    // Benutzer auffordern das Zielverzeichnis auszuwählen
                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        string targetFolder = folderBrowserDialog.SelectedPath;

                        // Erzeuge .csv und .txt Datei im ausgewählten Zielverzeichnis
                        string csvFilePath = Path.Combine(targetFolder, "Mitarbeiterliste.csv");
                        string txtFilePath = Path.Combine(targetFolder, "Mitarbeiterliste.txt");

                        // Überprüfe, ob Dateien überschrieben werden könnten
                        if (File.Exists(csvFilePath) || File.Exists(txtFilePath))
                        {
                            DialogResult overwriteResult = MessageBox.Show("Die Dateien 'Mitarbeiterliste.csv' und/oder 'Mitarbeiterliste.txt' existieren bereits. Möchten Sie die Dateien überschreiben?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (overwriteResult == DialogResult.No)
                            {
                                // Aktion abgebrochen
                                return;
                            }
                        }

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
    }
}
