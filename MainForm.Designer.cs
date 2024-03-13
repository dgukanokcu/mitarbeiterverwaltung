namespace BTS_Mitarbeiterverwaltung
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.lblSelectedRows = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geschlecht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emailadresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eintrittsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gehalt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentenBeginn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geburtsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AllowUserToResizeColumns = false;
            this.dataGridViewEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmployee.ColumnHeadersHeight = 40;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Vorname,
            this.Nachname,
            this.Geschlecht,
            this.Telefon,
            this.Emailadresse,
            this.Position,
            this.Eintrittsdatum,
            this.Gehalt,
            this.RentenBeginn,
            this.Geburtsdatum,
            this.Alter});
            this.dataGridViewEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewEmployee.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewEmployee.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(12, 162);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewEmployee.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEmployee.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1091, 306);
            this.dataGridViewEmployee.StandardTab = true;
            this.dataGridViewEmployee.TabIndex = 0;
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick);
            this.dataGridViewEmployee.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 62);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(169, 31);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Mitarbeiter hinzufügen";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(321, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 31);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(225, 62);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 31);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Bearbeiten";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(225, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(16, 14);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(165, 32);
            this.txtBoxName.TabIndex = 5;
            this.txtBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxName_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(321, 14);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 31);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Refresh";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExport.Location = new System.Drawing.Point(814, 84);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(70, 31);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnImport.Location = new System.Drawing.Point(738, 84);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(70, 31);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotalRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalRows.Location = new System.Drawing.Point(13, 479);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(112, 18);
            this.lblTotalRows.TabIndex = 9;
            this.lblTotalRows.Text = "Anzahl Datensätze:";
            this.lblTotalRows.UseCompatibleTextRendering = true;
            this.lblTotalRows.Click += new System.EventHandler(this.lblSelectedRows_Click);
            // 
            // lblSelectedRows
            // 
            this.lblSelectedRows.AutoSize = true;
            this.lblSelectedRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedRows.Location = new System.Drawing.Point(13, 140);
            this.lblSelectedRows.Name = "lblSelectedRows";
            this.lblSelectedRows.Size = new System.Drawing.Size(51, 17);
            this.lblSelectedRows.TabIndex = 10;
            this.lblSelectedRows.Text = "Selected:";
            this.lblSelectedRows.UseCompatibleTextRendering = true;
            this.lblSelectedRows.Click += new System.EventHandler(this.lblSelectedRows_Click_1);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkBlue;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 4;
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.ToolTipText = "Mitarbeiterkennung";
            this.ID.Width = 40;
            // 
            // Vorname
            // 
            this.Vorname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Vorname.DataPropertyName = "Vorname";
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.MinimumWidth = 6;
            this.Vorname.Name = "Vorname";
            this.Vorname.ReadOnly = true;
            this.Vorname.Width = 74;
            // 
            // Nachname
            // 
            this.Nachname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nachname.DataPropertyName = "Nachname";
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.MinimumWidth = 6;
            this.Nachname.Name = "Nachname";
            this.Nachname.ReadOnly = true;
            this.Nachname.Width = 84;
            // 
            // Geschlecht
            // 
            this.Geschlecht.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Geschlecht.DataPropertyName = "Geschlecht";
            this.Geschlecht.HeaderText = "Geschlecht";
            this.Geschlecht.MinimumWidth = 6;
            this.Geschlecht.Name = "Geschlecht";
            this.Geschlecht.ReadOnly = true;
            this.Geschlecht.Width = 86;
            // 
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Width = 68;
            // 
            // Emailadresse
            // 
            this.Emailadresse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Emailadresse.DataPropertyName = "E-Mail";
            this.Emailadresse.HeaderText = "Email";
            this.Emailadresse.MinimumWidth = 6;
            this.Emailadresse.Name = "Emailadresse";
            this.Emailadresse.ReadOnly = true;
            this.Emailadresse.Width = 57;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 69;
            // 
            // Eintrittsdatum
            // 
            this.Eintrittsdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Eintrittsdatum.DataPropertyName = "EintrittDatum";
            this.Eintrittsdatum.HeaderText = "Eintrittsdatum";
            this.Eintrittsdatum.MinimumWidth = 6;
            this.Eintrittsdatum.Name = "Eintrittsdatum";
            this.Eintrittsdatum.ReadOnly = true;
            this.Eintrittsdatum.Width = 95;
            // 
            // Gehalt
            // 
            this.Gehalt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Gehalt.DataPropertyName = "Gehalt";
            this.Gehalt.HeaderText = "Gehalt";
            this.Gehalt.MinimumWidth = 6;
            this.Gehalt.Name = "Gehalt";
            this.Gehalt.ReadOnly = true;
            this.Gehalt.Width = 63;
            // 
            // RentenBeginn
            // 
            this.RentenBeginn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RentenBeginn.DataPropertyName = "Rentenbeginn";
            this.RentenBeginn.HeaderText = "Rentenbeginn";
            this.RentenBeginn.MinimumWidth = 6;
            this.RentenBeginn.Name = "RentenBeginn";
            this.RentenBeginn.ReadOnly = true;
            this.RentenBeginn.Width = 99;
            // 
            // Geburtsdatum
            // 
            this.Geburtsdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Geburtsdatum.DataPropertyName = "Geburtsdatum";
            this.Geburtsdatum.HeaderText = "Geburtsdatum";
            this.Geburtsdatum.MinimumWidth = 6;
            this.Geburtsdatum.Name = "Geburtsdatum";
            this.Geburtsdatum.ReadOnly = true;
            this.Geburtsdatum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Geburtsdatum.Width = 79;
            // 
            // Alter
            // 
            this.Alter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Alter.DataPropertyName = "Alter";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Alter.DefaultCellStyle = dataGridViewCellStyle3;
            this.Alter.HeaderText = "Alter";
            this.Alter.Name = "Alter";
            this.Alter.ReadOnly = true;
            this.Alter.Width = 53;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1133, 505);
            this.Controls.Add(this.lblSelectedRows);
            this.Controls.Add(this.lblTotalRows);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste aller Mitarbeiter - Firma Pfusch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.Label lblSelectedRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geschlecht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emailadresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eintrittsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gehalt;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentenBeginn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geburtsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alter;
    }
}