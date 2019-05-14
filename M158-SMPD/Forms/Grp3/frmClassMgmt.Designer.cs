namespace Schnellerfassung
{
    partial class frmClassMgmt
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
            this.components = new System.ComponentModel.Container();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblclass = new System.Windows.Forms.Label();
            this.cmxclass = new System.Windows.Forms.ComboBox();
            this.btnclasses = new System.Windows.Forms.Button();
            this.btnsubj = new System.Windows.Forms.Button();
            this.lbxstudents = new System.Windows.Forms.ListBox();
            this.noten_2019DataSet = new Schnellerfassung.Noten_2019DataSet();
            this.tblAnredeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_AnredeTableAdapter = new Schnellerfassung.Noten_2019DataSetTableAdapters.tbl_AnredeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.noten_2019DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnredeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(10, 10);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(178, 13);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Klassen schnell erfassen/bearbeiten";
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.Location = new System.Drawing.Point(10, 40);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(75, 13);
            this.lblclass.TabIndex = 1;
            this.lblclass.Text = "Klasse wählen";
            // 
            // cmxclass
            // 
            this.cmxclass.FormattingEnabled = true;
            this.cmxclass.Location = new System.Drawing.Point(10, 60);
            this.cmxclass.Name = "cmxclass";
            this.cmxclass.Size = new System.Drawing.Size(400, 21);
            this.cmxclass.TabIndex = 1;
            this.cmxclass.SelectedValueChanged += new System.EventHandler(this.cmxclass_SelectedValueChanged);
            // 
            // btnclasses
            // 
            this.btnclasses.Location = new System.Drawing.Point(500, 60);
            this.btnclasses.Name = "btnclasses";
            this.btnclasses.Size = new System.Drawing.Size(75, 23);
            this.btnclasses.TabIndex = 1;
            this.btnclasses.Text = "...";
            this.btnclasses.UseVisualStyleBackColor = true;
            this.btnclasses.Click += new System.EventHandler(this.btnclasses_Click);
            // 
            // btnsubj
            // 
            this.btnsubj.Location = new System.Drawing.Point(580, 60);
            this.btnsubj.Name = "btnsubj";
            this.btnsubj.Size = new System.Drawing.Size(75, 23);
            this.btnsubj.TabIndex = 1;
            this.btnsubj.Text = "Fächer";
            this.btnsubj.UseVisualStyleBackColor = true;
            this.btnsubj.Click += new System.EventHandler(this.btnsubj_Click);
            // 
            // lbxstudents
            // 
            this.lbxstudents.FormattingEnabled = true;
            this.lbxstudents.Location = new System.Drawing.Point(10, 100);
            this.lbxstudents.Name = "lbxstudents";
            this.lbxstudents.Size = new System.Drawing.Size(200, 290);
            this.lbxstudents.TabIndex = 1;
            this.lbxstudents.SelectedIndexChanged += new System.EventHandler(this.lbxstudents_SelectedIndexChanged);
            // 
            // noten_2019DataSet
            // 
            this.noten_2019DataSet.DataSetName = "Noten_2019DataSet";
            this.noten_2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAnredeBindingSource
            // 
            this.tblAnredeBindingSource.DataMember = "tbl_Anrede";
            this.tblAnredeBindingSource.DataSource = this.noten_2019DataSet;
            // 
            // tbl_AnredeTableAdapter
            // 
            this.tbl_AnredeTableAdapter.ClearBeforeFill = true;
            // 
            // frmClassMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxstudents);
            this.Controls.Add(this.btnsubj);
            this.Controls.Add(this.btnclasses);
            this.Controls.Add(this.cmxclass);
            this.Controls.Add(this.lblclass);
            this.Controls.Add(this.lbltitle);
            this.Name = "frmClassMgmt";
            this.Text = "Klassenverwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.noten_2019DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnredeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.ComboBox cmxclass;
        private System.Windows.Forms.Button btnclasses;
        private System.Windows.Forms.Button btnsubj;
        private System.Windows.Forms.ListBox lbxstudents;
        private Noten_2019DataSet noten_2019DataSet;
        private System.Windows.Forms.BindingSource tblAnredeBindingSource;
        private Noten_2019DataSetTableAdapters.tbl_AnredeTableAdapter tbl_AnredeTableAdapter;
    }
}

