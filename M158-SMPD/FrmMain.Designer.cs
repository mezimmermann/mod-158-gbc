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
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonTab4 = new System.Windows.Forms.RibbonTab();
            this.ribbonTab5 = new System.Windows.Forms.RibbonTab();
            this.rbtBerichte = new System.Windows.Forms.RibbonTab();
            this.RibPan = new System.Windows.Forms.RibbonPanel();
            this.BtnReports = new System.Windows.Forms.RibbonButton();
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
            this.RbnMain.Tabs.Add(this.ribbonTab2);
            this.RbnMain.Tabs.Add(this.ribbonTab3);
            this.RbnMain.Tabs.Add(this.ribbonTab4);
            this.RbnMain.Tabs.Add(this.ribbonTab5);
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
            this.BtnNotendaten.Image = global::M158_SMPD.Properties.Resources.notendaten;
            this.BtnNotendaten.LargeImage = global::M158_SMPD.Properties.Resources.notendaten;
            this.BtnNotendaten.Name = "BtnNotendaten";
            this.BtnNotendaten.SmallImage = global::M158_SMPD.Properties.Resources.notendaten;
            this.BtnNotendaten.Text = "Notendaten";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "ribbonTab2";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "ribbonTab3";
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "ribbonTab4";
            // 
            // ribbonTab5
            // 
            this.ribbonTab5.Name = "ribbonTab5";
            this.ribbonTab5.Text = "ribbonTab5";
            // 
            // rbtBerichte
            // 
            this.rbtBerichte.Name = "rbtBerichte";
            this.rbtBerichte.Panels.Add(this.RibPan);
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
            this.BtnReports.Image = ((System.Drawing.Image)(resources.GetObject("BtnReports.Image")));
            this.BtnReports.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnReports.LargeImage")));
            this.BtnReports.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.SmallImage = ((System.Drawing.Image)(resources.GetObject("BtnReports.SmallImage")));
            this.BtnReports.Text = "Auswertungen anzeigen";
            this.BtnReports.Click += new System.EventHandler(this.BtnReports_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon RbnMain;
        private System.Windows.Forms.RibbonTab RbtbNotendaten;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonTab ribbonTab4;
        private System.Windows.Forms.RibbonTab ribbonTab5;
        private System.Windows.Forms.RibbonTab rbtBerichte;
        private System.Windows.Forms.RibbonPanel RibPan;
        private System.Windows.Forms.RibbonButton BtnReports;
        private System.Windows.Forms.RibbonOrbMenuItem BtnCreateUser;
        private System.Windows.Forms.RibbonPanel RibPanNotendaten;
        private System.Windows.Forms.RibbonButton BtnNotendaten;
    }
}

