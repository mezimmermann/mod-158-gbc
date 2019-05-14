namespace M158_SMPD.Forms.Grp1
{
    partial class FrmNotendaten
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.LblSubject = new System.Windows.Forms.Label();
            this.LblGrades = new System.Windows.Forms.Label();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.LbxBeruf = new System.Windows.Forms.ListBox();
            this.LbxSemester = new System.Windows.Forms.ListBox();
            this.LbxFach = new System.Windows.Forms.ListBox();
            this.DgvGrade = new System.Windows.Forms.DataGridView();
            this.DgvAverage = new System.Windows.Forms.DataGridView();
            this.DgvAverages = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAverages)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(13, 13);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(292, 26);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Noten erfassen/bearbeiten";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(13, 72);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(44, 13);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Klasse";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(143, 72);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(59, 13);
            this.lblSemester.TabIndex = 2;
            this.lblSemester.Text = "Semester";
            // 
            // LblSubject
            // 
            this.LblSubject.AutoSize = true;
            this.LblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubject.Location = new System.Drawing.Point(269, 72);
            this.LblSubject.Name = "LblSubject";
            this.LblSubject.Size = new System.Drawing.Size(35, 13);
            this.LblSubject.TabIndex = 3;
            this.LblSubject.Text = "Fach";
            // 
            // LblGrades
            // 
            this.LblGrades.AutoSize = true;
            this.LblGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrades.Location = new System.Drawing.Point(406, 72);
            this.LblGrades.Name = "LblGrades";
            this.LblGrades.Size = new System.Drawing.Size(73, 13);
            this.LblGrades.TabIndex = 4;
            this.LblGrades.Text = "Notendaten";
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(1242, 67);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(139, 23);
            this.BtnPrint.TabIndex = 5;
            this.BtnPrint.Text = "Notenblatt drucken";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // LbxBeruf
            // 
            this.LbxBeruf.FormattingEnabled = true;
            this.LbxBeruf.HorizontalScrollbar = true;
            this.LbxBeruf.Location = new System.Drawing.Point(16, 115);
            this.LbxBeruf.Name = "LbxBeruf";
            this.LbxBeruf.Size = new System.Drawing.Size(120, 485);
            this.LbxBeruf.TabIndex = 6;
            this.LbxBeruf.SelectedIndexChanged += new System.EventHandler(this.LbxBeruf_SelectedIndexChanged);
            // 
            // LbxSemester
            // 
            this.LbxSemester.FormattingEnabled = true;
            this.LbxSemester.HorizontalScrollbar = true;
            this.LbxSemester.Location = new System.Drawing.Point(146, 115);
            this.LbxSemester.Name = "LbxSemester";
            this.LbxSemester.Size = new System.Drawing.Size(120, 485);
            this.LbxSemester.TabIndex = 7;
            this.LbxSemester.SelectedIndexChanged += new System.EventHandler(this.LbxSemester_SelectedIndexChanged);
            // 
            // LbxFach
            // 
            this.LbxFach.FormattingEnabled = true;
            this.LbxFach.HorizontalScrollbar = true;
            this.LbxFach.Location = new System.Drawing.Point(272, 115);
            this.LbxFach.Name = "LbxFach";
            this.LbxFach.Size = new System.Drawing.Size(121, 485);
            this.LbxFach.TabIndex = 8;
            this.LbxFach.SelectedIndexChanged += new System.EventHandler(this.LbxFach_SelectedIndexChanged);
            // 
            // DgvGrade
            // 
            this.DgvGrade.AllowUserToAddRows = false;
            this.DgvGrade.AllowUserToDeleteRows = false;
            this.DgvGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGrade.Location = new System.Drawing.Point(409, 115);
            this.DgvGrade.Name = "DgvGrade";
            this.DgvGrade.Size = new System.Drawing.Size(817, 436);
            this.DgvGrade.TabIndex = 9;
            this.DgvGrade.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrade_CellValueChanged);
            // 
            // DgvAverage
            // 
            this.DgvAverage.AllowUserToAddRows = false;
            this.DgvAverage.AllowUserToDeleteRows = false;
            this.DgvAverage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvAverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAverage.Location = new System.Drawing.Point(1242, 115);
            this.DgvAverage.Name = "DgvAverage";
            this.DgvAverage.Size = new System.Drawing.Size(139, 436);
            this.DgvAverage.TabIndex = 10;
            // 
            // DgvAverages
            // 
            this.DgvAverages.AllowUserToAddRows = false;
            this.DgvAverages.AllowUserToDeleteRows = false;
            this.DgvAverages.AllowUserToOrderColumns = true;
            this.DgvAverages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAverages.Location = new System.Drawing.Point(409, 557);
            this.DgvAverages.Name = "DgvAverages";
            this.DgvAverages.Size = new System.Drawing.Size(817, 43);
            this.DgvAverages.TabIndex = 11;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FrmNotendaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 627);
            this.Controls.Add(this.DgvAverages);
            this.Controls.Add(this.DgvAverage);
            this.Controls.Add(this.DgvGrade);
            this.Controls.Add(this.LbxFach);
            this.Controls.Add(this.LbxSemester);
            this.Controls.Add(this.LbxBeruf);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.LblGrades);
            this.Controls.Add(this.LblSubject);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.LblTitle);
            this.Name = "FrmNotendaten";
            this.Text = "FrmNotendaten";
            this.Load += new System.EventHandler(this.FrmNotendaten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAverages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label LblSubject;
        private System.Windows.Forms.Label LblGrades;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.ListBox LbxBeruf;
        private System.Windows.Forms.ListBox LbxSemester;
        private System.Windows.Forms.ListBox LbxFach;
        private System.Windows.Forms.DataGridView DgvGrade;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.DataGridView DgvAverage;
        private System.Windows.Forms.DataGridView DgvAverages;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}