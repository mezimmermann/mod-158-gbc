namespace M158_SMPD
{
    partial class FrmReviewKlasse
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
            this.DgvKlasse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKlasse)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvKlasse
            // 
            this.DgvKlasse.AllowUserToAddRows = false;
            this.DgvKlasse.AllowUserToDeleteRows = false;
            this.DgvKlasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKlasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvKlasse.Location = new System.Drawing.Point(0, 0);
            this.DgvKlasse.Name = "DgvKlasse";
            this.DgvKlasse.ReadOnly = true;
            this.DgvKlasse.Size = new System.Drawing.Size(500, 400);
            this.DgvKlasse.TabIndex = 0;
            // 
            // FrmReviewKlasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.DgvKlasse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReviewKlasse";
            this.Text = "FrmReviewKlasse";
            this.Load += new System.EventHandler(this.FrmReviewKlasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvKlasse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvKlasse;
    }
}