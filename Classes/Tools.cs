using BTS_Mitarbeiterverwaltung.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BTS_Mitarbeiterverwaltung
{

    internal class Tools
    {

        internal Tools()
        {}

        internal void FileImport()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                //openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            while (!reader.EndOfStream)
                            {
                                string[] attributeValues = reader.ReadLine().Split(',');
                                InsertDataIntoDatabase(attributeValues);
                            }
                        }

                        MessageBox.Show("Daten erfolgreich aus der Datei importiert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fehler beim Importieren der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        internal void FileExport(Tools function)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
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
                        DataTable dataTable = null;

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
                                    dataTable = new DataTable();
                                    adapter.Fill(dataTable);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Fehler beim Laden der Daten: {ex.Message}");
                            return;
                        }
                        finally
                        {
                            if (SqlVariable.connection.State == ConnectionState.Open)
                            {
                                SqlVariable.connection.Close();
                            }
                        }

                        // Exportiere Daten in CSV und TXT
                        ExportDataTableToFile(dataTable, csvFilePath, ",");
                        ExportDataTableToFile(dataTable, txtFilePath, " | ");

                        MessageBox.Show("Daten erfolgreich exportiert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Öffne das Zielverzeichnis
                        Process.Start("explorer.exe", targetFolder);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Exportieren der Daten: {ex.Message}");
            }
        }

        private bool InsertDataIntoDatabase(string[] attributeValues)
        {
            try
            {
                SqlCommand commandUpdate = new SqlCommand(
                    "INSERT INTO mitarbeiter (Vorname, Nachname, Adresse, Telefon, [E-Mail], Position, " +
                    "EintrittDatum, Gehalt, Rentenbeginn, Geburtsdatum, Geschlecht) " +
                    "VALUES (@Vorname, @Nachname, @Adresse, @Telefon, @EMail, @Position, " +
                    "@EintrittDatum, @Gehalt, @Rentenbeginn, @Geburtsdatum, @Geschlecht)",
                    SqlVariable.connection);

                SqlVariable.connection.Open();

                //commandUpdate.Parameters.AddWithValue("@ID", Convert.ToInt32(attributeValues[0].Trim()));
                commandUpdate.Parameters.AddWithValue("@Vorname", attributeValues[1].Trim());
                commandUpdate.Parameters.AddWithValue("@Nachname", attributeValues[2].Trim());
                commandUpdate.Parameters.AddWithValue("@Adresse", attributeValues[3].Trim());
                commandUpdate.Parameters.AddWithValue("@Telefon", attributeValues[4].Trim());
                commandUpdate.Parameters.AddWithValue("@EMail", attributeValues[5].Trim());
                commandUpdate.Parameters.AddWithValue("@Position", attributeValues[6].Trim());
                commandUpdate.Parameters.AddWithValue("@EintrittDatum", Convert.ToDateTime(attributeValues[7]));
                commandUpdate.Parameters.AddWithValue("@Gehalt", attributeValues[8].Trim());
                commandUpdate.Parameters.AddWithValue("@Rentenbeginn", Convert.ToDateTime(attributeValues[9]));
                commandUpdate.Parameters.AddWithValue("@Geburtsdatum", Convert.ToDateTime(attributeValues[10]));
                commandUpdate.Parameters.AddWithValue("@Geschlecht", attributeValues[11].Trim());

                commandUpdate.ExecuteNonQuery();

                SqlVariable.connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Einfügen der Daten in die Datenbank: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal void ExportDataTableToFile(DataTable dataTable, string filePath, string delimiter)
        {
            try
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

                    //Headerzeile mit Delimiter
                    string headerLine = string.Join(delimiter, dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName.PadRight(columnWidths[column.ColumnName])));
                    writer.WriteLine(headerLine);

                    //Trennlinie mit Delimiter
                    string separatorLine = new string('-', columnWidths.Values.Sum() + (dataTable.Columns.Count - 1) * delimiter.Length); // Länge des Trennzeichens
                    writer.WriteLine(separatorLine);

                    // Schreibe Datenzeilen
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string dataLine = string.Join(delimiter, dataTable.Columns.Cast<DataColumn>().Select(column => row[column].ToString().PadRight(columnWidths[column.ColumnName])));
                        writer.WriteLine(dataLine);
                    }
                }

                Console.WriteLine($"Daten erfolgreich nach {Path.GetExtension(filePath).ToUpper()} exportiert!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Exportieren der Daten: {ex.Message}");
            }
        }

        internal static void DeleteRows(DataGridView dataGridView)
        {
            DialogResult result = MessageBox.Show("Möchten Sie wirklich löschen?", "Sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow selectedRow in dataGridView.SelectedRows)
                    {
                        int selectedRowID = Convert.ToInt32(selectedRow.Cells["ID"].Value); // Annahme: Die ID-Spalte hat den Namen "ID"
                        Employee.deleteEmployee(selectedRowID);
                    }
                    MessageBox.Show("Datensätze erfolgreich gelöscht!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // DataGridView aktualisieren (falls notwendig)
                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie mindestens eine Zeile zum Löschen aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
