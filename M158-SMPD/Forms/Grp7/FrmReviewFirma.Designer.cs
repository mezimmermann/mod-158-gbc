namespace M158_SMPD
{
    partial class FrmReviewFirma
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
            this.DgvFirma = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFirma
            // 
            this.DgvFirma.AllowUserToAddRows = false;
            this.DgvFirma.AllowUserToDeleteRows = false;
            this.DgvFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvFirma.Location = new System.Drawing.Point(0, 0);
            this.DgvFirma.Name = "DgvFirma";
            this.DgvFirma.ReadOnly = true;
            this.DgvFirma.Size = new System.Drawing.Size(1066, 486);
            this.DgvFirma.TabIndex = 0;
            // 
            // FrmReviewFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 486);
            this.Controls.Add(this.DgvFirma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReviewFirma";
            this.Text = "FrmReviewFirma";
            this.Load += new System.EventHandler(this.FrmReviewFirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFirma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvFirma;
    }
}