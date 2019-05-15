namespace M158_SMPD.Forms.Grp3
{
    partial class FrmCompData
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblcompsrc = new System.Windows.Forms.Label();
            this.lblcomp = new System.Windows.Forms.Label();
            this.lblsal = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblprename = new System.Windows.Forms.Label();
            this.lblstreet = new System.Windows.Forms.Label();
            this.lblplz = new System.Windows.Forms.Label();
            this.lbltown = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblfax = new System.Windows.Forms.Label();
            this.lblactive = new System.Windows.Forms.Label();
            this.cmxcompsrc = new System.Windows.Forms.ComboBox();
            this.tbxcomp = new System.Windows.Forms.TextBox();
            this.cmxsal = new System.Windows.Forms.ComboBox();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.tbxprename = new System.Windows.Forms.TextBox();
            this.tbxstreet = new System.Windows.Forms.TextBox();
            this.cmxplz = new System.Windows.Forms.ComboBox();
            this.cmxtown = new System.Windows.Forms.ComboBox();
            this.tbxcontact = new System.Windows.Forms.TextBox();
            this.tbxadd = new System.Windows.Forms.TextBox();
            this.tbxtel = new System.Windows.Forms.TextBox();
            this.tbxfax = new System.Windows.Forms.TextBox();
            this.cbxactive = new System.Windows.Forms.CheckBox();
            this.btndel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(10, 20);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(163, 13);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Firmendaten erfassen/bearbeiten";
            // 
            // lblcompsrc
            // 
            this.lblcompsrc.AutoSize = true;
            this.lblcompsrc.Location = new System.Drawing.Point(10, 50);
            this.lblcompsrc.Name = "lblcompsrc";
            this.lblcompsrc.Size = new System.Drawing.Size(70, 13);
            this.lblcompsrc.TabIndex = 1;
            this.lblcompsrc.Text = "Firma suchen";
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Location = new System.Drawing.Point(10, 80);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(64, 13);
            this.lblcomp.TabIndex = 1;
            this.lblcomp.Text = "Firmenname";
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.Location = new System.Drawing.Point(10, 110);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(41, 13);
            this.lblsal.TabIndex = 1;
            this.lblsal.Text = "Anrede";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(10, 140);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(59, 13);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Nachname";
            // 
            // lblprename
            // 
            this.lblprename.AutoSize = true;
            this.lblprename.Location = new System.Drawing.Point(10, 170);
            this.lblprename.Name = "lblprename";
            this.lblprename.Size = new System.Drawing.Size(49, 13);
            this.lblprename.TabIndex = 1;
            this.lblprename.Text = "Vorname";
            // 
            // lblstreet
            // 
            this.lblstreet.AutoSize = true;
            this.lblstreet.Location = new System.Drawing.Point(10, 200);
            this.lblstreet.Name = "lblstreet";
            this.lblstreet.Size = new System.Drawing.Size(42, 13);
            this.lblstreet.TabIndex = 1;
            this.lblstreet.Text = "Strasse";
            // 
            // lblplz
            // 
            this.lblplz.AutoSize = true;
            this.lblplz.Location = new System.Drawing.Point(10, 230);
            this.lblplz.Name = "lblplz";
            this.lblplz.Size = new System.Drawing.Size(27, 13);
            this.lblplz.TabIndex = 1;
            this.lblplz.Text = "PLZ";
            // 
            // lbltown
            // 
            this.lbltown.AutoSize = true;
            this.lbltown.Location = new System.Drawing.Point(151, 167);
            this.lbltown.Name = "lbltown";
            this.lbltown.Size = new System.Drawing.Size(21, 13);
            this.lbltown.TabIndex = 8;
            this.lbltown.Text = "Ort";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(10, 260);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(84, 13);
            this.lblcontact.TabIndex = 1;
            this.lblcontact.Text = "Ansprechperson";
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Location = new System.Drawing.Point(10, 290);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(39, 13);
            this.lbladd.TabIndex = 1;
            this.lbladd.Text = "Zusatz";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(10, 320);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(43, 13);
            this.lbltel.TabIndex = 1;
            this.lbltel.Text = "Telefon";
            // 
            // lblfax
            // 
            this.lblfax.AutoSize = true;
            this.lblfax.Location = new System.Drawing.Point(10, 350);
            this.lblfax.Name = "lblfax";
            this.lblfax.Size = new System.Drawing.Size(24, 13);
            this.lblfax.TabIndex = 1;
            this.lblfax.Text = "Fax";
            // 
            // lblactive
            // 
            this.lblactive.AutoSize = true;
            this.lblactive.Location = new System.Drawing.Point(10, 380);
            this.lblactive.Name = "lblactive";
            this.lblactive.Size = new System.Drawing.Size(31, 13);
            this.lblactive.TabIndex = 1;
            this.lblactive.Text = "Aktiv";
            // 
            // cmxcompsrc
            // 
            this.cmxcompsrc.FormattingEnabled = true;
            this.cmxcompsrc.Location = new System.Drawing.Point(100, 50);
            this.cmxcompsrc.Name = "cmxcompsrc";
            this.cmxcompsrc.Size = new System.Drawing.Size(121, 21);
            this.cmxcompsrc.TabIndex = 1;
            this.cmxcompsrc.SelectedIndexChanged += new System.EventHandler(this.cmxcompsrc_SelectedIndexChanged);
            // 
            // tbxcomp
            // 
            this.tbxcomp.Location = new System.Drawing.Point(100, 80);
            this.tbxcomp.Name = "tbxcomp";
            this.tbxcomp.Size = new System.Drawing.Size(100, 20);
            this.tbxcomp.TabIndex = 2;
            // 
            // cmxsal
            // 
            this.cmxsal.Location = new System.Drawing.Point(100, 110);
            this.cmxsal.Name = "cmxsal";
            this.cmxsal.Size = new System.Drawing.Size(100, 21);
            this.cmxsal.TabIndex = 3;
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(100, 140);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(100, 20);
            this.tbxname.TabIndex = 4;
            // 
            // tbxprename
            // 
            this.tbxprename.Location = new System.Drawing.Point(100, 170);
            this.tbxprename.Name = "tbxprename";
            this.tbxprename.Size = new System.Drawing.Size(100, 20);
            this.tbxprename.TabIndex = 5;
            // 
            // tbxstreet
            // 
            this.tbxstreet.Location = new System.Drawing.Point(100, 200);
            this.tbxstreet.Name = "tbxstreet";
            this.tbxstreet.Size = new System.Drawing.Size(100, 20);
            this.tbxstreet.TabIndex = 6;
            // 
            // cmxplz
            // 
            this.cmxplz.FormattingEnabled = true;
            this.cmxplz.Location = new System.Drawing.Point(100, 230);
            this.cmxplz.Name = "cmxplz";
            this.cmxplz.Size = new System.Drawing.Size(80, 21);
            this.cmxplz.TabIndex = 7;
            this.cmxplz.SelectedIndexChanged += new System.EventHandler(this.cmxplz_SelectedIndexChanged);
            // 
            // cmxtown
            // 
            this.cmxtown.FormattingEnabled = true;
            this.cmxtown.Location = new System.Drawing.Point(190, 230);
            this.cmxtown.Name = "cmxtown";
            this.cmxtown.Size = new System.Drawing.Size(121, 21);
            this.cmxtown.TabIndex = 8;
            this.cmxtown.SelectedIndexChanged += new System.EventHandler(this.cmxtown_SelectedIndexChanged);
            // 
            // tbxcontact
            // 
            this.tbxcontact.Location = new System.Drawing.Point(100, 260);
            this.tbxcontact.Name = "tbxcontact";
            this.tbxcontact.Size = new System.Drawing.Size(100, 20);
            this.tbxcontact.TabIndex = 9;
            // 
            // tbxadd
            // 
            this.tbxadd.Location = new System.Drawing.Point(100, 290);
            this.tbxadd.Name = "tbxadd";
            this.tbxadd.Size = new System.Drawing.Size(100, 20);
            this.tbxadd.TabIndex = 10;
            // 
            // tbxtel
            // 
            this.tbxtel.Location = new System.Drawing.Point(100, 320);
            this.tbxtel.Name = "tbxtel";
            this.tbxtel.Size = new System.Drawing.Size(100, 20);
            this.tbxtel.TabIndex = 11;
            // 
            // tbxfax
            // 
            this.tbxfax.Location = new System.Drawing.Point(100, 350);
            this.tbxfax.Name = "tbxfax";
            this.tbxfax.Size = new System.Drawing.Size(100, 20);
            this.tbxfax.TabIndex = 12;
            // 
            // cbxactive
            // 
            this.cbxactive.AutoSize = true;
            this.cbxactive.Location = new System.Drawing.Point(100, 380);
            this.cbxactive.Name = "cbxactive";
            this.cbxactive.Size = new System.Drawing.Size(15, 14);
            this.cbxactive.TabIndex = 13;
            this.cbxactive.UseVisualStyleBackColor = true;
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(314, 308);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 14;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(314, 337);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "Speichern";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmCompData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 408);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.cbxactive);
            this.Controls.Add(this.tbxfax);
            this.Controls.Add(this.tbxtel);
            this.Controls.Add(this.tbxadd);
            this.Controls.Add(this.tbxcontact);
            this.Controls.Add(this.cmxtown);
            this.Controls.Add(this.cmxplz);
            this.Controls.Add(this.tbxstreet);
            this.Controls.Add(this.tbxprename);
            this.Controls.Add(this.tbxname);
            this.Controls.Add(this.cmxsal);
            this.Controls.Add(this.tbxcomp);
            this.Controls.Add(this.cmxcompsrc);
            this.Controls.Add(this.lblactive);
            this.Controls.Add(this.lblfax);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.lbltown);
            this.Controls.Add(this.lblplz);
            this.Controls.Add(this.lblstreet);
            this.Controls.Add(this.lblprename);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblsal);
            this.Controls.Add(this.lblcomp);
            this.Controls.Add(this.lblcompsrc);
            this.Controls.Add(this.lbltitle);
            this.Name = "frmCompData";
            this.Text = "Firmendaten zu Studenten/Schüler/Lehrlinge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblcompsrc;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblprename;
        private System.Windows.Forms.Label lblstreet;
        private System.Windows.Forms.Label lblplz;
        private System.Windows.Forms.Label lbltown;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblfax;
        private System.Windows.Forms.Label lblactive;
        private System.Windows.Forms.ComboBox cmxcompsrc;
        private System.Windows.Forms.TextBox tbxcomp;
        private System.Windows.Forms.ComboBox cmxsal;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.TextBox tbxprename;
        private System.Windows.Forms.TextBox tbxstreet;
        private System.Windows.Forms.ComboBox cmxplz;
        private System.Windows.Forms.ComboBox cmxtown;
        private System.Windows.Forms.TextBox tbxcontact;
        private System.Windows.Forms.TextBox tbxadd;
        private System.Windows.Forms.TextBox tbxtel;
        private System.Windows.Forms.TextBox tbxfax;
        private System.Windows.Forms.CheckBox cbxactive;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnsave;
    }
}

