namespace IDProject.ChapterForms
{
    partial class AddActivities
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtmeetingdate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtremarks = new System.Windows.Forms.RichTextBox();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.txtmainagenda = new DevExpress.XtraEditors.TextEdit();
            this.txtmeetingid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMeetingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAttendeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMeetingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmeetingdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmeetingdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmainagenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmeetingid.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 223);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(733, 199);
            this.groupControl2.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(729, 174);
            this.gridControl1.TabIndex = 1;
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
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.PreviewIndent = 0;
            this.gridView1.RowHeight = 0;
            this.gridView1.ViewCaptionHeight = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtmeetingdate);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtremarks);
            this.groupControl1.Controls.Add(this.btncancel);
            this.groupControl1.Controls.Add(this.btnupdate);
            this.groupControl1.Controls.Add(this.btnadd);
            this.groupControl1.Controls.Add(this.btnnew);
            this.groupControl1.Controls.Add(this.txtmainagenda);
            this.groupControl1.Controls.Add(this.txtmeetingid);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(733, 223);
            this.groupControl1.TabIndex = 4;
            // 
            // txtmeetingdate
            // 
            this.txtmeetingdate.EditValue = null;
            this.txtmeetingdate.Location = new System.Drawing.Point(235, 28);
            this.txtmeetingdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmeetingdate.Name = "txtmeetingdate";
            this.txtmeetingdate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.8F);
            this.txtmeetingdate.Properties.Appearance.Options.UseFont = true;
            this.txtmeetingdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtmeetingdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtmeetingdate.Size = new System.Drawing.Size(95, 22);
            this.txtmeetingdate.TabIndex = 65;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(201, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 14);
            this.labelControl4.TabIndex = 64;
            this.labelControl4.Text = "Date:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 14);
            this.labelControl3.TabIndex = 63;
            this.labelControl3.Text = "Remarks:";
            // 
            // txtremarks
            // 
            this.txtremarks.Location = new System.Drawing.Point(124, 80);
            this.txtremarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(284, 99);
            this.txtremarks.TabIndex = 62;
            this.txtremarks.Text = "";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(321, 184);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(56, 26);
            this.btncancel.TabIndex = 61;
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(248, 184);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(68, 26);
            this.btnupdate.TabIndex = 60;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(187, 184);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(56, 26);
            this.btnadd.TabIndex = 59;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(126, 184);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(56, 26);
            this.btnnew.TabIndex = 58;
            this.btnnew.Text = "New";
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // txtmainagenda
            // 
            this.txtmainagenda.Location = new System.Drawing.Point(124, 55);
            this.txtmainagenda.Name = "txtmainagenda";
            this.txtmainagenda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtmainagenda.Properties.Appearance.Options.UseFont = true;
            this.txtmainagenda.Size = new System.Drawing.Size(283, 20);
            this.txtmainagenda.TabIndex = 3;
            // 
            // txtmeetingid
            // 
            this.txtmeetingid.Location = new System.Drawing.Point(124, 29);
            this.txtmeetingid.Name = "txtmeetingid";
            this.txtmeetingid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtmeetingid.Properties.Appearance.Options.UseFont = true;
            this.txtmeetingid.Properties.ReadOnly = true;
            this.txtmeetingid.Size = new System.Drawing.Size(72, 20);
            this.txtmeetingid.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Activity Name:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Activity ID:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMeetingDetailsToolStripMenuItem,
            this.showAttendeesToolStripMenuItem,
            this.viewMeetingDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 70);
            // 
            // showMeetingDetailsToolStripMenuItem
            // 
            this.showMeetingDetailsToolStripMenuItem.Name = "showMeetingDetailsToolStripMenuItem";
            this.showMeetingDetailsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.showMeetingDetailsToolStripMenuItem.Text = "Edit Meeting Details";
            this.showMeetingDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMeetingDetailsToolStripMenuItem_Click);
            // 
            // showAttendeesToolStripMenuItem
            // 
            this.showAttendeesToolStripMenuItem.Name = "showAttendeesToolStripMenuItem";
            this.showAttendeesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.showAttendeesToolStripMenuItem.Text = "Add Attendees";
            this.showAttendeesToolStripMenuItem.Click += new System.EventHandler(this.showAttendeesToolStripMenuItem_Click);
            // 
            // viewMeetingDetailsToolStripMenuItem
            // 
            this.viewMeetingDetailsToolStripMenuItem.Name = "viewMeetingDetailsToolStripMenuItem";
            this.viewMeetingDetailsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.viewMeetingDetailsToolStripMenuItem.Text = "View Meeting Details";
            this.viewMeetingDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewMeetingDetailsToolStripMenuItem_Click);
            // 
            // AddActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 422);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "AddActivities";
            this.Text = "AddActivities";
            this.Load += new System.EventHandler(this.AddActivities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmeetingdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmeetingdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmainagenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmeetingid.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit txtmeetingdate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.RichTextBox txtremarks;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btnnew;
        private DevExpress.XtraEditors.TextEdit txtmainagenda;
        private DevExpress.XtraEditors.TextEdit txtmeetingid;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showMeetingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAttendeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMeetingDetailsToolStripMenuItem;
    }
}