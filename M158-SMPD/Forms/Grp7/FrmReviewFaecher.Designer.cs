namespace M158_SMPD
{
    partial class FrmReviewFaecher
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
            this.DgvFaecher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFaecher)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFaecher
            // 
            this.DgvFaecher.AllowUserToAddRows = false;
            this.DgvFaecher.AllowUserToDeleteRows = false;
            this.DgvFaecher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFaecher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvFaecher.Location = new System.Drawing.Point(0, 0);
            this.DgvFaecher.Name = "DgvFaecher";
            this.DgvFaecher.ReadOnly = true;
            this.DgvFaecher.Size = new System.Drawing.Size(492, 395);
            this.DgvFaecher.TabIndex = 0;
            this.DgvFaecher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFaecher_CellContentClick);
            // 
            // FrmReviewFaecher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 395);
            this.Controls.Add(this.DgvFaecher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReviewFaecher";
            this.Text = "FrmReviewFaecher";
            this.Load += new System.EventHandler(this.FrmReviewFaecher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFaecher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvFaecher;
    }
}