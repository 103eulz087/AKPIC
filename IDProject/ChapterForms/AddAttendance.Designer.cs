namespace IDProject.ChapterForms
{
    partial class AddAttendance
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtreferencecode = new DevExpress.XtraEditors.TextEdit();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.txtreferenceid = new DevExpress.XtraEditors.TextEdit();
            this.txtattendanceid = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtreferencecode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtreferenceid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtattendanceid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.groupBox1.Size = new System.Drawing.Size(2962, 1205);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(13, 16, 13, 16);
            this.gridControl2.Location = new System.Drawing.Point(9, 45);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(13, 16, 13, 16);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(2944, 1144);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.DetailHeight = 1742;
            this.gridView2.FixedLineWidth = 9;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.gridView2.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView2_ShowingEditor);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtreferencecode);
            this.groupBox3.Controls.Add(this.btnsave);
            this.groupBox3.Controls.Add(this.txtreferenceid);
            this.groupBox3.Controls.Add(this.txtattendanceid);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.groupBox3.Size = new System.Drawing.Size(2962, 154);
            this.groupBox3.TabIndex = 110;
            this.groupBox3.TabStop = false;
            // 
            // txtreferencecode
            // 
            this.txtreferencecode.Location = new System.Drawing.Point(761, 58);
            this.txtreferencecode.Margin = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.txtreferencecode.Name = "txtreferencecode";
            this.txtreferencecode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtreferencecode.Properties.Appearance.Options.UseFont = true;
            this.txtreferencecode.Properties.MaxLength = 35;
            this.txtreferencecode.Size = new System.Drawing.Size(262, 54);
            this.txtreferencecode.TabIndex = 32;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(48, 49);
            this.btnsave.Margin = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(342, 67);
            this.btnsave.TabIndex = 31;
            this.btnsave.Text = "Save";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtreferenceid
            // 
            this.txtreferenceid.Location = new System.Drawing.Point(481, 58);
            this.txtreferenceid.Margin = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.txtreferenceid.Name = "txtreferenceid";
            this.txtreferenceid.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtreferenceid.Properties.Appearance.Options.UseFont = true;
            this.txtreferenceid.Properties.MaxLength = 35;
            this.txtreferenceid.Size = new System.Drawing.Size(262, 54);
            this.txtreferenceid.TabIndex = 27;
            // 
            // txtattendanceid
            // 
            this.txtattendanceid.Location = new System.Drawing.Point(481, 125);
            this.txtattendanceid.Margin = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.txtattendanceid.Name = "txtattendanceid";
            this.txtattendanceid.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtattendanceid.Properties.Appearance.Options.UseFont = true;
            this.txtattendanceid.Properties.MaxLength = 35;
            this.txtattendanceid.Size = new System.Drawing.Size(262, 54);
            this.txtattendanceid.TabIndex = 26;
            // 
            // AddAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2962, 1359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.Name = "AddAttendance";
            this.Text = "AddAttendance";
            this.Load += new System.EventHandler(this.AddAttendance_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtreferencecode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtreferenceid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtattendanceid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        public DevExpress.XtraEditors.TextEdit txtreferenceid;
        private DevExpress.XtraEditors.TextEdit txtattendanceid;
        public DevExpress.XtraGrid.GridControl gridControl2;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        public DevExpress.XtraEditors.TextEdit txtreferencecode;
    }
}