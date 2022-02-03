namespace IDProject.ChapterForms
{
    partial class ViewMembersLedger
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblidno = new DevExpress.XtraEditors.LabelControl();
            this.lblfullname = new DevExpress.XtraEditors.LabelControl();
            this.picimage = new System.Windows.Forms.PictureBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lbltransdate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblfundsamount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1029, 369);
            this.gridControl1.TabIndex = 8;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 46);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::IDProject.Properties.Resources.Refresh2_16x16__2_;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(133, 42);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.lblidno);
            this.groupControl1.Controls.Add(this.lblfullname);
            this.groupControl1.Controls.Add(this.picimage);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.lbltransdate);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lblfundsamount);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1033, 148);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Member Accounts";
            // 
            // lblidno
            // 
            this.lblidno.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidno.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblidno.Appearance.Options.UseFont = true;
            this.lblidno.Appearance.Options.UseForeColor = true;
            this.lblidno.Location = new System.Drawing.Point(147, 56);
            this.lblidno.Margin = new System.Windows.Forms.Padding(1);
            this.lblidno.Name = "lblidno";
            this.lblidno.Size = new System.Drawing.Size(76, 14);
            this.lblidno.TabIndex = 79;
            this.lblidno.Text = "Date of Birth:";
            // 
            // lblfullname
            // 
            this.lblfullname.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblfullname.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblfullname.Appearance.Options.UseFont = true;
            this.lblfullname.Appearance.Options.UseForeColor = true;
            this.lblfullname.Location = new System.Drawing.Point(147, 32);
            this.lblfullname.Margin = new System.Windows.Forms.Padding(1);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(162, 23);
            this.lblfullname.TabIndex = 78;
            this.lblfullname.Text = "EULZ AVANCENA";
            // 
            // picimage
            // 
            this.picimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picimage.Image = global::IDProject.Properties.Resources._10708863_elegant_vintage_background_;
            this.picimage.Location = new System.Drawing.Point(9, 23);
            this.picimage.Margin = new System.Windows.Forms.Padding(0);
            this.picimage.Name = "picimage";
            this.picimage.Size = new System.Drawing.Size(127, 110);
            this.picimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picimage.TabIndex = 34;
            this.picimage.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::IDProject.Properties.Resources.Print_32x32__2_;
            this.simpleButton1.Location = new System.Drawing.Point(632, 83);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(197, 50);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Print Transaction History";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lbltransdate
            // 
            this.lbltransdate.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltransdate.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbltransdate.Appearance.Options.UseFont = true;
            this.lbltransdate.Appearance.Options.UseForeColor = true;
            this.lbltransdate.Location = new System.Drawing.Point(383, 110);
            this.lbltransdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbltransdate.Name = "lbltransdate";
            this.lbltransdate.Size = new System.Drawing.Size(210, 23);
            this.lbltransdate.TabIndex = 4;
            this.lbltransdate.Text = "12/12/2021 12:12:01";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(147, 110);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(215, 23);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Last Transaction Date:";
            // 
            // lblfundsamount
            // 
            this.lblfundsamount.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfundsamount.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblfundsamount.Appearance.Options.UseFont = true;
            this.lblfundsamount.Appearance.Options.UseForeColor = true;
            this.lblfundsamount.Location = new System.Drawing.Point(383, 83);
            this.lblfundsamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblfundsamount.Name = "lblfundsamount";
            this.lblfundsamount.Size = new System.Drawing.Size(197, 23);
            this.lblfundsamount.TabIndex = 2;
            this.lblfundsamount.Text = "Total Amount Given:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(147, 83);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(197, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Total Amount Given:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 148);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1033, 394);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Transaction History";
            // 
            // ViewMembersLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 542);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "ViewMembersLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMembersLedger";
            this.Load += new System.EventHandler(this.ViewMembersLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LabelControl lblfundsamount;
        public DevExpress.XtraEditors.LabelControl lbltransdate;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public System.Windows.Forms.PictureBox picimage;
        public DevExpress.XtraEditors.LabelControl lblidno;
        public DevExpress.XtraEditors.LabelControl lblfullname;
    }
}