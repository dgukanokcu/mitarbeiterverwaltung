using BTS_Mitarbeiterverwaltung.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BTS_Mitarbeiterverwaltung
{

    internal class Tools
    {
        internal Tools()
        {}

        // Importiert Daten aus einer Textdatei in die Anwendung.
        // Öffnet einen Dateiauswahldialog, um die zu importierende Datei auszuwählen.
        // Liest die Daten aus der ausgewählten Datei und fügt sie in die Anwendung ein.
        // Bei erfolgreicher Ausführung wird eine Erfolgsmeldung angezeigt, andernfalls eine Fehlermeldung.
        internal void FileImport()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
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
                                InsertFromFile(attributeValues);
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

        // ermöglicht Benutzer, Daten aus der Anwendung in eine Textdatei zu exportieren
        // öffnet Dateiauswahldialog, um Speicherort und Dateinamen für exportierte Datei auszuwählen (.csv und .txt)
        // Anschließend werden die Daten aus der Anwendung in den ausgewählten Dateipfad abgelegt 
        // Bei erfolgreicher Ausführung -> Erfolgsmeldung an, andernfalls -> Fehlermeldung
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
                        ExportDataTableToFile(dataTable, csvFilePath, ";");
                        ExportDataTableToFile(dataTable, txtFilePath, " | ");

                        MessageBox.Show("Daten erfolgreich exportiert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Öffne Textdokument nach Export
                        Process.Start(txtFilePath);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Exportieren der Daten: {ex.Message}");
            }
        }

        // Diese Methode fügt Daten aus einer Textdatei in die Datenbanktabelle "Mitarbeiter" ein
        // nimmt ein Array von Attributwerten entgegen
        // Trim: entfernt unerwünschte Leerzeichen und formatiert die Daten für die Weiterverarbeitung
        // nach Validierung: SQL-Befehl für das Einfügen von Datensätzen in die Datenbank
        private bool InsertFromFile(string[] attributeValues)
        {
            try
            {
                SqlCommand commandUpdate = new SqlCommand(
                    "INSERT INTO mitarbeiter (Vorname, Nachname, Strasse, Nr, PLZ, Ort, Telefon, [E-Mail], Position, " +
                    "EintrittDatum, Gehalt, Geburtsdatum, Geschlecht) " +
                    "VALUES (@Vorname, @Nachname, @Strasse, @Nr, @PLZ, @Ort, @Telefon, @EMail, @Position, " +
                    "@Eintrittsdatum, @Gehalt, @Geburtsdatum, @Geschlecht)",
                    SqlVariable.connection);

                SqlVariable.connection.Open();

                commandUpdate.Parameters.AddWithValue("@Vorname", attributeValues[1].Trim());
                commandUpdate.Parameters.AddWithValue("@Nachname", attributeValues[2].Trim());
                commandUpdate.Parameters.AddWithValue("@Strasse", attributeValues[3].Trim());
                commandUpdate.Parameters.AddWithValue("@Nr", attributeValues[4].Trim());
                commandUpdate.Parameters.AddWithValue("@PLZ", attributeValues[5].Trim());
                commandUpdate.Parameters.AddWithValue("@Ort", attributeValues[6].Trim());
                commandUpdate.Parameters.AddWithValue("@Telefon", attributeValues[7].Trim());
                commandUpdate.Parameters.AddWithValue("@EMail", attributeValues[8].Trim());
                commandUpdate.Parameters.AddWithValue("@Position", attributeValues[9].Trim());

                DateTime eintrittsdatum;
                string rawEintrittsdatum = attributeValues[10].Trim();

                if (DateTime.TryParseExact(rawEintrittsdatum, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out eintrittsdatum) ||
                    DateTime.TryParseExact(rawEintrittsdatum, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out eintrittsdatum) ||
                    DateTime.TryParseExact(rawEintrittsdatum, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out eintrittsdatum))
                {
                    string formattedEintrittsdatum = eintrittsdatum.ToString("dd.MM.yyyy");
                    commandUpdate.Parameters.AddWithValue("@Eintrittsdatum", formattedEintrittsdatum);
                }
                else
                {
                    MessageBox.Show("Ungültiges Eintrittsdatum", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                commandUpdate.Parameters.AddWithValue("@Gehalt", attributeValues[11].Trim());
                commandUpdate.Parameters.AddWithValue("@Geburtsdatum", Convert.ToDateTime(attributeValues[12]));

                string geschlecht = attributeValues[13].Trim().ToLower();
                if (geschlecht == "männlich" || geschlecht == "weiblich")
                {
                    commandUpdate.Parameters.AddWithValue("@Geschlecht", geschlecht);
                }
                else
                {
                    MessageBox.Show("Ungültige Eingabe für Geschlecht", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                commandUpdate.ExecuteNonQuery();

                SqlVariable.connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Einfügen der Daten {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // exportiert Daten aus einer DataTable in eine Text- und CSV-Datei.
        // akzeptiert die DataTable 'dataTable', den Dateipfad 'filePath' und den Trennzeichen 'delimiter' als Parameter.
        // Verwendung von StreamWriter um Datei zu erstellen und zu beschreiben
        // Es wird eine Headerzeile mit den Spaltenüberschriften und dem angegebenen Trennzeichen geschrieben.
        // Eine Trennlinie wird mit dem Trennzeichen entsprechend der Breiten der Spaltenüberschriften geschrieben.
        // Die Datenzeilen werden nacheinander geschrieben, wobei jedes Datenfeld entsprechend seiner maximalen Breite formatiert wird.
        // Fehler während des Exportvorgangs werden abgefangen und ausgegeben.
        internal void ExportDataTableToFile(DataTable dataTable, string filePath, string delimiter)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    Dictionary<string, int> columnHeadersWidths = new Dictionary<string, int>();

                    foreach (DataColumn column in dataTable.Columns)
                    {
                        int maxLength = Math.Max(column.ColumnName.Length, dataTable.AsEnumerable().Select(r => r[column].ToString().Length).Max());
                        columnHeadersWidths[column.ColumnName] = maxLength;

                        Console.WriteLine($"Spalte: {column.ColumnName}, Max-Länge: {maxLength}");
                    }

                    // Headerzeile mit Delimiter
                    string headerLine = string.Join(delimiter, dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName.PadRight(columnHeadersWidths[column.ColumnName])));
                    writer.WriteLine(headerLine);

                    // Trennlinie mit Delimiter
                    string separatorLine = new string('-', columnHeadersWidths.Values.Sum() + (dataTable.Columns.Count - 1) * delimiter.Length);
                    writer.WriteLine(separatorLine);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string dataLine = string.Join(delimiter, dataTable.Columns.Cast<DataColumn>().Select(column => (column.DataType == typeof(DateTime) ? ((DateTime)row[column]).ToString("yyyy-MM-dd") : row[column].ToString()).PadRight(columnHeadersWidths[column.ColumnName])));
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

        // Löscht ausgewählte Zeilen aus der DataGrid + Datenbank.
        // Überprüft, ob mindestens eine Zeile ausgewählt wurde.
        // Zeigt eine Warnmeldung an, wenn keine Zeile ausgewählt wurde, und beendet die Methode.
        // Zeigt eine Bestätigungsmeldung an, um das Löschen der ausgewählten Zeilen zu bestätigen.
        // Wenn der Benutzer bestätigt, entfernt die Methode die ausgewählten Mitarbeiter aus der Datenbank.
        // Zählt die Anzahl der gelöschten Mitarbeiter und zeigt eine Erfolgsmeldung an.
        // Bei einem Fehler wird eine entsprechende Fehlermeldung ausgegeben.
        internal static void DeleteRows(DataGridView dataGridView)
        {
            int selectedRowsCount = dataGridView.SelectedRows.Count;

            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Keine Zeile ausgewählt.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = selectedRowsCount == 1 ? "Mitarbeiter" : $"{selectedRowsCount} Mitarbeiter";

            DialogResult result = MessageBox.Show($"{message} entfernen?", "Sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int deletedCount = 0;

                foreach (DataGridViewRow selectedRow in dataGridView.SelectedRows)
                {
                    int selectedRowID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    Employee.deleteEmployee(selectedRowID);
                    deletedCount++;
                }

                message = deletedCount == 1 ? "Mitarbeiter wurde erfolgreich entfernt!" : $"{deletedCount} Mitarbeiter wurde erfolgreich entfernt!";
                MessageBox.Show(message, "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
