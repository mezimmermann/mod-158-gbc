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
            this.BtnNewStudent = new System.Windows.Forms.Button();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxSurname = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
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
            this.dgvchoseclass.AllowUserToAddRows = false;
            this.dgvchoseclass.AllowUserToDeleteRows = false;
            this.dgvchoseclass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvchoseclass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvchoseclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchoseclass.Location = new System.Drawing.Point(10, 125);
            this.dgvchoseclass.Name = "dgvchoseclass";
            this.dgvchoseclass.Size = new System.Drawing.Size(442, 242);
            this.dgvchoseclass.TabIndex = 4;
            this.dgvchoseclass.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvchoseclass_CellValueChanged);
            // 
            // BtnNewStudent
            // 
            this.BtnNewStudent.Location = new System.Drawing.Point(360, 386);
            this.BtnNewStudent.Name = "BtnNewStudent";
            this.BtnNewStudent.Size = new System.Drawing.Size(92, 22);
            this.BtnNewStudent.TabIndex = 5;
            this.BtnNewStudent.Text = "Neuer Schüler";
            this.BtnNewStudent.UseVisualStyleBackColor = true;
            this.BtnNewStudent.Click += new System.EventHandler(this.BtnNewStudent_Click);
            // 
            // TbxName
            // 
            this.TbxName.Location = new System.Drawing.Point(177, 388);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(177, 20);
            this.TbxName.TabIndex = 6;
            // 
            // TbxSurname
            // 
            this.TbxSurname.Location = new System.Drawing.Point(10, 388);
            this.TbxSurname.Name = "TbxSurname";
            this.TbxSurname.Size = new System.Drawing.Size(161, 20);
            this.TbxSurname.TabIndex = 7;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(174, 372);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(49, 13);
            this.LblName.TabIndex = 8;
            this.LblName.Text = "Vorname";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(7, 372);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(59, 13);
            this.LblSurname.TabIndex = 9;
            this.LblSurname.Text = "Nachname";
            // 
            // FrmSchnellerfassung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 420);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TbxSurname);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.BtnNewStudent);
            this.Controls.Add(this.dgvchoseclass);
            this.Controls.Add(this.btn_subjects);
            this.Controls.Add(this.btn_class_search);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.cmx_class);
            this.Name = "FrmSchnellerfassung";
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
        private System.Windows.Forms.Button BtnNewStudent;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.TextBox TbxSurname;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblSurname;
    }
}