namespace M158_SMPD.Forms.Grp1
{
    partial class frmUserRegister
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
            this.LblName = new System.Windows.Forms.Label();
            this.CbxAdm = new System.Windows.Forms.CheckBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxSurname = new System.Windows.Forms.TextBox();
            this.TbxUsername = new System.Windows.Forms.TextBox();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.TbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.CmxUserGroups = new System.Windows.Forms.ComboBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblConfirmPassword = new System.Windows.Forms.Label();
            this.LblUserGroup = new System.Windows.Forms.Label();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.BtnBreak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(41, 57);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(49, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Vorname";
            // 
            // CbxAdm
            // 
            this.CbxAdm.AutoSize = true;
            this.CbxAdm.Location = new System.Drawing.Point(154, 212);
            this.CbxAdm.Name = "CbxAdm";
            this.CbxAdm.Size = new System.Drawing.Size(86, 17);
            this.CbxAdm.TabIndex = 1;
            this.CbxAdm.Text = "Administrator";
            this.CbxAdm.UseVisualStyleBackColor = true;
            // 
            // TbxName
            // 
            this.TbxName.Location = new System.Drawing.Point(154, 54);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(121, 20);
            this.TbxName.TabIndex = 2;
            // 
            // TbxSurname
            // 
            this.TbxSurname.Location = new System.Drawing.Point(154, 80);
            this.TbxSurname.Name = "TbxSurname";
            this.TbxSurname.Size = new System.Drawing.Size(121, 20);
            this.TbxSurname.TabIndex = 3;
            // 
            // TbxUsername
            // 
            this.TbxUsername.Location = new System.Drawing.Point(154, 106);
            this.TbxUsername.Name = "TbxUsername";
            this.TbxUsername.Size = new System.Drawing.Size(121, 20);
            this.TbxUsername.TabIndex = 4;
            // 
            // TbxPassword
            // 
            this.TbxPassword.Location = new System.Drawing.Point(154, 132);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(121, 20);
            this.TbxPassword.TabIndex = 5;
            // 
            // TbxConfirmPassword
            // 
            this.TbxConfirmPassword.Location = new System.Drawing.Point(154, 158);
            this.TbxConfirmPassword.Name = "TbxConfirmPassword";
            this.TbxConfirmPassword.Size = new System.Drawing.Size(121, 20);
            this.TbxConfirmPassword.TabIndex = 6;
            // 
            // CmxUserGroups
            // 
            this.CmxUserGroups.FormattingEnabled = true;
            this.CmxUserGroups.Location = new System.Drawing.Point(154, 185);
            this.CmxUserGroups.Name = "CmxUserGroups";
            this.CmxUserGroups.Size = new System.Drawing.Size(121, 21);
            this.CmxUserGroups.TabIndex = 7;
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(41, 86);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(59, 13);
            this.LblSurname.TabIndex = 8;
            this.LblSurname.Text = "Nachname";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(41, 112);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(75, 13);
            this.LblUsername.TabIndex = 9;
            this.LblUsername.Text = "Benutzername";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(41, 138);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(50, 13);
            this.LblPassword.TabIndex = 10;
            this.LblPassword.Text = "Passwort";
            // 
            // LblConfirmPassword
            // 
            this.LblConfirmPassword.AutoSize = true;
            this.LblConfirmPassword.Location = new System.Drawing.Point(41, 164);
            this.LblConfirmPassword.Name = "LblConfirmPassword";
            this.LblConfirmPassword.Size = new System.Drawing.Size(102, 13);
            this.LblConfirmPassword.TabIndex = 11;
            this.LblConfirmPassword.Text = "Passwort bestätigen";
            // 
            // LblUserGroup
            // 
            this.LblUserGroup.AutoSize = true;
            this.LblUserGroup.Location = new System.Drawing.Point(41, 191);
            this.LblUserGroup.Name = "LblUserGroup";
            this.LblUserGroup.Size = new System.Drawing.Size(82, 13);
            this.LblUserGroup.TabIndex = 12;
            this.LblUserGroup.Text = "Benutzergruppe";
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(44, 253);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(75, 23);
            this.BtnAddUser.TabIndex = 13;
            this.BtnAddUser.Text = "Hinzufügen";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            // 
            // BtnBreak
            // 
            this.BtnBreak.Location = new System.Drawing.Point(200, 253);
            this.BtnBreak.Name = "BtnBreak";
            this.BtnBreak.Size = new System.Drawing.Size(75, 23);
            this.BtnBreak.TabIndex = 14;
            this.BtnBreak.Text = "Abbrechen";
            this.BtnBreak.UseVisualStyleBackColor = true;
            // 
            // frmUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 305);
            this.Controls.Add(this.BtnBreak);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.LblUserGroup);
            this.Controls.Add(this.LblConfirmPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.CmxUserGroups);
            this.Controls.Add(this.TbxConfirmPassword);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.TbxUsername);
            this.Controls.Add(this.TbxSurname);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.CbxAdm);
            this.Controls.Add(this.LblName);
            this.Name = "frmUserRegister";
            this.Text = "frmUserRegister";
            this.Load += new System.EventHandler(this.frmUserRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.CheckBox CbxAdm;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.TextBox TbxSurname;
        private System.Windows.Forms.TextBox TbxUsername;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.TextBox TbxConfirmPassword;
        private System.Windows.Forms.ComboBox CmxUserGroups;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblConfirmPassword;
        private System.Windows.Forms.Label LblUserGroup;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Button BtnBreak;
    }
}