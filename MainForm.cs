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
        private void SetColumnWidths(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                int maxWidth = 0;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[column.Index].Value != null)
                    {
                        // Berücksichtige spezielle Breiten für die Spalten die den Datentyp "date" verwenden (Uhrzeit wird gefiltert)
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

                // Berücksichtige die Breite der Spaltenüberschrift
                int headerWidth = TextRenderer.MeasureText(column.HeaderText, dataGridView.Font).Width;
                maxWidth = Math.Max(maxWidth, headerWidth);

                // Setze die Breite der Spalte
                column.Width = maxWidth + 20; // 20 Pixel Puffer für Ausrichtung und Lesbarkeit
            }
        }
        //Autor: Okcu, Dogukan
        internal void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {   Application.Exit();     }

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
