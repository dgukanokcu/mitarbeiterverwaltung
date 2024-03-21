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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geschlecht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emailadresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eintrittsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gehalt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentenBeginn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geburtsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.lblSelectedRows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToOrderColumns = true;
            this.dataGridViewEmployee.AllowUserToResizeColumns = false;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.Nr,
            this.PLZ,
            this.Position,
            this.Eintrittsdatum,
            this.Gehalt,
            this.RentenBeginn,
            this.Geburtsdatum,
            this.Alter});
            this.dataGridViewEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewEmployee.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewEmployee.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(6, 92);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEmployee.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployee.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewEmployee.ShowEditingIcon = false;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1297, 321);
            this.dataGridViewEmployee.StandardTab = true;
            this.dataGridViewEmployee.TabIndex = 0;
            this.dataGridViewEmployee.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkBlue;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 4;
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.ToolTipText = "Mitarbeiterkennung";
            this.ID.Width = 43;
            // 
            // Vorname
            // 
            this.Vorname.DataPropertyName = "Vorname";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Vorname.DefaultCellStyle = dataGridViewCellStyle3;
            this.Vorname.Frozen = true;
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.MinimumWidth = 6;
            this.Vorname.Name = "Vorname";
            this.Vorname.ReadOnly = true;
            this.Vorname.Width = 74;
            // 
            // Nachname
            // 
            this.Nachname.DataPropertyName = "Nachname";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Nachname.DefaultCellStyle = dataGridViewCellStyle4;
            this.Nachname.Frozen = true;
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.MinimumWidth = 6;
            this.Nachname.Name = "Nachname";
            this.Nachname.ReadOnly = true;
            this.Nachname.Width = 84;
            // 
            // Geschlecht
            // 
            this.Geschlecht.DataPropertyName = "Geschlecht";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Geschlecht.DefaultCellStyle = dataGridViewCellStyle5;
            this.Geschlecht.HeaderText = "Geschlecht";
            this.Geschlecht.MinimumWidth = 6;
            this.Geschlecht.Name = "Geschlecht";
            this.Geschlecht.ReadOnly = true;
            this.Geschlecht.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Geschlecht.Width = 67;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Telefon.DefaultCellStyle = dataGridViewCellStyle6;
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Width = 68;
            // 
            // Emailadresse
            // 
            this.Emailadresse.DataPropertyName = "E-Mail";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Emailadresse.DefaultCellStyle = dataGridViewCellStyle7;
            this.Emailadresse.HeaderText = "Email";
            this.Emailadresse.MinimumWidth = 6;
            this.Emailadresse.Name = "Emailadresse";
            this.Emailadresse.ReadOnly = true;
            this.Emailadresse.Width = 57;
            // 
            // Nr
            // 
            this.Nr.DataPropertyName = "Nr";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Nr.DefaultCellStyle = dataGridViewCellStyle8;
            this.Nr.HeaderText = "Nr";
            this.Nr.MinimumWidth = 6;
            this.Nr.Name = "Nr";
            this.Nr.ReadOnly = true;
            this.Nr.Width = 43;
            // 
            // PLZ
            // 
            this.PLZ.DataPropertyName = "PLZ";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.PLZ.DefaultCellStyle = dataGridViewCellStyle9;
            this.PLZ.HeaderText = "PLZ";
            this.PLZ.MinimumWidth = 6;
            this.PLZ.Name = "PLZ";
            this.PLZ.ReadOnly = true;
            this.PLZ.Width = 52;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Position.DefaultCellStyle = dataGridViewCellStyle10;
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 69;
            // 
            // Eintrittsdatum
            // 
            this.Eintrittsdatum.DataPropertyName = "EintrittDatum";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Eintrittsdatum.DefaultCellStyle = dataGridViewCellStyle11;
            this.Eintrittsdatum.HeaderText = "Eintrittsdatum";
            this.Eintrittsdatum.MinimumWidth = 6;
            this.Eintrittsdatum.Name = "Eintrittsdatum";
            this.Eintrittsdatum.ReadOnly = true;
            this.Eintrittsdatum.Width = 95;
            // 
            // Gehalt
            // 
            this.Gehalt.DataPropertyName = "Gehalt";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Gehalt.DefaultCellStyle = dataGridViewCellStyle12;
            this.Gehalt.HeaderText = "Gehalt";
            this.Gehalt.MinimumWidth = 6;
            this.Gehalt.Name = "Gehalt";
            this.Gehalt.ReadOnly = true;
            this.Gehalt.Width = 63;
            // 
            // RentenBeginn
            // 
            this.RentenBeginn.DataPropertyName = "Rentenbeginn";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.RentenBeginn.DefaultCellStyle = dataGridViewCellStyle13;
            this.RentenBeginn.HeaderText = "Rentenbeginn";
            this.RentenBeginn.MinimumWidth = 6;
            this.RentenBeginn.Name = "RentenBeginn";
            this.RentenBeginn.ReadOnly = true;
            this.RentenBeginn.Width = 99;
            // 
            // Geburtsdatum
            // 
            this.Geburtsdatum.DataPropertyName = "Geburtsdatum";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Geburtsdatum.DefaultCellStyle = dataGridViewCellStyle14;
            this.Geburtsdatum.HeaderText = "Geburtsdatum";
            this.Geburtsdatum.MinimumWidth = 6;
            this.Geburtsdatum.Name = "Geburtsdatum";
            this.Geburtsdatum.ReadOnly = true;
            this.Geburtsdatum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Geburtsdatum.Width = 79;
            // 
            // Alter
            // 
            this.Alter.DataPropertyName = "Alter";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.DarkBlue;
            this.Alter.DefaultCellStyle = dataGridViewCellStyle15;
            this.Alter.HeaderText = "Alter";
            this.Alter.MinimumWidth = 6;
            this.Alter.Name = "Alter";
            this.Alter.ReadOnly = true;
            this.Alter.Width = 53;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEmployee.Location = new System.Drawing.Point(1103, 47);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(200, 39);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Mitarbeiter hinzufügen";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(850, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 39);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Entfernen";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(973, 47);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 39);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Bearbeiten";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(9, 24);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(165, 32);
            this.txtBoxName.TabIndex = 5;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(179, 24);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 34);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Refresh";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(1233, 8);
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
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(1157, 8);
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
            this.lblTotalRows.Location = new System.Drawing.Point(6, 433);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(112, 18);
            this.lblTotalRows.TabIndex = 9;
            this.lblTotalRows.Text = "Anzahl Datensätze:";
            this.lblTotalRows.UseCompatibleTextRendering = true;
            // 
            // lblSelectedRows
            // 
            this.lblSelectedRows.AutoSize = true;
            this.lblSelectedRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedRows.Location = new System.Drawing.Point(9, 71);
            this.lblSelectedRows.Name = "lblSelectedRows";
            this.lblSelectedRows.Size = new System.Drawing.Size(66, 17);
            this.lblSelectedRows.TabIndex = 10;
            this.lblSelectedRows.Text = "Ausgewählt:";
            this.lblSelectedRows.UseCompatibleTextRendering = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1315, 460);
            this.Controls.Add(this.lblSelectedRows);
            this.Controls.Add(this.lblTotalRows);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBoxName);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eintrittsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gehalt;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentenBeginn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geburtsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alter;
    }
}