﻿using System;
using System.Data;
using System.Windows.Forms;
using BTS_Mitarbeiterverwaltung.Classes;


namespace BTS_Mitarbeiterverwaltung
{
    public partial class MainForm : Form
    {
        private Tools tools;
        internal MainForm()
        {
            InitializeComponent();
            tools = new Tools();
        }

        internal void MainForm_Load(object sender, EventArgs e)
        {
            DataTable table = Employee.GetAllEmployees();
            dataGridViewEmployee.DataSource = table;
            UpdateRowCount();

            SetColumnWidths(dataGridViewEmployee);
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
                            maxWidth = Math.Max(maxWidth, 40); // Setze Breite auf 40
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
        public void btnReset_Click(object sender, EventArgs e)
        {
            DataTable table = Employee.GetAllEmployees();
            dataGridViewEmployee.DataSource = table;
            UpdateRowCount();
        }
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
            }
            else
            {
                lblSelectedRows.Text = "";
            }
        }
        internal void btnBearbeiten_Click(object sender, EventArgs e)
        {}
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
        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}
        private void lblSelectedRows_Click(object sender, EventArgs e)
        {}
        private void lblSelectedRows_Click_1(object sender, EventArgs e)
        {}
    }
}
