namespace M158_SMPD
{
    partial class FrmDBSettings
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TbxDBServer = new System.Windows.Forms.TextBox();
            this.LblDBSrv = new System.Windows.Forms.Label();
            this.LblDBUsr = new System.Windows.Forms.Label();
            this.TbxDBUser = new System.Windows.Forms.TextBox();
            this.lblDBPass = new System.Windows.Forms.Label();
            this.TbxDBPass = new System.Windows.Forms.TextBox();
            this.LblDBName = new System.Windows.Forms.Label();
            this.TbxDBName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(210, 160);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 23);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Übernehmen";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Abbrechen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TbxDBServer
            // 
            this.TbxDBServer.Location = new System.Drawing.Point(129, 36);
            this.TbxDBServer.Name = "TbxDBServer";
            this.TbxDBServer.Size = new System.Drawing.Size(160, 20);
            this.TbxDBServer.TabIndex = 2;
            // 
            // LblDBSrv
            // 
            this.LblDBSrv.AutoSize = true;
            this.LblDBSrv.Location = new System.Drawing.Point(67, 39);
            this.LblDBSrv.Name = "LblDBSrv";
            this.LblDBSrv.Size = new System.Drawing.Size(56, 13);
            this.LblDBSrv.TabIndex = 5;
            this.LblDBSrv.Text = "DB-Server";
            // 
            // LblDBUsr
            // 
            this.LblDBUsr.AutoSize = true;
            this.LblDBUsr.Location = new System.Drawing.Point(76, 91);
            this.LblDBUsr.Name = "LblDBUsr";
            this.LblDBUsr.Size = new System.Drawing.Size(47, 13);
            this.LblDBUsr.TabIndex = 7;
            this.LblDBUsr.Text = "DB User";
            // 
            // TbxDBUser
            // 
            this.TbxDBUser.Location = new System.Drawing.Point(129, 88);
            this.TbxDBUser.Name = "TbxDBUser";
            this.TbxDBUser.Size = new System.Drawing.Size(160, 20);
            this.TbxDBUser.TabIndex = 6;
            // 
            // lblDBPass
            // 
            this.lblDBPass.AutoSize = true;
            this.lblDBPass.Location = new System.Drawing.Point(52, 117);
            this.lblDBPass.Name = "lblDBPass";
            this.lblDBPass.Size = new System.Drawing.Size(71, 13);
            this.lblDBPass.TabIndex = 9;
            this.lblDBPass.Text = "DB Password";
            // 
            // TbxDBPass
            // 
            this.TbxDBPass.Location = new System.Drawing.Point(129, 114);
            this.TbxDBPass.Name = "TbxDBPass";
            this.TbxDBPass.Size = new System.Drawing.Size(160, 20);
            this.TbxDBPass.TabIndex = 8;
            this.TbxDBPass.UseSystemPasswordChar = true;
            // 
            // LblDBName
            // 
            this.LblDBName.AutoSize = true;
            this.LblDBName.Location = new System.Drawing.Point(63, 65);
            this.LblDBName.Name = "LblDBName";
            this.LblDBName.Size = new System.Drawing.Size(60, 13);
            this.LblDBName.TabIndex = 11;
            this.LblDBName.Text = "Datenbank";
            // 
            // TbxDBName
            // 
            this.TbxDBName.Location = new System.Drawing.Point(129, 62);
            this.TbxDBName.Name = "TbxDBName";
            this.TbxDBName.Size = new System.Drawing.Size(160, 20);
            this.TbxDBName.TabIndex = 10;
            // 
            // FrmDBSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 201);
            this.Controls.Add(this.LblDBName);
            this.Controls.Add(this.TbxDBName);
            this.Controls.Add(this.lblDBPass);
            this.Controls.Add(this.TbxDBPass);
            this.Controls.Add(this.LblDBUsr);
            this.Controls.Add(this.TbxDBUser);
            this.Controls.Add(this.LblDBSrv);
            this.Controls.Add(this.TbxDBServer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDBSettings";
            this.Text = "Datenbankeinstellungen";
            this.Load += new System.EventHandler(this.FrmDBSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TbxDBServer;
        private System.Windows.Forms.Label LblDBSrv;
        private System.Windows.Forms.Label LblDBUsr;
        private System.Windows.Forms.TextBox TbxDBUser;
        private System.Windows.Forms.Label lblDBPass;
        private System.Windows.Forms.Label LblDBName;
        private System.Windows.Forms.TextBox TbxDBName;
        private System.Windows.Forms.TextBox TbxDBPass;
    }
}