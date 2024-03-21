using System;
using System.Data;
using System.Windows.Forms;
using BTS_Mitarbeiterverwaltung.Classes;


namespace BTS_Mitarbeiterverwaltung
{
    public partial class MainForm : Form
    {
        private Tools tools;
        internal int selectedRowID { get; set; }

        internal MainForm()
        {
            InitializeComponent();
            tools = new Tools();
        }
        internal void MainForm_Load(object sender, EventArgs e)
        {
            DataTable table = Employee.GetAllEmployees();
            dataGridViewEmployee.DataSource = table;
            SetColumnWidths(dataGridViewEmployee);

            UpdateRowCount();
        }

        // Passt die Breite der Spalten in der DataGrid an.
        // Durchläuft jede Spalte des DataGridViews.
        // Berechnet die maximale Breite für jede Spalte basierend auf den Zellwerten und der Spaltenüberschrift.
        // Berücksichtigt spezielle Breiten für Spalten mit Datentyp "date" (Uhrzeit wird gefiltert).
        // Setzt die Breite jeder Spalte entsprechend der berechneten maximalen Breite plus einem Puffer von 20 Pixeln für Ausrichtung und Lesbarkeit.
        private void SetColumnWidths(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                int maxWidth = 0;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[column.Index].Value != null)
                    {
                        if (column.Name == "Eintrittsdatum" || column.Name == "RentenBeginn" || column.Name == "Geburtsdatum")
                        {
                            maxWidth = Math.Max(maxWidth, 40);
                        }
                        else
                        {
                            int cellWidth = TextRenderer.MeasureText(row.Cells[column.Index].Value.ToString(), dataGridView.Font).Width;
                            maxWidth = Math.Max(maxWidth, cellWidth);
                        }
                    }
                }
                int headerWidth = TextRenderer.MeasureText(column.HeaderText, dataGridView.Font).Width;
                maxWidth = Math.Max(maxWidth, headerWidth);

                column.Width = maxWidth + 20;
            }
        }

        //Autor: Okcu, Dogukan
        internal void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {   Application.Exit();     }

        // Aktualisiert die Anzeige der Gesamtzahl der Datensätze und der ausgewählten Zeilen im DataGrid.
        // Ermittelt die Gesamtzahl der Zeilen im DataGrid und die Anzahl der ausgewählten Zeilen.
        // Aktualisiert die entsprechenden Anzeige-Labels mit den ermittelten Werten.
        internal void UpdateRowCount()
        {
            int totalRowCount = dataGridViewEmployee.RowCount;
            int selectedRowsCount = dataGridViewEmployee.SelectedRows.Count;

            lblTotalRows.Text = $"Anzahl Datensätze: {totalRowCount}";

            if (selectedRowsCount > 0)
            {
                lblSelectedRows.Text = $"Selected:  {selectedRowsCount}";
            }
            else
            {
                lblSelectedRows.Text = "";
            }
        }

        /// <summary>
        /// Reset the table and delete the text from search textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Autor: Okcu, Dogukan
        public void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = "";
            DataTable table = Employee.GetAllEmployees();
            dataGridViewEmployee.DataSource = table;

            UpdateRowCount();
        }

        /// <summary>
        /// Opens the employee-add interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Autor: Okcu, Dogukan
        internal void btnHinzufügen_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(this, 0);
            updateForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Tools.DeleteRows(dataGridViewEmployee);
            btnReset.PerformClick();
        }

        internal void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int totalRowCount = dataGridViewEmployee.RowCount;
            int selectedRowsCount = dataGridViewEmployee.SelectedRows.Count;

            lblTotalRows.Text = $"Anzahl Datensätze: {totalRowCount}";

            if (selectedRowsCount > 0)
            {
                lblSelectedRows.Text = $"Ausgewählt: {selectedRowsCount}";
                selectedRowID = Convert.ToInt32(dataGridViewEmployee.SelectedRows[0].Cells["ID"].Value);
            }
            else
            {
                lblSelectedRows.Text = "";
                selectedRowID = 0; // keine Zeile ausgewählt
            }
        }

        /// <summary>
        /// Opens the employee-edit interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Autor: Okcu, Dogukan
        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            if (selectedRowID != 0)
            {
                UpdateForm updateForm = new UpdateForm(this, selectedRowID);
                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wählen Sie bitte ein Mitarbeiter aus.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// search the employee that in the textbox given
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Autor: Okcu, Dogukan
        internal void txtBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridViewEmployee.DataSource = Employee.getEmployeeByName(txtBoxName.Text, txtBoxName.Text);
        }

        internal void btnExport_Click(object sender, EventArgs e)
        {
            Tools function = new Tools();
            tools.FileExport(function);
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            tools.FileImport();
            btnReset.PerformClick();
        }
    }
}
