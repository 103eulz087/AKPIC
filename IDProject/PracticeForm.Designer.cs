namespace IDProject
{
    partial class PracticeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticeForm));
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckischapterid = new System.Windows.Forms.CheckBox();
            this.chckisByGroup = new System.Windows.Forms.CheckBox();
            this.txtgroupname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtchaptercountrycode = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.txtchapter = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtchapterzipcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtchapterregioncode = new System.Windows.Forms.TextBox();
            this.txtchapterchaptercode = new System.Windows.Forms.TextBox();
            this.txtchapterprovincecode = new System.Windows.Forms.TextBox();
            this.txtchaptercountries = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtchaptermunicipalitycode = new System.Windows.Forms.TextBox();
            this.txtchapterregions = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtchapterprovinces = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtchaptermunicipalites = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtchapter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchaptercountries.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchapterregions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchapterprovinces.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchaptermunicipalites.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl2.Size = new System.Drawing.Size(1172, 241);
            this.gridControl2.TabIndex = 64;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.ColumnPanelRowHeight = 0;
            this.gridView1.DetailHeight = 284;
            this.gridView1.FooterPanelHeight = 0;
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.GroupRowHeight = 0;
            this.gridView1.LevelIndent = 0;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.PreviewIndent = 0;
            this.gridView1.RowHeight = 8;
            this.gridView1.ViewCaptionHeight = 0;
            this.gridView1.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEdit);
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.CustomHeight = 20;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.progressBarControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 180);
            this.panel1.TabIndex = 65;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.8F);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton4.Location = new System.Drawing.Point(838, 21);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(124, 68);
            this.simpleButton4.TabIndex = 144;
            this.simpleButton4.Text = "Export Images";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.8F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.Location = new System.Drawing.Point(709, 22);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(124, 93);
            this.simpleButton2.TabIndex = 143;
            this.simpleButton2.Text = "Export Images";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(839, 95);
            this.progressBarControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.ShowProgressInTaskBar = true;
            this.progressBarControl1.Size = new System.Drawing.Size(224, 20);
            this.progressBarControl1.TabIndex = 142;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckischapterid);
            this.groupBox1.Controls.Add(this.chckisByGroup);
            this.groupBox1.Controls.Add(this.txtgroupname);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtchaptercountrycode);
            this.groupBox1.Controls.Add(this.label65);
            this.groupBox1.Controls.Add(this.txtchapter);
            this.groupBox1.Controls.Add(this.txtchapterzipcode);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtchapterregioncode);
            this.groupBox1.Controls.Add(this.txtchapterchaptercode);
            this.groupBox1.Controls.Add(this.txtchapterprovincecode);
            this.groupBox1.Controls.Add(this.txtchaptercountries);
            this.groupBox1.Controls.Add(this.txtchaptermunicipalitycode);
            this.groupBox1.Controls.Add(this.txtchapterregions);
            this.groupBox1.Controls.Add(this.txtchapterprovinces);
            this.groupBox1.Controls.Add(this.txtchaptermunicipalites);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(460, 154);
            this.groupBox1.TabIndex = 139;
            this.groupBox1.TabStop = false;
            // 
            // chckischapterid
            // 
            this.chckischapterid.AutoSize = true;
            this.chckischapterid.Location = new System.Drawing.Point(104, 121);
            this.chckischapterid.Margin = new System.Windows.Forms.Padding(2);
            this.chckischapterid.Name = "chckischapterid";
            this.chckischapterid.Size = new System.Drawing.Size(86, 17);
            this.chckischapterid.TabIndex = 147;
            this.chckischapterid.Text = "is ChapterID";
            this.chckischapterid.UseVisualStyleBackColor = true;
            // 
            // chckisByGroup
            // 
            this.chckisByGroup.AutoSize = true;
            this.chckisByGroup.Location = new System.Drawing.Point(238, 99);
            this.chckisByGroup.Margin = new System.Windows.Forms.Padding(2);
            this.chckisByGroup.Name = "chckisByGroup";
            this.chckisByGroup.Size = new System.Drawing.Size(70, 17);
            this.chckisByGroup.TabIndex = 144;
            this.chckisByGroup.Text = "By Group";
            this.chckisByGroup.UseVisualStyleBackColor = true;
            this.chckisByGroup.CheckedChanged += new System.EventHandler(this.chckisByGroup_CheckedChanged);
            // 
            // txtgroupname
            // 
            this.txtgroupname.Enabled = false;
            this.txtgroupname.Location = new System.Drawing.Point(104, 98);
            this.txtgroupname.Margin = new System.Windows.Forms.Padding(2);
            this.txtgroupname.Name = "txtgroupname";
            this.txtgroupname.Size = new System.Drawing.Size(129, 21);
            this.txtgroupname.TabIndex = 145;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(5, 98);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 14);
            this.label13.TabIndex = 146;
            this.label13.Text = "Group Name:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(16, 25);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 14);
            this.label24.TabIndex = 128;
            this.label24.Text = "Country:";
            // 
            // txtchaptercountrycode
            // 
            this.txtchaptercountrycode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchaptercountrycode.Location = new System.Drawing.Point(460, 21);
            this.txtchaptercountrycode.Margin = new System.Windows.Forms.Padding(2);
            this.txtchaptercountrycode.Name = "txtchaptercountrycode";
            this.txtchaptercountrycode.ReadOnly = true;
            this.txtchaptercountrycode.Size = new System.Drawing.Size(56, 22);
            this.txtchaptercountrycode.TabIndex = 132;
            this.txtchaptercountrycode.Visible = false;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label65.Location = new System.Drawing.Point(221, 48);
            this.label65.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(58, 14);
            this.label65.TabIndex = 137;
            this.label65.Text = "Zipcode:";
            // 
            // txtchapter
            // 
            this.txtchapter.Location = new System.Drawing.Point(338, 71);
            this.txtchapter.Margin = new System.Windows.Forms.Padding(2);
            this.txtchapter.Name = "txtchapter";
            this.txtchapter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtchapter.Properties.Appearance.Options.UseFont = true;
            this.txtchapter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtchapter.Properties.NullText = "";
            this.txtchapter.Properties.PopupView = this.searchLookUpEdit1View;
            this.txtchapter.Size = new System.Drawing.Size(110, 20);
            this.txtchapter.TabIndex = 123;
            this.txtchapter.EditValueChanged += new System.EventHandler(this.txtchapter_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.ColumnPanelRowHeight = 0;
            this.searchLookUpEdit1View.DetailHeight = 284;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.FooterPanelHeight = 0;
            this.searchLookUpEdit1View.GroupRowHeight = 0;
            this.searchLookUpEdit1View.LevelIndent = 0;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit1View.PreviewIndent = 0;
            this.searchLookUpEdit1View.RowHeight = 0;
            this.searchLookUpEdit1View.ViewCaptionHeight = 0;
            // 
            // txtchapterzipcode
            // 
            this.txtchapterzipcode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchapterzipcode.Location = new System.Drawing.Point(338, 46);
            this.txtchapterzipcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtchapterzipcode.Name = "txtchapterzipcode";
            this.txtchapterzipcode.ReadOnly = true;
            this.txtchapterzipcode.Size = new System.Drawing.Size(111, 22);
            this.txtchapterzipcode.TabIndex = 138;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(220, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 14);
            this.label10.TabIndex = 122;
            this.label10.Text = "Chapter Name:";
            // 
            // txtchapterregioncode
            // 
            this.txtchapterregioncode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchapterregioncode.Location = new System.Drawing.Point(460, 46);
            this.txtchapterregioncode.Margin = new System.Windows.Forms.Padding(2);
            this.txtchapterregioncode.Name = "txtchapterregioncode";
            this.txtchapterregioncode.ReadOnly = true;
            this.txtchapterregioncode.Size = new System.Drawing.Size(56, 22);
            this.txtchapterregioncode.TabIndex = 133;
            this.txtchapterregioncode.Visible = false;
            // 
            // txtchapterchaptercode
            // 
            this.txtchapterchaptercode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchapterchaptercode.Location = new System.Drawing.Point(521, 69);
            this.txtchapterchaptercode.Margin = new System.Windows.Forms.Padding(2);
            this.txtchapterchaptercode.Name = "txtchapterchaptercode";
            this.txtchapterchaptercode.ReadOnly = true;
            this.txtchapterchaptercode.Size = new System.Drawing.Size(56, 22);
            this.txtchapterchaptercode.TabIndex = 136;
            this.txtchapterchaptercode.Visible = false;
            // 
            // txtchapterprovincecode
            // 
            this.txtchapterprovincecode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchapterprovincecode.Location = new System.Drawing.Point(460, 69);
            this.txtchapterprovincecode.Margin = new System.Windows.Forms.Padding(2);
            this.txtchapterprovincecode.Name = "txtchapterprovincecode";
            this.txtchapterprovincecode.ReadOnly = true;
            this.txtchapterprovincecode.Size = new System.Drawing.Size(56, 22);
            this.txtchapterprovincecode.TabIndex = 134;
            this.txtchapterprovincecode.Visible = false;
            // 
            // txtchaptercountries
            // 
            this.txtchaptercountries.Location = new System.Drawing.Point(104, 23);
            this.txtchaptercountries.Margin = new System.Windows.Forms.Padding(2);
            this.txtchaptercountries.Name = "txtchaptercountries";
            this.txtchaptercountries.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtchaptercountries.Properties.Appearance.Options.UseFont = true;
            this.txtchaptercountries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtchaptercountries.Properties.NullText = "";
            this.txtchaptercountries.Properties.PopupView = this.gridView3;
            this.txtchaptercountries.Size = new System.Drawing.Size(110, 20);
            this.txtchaptercountries.TabIndex = 124;
            this.txtchaptercountries.EditValueChanged += new System.EventHandler(this.txtchaptercountries_EditValueChanged);
            // 
            // gridView3
            // 
            this.gridView3.ColumnPanelRowHeight = 0;
            this.gridView3.DetailHeight = 284;
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.FooterPanelHeight = 0;
            this.gridView3.GroupRowHeight = 0;
            this.gridView3.LevelIndent = 0;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.PreviewIndent = 0;
            this.gridView3.RowHeight = 0;
            this.gridView3.ViewCaptionHeight = 0;
            // 
            // txtchaptermunicipalitycode
            // 
            this.txtchaptermunicipalitycode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchaptermunicipalitycode.Location = new System.Drawing.Point(521, 21);
            this.txtchaptermunicipalitycode.Margin = new System.Windows.Forms.Padding(2);
            this.txtchaptermunicipalitycode.Name = "txtchaptermunicipalitycode";
            this.txtchaptermunicipalitycode.ReadOnly = true;
            this.txtchaptermunicipalitycode.Size = new System.Drawing.Size(56, 22);
            this.txtchaptermunicipalitycode.TabIndex = 135;
            this.txtchaptermunicipalitycode.Visible = false;
            // 
            // txtchapterregions
            // 
            this.txtchapterregions.Location = new System.Drawing.Point(104, 47);
            this.txtchapterregions.Margin = new System.Windows.Forms.Padding(2);
            this.txtchapterregions.Name = "txtchapterregions";
            this.txtchapterregions.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtchapterregions.Properties.Appearance.Options.UseFont = true;
            this.txtchapterregions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtchapterregions.Properties.NullText = "";
            this.txtchapterregions.Properties.PopupView = this.gridView4;
            this.txtchapterregions.Size = new System.Drawing.Size(110, 20);
            this.txtchapterregions.TabIndex = 125;
            this.txtchapterregions.EditValueChanged += new System.EventHandler(this.txtchapterregions_EditValueChanged);
            // 
            // gridView4
            // 
            this.gridView4.ColumnPanelRowHeight = 0;
            this.gridView4.DetailHeight = 284;
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.FooterPanelHeight = 0;
            this.gridView4.GroupRowHeight = 0;
            this.gridView4.LevelIndent = 0;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.PreviewIndent = 0;
            this.gridView4.RowHeight = 0;
            this.gridView4.ViewCaptionHeight = 0;
            // 
            // txtchapterprovinces
            // 
            this.txtchapterprovinces.Location = new System.Drawing.Point(104, 72);
            this.txtchapterprovinces.Margin = new System.Windows.Forms.Padding(2);
            this.txtchapterprovinces.Name = "txtchapterprovinces";
            this.txtchapterprovinces.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtchapterprovinces.Properties.Appearance.Options.UseFont = true;
            this.txtchapterprovinces.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtchapterprovinces.Properties.NullText = "";
            this.txtchapterprovinces.Properties.PopupView = this.gridView5;
            this.txtchapterprovinces.Size = new System.Drawing.Size(110, 20);
            this.txtchapterprovinces.TabIndex = 126;
            this.txtchapterprovinces.EditValueChanged += new System.EventHandler(this.txtchapterprovinces_EditValueChanged);
            // 
            // gridView5
            // 
            this.gridView5.ColumnPanelRowHeight = 0;
            this.gridView5.DetailHeight = 284;
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.FooterPanelHeight = 0;
            this.gridView5.GroupRowHeight = 0;
            this.gridView5.LevelIndent = 0;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.PreviewIndent = 0;
            this.gridView5.RowHeight = 0;
            this.gridView5.ViewCaptionHeight = 0;
            // 
            // txtchaptermunicipalites
            // 
            this.txtchaptermunicipalites.Location = new System.Drawing.Point(338, 23);
            this.txtchaptermunicipalites.Margin = new System.Windows.Forms.Padding(2);
            this.txtchaptermunicipalites.Name = "txtchaptermunicipalites";
            this.txtchaptermunicipalites.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.txtchaptermunicipalites.Properties.Appearance.Options.UseFont = true;
            this.txtchaptermunicipalites.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtchaptermunicipalites.Properties.NullText = "";
            this.txtchaptermunicipalites.Properties.PopupView = this.gridView6;
            this.txtchaptermunicipalites.Size = new System.Drawing.Size(110, 20);
            this.txtchaptermunicipalites.TabIndex = 127;
            this.txtchaptermunicipalites.EditValueChanged += new System.EventHandler(this.txtchaptermunicipalites_EditValueChanged);
            // 
            // gridView6
            // 
            this.gridView6.ColumnPanelRowHeight = 0;
            this.gridView6.DetailHeight = 284;
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.FooterPanelHeight = 0;
            this.gridView6.GroupRowHeight = 0;
            this.gridView6.LevelIndent = 0;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            this.gridView6.PreviewIndent = 0;
            this.gridView6.RowHeight = 0;
            this.gridView6.ViewCaptionHeight = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(220, 25);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 14);
            this.label27.TabIndex = 131;
            this.label27.Text = "Municipalities:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(16, 74);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 14);
            this.label26.TabIndex = 130;
            this.label26.Text = "Provinces:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(16, 50);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 14);
            this.label25.TabIndex = 129;
            this.label25.Text = "Regions:";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.8F);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton3.Location = new System.Drawing.Point(592, 22);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(112, 93);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Print";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.8F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(474, 21);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(113, 93);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Extract List";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 241);
            this.panel2.TabIndex = 66;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 421);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PracticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PracticeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtchapter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchaptercountries.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchapterregions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchapterprovinces.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtchaptermunicipalites.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtchaptercountrycode;
        private DevExpress.XtraEditors.SearchLookUpEdit txtchapter;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SearchLookUpEdit txtchaptercountries;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SearchLookUpEdit txtchapterregions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SearchLookUpEdit txtchapterprovinces;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.SearchLookUpEdit txtchaptermunicipalites;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtchapterregioncode;
        private System.Windows.Forms.TextBox txtchapterprovincecode;
        private System.Windows.Forms.TextBox txtchaptermunicipalitycode;
        private System.Windows.Forms.TextBox txtchapterchaptercode;
        private System.Windows.Forms.TextBox txtchapterzipcode;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.CheckBox chckisByGroup;
        private System.Windows.Forms.TextBox txtgroupname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chckischapterid;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}