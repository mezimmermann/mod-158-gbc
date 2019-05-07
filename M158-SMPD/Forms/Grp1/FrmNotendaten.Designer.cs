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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LbxBeruf = new System.Windows.Forms.ListBox();
            this.LbxSemester = new System.Windows.Forms.ListBox();
            this.LbxFach = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LbxBeruf
            // 
            this.LbxBeruf.FormattingEnabled = true;
            this.LbxBeruf.Location = new System.Drawing.Point(20, 115);
            this.LbxBeruf.Name = "LbxBeruf";
            this.LbxBeruf.Size = new System.Drawing.Size(120, 485);
            this.LbxBeruf.TabIndex = 6;
            this.LbxBeruf.SelectedIndexChanged += new System.EventHandler(this.LbxBeruf_SelectedIndexChanged);
            // 
            // LbxSemester
            // 
            this.LbxSemester.FormattingEnabled = true;
            this.LbxSemester.Location = new System.Drawing.Point(146, 115);
            this.LbxSemester.Name = "LbxSemester";
            this.LbxSemester.Size = new System.Drawing.Size(120, 485);
            this.LbxSemester.TabIndex = 7;
            this.LbxSemester.SelectedIndexChanged += new System.EventHandler(this.LbxSemester_SelectedIndexChanged);
            // 
            // LbxFach
            // 
            this.LbxFach.FormattingEnabled = true;
            this.LbxFach.Location = new System.Drawing.Point(272, 115);
            this.LbxFach.Name = "LbxFach";
            this.LbxFach.Size = new System.Drawing.Size(120, 485);
            this.LbxFach.TabIndex = 8;
            // 
            // FrmNotendaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 673);
            this.Controls.Add(this.LbxFach);
            this.Controls.Add(this.LbxSemester);
            this.Controls.Add(this.LbxBeruf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNotendaten";
            this.Text = "FrmNotendaten";
            this.Load += new System.EventHandler(this.FrmNotendaten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox LbxBeruf;
        private System.Windows.Forms.ListBox LbxSemester;
        private System.Windows.Forms.ListBox LbxFach;
    }
}