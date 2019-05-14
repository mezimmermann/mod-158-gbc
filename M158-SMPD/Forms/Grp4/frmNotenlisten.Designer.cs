namespace M158_SMPD.Forms.Grp4
{
    partial class frmNotenlisten
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
            this.dgvchoseclass = new System.Windows.Forms.DataGridView();
            this.cmx_class = new System.Windows.Forms.ComboBox();
            this.cmx_subject = new System.Windows.Forms.ComboBox();
            this.lbl_class = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchoseclass)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvchoseclass
            // 
            this.dgvchoseclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchoseclass.Location = new System.Drawing.Point(12, 154);
            this.dgvchoseclass.Name = "dgvchoseclass";
            this.dgvchoseclass.Size = new System.Drawing.Size(609, 289);
            this.dgvchoseclass.TabIndex = 3;
            // 
            // cmx_class
            // 
            this.cmx_class.FormattingEnabled = true;
            this.cmx_class.Location = new System.Drawing.Point(12, 32);
            this.cmx_class.Margin = new System.Windows.Forms.Padding(2);
            this.cmx_class.Name = "cmx_class";
            this.cmx_class.Size = new System.Drawing.Size(611, 21);
            this.cmx_class.TabIndex = 5;
            this.cmx_class.SelectedIndexChanged += new System.EventHandler(this.cmx_class_SelectedIndexChanged);
            // 
            // cmx_subject
            // 
            this.cmx_subject.FormattingEnabled = true;
            this.cmx_subject.Location = new System.Drawing.Point(12, 103);
            this.cmx_subject.Margin = new System.Windows.Forms.Padding(2);
            this.cmx_subject.Name = "cmx_subject";
            this.cmx_subject.Size = new System.Drawing.Size(611, 21);
            this.cmx_subject.TabIndex = 6;
            this.cmx_subject.SelectedIndexChanged += new System.EventHandler(this.cmx_subject_SelectedIndexChanged);
            this.cmx_subject.SelectionChangeCommitted += new System.EventHandler(this.cmx_subject_SelectionChangeCommitted_1);
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Location = new System.Drawing.Point(9, 6);
            this.lbl_class.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(78, 13);
            this.lbl_class.TabIndex = 4;
            this.lbl_class.Text = "Klasse Wählen";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Location = new System.Drawing.Point(9, 79);
            this.lbl_subject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(80, 13);
            this.lbl_subject.TabIndex = 7;
            this.lbl_subject.Text = "Fächer Wählen";
            // 
            // frmNotenlisten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 460);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.cmx_subject);
            this.Controls.Add(this.cmx_class);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.dgvchoseclass);
            this.Name = "frmNotenlisten";
            this.Text = "frmNotenlisten";
            this.Load += new System.EventHandler(this.frmNotenlisten_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchoseclass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvchoseclass;
        private System.Windows.Forms.ComboBox cmx_class;
        private System.Windows.Forms.ComboBox cmx_subject;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Label lbl_subject;
    }
}