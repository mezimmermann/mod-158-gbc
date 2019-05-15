namespace M158_SMPD.Forms.Grp6
{
    partial class FrmBerufe
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmxBerufe = new System.Windows.Forms.ComboBox();
            this.lbxBerufe = new System.Windows.Forms.ListBox();
            this.TbxBerufe = new System.Windows.Forms.TextBox();
            this.TbxKuerzel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbxBerufNr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(223, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 22);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(223, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 22);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // cmxBerufe
            // 
            this.cmxBerufe.FormattingEnabled = true;
            this.cmxBerufe.Location = new System.Drawing.Point(12, 39);
            this.cmxBerufe.Name = "cmxBerufe";
            this.cmxBerufe.Size = new System.Drawing.Size(286, 21);
            this.cmxBerufe.TabIndex = 16;
            this.cmxBerufe.SelectedIndexChanged += new System.EventHandler(this.CmxBerufe_SelectedIndexChanged);
            // 
            // lbxBerufe
            // 
            this.lbxBerufe.FormattingEnabled = true;
            this.lbxBerufe.Location = new System.Drawing.Point(12, 125);
            this.lbxBerufe.Name = "lbxBerufe";
            this.lbxBerufe.Size = new System.Drawing.Size(196, 199);
            this.lbxBerufe.TabIndex = 17;
            // 
            // tbxBerufe
            // 
            this.TbxBerufe.Location = new System.Drawing.Point(12, 93);
            this.TbxBerufe.Name = "tbxBerufe";
            this.TbxBerufe.Size = new System.Drawing.Size(174, 20);
            this.TbxBerufe.TabIndex = 18;
            this.TbxBerufe.TextChanged += new System.EventHandler(this.TbxBerufe_TextChanged);
            // 
            // tbxKuerzel
            // 
            this.TbxKuerzel.Location = new System.Drawing.Point(192, 93);
            this.TbxKuerzel.Name = "tbxKuerzel";
            this.TbxKuerzel.Size = new System.Drawing.Size(106, 20);
            this.TbxKuerzel.TabIndex = 19;
            this.TbxKuerzel.TextChanged += new System.EventHandler(this.TbxKuerzel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Berufe erstellen / bearbeiten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kürzel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Berufe suchen";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(223, 152);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 22);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // tbxBerufNr
            // 
            this.tbxBerufNr.Location = new System.Drawing.Point(234, 66);
            this.tbxBerufNr.Name = "tbxBerufNr";
            this.tbxBerufNr.Size = new System.Drawing.Size(64, 20);
            this.tbxBerufNr.TabIndex = 28;
            this.tbxBerufNr.Visible = false;
            // 
            // frmBerufe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 336);
            this.Controls.Add(this.tbxBerufNr);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxKuerzel);
            this.Controls.Add(this.TbxBerufe);
            this.Controls.Add(this.lbxBerufe);
            this.Controls.Add(this.cmxBerufe);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBerufe";
            this.Text = "frmBerufe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmxBerufe;
        private System.Windows.Forms.ListBox lbxBerufe;
        private System.Windows.Forms.TextBox TbxBerufe;
        private System.Windows.Forms.TextBox TbxKuerzel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbxBerufNr;
    }
}