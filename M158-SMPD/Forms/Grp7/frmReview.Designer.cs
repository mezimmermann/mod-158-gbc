namespace M158_SMPD.Forms
{
    partial class FrmReview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LblReviewTitle = new System.Windows.Forms.Label();
            this.BtnBeruf = new System.Windows.Forms.Button();
            this.BtnFaecher = new System.Windows.Forms.Button();
            this.BtnFirma = new System.Windows.Forms.Button();
            this.BtnKlasse = new System.Windows.Forms.Button();
            this.BtnLehrling = new System.Windows.Forms.Button();
            this.BtnLehrzeiten = new System.Windows.Forms.Button();
            this.BtnSemester = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnBerufCSV = new System.Windows.Forms.Button();
            this.BtnFaecherCSV = new System.Windows.Forms.Button();
            this.BtnFirmaCSV = new System.Windows.Forms.Button();
            this.BtnKlasseCSV = new System.Windows.Forms.Button();
            this.BtnLehrlingCSV = new System.Windows.Forms.Button();
            this.BtnLehrzeitenCSV = new System.Windows.Forms.Button();
            this.BtnSemesterCSV = new System.Windows.Forms.Button();
            this.chr_auswertung = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chr_auswertung)).BeginInit();
            this.SuspendLayout();
            // 
            // LblReviewTitle
            // 
            this.LblReviewTitle.AutoSize = true;
            this.LblReviewTitle.Location = new System.Drawing.Point(13, 13);
            this.LblReviewTitle.Name = "LblReviewTitle";
            this.LblReviewTitle.Size = new System.Drawing.Size(51, 13);
            this.LblReviewTitle.TabIndex = 0;
            this.LblReviewTitle.Text = "Reviews:";
            // 
            // BtnBeruf
            // 
            this.BtnBeruf.Location = new System.Drawing.Point(16, 42);
            this.BtnBeruf.Name = "BtnBeruf";
            this.BtnBeruf.Size = new System.Drawing.Size(148, 31);
            this.BtnBeruf.TabIndex = 1;
            this.BtnBeruf.Text = "Beruf";
            this.BtnBeruf.UseVisualStyleBackColor = true;
            this.BtnBeruf.Click += new System.EventHandler(this.btn_beruf_ext_form_Click);
            // 
            // BtnFaecher
            // 
            this.BtnFaecher.Location = new System.Drawing.Point(16, 90);
            this.BtnFaecher.Name = "BtnFaecher";
            this.BtnFaecher.Size = new System.Drawing.Size(148, 31);
            this.BtnFaecher.TabIndex = 3;
            this.BtnFaecher.Text = "Fächer";
            this.BtnFaecher.UseVisualStyleBackColor = true;
            this.BtnFaecher.Click += new System.EventHandler(this.BtnFaecher_Click);
            // 
            // BtnFirma
            // 
            this.BtnFirma.Location = new System.Drawing.Point(16, 138);
            this.BtnFirma.Name = "BtnFirma";
            this.BtnFirma.Size = new System.Drawing.Size(148, 31);
            this.BtnFirma.TabIndex = 4;
            this.BtnFirma.Text = "Firma";
            this.BtnFirma.UseVisualStyleBackColor = true;
            this.BtnFirma.Click += new System.EventHandler(this.BtnFirma_Click);
            // 
            // BtnKlasse
            // 
            this.BtnKlasse.Location = new System.Drawing.Point(16, 187);
            this.BtnKlasse.Name = "BtnKlasse";
            this.BtnKlasse.Size = new System.Drawing.Size(148, 31);
            this.BtnKlasse.TabIndex = 5;
            this.BtnKlasse.Text = "Klasse";
            this.BtnKlasse.UseVisualStyleBackColor = true;
            this.BtnKlasse.Click += new System.EventHandler(this.BtnKlasse_Click);
            // 
            // BtnLehrling
            // 
            this.BtnLehrling.Location = new System.Drawing.Point(16, 236);
            this.BtnLehrling.Name = "BtnLehrling";
            this.BtnLehrling.Size = new System.Drawing.Size(148, 31);
            this.BtnLehrling.TabIndex = 6;
            this.BtnLehrling.Text = "Lehrling";
            this.BtnLehrling.UseVisualStyleBackColor = true;
            this.BtnLehrling.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnLehrzeiten
            // 
            this.BtnLehrzeiten.Location = new System.Drawing.Point(16, 285);
            this.BtnLehrzeiten.Name = "BtnLehrzeiten";
            this.BtnLehrzeiten.Size = new System.Drawing.Size(148, 31);
            this.BtnLehrzeiten.TabIndex = 7;
            this.BtnLehrzeiten.Text = "Lehrzeiten";
            this.BtnLehrzeiten.UseVisualStyleBackColor = true;
            this.BtnLehrzeiten.Click += new System.EventHandler(this.BtnLehrzeiten_Click);
            // 
            // BtnSemester
            // 
            this.BtnSemester.Location = new System.Drawing.Point(16, 334);
            this.BtnSemester.Name = "BtnSemester";
            this.BtnSemester.Size = new System.Drawing.Size(148, 31);
            this.BtnSemester.TabIndex = 8;
            this.BtnSemester.Text = "Semester";
            this.BtnSemester.UseVisualStyleBackColor = true;
            this.BtnSemester.Click += new System.EventHandler(this.BtnSemester_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(16, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(16, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 1);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(16, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 1);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(16, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 1);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(16, 273);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 1);
            this.panel5.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(16, 322);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 1);
            this.panel6.TabIndex = 14;
            // 
            // BtnBerufCSV
            // 
            this.BtnBerufCSV.Location = new System.Drawing.Point(226, 42);
            this.BtnBerufCSV.Name = "BtnBerufCSV";
            this.BtnBerufCSV.Size = new System.Drawing.Size(190, 31);
            this.BtnBerufCSV.TabIndex = 15;
            this.BtnBerufCSV.Text = "Beruf als CSV exportieren";
            this.BtnBerufCSV.UseVisualStyleBackColor = true;
            this.BtnBerufCSV.Click += new System.EventHandler(this.CsvExport_Click);
            // 
            // BtnFaecherCSV
            // 
            this.BtnFaecherCSV.Location = new System.Drawing.Point(226, 90);
            this.BtnFaecherCSV.Name = "BtnFaecherCSV";
            this.BtnFaecherCSV.Size = new System.Drawing.Size(190, 31);
            this.BtnFaecherCSV.TabIndex = 16;
            this.BtnFaecherCSV.Text = "Fächer als CSV exportieren";
            this.BtnFaecherCSV.UseVisualStyleBackColor = true;
            this.BtnFaecherCSV.Click += new System.EventHandler(this.CsvExport_Click);
            // 
            // BtnFirmaCSV
            // 
            this.BtnFirmaCSV.Location = new System.Drawing.Point(226, 138);
            this.BtnFirmaCSV.Name = "BtnFirmaCSV";
            this.BtnFirmaCSV.Size = new System.Drawing.Size(190, 31);
            this.BtnFirmaCSV.TabIndex = 17;
            this.BtnFirmaCSV.Text = "Firma als CSV exportieren";
            this.BtnFirmaCSV.UseVisualStyleBackColor = true;
            this.BtnFirmaCSV.Click += new System.EventHandler(this.CsvExport_Click);
            // 
            // BtnKlasseCSV
            // 
            this.BtnKlasseCSV.Location = new System.Drawing.Point(226, 187);
            this.BtnKlasseCSV.Name = "BtnKlasseCSV";
            this.BtnKlasseCSV.Size = new System.Drawing.Size(190, 31);
            this.BtnKlasseCSV.TabIndex = 18;
            this.BtnKlasseCSV.Text = "Klasse als CSV exportieren";
            this.BtnKlasseCSV.UseVisualStyleBackColor = true;
            this.BtnKlasseCSV.Click += new System.EventHandler(this.CsvExport_Click);
            // 
            // BtnLehrlingCSV
            // 
            this.BtnLehrlingCSV.Location = new System.Drawing.Point(226, 236);
            this.BtnLehrlingCSV.Name = "BtnLehrlingCSV";
            this.BtnLehrlingCSV.Size = new System.Drawing.Size(190, 31);
            this.BtnLehrlingCSV.TabIndex = 19;
            this.BtnLehrlingCSV.Text = "Lehrling als CSV exportieren";
            this.BtnLehrlingCSV.UseVisualStyleBackColor = true;
            this.BtnLehrlingCSV.Click += new System.EventHandler(this.CsvExport_Click);
            // 
            // BtnLehrzeitenCSV
            // 
            this.BtnLehrzeitenCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLehrzeitenCSV.Location = new System.Drawing.Point(226, 285);
            this.BtnLehrzeitenCSV.Name = "BtnLehrzeitenCSV";
            this.BtnLehrzeitenCSV.Size = new System.Drawing.Size(190, 31);
            this.BtnLehrzeitenCSV.TabIndex = 20;
            this.BtnLehrzeitenCSV.Text = "Lehrzeiten als CSV exportieren";
            this.BtnLehrzeitenCSV.UseVisualStyleBackColor = true;
            this.BtnLehrzeitenCSV.Click += new System.EventHandler(this.CsvExport_Click);
            // 
            // BtnSemesterCSV
            // 
            this.BtnSemesterCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSemesterCSV.Location = new System.Drawing.Point(226, 334);
            this.BtnSemesterCSV.Name = "BtnSemesterCSV";
            this.BtnSemesterCSV.Size = new System.Drawing.Size(190, 31);
            this.BtnSemesterCSV.TabIndex = 21;
            this.BtnSemesterCSV.Text = "Semester als CSV exportieren";
            this.BtnSemesterCSV.UseVisualStyleBackColor = true;
            this.BtnSemesterCSV.Click += new System.EventHandler(this.CsvExport_Click);
            // 
            // chr_auswertung
            // 
            chartArea1.Name = "ChartArea1";
            this.chr_auswertung.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chr_auswertung.Legends.Add(legend1);
            this.chr_auswertung.Location = new System.Drawing.Point(528, 42);
            this.chr_auswertung.Name = "chr_auswertung";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chr_auswertung.Series.Add(series1);
            this.chr_auswertung.Size = new System.Drawing.Size(604, 455);
            this.chr_auswertung.TabIndex = 22;
            this.chr_auswertung.Text = "chart1";
            this.chr_auswertung.Click += new System.EventHandler(this.chart1_Click);
            // 
            // FrmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 509);
            this.Controls.Add(this.chr_auswertung);
            this.Controls.Add(this.BtnSemesterCSV);
            this.Controls.Add(this.BtnLehrzeitenCSV);
            this.Controls.Add(this.BtnLehrlingCSV);
            this.Controls.Add(this.BtnKlasseCSV);
            this.Controls.Add(this.BtnFirmaCSV);
            this.Controls.Add(this.BtnFaecherCSV);
            this.Controls.Add(this.BtnBerufCSV);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnSemester);
            this.Controls.Add(this.BtnLehrzeiten);
            this.Controls.Add(this.BtnLehrling);
            this.Controls.Add(this.BtnKlasse);
            this.Controls.Add(this.BtnFirma);
            this.Controls.Add(this.BtnFaecher);
            this.Controls.Add(this.BtnBeruf);
            this.Controls.Add(this.LblReviewTitle);
            this.Name = "FrmReview";
            this.Text = "frmReview";
            this.Load += new System.EventHandler(this.FrmReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chr_auswertung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblReviewTitle;
        private System.Windows.Forms.Button BtnBeruf;
        private System.Windows.Forms.Button BtnFaecher;
        private System.Windows.Forms.Button BtnFirma;
        private System.Windows.Forms.Button BtnKlasse;
        private System.Windows.Forms.Button BtnLehrling;
        private System.Windows.Forms.Button BtnLehrzeiten;
        private System.Windows.Forms.Button BtnSemester;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnBerufCSV;
        private System.Windows.Forms.Button BtnFaecherCSV;
        private System.Windows.Forms.Button BtnFirmaCSV;
        private System.Windows.Forms.Button BtnKlasseCSV;
        private System.Windows.Forms.Button BtnLehrlingCSV;
        private System.Windows.Forms.Button BtnLehrzeitenCSV;
        private System.Windows.Forms.Button BtnSemesterCSV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chr_auswertung;
    }
}