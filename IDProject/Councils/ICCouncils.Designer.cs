namespace IDProject.Councils
{
    partial class ICCouncils
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
            this.txtcountry = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.picimage = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.txtcouncilname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcouncilname.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 294);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(7);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(2627, 1143);
            this.groupControl2.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(7);
            this.gridControl1.Location = new System.Drawing.Point(3, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(7);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(2621, 1090);
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
            this.gridView1.DetailHeight = 634;
            this.gridView1.FixedLineWidth = 4;
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
            this.groupControl1.Controls.Add(this.txtcountry);
            this.groupControl1.Controls.Add(this.picimage);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btncancel);
            this.groupControl1.Controls.Add(this.btnupdate);
            this.groupControl1.Controls.Add(this.btnadd);
            this.groupControl1.Controls.Add(this.btnnew);
            this.groupControl1.Controls.Add(this.txtcouncilname);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(2627, 294);
            this.groupControl1.TabIndex = 8;
            // 
            // txtcountry
            // 
            this.txtcountry.Location = new System.Drawing.Point(313, 89);
            this.txtcountry.Margin = new System.Windows.Forms.Padding(7);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtcountry.Properties.Appearance.Options.UseFont = true;
            this.txtcountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtcountry.Properties.PopupView = this.searchLookUpEdit1View;
            this.txtcountry.Size = new System.Drawing.Size(558, 48);
            this.txtcountry.TabIndex = 70;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.DetailHeight = 781;
            this.searchLookUpEdit1View.FixedLineWidth = 4;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // picimage
            // 
            this.picimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picimage.Image = global::IDProject.Properties.Resources._10708863_elegant_vintage_background_;
            this.picimage.Location = new System.Drawing.Point(1036, 80);
            this.picimage.Margin = new System.Windows.Forms.Padding(0);
            this.picimage.Name = "picimage";
            this.picimage.Size = new System.Drawing.Size(114, 109);
            this.picimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picimage.TabIndex = 69;
            this.picimage.TabStop = false;
            this.picimage.Click += new System.EventHandler(this.picimage_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 96);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 34);
            this.labelControl1.TabIndex = 68;
            this.labelControl1.Text = "Country:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(929, 96);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 34);
            this.labelControl3.TabIndex = 63;
            this.labelControl3.Text = "Logo:";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(805, 205);
            this.btncancel.Margin = new System.Windows.Forms.Padding(7);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(140, 58);
            this.btncancel.TabIndex = 61;
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(623, 205);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(7);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(170, 58);
            this.btnupdate.TabIndex = 60;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(469, 205);
            this.btnadd.Margin = new System.Windows.Forms.Padding(7);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(140, 58);
            this.btnadd.TabIndex = 59;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(315, 205);
            this.btnnew.Margin = new System.Windows.Forms.Padding(7);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(140, 58);
            this.btnnew.TabIndex = 58;
            this.btnnew.Text = "New";
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // txtcouncilname
            // 
            this.txtcouncilname.Location = new System.Drawing.Point(313, 147);
            this.txtcouncilname.Margin = new System.Windows.Forms.Padding(7);
            this.txtcouncilname.Name = "txtcouncilname";
            this.txtcouncilname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtcouncilname.Properties.Appearance.Options.UseFont = true;
            this.txtcouncilname.Size = new System.Drawing.Size(558, 48);
            this.txtcouncilname.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(28, 154);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(181, 34);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Council Name:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDetailsToolStripMenuItem,
            this.showMembersToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(331, 138);
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(330, 42);
            this.updateDetailsToolStripMenuItem.Text = "Edit Details";
            this.updateDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDetailsToolStripMenuItem_Click);
            // 
            // showMembersToolStripMenuItem
            // 
            this.showMembersToolStripMenuItem.Name = "showMembersToolStripMenuItem";
            this.showMembersToolStripMenuItem.Size = new System.Drawing.Size(330, 42);
            this.showMembersToolStripMenuItem.Text = "Show Members";
            this.showMembersToolStripMenuItem.Click += new System.EventHandler(this.showMembersToolStripMenuItem_Click);
            // 
            // ICCouncils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2627, 1437);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "ICCouncils";
            this.Text = "ICCouncils";
            this.Load += new System.EventHandler(this.ICCouncils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcouncilname.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btnnew;
        private DevExpress.XtraEditors.TextEdit txtcouncilname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox picimage;
        private DevExpress.XtraEditors.SearchLookUpEdit txtcountry;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMembersToolStripMenuItem;
    }
}