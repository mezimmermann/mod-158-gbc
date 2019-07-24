namespace M158_SMPD
{
    partial class FrmReviewSemester
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
            this.DgvSemester = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSemester)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSemester
            // 
            this.DgvSemester.AllowUserToAddRows = false;
            this.DgvSemester.AllowUserToDeleteRows = false;
            this.DgvSemester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSemester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSemester.Location = new System.Drawing.Point(0, 0);
            this.DgvSemester.Name = "DgvSemester";
            this.DgvSemester.ReadOnly = true;
            this.DgvSemester.Size = new System.Drawing.Size(516, 446);
            this.DgvSemester.TabIndex = 0;
            // 
            // FrmReviewSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 446);
            this.Controls.Add(this.DgvSemester);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReviewSemester";
            this.Text = "FrmReviewSemester";
            this.Load += new System.EventHandler(this.FrmReviewSemester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSemester)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSemester;
    }
}