﻿namespace M158_SMPD.Forms
{
    partial class frmReview
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
            // frmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 388);
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
            this.Name = "frmReview";
            this.Text = "frmReview";
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
    }
}