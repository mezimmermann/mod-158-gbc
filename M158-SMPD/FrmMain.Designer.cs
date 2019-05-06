namespace M158_SMPD
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mstrip = new System.Windows.Forms.MenuStrip();
            this.MstripForms = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.TsmiNotendaten = new System.Windows.Forms.ToolStripMenuItem();
            this.Mstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mstrip
            // 
            this.Mstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MstripForms});
            this.Mstrip.Location = new System.Drawing.Point(0, 0);
            this.Mstrip.Name = "Mstrip";
            this.Mstrip.Size = new System.Drawing.Size(239, 24);
            this.Mstrip.TabIndex = 1;
            this.Mstrip.Text = "Formulare";
            // 
            // MstripForms
            // 
            this.MstripForms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiRegistration,
            this.TsmiSeperator,
            this.TsmiNotendaten});
            this.MstripForms.Name = "MstripForms";
            this.MstripForms.Size = new System.Drawing.Size(73, 20);
            this.MstripForms.Text = "Formulare";
            // 
            // TsmiRegistration
            // 
            this.TsmiRegistration.Name = "TsmiRegistration";
            this.TsmiRegistration.Size = new System.Drawing.Size(180, 22);
            this.TsmiRegistration.Text = "User Registration";
            this.TsmiRegistration.Visible = false;
            this.TsmiRegistration.Click += new System.EventHandler(this.TsmiRegistration_Click);
            // 
            // TsmiSeperator
            // 
            this.TsmiSeperator.Name = "TsmiSeperator";
            this.TsmiSeperator.Size = new System.Drawing.Size(177, 6);
            this.TsmiSeperator.Visible = false;
            // 
            // TsmiNotendaten
            // 
            this.TsmiNotendaten.Name = "TsmiNotendaten";
            this.TsmiNotendaten.Size = new System.Drawing.Size(180, 22);
            this.TsmiNotendaten.Text = "Notendaten";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 71);
            this.Controls.Add(this.Mstrip);
            this.MainMenuStrip = this.Mstrip;
            this.Name = "FrmMain";
            this.Text = "Hauptmaske";
            this.Mstrip.ResumeLayout(false);
            this.Mstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Mstrip;
        private System.Windows.Forms.ToolStripMenuItem MstripForms;
        private System.Windows.Forms.ToolStripMenuItem TsmiNotendaten;
        private System.Windows.Forms.ToolStripMenuItem TsmiRegistration;
        private System.Windows.Forms.ToolStripSeparator TsmiSeperator;
    }
}

