namespace M158_SMPD
{
    partial class frmLogin
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
            this.LblUsername = new System.Windows.Forms.Label();
            this.TbxUsername = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(16, 76);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(78, 13);
            this.LblUsername.TabIndex = 0;
            this.LblUsername.Text = "Benutzername:";
            // 
            // TbxUsername
            // 
            this.TbxUsername.Location = new System.Drawing.Point(100, 73);
            this.TbxUsername.Name = "TbxUsername";
            this.TbxUsername.Size = new System.Drawing.Size(137, 20);
            this.TbxUsername.TabIndex = 1;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(44, 102);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(50, 13);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Passwort";
            // 
            // TbxPassword
            // 
            this.TbxPassword.Location = new System.Drawing.Point(100, 99);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(137, 20);
            this.TbxPassword.TabIndex = 3;
            this.TbxPassword.UseSystemPasswordChar = true;
            this.TbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxPassword_KeyPress);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(12, 20);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(299, 42);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "Notenprogramm";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(18, 133);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(127, 42);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(151, 133);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(127, 42);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Schliessen";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Image = global::M158_SMPD.Properties.Resources.settingsico;
            this.BtnSettings.Location = new System.Drawing.Point(293, 4);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(25, 25);
            this.BtnSettings.TabIndex = 7;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 187);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TbxUsername);
            this.Controls.Add(this.LblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowInTaskbar = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox TbxUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSettings;
    }
}