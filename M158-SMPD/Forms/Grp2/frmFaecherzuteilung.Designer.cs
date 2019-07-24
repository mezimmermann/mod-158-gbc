namespace M158_SMPD.Forms
{
    partial class frmFaecherzuteilung
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
            this.CmxClass = new System.Windows.Forms.ComboBox();
            this.DgvView = new System.Windows.Forms.DataGridView();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // CmxClass
            // 
            this.CmxClass.FormattingEnabled = true;
            this.CmxClass.Location = new System.Drawing.Point(34, 80);
            this.CmxClass.Name = "CmxClass";
            this.CmxClass.Size = new System.Drawing.Size(494, 21);
            this.CmxClass.TabIndex = 1;
            this.CmxClass.SelectedIndexChanged += new System.EventHandler(this.CmxClass_SelectedIndexChanged);
            // 
            // DgvView
            // 
            this.DgvView.AllowUserToAddRows = false;
            this.DgvView.AllowUserToDeleteRows = false;
            this.DgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvView.Location = new System.Drawing.Point(34, 107);
            this.DgvView.Name = "DgvView";
            this.DgvView.Size = new System.Drawing.Size(494, 153);
            this.DgvView.TabIndex = 2;
            this.DgvView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvView_CellValueChanged);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(28, 9);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(310, 33);
            this.lbl_1.TabIndex = 3;
            this.lbl_1.Text = "Fächerzuteilung bearbeiten";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(30, 58);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(102, 19);
            this.lbl_2.TabIndex = 4;
            this.lbl_2.Text = "Klasse wählen";
            // 
            // frmFaecherzuteilung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 272);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.DgvView);
            this.Controls.Add(this.CmxClass);
            this.Name = "frmFaecherzuteilung";
            this.Text = "frmFaecherzuteilung";
            this.Load += new System.EventHandler(this.frmFaecherzuteilung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmxClass;
        private System.Windows.Forms.DataGridView DgvView;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
    }
}