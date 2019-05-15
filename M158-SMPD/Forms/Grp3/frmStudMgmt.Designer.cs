//namespace Schüler_Studenten_Lehrlinge
namespace M158_SMPD.Forms.Grp3
{
    partial class FrmStudMgmt
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
            this.tbxap = new System.Windows.Forms.TextBox();
            this.lblap = new System.Windows.Forms.Label();
            this.lblsal = new System.Windows.Forms.Label();
            this.tbxstr = new System.Windows.Forms.TextBox();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.tbxpre = new System.Windows.Forms.TextBox();
            this.cmxsal = new System.Windows.Forms.ComboBox();
            this.tbxtel = new System.Windows.Forms.TextBox();
            this.cmxcity = new System.Windows.Forms.ComboBox();
            this.cmxplz = new System.Windows.Forms.ComboBox();
            this.tbxadd = new System.Windows.Forms.TextBox();
            this.lblpre = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblstr = new System.Windows.Forms.Label();
            this.lblplz = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblcomp = new System.Windows.Forms.Label();
            this.cmxcomp = new System.Windows.Forms.ComboBox();
            this.lblclass = new System.Windows.Forms.Label();
            this.cmxclass = new System.Windows.Forms.ComboBox();
            this.lblbirth = new System.Windows.Forms.Label();
            this.dtrbirth = new System.Windows.Forms.DateTimePicker();
            this.cmxapsrc = new System.Windows.Forms.ComboBox();
            this.lblapsrc = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.cmxtime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbxap
            // 
            this.tbxap.Location = new System.Drawing.Point(99, 29);
            this.tbxap.Name = "tbxap";
            this.tbxap.Size = new System.Drawing.Size(100, 20);
            this.tbxap.TabIndex = 2;
            // 
            // lblap
            // 
            this.lblap.AutoSize = true;
            this.lblap.Location = new System.Drawing.Point(10, 31);
            this.lblap.Name = "lblap";
            this.lblap.Size = new System.Drawing.Size(89, 13);
            this.lblap.TabIndex = 1;
            this.lblap.Text = "Lehrlingsnummer:";
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.Location = new System.Drawing.Point(10, 57);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(41, 13);
            this.lblsal.TabIndex = 2;
            this.lblsal.Text = "Anrede";
            // 
            // tbxstr
            // 
            this.tbxstr.Location = new System.Drawing.Point(99, 134);
            this.tbxstr.Name = "tbxstr";
            this.tbxstr.Size = new System.Drawing.Size(100, 20);
            this.tbxstr.TabIndex = 6;
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(99, 108);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(100, 20);
            this.tbxname.TabIndex = 5;
            // 
            // tbxpre
            // 
            this.tbxpre.Location = new System.Drawing.Point(99, 82);
            this.tbxpre.Name = "tbxpre";
            this.tbxpre.Size = new System.Drawing.Size(100, 20);
            this.tbxpre.TabIndex = 4;
            // 
            // cmxsal
            // 
            this.cmxsal.FormattingEnabled = true;
            this.cmxsal.Location = new System.Drawing.Point(99, 55);
            this.cmxsal.Name = "cmxsal";
            this.cmxsal.Size = new System.Drawing.Size(100, 21);
            this.cmxsal.TabIndex = 3;
            // 
            // tbxtel
            // 
            this.tbxtel.Location = new System.Drawing.Point(99, 187);
            this.tbxtel.Name = "tbxtel";
            this.tbxtel.Size = new System.Drawing.Size(100, 20);
            this.tbxtel.TabIndex = 9;
            // 
            // cmxcity
            // 
            this.cmxcity.FormattingEnabled = true;
            this.cmxcity.Location = new System.Drawing.Point(199, 160);
            this.cmxcity.Name = "cmxcity";
            this.cmxcity.Size = new System.Drawing.Size(100, 21);
            this.cmxcity.TabIndex = 8;
            this.cmxcity.SelectedIndexChanged += new System.EventHandler(this.cmxcity_SelectedIndexChanged);
            // 
            // cmxplz
            // 
            this.cmxplz.FormattingEnabled = true;
            this.cmxplz.Location = new System.Drawing.Point(99, 160);
            this.cmxplz.Name = "cmxplz";
            this.cmxplz.Size = new System.Drawing.Size(63, 21);
            this.cmxplz.TabIndex = 7;
            this.cmxplz.SelectedIndexChanged += new System.EventHandler(this.cmxplz_SelectedIndexChanged);
            // 
            // tbxadd
            // 
            this.tbxadd.Location = new System.Drawing.Point(99, 239);
            this.tbxadd.Name = "tbxadd";
            this.tbxadd.Size = new System.Drawing.Size(100, 20);
            this.tbxadd.TabIndex = 11;
            // 
            // lblpre
            // 
            this.lblpre.AutoSize = true;
            this.lblpre.Location = new System.Drawing.Point(10, 84);
            this.lblpre.Name = "lblpre";
            this.lblpre.Size = new System.Drawing.Size(49, 13);
            this.lblpre.TabIndex = 13;
            this.lblpre.Text = "Vorname";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(10, 110);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 14;
            this.lblname.Text = "Name";
            // 
            // lblstr
            // 
            this.lblstr.AutoSize = true;
            this.lblstr.Location = new System.Drawing.Point(10, 136);
            this.lblstr.Name = "lblstr";
            this.lblstr.Size = new System.Drawing.Size(42, 13);
            this.lblstr.TabIndex = 15;
            this.lblstr.Text = "Strasse";
            // 
            // lblplz
            // 
            this.lblplz.AutoSize = true;
            this.lblplz.Location = new System.Drawing.Point(10, 162);
            this.lblplz.Name = "lblplz";
            this.lblplz.Size = new System.Drawing.Size(27, 13);
            this.lblplz.TabIndex = 16;
            this.lblplz.Text = "PLZ";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(10, 189);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(52, 13);
            this.lbltel.TabIndex = 17;
            this.lbltel.Text = "Telefonnr";
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Location = new System.Drawing.Point(10, 241);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(39, 13);
            this.lbladd.TabIndex = 18;
            this.lbladd.Text = "Zusatz";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(168, 162);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(21, 13);
            this.lblcity.TabIndex = 19;
            this.lblcity.Text = "Ort";
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Location = new System.Drawing.Point(256, 31);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(64, 13);
            this.lblcomp.TabIndex = 20;
            this.lblcomp.Text = "Firmenname";
            // 
            // cmxcomp
            // 
            this.cmxcomp.FormattingEnabled = true;
            this.cmxcomp.Location = new System.Drawing.Point(326, 29);
            this.cmxcomp.Name = "cmxcomp";
            this.cmxcomp.Size = new System.Drawing.Size(207, 21);
            this.cmxcomp.TabIndex = 13;
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.Location = new System.Drawing.Point(10, 267);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(41, 13);
            this.lblclass.TabIndex = 23;
            this.lblclass.Text = "Klasse:";
            // 
            // cmxclass
            // 
            this.cmxclass.FormattingEnabled = true;
            this.cmxclass.Location = new System.Drawing.Point(99, 265);
            this.cmxclass.Name = "cmxclass";
            this.cmxclass.Size = new System.Drawing.Size(147, 21);
            this.cmxclass.TabIndex = 12;
            // 
            // lblbirth
            // 
            this.lblbirth.AutoSize = true;
            this.lblbirth.Location = new System.Drawing.Point(10, 215);
            this.lblbirth.Name = "lblbirth";
            this.lblbirth.Size = new System.Drawing.Size(73, 13);
            this.lblbirth.TabIndex = 25;
            this.lblbirth.Text = "Geburtsdatum";
            // 
            // dtrbirth
            // 
            this.dtrbirth.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtrbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtrbirth.Location = new System.Drawing.Point(99, 213);
            this.dtrbirth.Name = "dtrbirth";
            this.dtrbirth.Size = new System.Drawing.Size(200, 20);
            this.dtrbirth.TabIndex = 10;
            // 
            // cmxapsrc
            // 
            this.cmxapsrc.FormattingEnabled = true;
            this.cmxapsrc.Location = new System.Drawing.Point(99, 2);
            this.cmxapsrc.Name = "cmxapsrc";
            this.cmxapsrc.Size = new System.Drawing.Size(187, 21);
            this.cmxapsrc.TabIndex = 1;
            this.cmxapsrc.SelectedIndexChanged += new System.EventHandler(this.cmxapsrc_SelectedIndexChanged);
            // 
            // lblapsrc
            // 
            this.lblapsrc.AutoSize = true;
            this.lblapsrc.Location = new System.Drawing.Point(10, 5);
            this.lblapsrc.Name = "lblapsrc";
            this.lblapsrc.Size = new System.Drawing.Size(82, 13);
            this.lblapsrc.TabIndex = 29;
            this.lblapsrc.Text = "Lehrling suchen";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(379, 241);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Speichern";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(379, 267);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 15;
            this.btndel.Text = "Löschen";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(256, 81);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(56, 13);
            this.lbltime.TabIndex = 32;
            this.lbltime.Text = "Lehrzeiten";
            // 
            // cmxtime
            // 
            this.cmxtime.FormattingEnabled = true;
            this.cmxtime.Location = new System.Drawing.Point(326, 78);
            this.cmxtime.Name = "cmxtime";
            this.cmxtime.Size = new System.Drawing.Size(121, 21);
            this.cmxtime.TabIndex = 33;
            // 
            // frmStudMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 311);
            this.Controls.Add(this.cmxtime);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblapsrc);
            this.Controls.Add(this.cmxapsrc);
            this.Controls.Add(this.dtrbirth);
            this.Controls.Add(this.lblbirth);
            this.Controls.Add(this.cmxclass);
            this.Controls.Add(this.lblclass);
            this.Controls.Add(this.cmxcomp);
            this.Controls.Add(this.lblcomp);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lblplz);
            this.Controls.Add(this.lblstr);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblpre);
            this.Controls.Add(this.tbxadd);
            this.Controls.Add(this.cmxplz);
            this.Controls.Add(this.cmxcity);
            this.Controls.Add(this.tbxtel);
            this.Controls.Add(this.cmxsal);
            this.Controls.Add(this.tbxpre);
            this.Controls.Add(this.tbxname);
            this.Controls.Add(this.tbxstr);
            this.Controls.Add(this.lblsal);
            this.Controls.Add(this.lblap);
            this.Controls.Add(this.tbxap);
            this.Name = "frmStudMgmt";
            this.Text = "Lehrlinge Verwalten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxap;
        private System.Windows.Forms.Label lblap;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.TextBox tbxstr;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.TextBox tbxpre;
        private System.Windows.Forms.ComboBox cmxsal;
        private System.Windows.Forms.TextBox tbxtel;
        private System.Windows.Forms.ComboBox cmxcity;
        private System.Windows.Forms.ComboBox cmxplz;
        private System.Windows.Forms.TextBox tbxadd;
        private System.Windows.Forms.Label lblpre;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstr;
        private System.Windows.Forms.Label lblplz;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.ComboBox cmxcomp;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.ComboBox cmxclass;
        private System.Windows.Forms.Label lblbirth;
        private System.Windows.Forms.DateTimePicker dtrbirth;
        private System.Windows.Forms.ComboBox cmxapsrc;
        private System.Windows.Forms.Label lblapsrc;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.ComboBox cmxtime;
    }
}

