﻿using System;
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
            DataTable table = Mitarbeiter.getAllMitarbeiter();
            dataGridView1.DataSource = table;
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
                Mitarbeiter.deleteMitarbeiter(selectedRowID);              
                DataTable table = Mitarbeiter.getAllMitarbeiter();
                dataGridView1.DataSource = table;                           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedRowID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            }
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(this, selectedRowID);
            updateForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Mitarbeiter.getMitarbeiterByName(txtBoxName.Text, txtBoxName.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DataTable table = Mitarbeiter.getAllMitarbeiter();
            dataGridView1.DataSource = table;
        }
    }
}
