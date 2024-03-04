using System;
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

        internal int selectedRowID { get; set; }

        internal void MainForm_Load(object sender, EventArgs e)
        {
            DataTable table = Employee.GetAllEmployees();
            dataGridViewEmployee.DataSource = table;
        }

        internal void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        internal void btnHinzufügen_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(this, 0);
            updateForm.Show();
        }

        internal void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie wirklich löschen?", "Sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dataGridViewEmployee.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow selectedRow in dataGridViewEmployee.SelectedRows)
                    {
                        int selectedRowID = Convert.ToInt32(selectedRow.Cells["ID"].Value); // Annahme: Die ID-Spalte hat den Namen "ID"
                        Employee.deleteEmployee(selectedRowID);
                        dataGridViewEmployee.Rows.Remove(selectedRow);
                    }
                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie mindestens eine Zeile zum Löschen aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        internal void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.CurrentRow != null &&
                dataGridViewEmployee.CurrentRow.Cells["ID"].Value != DBNull.Value)
            {
                try
                {
                    selectedRowID = Convert.ToInt32(dataGridViewEmployee.CurrentRow.Cells["ID"].Value);
                }
                catch (FormatException)
                {}
            }
        }

        internal void btnBearbeiten_Click(object sender, EventArgs e)
        {
            if (selectedRowID != 0)
            {
                UpdateForm updateForm = new UpdateForm(this, selectedRowID);
                updateForm.Show();
            }
        }

        internal void btnReset_Click(object sender, EventArgs e)
        {
            DataTable table = Employee.GetAllEmployees();
            dataGridViewEmployee.DataSource = table;
        }

        internal void txtBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridViewEmployee.DataSource = Employee.getEmployeeByName(txtBoxName.Text, txtBoxName.Text);
        }

        internal void dataGridViewEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                dataGridViewEmployee.ClearSelection();
            }
        }

        internal void btnExport_Click(object sender, EventArgs e)
        {
            Tools function = new Tools();
            tools.TryExport(function);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            tools.FileImport();
        }
    }
}
