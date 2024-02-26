using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using BTS_Mitarbeiterverwaltung.Classes;

namespace BTS_Mitarbeiterverwaltung
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int selectedRowID { get; set; }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable table = Employee.getAllEmployees();
            dataGridViewEmployee.DataSource = table;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(this, 0);
            updateForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataGridViewEmployee.SelectedRows.Count > 0)
            {
                //if (dataGridViewEmployee.SelectedRows[0].Cells["ID"].Value is int)
                {
                    //selectedRowID = Convert.ToInt32(dataGridViewEmployee.SelectedRows[0].Cells["ID"].Value);
                    

                    try
                    {
                        selectedRowID = Convert.ToInt32(dataGridViewEmployee.CurrentRow.Cells["ID"].Value);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            if (selectedRowID != 0)
            {
                UpdateForm updateForm = new UpdateForm(this, selectedRowID);
                updateForm.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DataTable table = Employee.getAllEmployees();
            dataGridViewEmployee.DataSource = table;
        }

        private void txtBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridViewEmployee.DataSource = Employee.getEmployeeByName(txtBoxName.Text, txtBoxName.Text);
        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 /*&& e.RowIndex >= 0*/)
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
            else if (e.ColumnIndex == 1)
            {
                UpdateForm updateForm = new UpdateForm(this, selectedRowID);
                updateForm.Show();
            }
        }

        private void dataGridViewEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                dataGridViewEmployee.ClearSelection();
            }
        }
    }
}
