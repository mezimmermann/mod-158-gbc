namespace M158_SMPD
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.RbnMain = new System.Windows.Forms.Ribbon();
            this.BtnCreateUser = new System.Windows.Forms.RibbonOrbMenuItem();
            this.RbtbNotendaten = new System.Windows.Forms.RibbonTab();
            this.RibPanNotendaten = new System.Windows.Forms.RibbonPanel();
            this.BtnNotendaten = new System.Windows.Forms.RibbonButton();
            this.RibTabSemesterdaten = new System.Windows.Forms.RibbonTab();
            this.RibPanSemesterdaten = new System.Windows.Forms.RibbonPanel();
            this.BtnFaecherzuteilung = new System.Windows.Forms.RibbonButton();
            this.BtnNotenperiode = new System.Windows.Forms.RibbonButton();
            this.RibTabStammdaten = new System.Windows.Forms.RibbonTab();
            this.RibPanAdressen = new System.Windows.Forms.RibbonPanel();
            this.BtnSSL = new System.Windows.Forms.RibbonButton();
            this.BtnFirmendaten = new System.Windows.Forms.RibbonButton();
            this.BtnSchnellerfassung = new System.Windows.Forms.RibbonButton();
            this.RibPanOtherStd = new System.Windows.Forms.RibbonPanel();
            this.BtnAnrede = new System.Windows.Forms.RibbonButton();
            this.BtnFaecher = new System.Windows.Forms.RibbonButton();
            this.BtnOrte = new System.Windows.Forms.RibbonButton();
            this.BtnKlassen = new System.Windows.Forms.RibbonButton();
            this.BtnBerufe = new System.Windows.Forms.RibbonButton();
            this.rbtBerichte = new System.Windows.Forms.RibbonTab();
            this.RibPan = new System.Windows.Forms.RibbonPanel();
            this.BtnReports = new System.Windows.Forms.RibbonButton();
            this.RibPanListen = new System.Windows.Forms.RibbonPanel();
            this.btnNotenlisten = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // RbnMain
            // 
            this.RbnMain.CaptionBarVisible = false;
            this.RbnMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RbnMain.Location = new System.Drawing.Point(0, 0);
            this.RbnMain.Minimized = false;
            this.RbnMain.Name = "RbnMain";
            // 
            // 
            // 
            this.RbnMain.OrbDropDown.BorderRoundness = 8;
            this.RbnMain.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.RbnMain.OrbDropDown.MenuItems.Add(this.BtnCreateUser);
            this.RbnMain.OrbDropDown.Name = "";
            this.RbnMain.OrbDropDown.Size = new System.Drawing.Size(527, 116);
            this.RbnMain.OrbDropDown.TabIndex = 0;
            this.RbnMain.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.RbnMain.OrbText = "Start";
            this.RbnMain.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.RbnMain.Size = new System.Drawing.Size(1235, 117);
            this.RbnMain.TabIndex = 1;
            this.RbnMain.Tabs.Add(this.RbtbNotendaten);
            this.RbnMain.Tabs.Add(this.RibTabSemesterdaten);
            this.RbnMain.Tabs.Add(this.RibTabStammdaten);
            this.RbnMain.Tabs.Add(this.rbtBerichte);
            this.RbnMain.TabsMargin = new System.Windows.Forms.Padding(5, 2, 20, 0);
            this.RbnMain.TabSpacing = 4;
            // 
            // BtnCreateUser
            // 
            this.BtnCreateUser.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.BtnCreateUser.Enabled = false;
            this.BtnCreateUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnCreateUser.Image")));
            this.BtnCreateUser.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnCreateUser.LargeImage")));
            this.BtnCreateUser.Name = "BtnCreateUser";
            this.BtnCreateUser.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnCreateUser.SmallImage")));
            this.BtnCreateUser.Text = "Benutzer erstellen";
            this.BtnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // RbtbNotendaten
            // 
            this.RbtbNotendaten.Name = "RbtbNotendaten";
            this.RbtbNotendaten.Panels.Add(this.RibPanNotendaten);
            this.RbtbNotendaten.Text = "Notendaten";
            // 
            // RibPanNotendaten
            // 
            this.RibPanNotendaten.ButtonMoreEnabled = false;
            this.RibPanNotendaten.ButtonMoreVisible = false;
            this.RibPanNotendaten.Items.Add(this.BtnNotendaten);
            this.RibPanNotendaten.Name = "RibPanNotendaten";
            this.RibPanNotendaten.Text = "Notendaten";
            // 
            // BtnNotendaten
            // 
            this.BtnNotendaten.Image = global::M158_SMPD.Properties.Resources.notdatico;
            this.BtnNotendaten.LargeImage = global::M158_SMPD.Properties.Resources.notdatico;
            this.BtnNotendaten.Name = "BtnNotendaten";
            this.BtnNotendaten.SmallImage = global::M158_SMPD.Properties.Resources.notdatico;
            this.BtnNotendaten.Text = "Notendaten";
            this.BtnNotendaten.Click += new System.EventHandler(this.BtnNotendaten_Click);
            // 
            // RibTabSemesterdaten
            // 
            this.RibTabSemesterdaten.Name = "RibTabSemesterdaten";
            this.RibTabSemesterdaten.Panels.Add(this.RibPanSemesterdaten);
            this.RibTabSemesterdaten.Text = "Semesterdaten";
            // 
            // RibPanSemesterdaten
            // 
            this.RibPanSemesterdaten.ButtonMoreEnabled = false;
            this.RibPanSemesterdaten.ButtonMoreVisible = false;
            this.RibPanSemesterdaten.Items.Add(this.BtnFaecherzuteilung);
            this.RibPanSemesterdaten.Items.Add(this.BtnNotenperiode);
            this.RibPanSemesterdaten.Name = "RibPanSemesterdaten";
            this.RibPanSemesterdaten.Text = "";
            // 
            // BtnFaecherzuteilung
            // 
            this.BtnFaecherzuteilung.Image = global::M158_SMPD.Properties.Resources.classesico;
            this.BtnFaecherzuteilung.LargeImage = global::M158_SMPD.Properties.Resources.classesico;
            this.BtnFaecherzuteilung.Name = "BtnFaecherzuteilung";
            this.BtnFaecherzuteilung.SmallImage = global::M158_SMPD.Properties.Resources.classesico;
            this.BtnFaecherzuteilung.Text = "Fächerzuteilung";
            this.BtnFaecherzuteilung.Click += new System.EventHandler(this.BtnFaecherzuteilung_Click);
            // 
            // BtnNotenperiode
            // 
            this.BtnNotenperiode.Image = global::M158_SMPD.Properties.Resources.periodico;
            this.BtnNotenperiode.LargeImage = global::M158_SMPD.Properties.Resources.periodico;
            this.BtnNotenperiode.Name = "BtnNotenperiode";
            this.BtnNotenperiode.SmallImage = global::M158_SMPD.Properties.Resources.periodico;
            this.BtnNotenperiode.Text = "Notenperiode";
            this.BtnNotenperiode.Click += new System.EventHandler(this.BtnNotenperiode_Click);
            // 
            // RibTabStammdaten
            // 
            this.RibTabStammdaten.Name = "RibTabStammdaten";
            this.RibTabStammdaten.Panels.Add(this.RibPanAdressen);
            this.RibTabStammdaten.Panels.Add(this.RibPanOtherStd);
            this.RibTabStammdaten.Text = "Stammdaten";
            // 
            // RibPanAdressen
            // 
            this.RibPanAdressen.ButtonMoreEnabled = false;
            this.RibPanAdressen.ButtonMoreVisible = false;
            this.RibPanAdressen.Items.Add(this.BtnSSL);
            this.RibPanAdressen.Items.Add(this.BtnFirmendaten);
            this.RibPanAdressen.Items.Add(this.BtnSchnellerfassung);
            this.RibPanAdressen.Name = "RibPanAdressen";
            this.RibPanAdressen.Text = "Adressen";
            // 
            // BtnSSL
            // 
            this.BtnSSL.Image = ((System.Drawing.Image)(resources.GetObject("BtnSSL.Image")));
            this.BtnSSL.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnSSL.LargeImage")));
            this.BtnSSL.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnSSL.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnSSL.Name = "BtnSSL";
            this.BtnSSL.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnSSL.SmallImage")));
            this.BtnSSL.Text = "Studenten / Schüler / Lehrlinge";
            this.BtnSSL.Click += new System.EventHandler(this.BtnSSL_Click);
            // 
            // BtnFirmendaten
            // 
            this.BtnFirmendaten.Image = ((System.Drawing.Image)(resources.GetObject("BtnFirmendaten.Image")));
            this.BtnFirmendaten.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFirmendaten.LargeImage")));
            this.BtnFirmendaten.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnFirmendaten.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnFirmendaten.Name = "BtnFirmendaten";
            this.BtnFirmendaten.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnFirmendaten.SmallImage")));
            this.BtnFirmendaten.Text = "Firmendaten";
            this.BtnFirmendaten.Click += new System.EventHandler(this.BtnFirmendaten_Click);
            // 
            // BtnSchnellerfassung
            // 
            this.BtnSchnellerfassung.Image = global::M158_SMPD.Properties.Resources.erfassenico;
            this.BtnSchnellerfassung.LargeImage = global::M158_SMPD.Properties.Resources.erfassenico;
            this.BtnSchnellerfassung.Name = "BtnSchnellerfassung";
            this.BtnSchnellerfassung.SmallImage = global::M158_SMPD.Properties.Resources.erfassenico;
            this.BtnSchnellerfassung.Text = "Schnellerfassung (SSL)";
            this.BtnSchnellerfassung.Click += new System.EventHandler(this.BtnSchnellerfassung_Click);
            // 
            // RibPanOtherStd
            // 
            this.RibPanOtherStd.ButtonMoreEnabled = false;
            this.RibPanOtherStd.ButtonMoreVisible = false;
            this.RibPanOtherStd.Items.Add(this.BtnAnrede);
            this.RibPanOtherStd.Items.Add(this.BtnFaecher);
            this.RibPanOtherStd.Items.Add(this.BtnOrte);
            this.RibPanOtherStd.Items.Add(this.BtnKlassen);
            this.RibPanOtherStd.Items.Add(this.BtnBerufe);
            this.RibPanOtherStd.Name = "RibPanOtherStd";
            this.RibPanOtherStd.Text = "Weitere Stammdaten";
            // 
            // BtnAnrede
            // 
            this.BtnAnrede.Image = global::M158_SMPD.Properties.Resources.stammdatenico;
            this.BtnAnrede.LargeImage = global::M158_SMPD.Properties.Resources.stammdatenico;
            this.BtnAnrede.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnAnrede.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnAnrede.Name = "BtnAnrede";
            this.BtnAnrede.SmallImage = global::M158_SMPD.Properties.Resources.stammdatenico;
            this.BtnAnrede.Text = "Anrede";
            this.BtnAnrede.Click += new System.EventHandler(this.BtnAnrede_Click);
            // 
            // BtnFaecher
            // 
            this.BtnFaecher.Image = ((System.Drawing.Image)(resources.GetObject("BtnFaecher.Image")));
            this.BtnFaecher.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFaecher.LargeImage")));
            this.BtnFaecher.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnFaecher.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnFaecher.Name = "BtnFaecher";
            this.BtnFaecher.SmallImage = global::M158_SMPD.Properties.Resources.stammdatenico;
            this.BtnFaecher.Text = "Fächer";
            this.BtnFaecher.Click += new System.EventHandler(this.BtnFaecher_Click);
            // 
            // BtnOrte
            // 
            this.BtnOrte.Image = ((System.Drawing.Image)(resources.GetObject("BtnOrte.Image")));
            this.BtnOrte.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnOrte.LargeImage")));
            this.BtnOrte.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnOrte.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnOrte.Name = "BtnOrte";
            this.BtnOrte.SmallImage = global::M158_SMPD.Properties.Resources.locico;
            this.BtnOrte.Text = "Orte";
            this.BtnOrte.Click += new System.EventHandler(this.BtnOrte_Click);
            // 
            // BtnKlassen
            // 
            this.BtnKlassen.Image = ((System.Drawing.Image)(resources.GetObject("BtnKlassen.Image")));
            this.BtnKlassen.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKlassen.LargeImage")));
            this.BtnKlassen.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnKlassen.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnKlassen.Name = "BtnKlassen";
            this.BtnKlassen.SmallImage = global::M158_SMPD.Properties.Resources.classico;
            this.BtnKlassen.Text = "Klassen";
            this.BtnKlassen.Click += new System.EventHandler(this.BtnKlassen_Click);
            // 
            // BtnBerufe
            // 
            this.BtnBerufe.Image = global::M158_SMPD.Properties.Resources.jobico;
            this.BtnBerufe.LargeImage = global::M158_SMPD.Properties.Resources.jobico;
            this.BtnBerufe.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnBerufe.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnBerufe.Name = "BtnBerufe";
            this.BtnBerufe.SmallImage = global::M158_SMPD.Properties.Resources.jobico;
            this.BtnBerufe.Text = "Berufe";
            this.BtnBerufe.Click += new System.EventHandler(this.BtnBerufe_Click);
            // 
            // rbtBerichte
            // 
            this.rbtBerichte.Name = "rbtBerichte";
            this.rbtBerichte.Panels.Add(this.RibPan);
            this.rbtBerichte.Panels.Add(this.RibPanListen);
            this.rbtBerichte.Text = "Berichte";
            // 
            // RibPan
            // 
            this.RibPan.ButtonMoreEnabled = false;
            this.RibPan.ButtonMoreVisible = false;
            this.RibPan.Items.Add(this.BtnReports);
            this.RibPan.Name = "RibPan";
            this.RibPan.Text = "Auswertungsfenster";
            // 
            // BtnReports
            // 
            this.BtnReports.Image = global::M158_SMPD.Properties.Resources.reportico;
            this.BtnReports.LargeImage = global::M158_SMPD.Properties.Resources.reportico;
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnReports.SmallImage")));
            this.BtnReports.Text = "Auswertungen anzeigen";
            this.BtnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // RibPanListen
            // 
            this.RibPanListen.Items.Add(this.btnNotenlisten);
            this.RibPanListen.Name = "RibPanListen";
            this.RibPanListen.Text = "Listen";
            // 
            // btnNotenlisten
            // 
            this.btnNotenlisten.Image = global::M158_SMPD.Properties.Resources.marklistico;
            this.btnNotenlisten.LargeImage = global::M158_SMPD.Properties.Resources.marklistico;
            this.btnNotenlisten.Name = "btnNotenlisten";
            this.btnNotenlisten.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnNotenlisten.SmallImage")));
            this.btnNotenlisten.Text = "Notenlisten";
            this.btnNotenlisten.Click += new System.EventHandler(this.BtnNotenlisten_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1235, 659);
            this.Controls.Add(this.RbnMain);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.Text = "Hauptmaske";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon RbnMain;
        private System.Windows.Forms.RibbonTab RbtbNotendaten;
        private System.Windows.Forms.RibbonTab RibTabSemesterdaten;
        private System.Windows.Forms.RibbonTab RibTabStammdaten;
        private System.Windows.Forms.RibbonTab rbtBerichte;
        private System.Windows.Forms.RibbonPanel RibPan;
        private System.Windows.Forms.RibbonButton BtnReports;
        private System.Windows.Forms.RibbonOrbMenuItem BtnCreateUser;
        private System.Windows.Forms.RibbonPanel RibPanNotendaten;
        private System.Windows.Forms.RibbonButton BtnNotendaten;
        private System.Windows.Forms.RibbonPanel RibPanSemesterdaten;
        private System.Windows.Forms.RibbonButton BtnFaecherzuteilung;
        private System.Windows.Forms.RibbonButton BtnNotenperiode;
        private System.Windows.Forms.RibbonPanel RibPanAdressen;
        private System.Windows.Forms.RibbonButton BtnSSL;
        private System.Windows.Forms.RibbonButton BtnFirmendaten;
        private System.Windows.Forms.RibbonButton BtnSchnellerfassung;
        private System.Windows.Forms.RibbonPanel RibPanListen;
        private System.Windows.Forms.RibbonButton btnNotenlisten;
        private System.Windows.Forms.RibbonPanel RibPanOtherStd;
        private System.Windows.Forms.RibbonButton BtnAnrede;
        private System.Windows.Forms.RibbonButton BtnFaecher;
        private System.Windows.Forms.RibbonButton BtnOrte;
        private System.Windows.Forms.RibbonButton BtnKlassen;
        private System.Windows.Forms.RibbonButton BtnBerufe;
    }
}

