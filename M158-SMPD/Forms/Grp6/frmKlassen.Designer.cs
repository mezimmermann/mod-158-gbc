namespace M158_SMPD.Forms.Grp6
{
    partial class FrmKlassen
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbxKlasse = new System.Windows.Forms.TextBox();
            this.lbxKlasse = new System.Windows.Forms.ListBox();
            this.cmxKlasse = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmxKuerzel = new System.Windows.Forms.ComboBox();
            this.tbxKlasseNr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Klasse suchen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Kürzel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Klasse erstellen / bearbeiten";
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.Location = new System.Drawing.Point(223, 152);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // tbxKlasse
            // 
            this.tbxKlasse.Location = new System.Drawing.Point(12, 93);
            this.tbxKlasse.Name = "tbxKlasse";
            this.tbxKlasse.Size = new System.Drawing.Size(174, 20);
            this.tbxKlasse.TabIndex = 28;
            this.tbxKlasse.TextChanged += new System.EventHandler(this.TbxKlasse_TextChanged);
            // 
            // lbxKlasse
            // 
            this.lbxKlasse.FormattingEnabled = true;
            this.lbxKlasse.Location = new System.Drawing.Point(12, 125);
            this.lbxKlasse.Name = "lbxKlasse";
            this.lbxKlasse.Size = new System.Drawing.Size(196, 199);
            this.lbxKlasse.TabIndex = 27;
            // 
            // cmxKlasse
            // 
            this.cmxKlasse.FormattingEnabled = true;
            this.cmxKlasse.Location = new System.Drawing.Point(12, 39);
            this.cmxKlasse.Name = "cmxKlasse";
            this.cmxKlasse.Size = new System.Drawing.Size(286, 21);
            this.cmxKlasse.TabIndex = 26;
            this.cmxKlasse.SelectedIndexChanged += new System.EventHandler(this.cmxKlasse_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(223, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 22);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(223, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // cmxKuerzel
            // 
            this.cmxKuerzel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmxKuerzel.FormattingEnabled = true;
            this.cmxKuerzel.Location = new System.Drawing.Point(192, 93);
            this.cmxKuerzel.Name = "cmxKuerzel";
            this.cmxKuerzel.Size = new System.Drawing.Size(106, 21);
            this.cmxKuerzel.TabIndex = 34;
            // 
            // tbxKlasseNr
            // 
            this.tbxKlasseNr.Location = new System.Drawing.Point(234, 66);
            this.tbxKlasseNr.Name = "tbxKlasseNr";
            this.tbxKlasseNr.Size = new System.Drawing.Size(64, 20);
            this.tbxKlasseNr.TabIndex = 35;
            this.tbxKlasseNr.Visible = false;
            // 
            // frmKlassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 336);
            this.Controls.Add(this.tbxKlasseNr);
            this.Controls.Add(this.cmxKuerzel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbxKlasse);
            this.Controls.Add(this.lbxKlasse);
            this.Controls.Add(this.cmxKlasse);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKlassen";
            this.Text = "frmKlassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbxKlasse;
        private System.Windows.Forms.ListBox lbxKlasse;
        private System.Windows.Forms.ComboBox cmxKlasse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmxKuerzel;
        private System.Windows.Forms.TextBox tbxKlasseNr;
    }
}