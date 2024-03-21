﻿namespace BTS_Mitarbeiterverwaltung
{
    partial class RegisterForm
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
            this.txtBenutzername = new System.Windows.Forms.TextBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVerify = new System.Windows.Forms.TextBox();
            this.ckShowPasswort = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBenutzername
            // 
            this.txtBenutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBenutzername.Location = new System.Drawing.Point(162, 34);
            this.txtBenutzername.Name = "txtBenutzername";
            this.txtBenutzername.Size = new System.Drawing.Size(100, 21);
            this.txtBenutzername.TabIndex = 0;
            this.txtBenutzername.TextChanged += new System.EventHandler(this.txtBenutzername_TextChanged);
            // 
            // txtPasswort
            // 
            this.txtPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPasswort.Location = new System.Drawing.Point(162, 65);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(100, 21);
            this.txtPasswort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Benutzername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(80, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passwort";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCreateUser.Location = new System.Drawing.Point(161, 137);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(101, 25);
            this.btnCreateUser.TabIndex = 3;
            this.btnCreateUser.Text = "Erstellen";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(20, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Passwort bestätigen";
            // 
            // txtVerify
            // 
            this.txtVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtVerify.Location = new System.Drawing.Point(162, 98);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Size = new System.Drawing.Size(100, 21);
            this.txtVerify.TabIndex = 2;
            // 
            // ckShowPasswort
            // 
            this.ckShowPasswort.AutoSize = true;
            this.ckShowPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ckShowPasswort.Location = new System.Drawing.Point(268, 69);
            this.ckShowPasswort.Name = "ckShowPasswort";
            this.ckShowPasswort.Size = new System.Drawing.Size(115, 17);
            this.ckShowPasswort.TabIndex = 7;
            this.ckShowPasswort.Text = "Passwort anzeigen";
            this.ckShowPasswort.UseVisualStyleBackColor = true;
            this.ckShowPasswort.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(438, 205);
            this.Controls.Add(this.ckShowPasswort);
            this.Controls.Add(this.txtVerify);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtBenutzername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil erstellen";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBenutzername;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVerify;
        private System.Windows.Forms.CheckBox ckShowPasswort;
    }
}