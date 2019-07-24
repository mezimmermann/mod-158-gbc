namespace M158_SMPD
{
    partial class FrmReviewBeruf
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
            this.DgvBeruf = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBeruf)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBeruf
            // 
            this.DgvBeruf.AllowUserToAddRows = false;
            this.DgvBeruf.AllowUserToDeleteRows = false;
            this.DgvBeruf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBeruf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvBeruf.Location = new System.Drawing.Point(0, 0);
            this.DgvBeruf.Name = "DgvBeruf";
            this.DgvBeruf.ReadOnly = true;
            this.DgvBeruf.Size = new System.Drawing.Size(484, 335);
            this.DgvBeruf.TabIndex = 0;
            // 
            // FrmReviewBeruf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 335);
            this.Controls.Add(this.DgvBeruf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReviewBeruf";
            this.Text = "FrmReviewBeruf";
            this.Load += new System.EventHandler(this.FrmReviewBeruf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBeruf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBeruf;
    }
}