namespace M158_SMPD.Forms
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
            this.lbl_review_title = new System.Windows.Forms.Label();
            this.btn_beruf_ext_form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_review_title
            // 
            this.lbl_review_title.AutoSize = true;
            this.lbl_review_title.Location = new System.Drawing.Point(13, 13);
            this.lbl_review_title.Name = "lbl_review_title";
            this.lbl_review_title.Size = new System.Drawing.Size(51, 13);
            this.lbl_review_title.TabIndex = 0;
            this.lbl_review_title.Text = "Reviews:";
            // 
            // btn_beruf_ext_form
            // 
            this.btn_beruf_ext_form.Location = new System.Drawing.Point(16, 42);
            this.btn_beruf_ext_form.Name = "btn_beruf_ext_form";
            this.btn_beruf_ext_form.Size = new System.Drawing.Size(148, 31);
            this.btn_beruf_ext_form.TabIndex = 1;
            this.btn_beruf_ext_form.Text = "Beruf";
            this.btn_beruf_ext_form.UseVisualStyleBackColor = true;
            this.btn_beruf_ext_form.Click += new System.EventHandler(this.btn_beruf_ext_form_Click);
            // 
            // frmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 314);
            this.Controls.Add(this.btn_beruf_ext_form);
            this.Controls.Add(this.lbl_review_title);
            this.Name = "frmReview";
            this.Text = "frmReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_review_title;
        private System.Windows.Forms.Button btn_beruf_ext_form;
    }
}