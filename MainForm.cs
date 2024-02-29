using System;
using System.Data;
using System.Windows.Forms;
using BTS_Mitarbeiterverwaltung.Classes;

namespace BTS_Mitarbeiterverwaltung
{
    public partial class MainForm : Form
    {
        internal MainForm()
        {
            InitializeComponent();
        }

        internal int selectedRowID { get; set; }
        internal void MainForm_Load(object sender, EventArgs e)
        {
            DataTable table = Employee.getAllEmployees();
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
                Employee.deleteEmployee(selectedRowID);
                DataTable table = Employee.getAllEmployees();
                dataGridViewEmployee.DataSource = table;
                MessageBox.Show("Mitarbeiter wurde erfolgreich gelöscht!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DataTable table = Employee.getAllEmployees();
            dataGridViewEmployee.DataSource = table;
        }

        internal void txtBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridViewEmployee.DataSource = Employee.getEmployeeByName(txtBoxName.Text, txtBoxName.Text);
        }

        internal void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 /*&& e.RowIndex >= 0*/)
            {
                DialogResult result = MessageBox.Show("Möchten Sie es wirklich löschen?", "Sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Employee.deleteEmployee(selectedRowID);
                    DataTable table = Employee.getAllEmployees();
                    dataGridViewEmployee.DataSource = table;
                    MessageBox.Show("Mitarbeiter wurde erfolgreich gelöscht!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (e.ColumnIndex == 1)
            {
                UpdateForm updateForm = new UpdateForm(this, selectedRowID);
                updateForm.Show();
            }
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
            Tools.TryExport(function);
        }
    }
}
