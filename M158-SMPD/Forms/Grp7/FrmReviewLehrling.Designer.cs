namespace M158_SMPD
{
    partial class FrmReviewLehrling
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
            this.DgvLehrling = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLehrling)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLehrling
            // 
            this.DgvLehrling.AllowUserToAddRows = false;
            this.DgvLehrling.AllowUserToDeleteRows = false;
            this.DgvLehrling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLehrling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLehrling.Location = new System.Drawing.Point(0, 0);
            this.DgvLehrling.Name = "DgvLehrling";
            this.DgvLehrling.ReadOnly = true;
            this.DgvLehrling.Size = new System.Drawing.Size(1162, 609);
            this.DgvLehrling.TabIndex = 0;
            // 
            // FrmReviewLehrling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 609);
            this.Controls.Add(this.DgvLehrling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReviewLehrling";
            this.Text = "FrmReviewLehrling";
            this.Load += new System.EventHandler(this.FrmReviewLehrling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLehrling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLehrling;
    }
}