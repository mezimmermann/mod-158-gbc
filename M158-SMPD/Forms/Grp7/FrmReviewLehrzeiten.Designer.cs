namespace M158_SMPD
{
    partial class FrmReviewLehrzeiten
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
            this.DgvLehrzeiten = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLehrzeiten)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLehrzeiten
            // 
            this.DgvLehrzeiten.AllowUserToAddRows = false;
            this.DgvLehrzeiten.AllowUserToDeleteRows = false;
            this.DgvLehrzeiten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLehrzeiten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLehrzeiten.Location = new System.Drawing.Point(0, 0);
            this.DgvLehrzeiten.Name = "DgvLehrzeiten";
            this.DgvLehrzeiten.ReadOnly = true;
            this.DgvLehrzeiten.Size = new System.Drawing.Size(594, 419);
            this.DgvLehrzeiten.TabIndex = 0;
            // 
            // FrmReviewLehrzeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 419);
            this.Controls.Add(this.DgvLehrzeiten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReviewLehrzeiten";
            this.Text = "FrmReviewLehrzeiten";
            this.Load += new System.EventHandler(this.FrmReviewLehrzeiten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLehrzeiten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLehrzeiten;
    }
}