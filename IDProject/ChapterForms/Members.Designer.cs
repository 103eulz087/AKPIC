namespace IDProject.ChapterForms
{
    partial class Members
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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtsearchcat = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnprintcert = new DevExpress.XtraEditors.SimpleButton();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            this.btnexporttoexcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtsearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMembershipStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCorrectiveActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recognitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appreciationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtsearchcat);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnprintcert);
            this.groupControl1.Controls.Add(this.btnprint);
            this.groupControl1.Controls.Add(this.btnexporttoexcel);
            this.groupControl1.Controls.Add(this.btnsearch);
            this.groupControl1.Controls.Add(this.txtsearch);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(888, 120);
            this.groupControl1.TabIndex = 0;
            // 
            // txtsearchcat
            // 
            this.txtsearchcat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchcat.FormattingEnabled = true;
            this.txtsearchcat.Items.AddRange(new object[] {
            "FirstName",
            "MiddleName",
            "LastName",
            "ID",
            "BloodType",
            "Skills",
            "Occupation",
            "Religion",
            "CivilStatus",
            "Gender",
            "Citizenship"});
            this.txtsearchcat.Location = new System.Drawing.Point(109, 43);
            this.txtsearchcat.Name = "txtsearchcat";
            this.txtsearchcat.Size = new System.Drawing.Size(193, 22);
            this.txtsearchcat.TabIndex = 54;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.8F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 45);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Search Category:";
            // 
            // btnprintcert
            // 
            this.btnprintcert.Location = new System.Drawing.Point(742, 72);
            this.btnprintcert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprintcert.Name = "btnprintcert";
            this.btnprintcert.Size = new System.Drawing.Size(105, 24);
            this.btnprintcert.TabIndex = 5;
            this.btnprintcert.Text = "Print as Certificate";
            this.btnprintcert.Click += new System.EventHandler(this.btnprintcert_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(657, 72);
            this.btnprint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(81, 24);
            this.btnprint.TabIndex = 4;
            this.btnprint.Text = "Print";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnexporttoexcel
            // 
            this.btnexporttoexcel.Location = new System.Drawing.Point(571, 72);
            this.btnexporttoexcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexporttoexcel.Name = "btnexporttoexcel";
            this.btnexporttoexcel.Size = new System.Drawing.Size(81, 24);
            this.btnexporttoexcel.TabIndex = 3;
            this.btnexporttoexcel.Text = "Export to Excel";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(485, 72);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(81, 24);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Search";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(109, 73);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.8F);
            this.txtsearch.Properties.Appearance.Options.UseFont = true;
            this.txtsearch.Size = new System.Drawing.Size(371, 22);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.8F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 75);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Search Keyword:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 120);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(888, 305);
            this.panelControl1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(884, 301);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseUp);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.ColumnPanelRowHeight = 0;
            this.gridView1.DetailHeight = 284;
            this.gridView1.FooterPanelHeight = 0;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupRowHeight = 0;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PreviewIndent = 0;
            this.gridView1.RowHeight = 0;
            this.gridView1.ViewCaptionHeight = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLedgerToolStripMenuItem,
            this.viewLedgerToolStripMenuItem,
            this.updateMembershipStatusToolStripMenuItem,
            this.addCorrectiveActionToolStripMenuItem,
            this.printFilesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 114);
            // 
            // showLedgerToolStripMenuItem
            // 
            this.showLedgerToolStripMenuItem.Name = "showLedgerToolStripMenuItem";
            this.showLedgerToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.showLedgerToolStripMenuItem.Text = "View Details";
            this.showLedgerToolStripMenuItem.Click += new System.EventHandler(this.showLedgerToolStripMenuItem_Click);
            // 
            // viewLedgerToolStripMenuItem
            // 
            this.viewLedgerToolStripMenuItem.Name = "viewLedgerToolStripMenuItem";
            this.viewLedgerToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.viewLedgerToolStripMenuItem.Text = "View Ledger";
            this.viewLedgerToolStripMenuItem.Click += new System.EventHandler(this.viewLedgerToolStripMenuItem_Click);
            // 
            // updateMembershipStatusToolStripMenuItem
            // 
            this.updateMembershipStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeToolStripMenuItem,
            this.inactiveToolStripMenuItem});
            this.updateMembershipStatusToolStripMenuItem.Name = "updateMembershipStatusToolStripMenuItem";
            this.updateMembershipStatusToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.updateMembershipStatusToolStripMenuItem.Text = "Update Membership Status";
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.activeToolStripMenuItem.Text = "Active";
            this.activeToolStripMenuItem.Click += new System.EventHandler(this.activeToolStripMenuItem_Click);
            // 
            // inactiveToolStripMenuItem
            // 
            this.inactiveToolStripMenuItem.Name = "inactiveToolStripMenuItem";
            this.inactiveToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.inactiveToolStripMenuItem.Text = "Inactive";
            this.inactiveToolStripMenuItem.Click += new System.EventHandler(this.inactiveToolStripMenuItem_Click);
            // 
            // addCorrectiveActionToolStripMenuItem
            // 
            this.addCorrectiveActionToolStripMenuItem.Name = "addCorrectiveActionToolStripMenuItem";
            this.addCorrectiveActionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.addCorrectiveActionToolStripMenuItem.Text = "Add Corrective Action";
            // 
            // printFilesToolStripMenuItem
            // 
            this.printFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printCertificateToolStripMenuItem,
            this.printIDToolStripMenuItem});
            this.printFilesToolStripMenuItem.Name = "printFilesToolStripMenuItem";
            this.printFilesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.printFilesToolStripMenuItem.Text = "Print Files";
            // 
            // printCertificateToolStripMenuItem
            // 
            this.printCertificateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recognitionToolStripMenuItem,
            this.appreciationToolStripMenuItem,
            this.registrationToolStripMenuItem});
            this.printCertificateToolStripMenuItem.Name = "printCertificateToolStripMenuItem";
            this.printCertificateToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.printCertificateToolStripMenuItem.Text = "Print Certificate";
            // 
            // recognitionToolStripMenuItem
            // 
            this.recognitionToolStripMenuItem.Name = "recognitionToolStripMenuItem";
            this.recognitionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.recognitionToolStripMenuItem.Text = "Recognition";
            this.recognitionToolStripMenuItem.Click += new System.EventHandler(this.recognitionToolStripMenuItem_Click);
            // 
            // appreciationToolStripMenuItem
            // 
            this.appreciationToolStripMenuItem.Name = "appreciationToolStripMenuItem";
            this.appreciationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.appreciationToolStripMenuItem.Text = "Appreciation";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.registrationToolStripMenuItem.Text = "Registration";
            // 
            // printIDToolStripMenuItem
            // 
            this.printIDToolStripMenuItem.Name = "printIDToolStripMenuItem";
            this.printIDToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.printIDToolStripMenuItem.Text = "Print ID";
            this.printIDToolStripMenuItem.Click += new System.EventHandler(this.printIDToolStripMenuItem_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 425);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Members";
            this.Text = "Rho Nu - Exclusive Masterlist File";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtsearch;
        private DevExpress.XtraEditors.SimpleButton btnprint;
        private DevExpress.XtraEditors.SimpleButton btnexporttoexcel;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private DevExpress.XtraEditors.SimpleButton btnprintcert;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLedgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMembershipStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCorrectiveActionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printCertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLedgerToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox txtsearchcat;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inactiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recognitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appreciationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Data.DataSet dataSet1;
    }
}