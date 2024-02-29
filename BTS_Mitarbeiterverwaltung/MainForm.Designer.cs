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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geschlecht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emailadresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geburtsdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eintritt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gehalt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentenBeginn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DeleteColumn,
            this.EditColumn,
            this.Vorname,
            this.Name,
            this.Geschlecht,
            this.Adresse,
            this.Telefon,
            this.Emailadresse,
            this.Position,
            this.Geburtsdatum,
            this.Alter,
            this.Eintritt,
            this.Gehalt,
            this.RentenBeginn});
            this.dataGridViewEmployee.Location = new System.Drawing.Point(15, 77);
            this.dataGridViewEmployee.Location = new System.Drawing.Point(16, 54);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1121, 343);
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1084, 329);
            this.dataGridViewEmployee.TabIndex = 0;
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick);
            this.dataGridViewEmployee.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewEmployee_CellMouseClick);
            this.dataGridViewEmployee.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 6;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteColumn.Image")));
            this.DeleteColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DeleteColumn.MinimumWidth = 6;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Width = 20;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "";
            this.EditColumn.Image = ((System.Drawing.Image)(resources.GetObject("EditColumn.Image")));
            this.EditColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditColumn.MinimumWidth = 6;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditColumn.Width = 20;
            // 
            // Vorname
            // 
            this.Vorname.DataPropertyName = "Vorname";
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.MinimumWidth = 6;
            this.Vorname.Name = "Vorname";
            this.Vorname.ReadOnly = true;
            this.Vorname.Width = 75;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 75;
            // 
            // Geschlecht
            // 
            this.Geschlecht.DataPropertyName = "Geschlecht";
            this.Geschlecht.HeaderText = "Geschlecht";
            this.Geschlecht.MinimumWidth = 6;
            this.Geschlecht.Name = "Geschlecht";
            this.Geschlecht.ReadOnly = true;
            this.Geschlecht.Width = 80;
            // 
            // Adresse
            // 
            this.Adresse.DataPropertyName = "Adresse";
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.MinimumWidth = 6;
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            this.Adresse.Width = 125;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Width = 80;
            // 
            // Emailadresse
            // 
            this.Emailadresse.DataPropertyName = "E-Mail";
            this.Emailadresse.HeaderText = "Email";
            this.Emailadresse.MinimumWidth = 6;
            this.Emailadresse.Name = "Emailadresse";
            this.Emailadresse.ReadOnly = true;
            this.Emailadresse.Width = 125;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Geburtsdatum
            // 
            this.Geburtsdatum.DataPropertyName = "Geburtsdatum";
            this.Geburtsdatum.HeaderText = "Geburtsdatum";
            this.Geburtsdatum.MinimumWidth = 6;
            this.Geburtsdatum.Name = "Geburtsdatum";
            this.Geburtsdatum.ReadOnly = true;
            this.Geburtsdatum.Width = 80;
            // 
            // Alter
            // 
            this.Alter.DataPropertyName = "Alter";
            this.Alter.HeaderText = "Alter";
            this.Alter.MinimumWidth = 6;
            this.Alter.Name = "Alter";
            this.Alter.ReadOnly = true;
            this.Alter.Width = 50;
            // 
            // Eintritt
            // 
            this.Eintritt.DataPropertyName = "EintrittDatum";
            this.Eintritt.HeaderText = "Eintrittsdatum";
            this.Eintritt.MinimumWidth = 6;
            this.Eintritt.Name = "Eintritt";
            this.Eintritt.ReadOnly = true;
            this.Eintritt.Width = 80;
            // 
            // Gehalt
            // 
            this.Gehalt.DataPropertyName = "Gehalt";
            this.Gehalt.HeaderText = "Gehalt";
            this.Gehalt.MinimumWidth = 6;
            this.Gehalt.Name = "Gehalt";
            this.Gehalt.ReadOnly = true;
            this.Gehalt.Width = 80;
            // 
            // RentenBeginn
            // 
            this.RentenBeginn.DataPropertyName = "Rentenbeginn";
            this.RentenBeginn.HeaderText = "Rentenbeginn";
            this.RentenBeginn.MinimumWidth = 6;
            this.RentenBeginn.Name = "RentenBeginn";
            this.RentenBeginn.ReadOnly = true;
            this.RentenBeginn.Width = 80;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEmployee.Location = new System.Drawing.Point(691, 38);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(154, 34);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Hinzufügen";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(1008, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(851, 37);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(151, 34);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Bearbeiten";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(15, 40);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(154, 32);
            this.txtBoxName.TabIndex = 5;
            this.txtBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxName_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(175, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(203, 33);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Suchen Abbrechen";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Suchen";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEmployee.Location = new System.Drawing.Point(728, 9);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(187, 34);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Mitarbeiter hinzufügen";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1016, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(920, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 31);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Bearbeiten";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(190, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(16, 14);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(169, 32);
            this.txtBoxName.TabIndex = 5;
            this.txtBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxName_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(259, 14);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 32);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExport.Location = new System.Drawing.Point(580, 11);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 31);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Exportieren";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1148, 434);
            this.Controls.Add(this.label1);
            this.ClientSize = new System.Drawing.Size(1111, 393);
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
            this.Text = "Mitarbeiterverwaltung";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geschlecht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emailadresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geburtsdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eintritt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gehalt;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentenBeginn;
        private System.Windows.Forms.Button btnExport;
    }
}