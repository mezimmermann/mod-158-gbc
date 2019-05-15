namespace M158_SMPD.Forms.Grp4
{
    partial class FrmSchnellerfassung
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
            this.cmx_class = new System.Windows.Forms.ComboBox();
            this.lbl_class = new System.Windows.Forms.Label();
            this.btn_class_search = new System.Windows.Forms.Button();
            this.btn_subjects = new System.Windows.Forms.Button();
            this.dgvchoseclass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchoseclass)).BeginInit();
            this.SuspendLayout();
            // 
            // cmx_class
            // 
            this.cmx_class.FormattingEnabled = true;
            this.cmx_class.Location = new System.Drawing.Point(10, 48);
            this.cmx_class.Name = "cmx_class";
            this.cmx_class.Size = new System.Drawing.Size(442, 21);
            this.cmx_class.TabIndex = 0;
            this.cmx_class.SelectedIndexChanged += new System.EventHandler(this.cmx_class_SelectedIndexChanged);
            this.cmx_class.SelectionChangeCommitted += new System.EventHandler(this.cmx_class_SelectionChangeCommitted);
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.Location = new System.Drawing.Point(12, 14);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(151, 25);
            this.lbl_class.TabIndex = 1;
            this.lbl_class.Text = "Klasse wählen";
            // 
            // btn_class_search
            // 
            this.btn_class_search.Location = new System.Drawing.Point(10, 85);
            this.btn_class_search.Name = "btn_class_search";
            this.btn_class_search.Size = new System.Drawing.Size(92, 22);
            this.btn_class_search.TabIndex = 2;
            this.btn_class_search.Text = "Klasse suchen";
            this.btn_class_search.UseVisualStyleBackColor = true;
            this.btn_class_search.Click += new System.EventHandler(this.btn_class_search_Click);
            // 
            // btn_subjects
            // 
            this.btn_subjects.Location = new System.Drawing.Point(360, 85);
            this.btn_subjects.Name = "btn_subjects";
            this.btn_subjects.Size = new System.Drawing.Size(92, 22);
            this.btn_subjects.TabIndex = 3;
            this.btn_subjects.Text = "Fächer suchen";
            this.btn_subjects.UseVisualStyleBackColor = true;
            this.btn_subjects.Click += new System.EventHandler(this.btn_subjects_Click);
            // 
            // dgvchoseclass
            // 
            this.dgvchoseclass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvchoseclass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvchoseclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchoseclass.Location = new System.Drawing.Point(10, 125);
            this.dgvchoseclass.Name = "dgvchoseclass";
            this.dgvchoseclass.Size = new System.Drawing.Size(442, 242);
            this.dgvchoseclass.TabIndex = 4;
            this.dgvchoseclass.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvchoseclass_CellValueChanged);
            // 
            // frmSchnellerfassung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 387);
            this.Controls.Add(this.dgvchoseclass);
            this.Controls.Add(this.btn_subjects);
            this.Controls.Add(this.btn_class_search);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.cmx_class);
            this.Name = "frmSchnellerfassung";
            this.Text = "frmSchnellerfassung";
            this.Load += new System.EventHandler(this.frmSchnellerfassung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchoseclass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmx_class;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Button btn_class_search;
        private System.Windows.Forms.Button btn_subjects;
        private System.Windows.Forms.DataGridView dgvchoseclass;
    }
}