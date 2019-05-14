namespace M158_SMPD.Forms
{
    partial class frmNotenperiode
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.CbxDrop = new System.Windows.Forms.ComboBox();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.TbxEdit = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(12, 9);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(161, 20);
            this.lbl_1.TabIndex = 4;
            this.lbl_1.Text = "Notenperiode suchen";
            // 
            // CbxDrop
            // 
            this.CbxDrop.FormattingEnabled = true;
            this.CbxDrop.Location = new System.Drawing.Point(16, 32);
            this.CbxDrop.Name = "CbxDrop";
            this.CbxDrop.Size = new System.Drawing.Size(375, 21);
            this.CbxDrop.TabIndex = 5;
            this.CbxDrop.SelectedIndexChanged += new System.EventHandler(this.CbxDrop_SelectedIndexChanged);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(12, 56);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(251, 20);
            this.lbl_2.TabIndex = 6;
            this.lbl_2.Text = "Notenperiode erfassen/bearbeiten";
            // 
            // TbxEdit
            // 
            this.TbxEdit.Location = new System.Drawing.Point(16, 79);
            this.TbxEdit.Name = "TbxEdit";
            this.TbxEdit.Size = new System.Drawing.Size(375, 20);
            this.TbxEdit.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(375, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNotenperiode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 144);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TbxEdit);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.CbxDrop);
            this.Controls.Add(this.lbl_1);
            this.Name = "frmNotenperiode";
            this.Text = "frmNotenperiode";
            this.Load += new System.EventHandler(this.frmNotenperiode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.ComboBox CbxDrop;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox TbxEdit;
        private System.Windows.Forms.Button btnSave;
    }
}