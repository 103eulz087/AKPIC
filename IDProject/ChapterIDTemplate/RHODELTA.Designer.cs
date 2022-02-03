namespace IDProject
{
    partial class RHODELTA
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RHODELTA));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblname = new DevExpress.XtraReports.UI.XRLabel();
            this.lblbirthdate = new DevExpress.XtraReports.UI.XRLabel();
            this.lblgs = new DevExpress.XtraReports.UI.XRLabel();
            this.lbldatesurvive = new DevExpress.XtraReports.UI.XRLabel();
            this.lblmasterinitiator = new DevExpress.XtraReports.UI.XRLabel();
            this.lblbloodtype = new DevExpress.XtraReports.UI.XRLabel();
            this.xrpic = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblname,
            this.lblbirthdate,
            this.lblgs,
            this.lbldatesurvive,
            this.lblmasterinitiator,
            this.lblbloodtype,
            this.xrpic,
            this.xrPictureBox2,
            this.xrBarCode1,
            this.xrPictureBox1});
            this.ReportHeader.HeightF = 220F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblname
            // 
            this.lblname.BorderColor = System.Drawing.Color.Black;
            this.lblname.CanGrow = false;
            this.lblname.Font = new System.Drawing.Font("Avenir LT Std 65 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.LocationFloat = new DevExpress.Utils.PointFloat(127F, 84.83002F);
            this.lblname.Name = "lblname";
            this.lblname.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblname.SizeF = new System.Drawing.SizeF(202.4166F, 26.33672F);
            this.lblname.StylePriority.UseBorderColor = false;
            this.lblname.StylePriority.UseFont = false;
            this.lblname.StylePriority.UseForeColor = false;
            this.lblname.StylePriority.UseTextAlignment = false;
            this.lblname.Text = "RHO DELTA";
            this.lblname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblname.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkAndGrow;
            this.lblname.TextTrimming = System.Drawing.StringTrimming.None;
            this.lblname.WordWrap = false;
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.BorderColor = System.Drawing.Color.Black;
            this.lblbirthdate.Font = new System.Drawing.Font("Avenir LT Std 65 Medium", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbirthdate.ForeColor = System.Drawing.Color.White;
            this.lblbirthdate.LocationFloat = new DevExpress.Utils.PointFloat(143.3333F, 133F);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblbirthdate.SizeF = new System.Drawing.SizeF(74.70826F, 13.625F);
            this.lblbirthdate.StylePriority.UseBorderColor = false;
            this.lblbirthdate.StylePriority.UseFont = false;
            this.lblbirthdate.StylePriority.UseForeColor = false;
            this.lblbirthdate.StylePriority.UseTextAlignment = false;
            this.lblbirthdate.Text = "Date Survived:";
            this.lblbirthdate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblgs
            // 
            this.lblgs.BorderColor = System.Drawing.Color.Black;
            this.lblgs.CanGrow = false;
            this.lblgs.Font = new System.Drawing.Font("Avenir LT Std 65 Medium", 7.2F, System.Drawing.FontStyle.Bold);
            this.lblgs.ForeColor = System.Drawing.Color.White;
            this.lblgs.LocationFloat = new DevExpress.Utils.PointFloat(127F, 165F);
            this.lblgs.Name = "lblgs";
            this.lblgs.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblgs.SizeF = new System.Drawing.SizeF(102.9167F, 13.62502F);
            this.lblgs.StylePriority.UseBorderColor = false;
            this.lblgs.StylePriority.UseFont = false;
            this.lblgs.StylePriority.UseForeColor = false;
            this.lblgs.StylePriority.UseTextAlignment = false;
            this.lblgs.Text = "Blood Type:";
            this.lblgs.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblgs.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkAndGrow;
            this.lblgs.TextTrimming = System.Drawing.StringTrimming.None;
            this.lblgs.WordWrap = false;
            // 
            // lbldatesurvive
            // 
            this.lbldatesurvive.BorderColor = System.Drawing.Color.Black;
            this.lbldatesurvive.Font = new System.Drawing.Font("Avenir LT Std 65 Medium", 7.2F, System.Drawing.FontStyle.Bold);
            this.lbldatesurvive.ForeColor = System.Drawing.Color.White;
            this.lbldatesurvive.LocationFloat = new DevExpress.Utils.PointFloat(241.37F, 133F);
            this.lbldatesurvive.Name = "lbldatesurvive";
            this.lbldatesurvive.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbldatesurvive.SizeF = new System.Drawing.SizeF(72.29166F, 13.62501F);
            this.lbldatesurvive.StylePriority.UseBorderColor = false;
            this.lbldatesurvive.StylePriority.UseFont = false;
            this.lbldatesurvive.StylePriority.UseForeColor = false;
            this.lbldatesurvive.StylePriority.UseTextAlignment = false;
            this.lbldatesurvive.Text = "08/08/2020";
            this.lbldatesurvive.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblmasterinitiator
            // 
            this.lblmasterinitiator.BorderColor = System.Drawing.Color.Black;
            this.lblmasterinitiator.CanGrow = false;
            this.lblmasterinitiator.Font = new System.Drawing.Font("Avenir LT Std 65 Medium", 7.2F, System.Drawing.FontStyle.Bold);
            this.lblmasterinitiator.ForeColor = System.Drawing.Color.White;
            this.lblmasterinitiator.LocationFloat = new DevExpress.Utils.PointFloat(229.9167F, 165F);
            this.lblmasterinitiator.Name = "lblmasterinitiator";
            this.lblmasterinitiator.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblmasterinitiator.SizeF = new System.Drawing.SizeF(99.50003F, 13.62502F);
            this.lblmasterinitiator.StylePriority.UseBorderColor = false;
            this.lblmasterinitiator.StylePriority.UseFont = false;
            this.lblmasterinitiator.StylePriority.UseForeColor = false;
            this.lblmasterinitiator.StylePriority.UseTextAlignment = false;
            this.lblmasterinitiator.Text = "giftname";
            this.lblmasterinitiator.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblmasterinitiator.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkAndGrow;
            this.lblmasterinitiator.WordWrap = false;
            // 
            // lblbloodtype
            // 
            this.lblbloodtype.BorderColor = System.Drawing.Color.Black;
            this.lblbloodtype.Font = new System.Drawing.Font("Avenir LT Std 65 Medium", 7.2F, System.Drawing.FontStyle.Bold);
            this.lblbloodtype.ForeColor = System.Drawing.Color.White;
            this.lblbloodtype.LocationFloat = new DevExpress.Utils.PointFloat(13.20834F, 0.6250255F);
            this.lblbloodtype.Name = "lblbloodtype";
            this.lblbloodtype.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblbloodtype.SizeF = new System.Drawing.SizeF(72.29166F, 13.62501F);
            this.lblbloodtype.StylePriority.UseBorderColor = false;
            this.lblbloodtype.StylePriority.UseFont = false;
            this.lblbloodtype.StylePriority.UseForeColor = false;
            this.lblbloodtype.Text = "RHO DELTA";
            this.lblbloodtype.Visible = false;
            // 
            // xrpic
            // 
            this.xrpic.LocationFloat = new DevExpress.Utils.PointFloat(14F, 48.33F);
            this.xrpic.Name = "xrpic";
            this.xrpic.SizeF = new System.Drawing.SizeF(100F, 104F);
            this.xrpic.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(13F, 14.25003F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrPictureBox2.Visible = false;
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.AutoModule = true;
            this.xrBarCode1.BackColor = System.Drawing.Color.Transparent;
            this.xrBarCode1.BorderColor = System.Drawing.Color.White;
            this.xrBarCode1.ForeColor = System.Drawing.Color.White;
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(38.33333F, 158.4967F);
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrBarCode1.ShowText = false;
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(47.16668F, 51.50334F);
            this.xrBarCode1.StylePriority.UseBackColor = false;
            this.xrBarCode1.StylePriority.UseBorderColor = false;
            this.xrBarCode1.StylePriority.UseForeColor = false;
            this.xrBarCode1.StylePriority.UsePadding = false;
            this.xrBarCode1.StylePriority.UseTextAlignment = false;
            this.xrBarCode1.Symbology = qrCodeGenerator1;
            this.xrBarCode1.Text = "636000000100001";
            this.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(336.9999F, 220F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // RHODELTA
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader});
            this.DesignerOptions.ShowDesignerHints = false;
            this.DesignerOptions.ShowExportWarnings = false;
            this.DesignerOptions.ShowPrintingWarnings = false;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 214;
            this.PageWidth = 337;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        public DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        public DevExpress.XtraReports.UI.XRLabel lblbloodtype;
        public DevExpress.XtraReports.UI.XRLabel lblgs;
        public DevExpress.XtraReports.UI.XRLabel lbldatesurvive;
        public DevExpress.XtraReports.UI.XRLabel lblmasterinitiator;
        public DevExpress.XtraReports.UI.XRLabel lblbirthdate;
        public DevExpress.XtraReports.UI.XRLabel lblname;
        public DevExpress.XtraReports.UI.XRPictureBox xrpic;
    }
}
