namespace IDProject
{
    partial class MainDashboard
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnmembersmasterlist = new DevExpress.XtraBars.BarButtonItem();
            this.btnattendancedashboard = new DevExpress.XtraBars.BarButtonItem();
            this.btnmeetingsandactivities = new DevExpress.XtraBars.BarButtonItem();
            this.btnactivities = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnCorrectiveAction = new DevExpress.XtraBars.BarButtonItem();
            this.btnAnnouncement = new DevExpress.XtraBars.BarButtonItem();
            this.btnStats = new DevExpress.XtraBars.BarButtonItem();
            this.btnMemo = new DevExpress.XtraBars.BarButtonItem();
            this.btnExpense = new DevExpress.XtraBars.BarButtonItem();
            this.btnChapterLogo = new DevExpress.XtraBars.BarButtonItem();
            this.btnLedger = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonations = new DevExpress.XtraBars.BarButtonItem();
            this.btnAttendanceSummary = new DevExpress.XtraBars.BarButtonItem();
            this.btnChapterMasterlist = new DevExpress.XtraBars.BarButtonItem();
            this.btnSmsBlast = new DevExpress.XtraBars.BarButtonItem();
            this.btnNatlForms = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCertificates = new DevExpress.XtraBars.BarButtonItem();
            this.btnCouncilMasterlist = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnmembersmasterlist,
            this.btnattendancedashboard,
            this.btnmeetingsandactivities,
            this.btnactivities,
            this.barbtnCorrectiveAction,
            this.btnAnnouncement,
            this.btnStats,
            this.btnMemo,
            this.btnExpense,
            this.btnChapterLogo,
            this.btnLedger,
            this.btnDonations,
            this.btnAttendanceSummary,
            this.btnChapterMasterlist,
            this.btnSmsBlast,
            this.btnNatlForms,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.btnCertificates,
            this.btnCouncilMasterlist});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 25;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbon.Size = new System.Drawing.Size(1088, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnmembersmasterlist
            // 
            this.btnmembersmasterlist.Caption = "Members Masterlist";
            this.btnmembersmasterlist.Id = 1;
            this.btnmembersmasterlist.ImageOptions.LargeImage = global::IDProject.Properties.Resources.UserGroup_32x32__2_;
            this.btnmembersmasterlist.Name = "btnmembersmasterlist";
            this.btnmembersmasterlist.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnmembersmasterlist_ItemClick);
            // 
            // btnattendancedashboard
            // 
            this.btnattendancedashboard.Caption = "Attendance Board";
            this.btnattendancedashboard.Id = 2;
            this.btnattendancedashboard.ImageOptions.Image = global::IDProject.Properties.Resources.Today_32x32__2_;
            this.btnattendancedashboard.ImageOptions.LargeImage = global::IDProject.Properties.Resources.Today_32x32__2_;
            this.btnattendancedashboard.Name = "btnattendancedashboard";
            this.btnattendancedashboard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnattendancedashboard_ItemClick);
            // 
            // btnmeetingsandactivities
            // 
            this.btnmeetingsandactivities.Caption = "Meetings";
            this.btnmeetingsandactivities.Id = 3;
            this.btnmeetingsandactivities.ImageOptions.LargeImage = global::IDProject.Properties.Resources.Meeting_32x32;
            this.btnmeetingsandactivities.Name = "btnmeetingsandactivities";
            this.btnmeetingsandactivities.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnmeetingsandactivities_ItemClick);
            // 
            // btnactivities
            // 
            this.btnactivities.Caption = "Activities";
            this.btnactivities.Id = 4;
            this.btnactivities.ImageOptions.LargeImage = global::IDProject.Properties.Resources.AddFile_32x32__2_;
            this.btnactivities.Name = "btnactivities";
            this.btnactivities.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnactivities_ItemClick);
            // 
            // barbtnCorrectiveAction
            // 
            this.barbtnCorrectiveAction.Caption = "Corrective Action";
            this.barbtnCorrectiveAction.Id = 5;
            this.barbtnCorrectiveAction.ImageOptions.LargeImage = global::IDProject.Properties.Resources.ActiveCustomersList_32x32;
            this.barbtnCorrectiveAction.Name = "barbtnCorrectiveAction";
            this.barbtnCorrectiveAction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCorrectiveAction_ItemClick);
            // 
            // btnAnnouncement
            // 
            this.btnAnnouncement.Caption = "Announcement";
            this.btnAnnouncement.Id = 6;
            this.btnAnnouncement.ImageOptions.Image = global::IDProject.Properties.Resources.Announcement_32x32__2_;
            this.btnAnnouncement.ImageOptions.LargeImage = global::IDProject.Properties.Resources.Announcement_32x32__2_;
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnnouncement_ItemClick);
            // 
            // btnStats
            // 
            this.btnStats.Caption = "Statistics";
            this.btnStats.Id = 7;
            this.btnStats.ImageOptions.LargeImage = global::IDProject.Properties.Resources.Statistical_32x32;
            this.btnStats.Name = "btnStats";
            this.btnStats.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStats_ItemClick);
            // 
            // btnMemo
            // 
            this.btnMemo.Caption = "Memo";
            this.btnMemo.Id = 8;
            this.btnMemo.ImageOptions.LargeImage = global::IDProject.Properties.Resources.MemoStyle__2_;
            this.btnMemo.Name = "btnMemo";
            this.btnMemo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMemo_ItemClick);
            // 
            // btnExpense
            // 
            this.btnExpense.Caption = "Expenses";
            this.btnExpense.Id = 9;
            this.btnExpense.ImageOptions.LargeImage = global::IDProject.Properties.Resources.Currency_32x32__2_;
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExpense_ItemClick);
            // 
            // btnChapterLogo
            // 
            this.btnChapterLogo.Caption = "Logo";
            this.btnChapterLogo.Id = 10;
            this.btnChapterLogo.ImageOptions.Image = global::IDProject.Properties.Resources.Image_32x32;
            this.btnChapterLogo.ImageOptions.LargeImage = global::IDProject.Properties.Resources.Image_32x321;
            this.btnChapterLogo.Name = "btnChapterLogo";
            this.btnChapterLogo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChapterLogo_ItemClick);
            // 
            // btnLedger
            // 
            this.btnLedger.Caption = "Chapter Ledger";
            this.btnLedger.Id = 11;
            this.btnLedger.ImageOptions.LargeImage = global::IDProject.Properties.Resources.Demo_Report_WithInlinePreviewAction_32x32;
            this.btnLedger.Name = "btnLedger";
            this.btnLedger.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLedger_ItemClick);
            // 
            // btnDonations
            // 
            this.btnDonations.Caption = "Donations";
            this.btnDonations.Id = 12;
            this.btnDonations.ImageOptions.LargeImage = global::IDProject.Properties.Resources.CustomerRevenue_32x32;
            this.btnDonations.Name = "btnDonations";
            this.btnDonations.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonations_ItemClick);
            // 
            // btnAttendanceSummary
            // 
            this.btnAttendanceSummary.Caption = "Attendance Summary";
            this.btnAttendanceSummary.Id = 13;
            this.btnAttendanceSummary.ImageOptions.LargeImage = global::IDProject.Properties.Resources.URL_History;
            this.btnAttendanceSummary.Name = "btnAttendanceSummary";
            this.btnAttendanceSummary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAttendanceSummary_ItemClick);
            // 
            // btnChapterMasterlist
            // 
            this.btnChapterMasterlist.Caption = "Chapters Masterlist";
            this.btnChapterMasterlist.Id = 14;
            this.btnChapterMasterlist.ImageOptions.LargeImage = global::IDProject.Properties.Resources.List_32x32__2_;
            this.btnChapterMasterlist.Name = "btnChapterMasterlist";
            // 
            // btnSmsBlast
            // 
            this.btnSmsBlast.Caption = "SMS Text Blast";
            this.btnSmsBlast.Id = 15;
            this.btnSmsBlast.Name = "btnSmsBlast";
            // 
            // btnNatlForms
            // 
            this.btnNatlForms.ActAsDropDown = true;
            this.btnNatlForms.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnNatlForms.Caption = "Forms";
            this.btnNatlForms.DropDownControl = this.popupMenu1;
            this.btnNatlForms.Id = 16;
            this.btnNatlForms.Name = "btnNatlForms";
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barButtonItem1);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem2);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem3);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem4);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem5);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem6);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 17;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 18;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 19;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 20;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 21;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 22;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // btnCertificates
            // 
            this.btnCertificates.Caption = "Certificates";
            this.btnCertificates.Id = 23;
            this.btnCertificates.ImageOptions.LargeImage = global::IDProject.Properties.Resources.Outlook_Post;
            this.btnCertificates.Name = "btnCertificates";
            this.btnCertificates.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCertificates_ItemClick);
            // 
            // btnCouncilMasterlist
            // 
            this.btnCouncilMasterlist.Caption = "Councils Masterlist";
            this.btnCouncilMasterlist.Id = 24;
            this.btnCouncilMasterlist.Name = "btnCouncilMasterlist";
            this.btnCouncilMasterlist.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCouncilMasterlist_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "MAIN";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnChapterMasterlist);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLedger);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnmembersmasterlist);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnCouncilMasterlist);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ACOUNTS";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnmeetingsandactivities);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnactivities);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnExpense);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDonations);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnCorrectiveAction);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAnnouncement);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMemo);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnattendancedashboard);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChapterLogo);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSmsBlast);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNatlForms);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ADMINISTRATIVE TOOLS";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnStats);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnAttendanceSummary);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCertificates);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "REPORTING";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 469);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1088, 24);
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController1.PropertiesDocking.ViewStyle = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Classic;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.xtraTabbedMdiManager1.Appearance.BackColor2 = System.Drawing.Color.DimGray;
            this.xtraTabbedMdiManager1.Appearance.BorderColor = System.Drawing.Color.White;
            this.xtraTabbedMdiManager1.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.xtraTabbedMdiManager1.Appearance.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.Appearance.Options.UseBorderColor = true;
            this.xtraTabbedMdiManager1.Appearance.Options.UseForeColor = true;
            this.xtraTabbedMdiManager1.AppearancePage.Header.BackColor = System.Drawing.Color.DarkSlateGray;
            this.xtraTabbedMdiManager1.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xtraTabbedMdiManager1.AppearancePage.Header.ForeColor = System.Drawing.SystemColors.Control;
            this.xtraTabbedMdiManager1.AppearancePage.Header.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabbedMdiManager1.AppearancePage.Header.Options.UseForeColor = true;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.White;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 493);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::IDProject.Properties.Resources.Alpha_Kappa_Rho;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainDashboard";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnmembersmasterlist;
        private DevExpress.XtraBars.BarButtonItem btnattendancedashboard;
        private DevExpress.XtraBars.BarButtonItem btnmeetingsandactivities;
        private DevExpress.XtraBars.BarButtonItem btnactivities;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barbtnCorrectiveAction;
        private DevExpress.XtraBars.BarButtonItem btnAnnouncement;
        private DevExpress.XtraBars.BarButtonItem btnStats;
        private DevExpress.XtraBars.BarButtonItem btnMemo;
        private DevExpress.XtraBars.BarButtonItem btnExpense;
        private DevExpress.XtraBars.BarButtonItem btnChapterLogo;
        private DevExpress.XtraBars.BarButtonItem btnLedger;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDonations;
        private DevExpress.XtraBars.BarButtonItem btnAttendanceSummary;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnChapterMasterlist;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnSmsBlast;
        private DevExpress.XtraBars.BarButtonItem btnNatlForms;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnCertificates;
        private DevExpress.XtraBars.BarButtonItem btnCouncilMasterlist;
    }
}