namespace IDProject
{
    partial class OMEGABETA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OMEGABETA));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblname = new DevExpress.XtraReports.UI.XRLabel();
            this.xrpic = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lbldatesurvive = new DevExpress.XtraReports.UI.XRLabel();
            this.lblbloodtype = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.lblbloodtype,
            this.lbldatesurvive,
            this.lblname,
            this.xrpic,
            this.xrBarCode1,
            this.xrPictureBox1});
            this.ReportHeader.HeightF = 220F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblname
            // 
            this.lblname.BorderColor = System.Drawing.Color.Black;
            this.lblname.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F);
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.LocationFloat = new DevExpress.Utils.PointFloat(146.6666F, 90.83334F);
            this.lblname.Name = "lblname";
            this.lblname.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblname.SizeF = new System.Drawing.SizeF(180.3334F, 17.50005F);
            this.lblname.StylePriority.UseBorderColor = false;
            this.lblname.StylePriority.UseFont = false;
            this.lblname.StylePriority.UseForeColor = false;
            this.lblname.Text = "RHO DELTA";
            // 
            // xrpic
            // 
            this.xrpic.LocationFloat = new DevExpress.Utils.PointFloat(8.000005F, 90.83334F);
            this.xrpic.Name = "xrpic";
            this.xrpic.SizeF = new System.Drawing.SizeF(74.49999F, 78.83331F);
            this.xrpic.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.AutoModule = true;
            this.xrBarCode1.BackColor = System.Drawing.Color.White;
            this.xrBarCode1.ForeColor = System.Drawing.Color.Black;
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(285.0001F, 175F);
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrBarCode1.ShowText = false;
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(41.99994F, 41.50334F);
            this.xrBarCode1.StylePriority.UseBackColor = false;
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
            // lbldatesurvive
            // 
            this.lbldatesurvive.BorderColor = System.Drawing.Color.Black;
            this.lbldatesurvive.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F);
            this.lbldatesurvive.ForeColor = System.Drawing.Color.Black;
            this.lbldatesurvive.LocationFloat = new DevExpress.Utils.PointFloat(215.8334F, 123.3333F);
            this.lbldatesurvive.Name = "lbldatesurvive";
            this.lbldatesurvive.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbldatesurvive.SizeF = new System.Drawing.SizeF(111.1666F, 17.50004F);
            this.lbldatesurvive.StylePriority.UseBorderColor = false;
            this.lbldatesurvive.StylePriority.UseFont = false;
            this.lbldatesurvive.StylePriority.UseForeColor = false;
            this.lbldatesurvive.Text = "RHO DELTA";
            // 
            // lblbloodtype
            // 
            this.lblbloodtype.BorderColor = System.Drawing.Color.Black;
            this.lblbloodtype.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F);
            this.lblbloodtype.ForeColor = System.Drawing.Color.Black;
            this.lblbloodtype.LocationFloat = new DevExpress.Utils.PointFloat(196.6667F, 152.1666F);
            this.lblbloodtype.Name = "lblbloodtype";
            this.lblbloodtype.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblbloodtype.SizeF = new System.Drawing.SizeF(117.8333F, 17.50005F);
            this.lblbloodtype.StylePriority.UseBorderColor = false;
            this.lblbloodtype.StylePriority.UseFont = false;
            this.lblbloodtype.StylePriority.UseForeColor = false;
            this.lblbloodtype.Text = "RHO DELTA";
            // 
            // xrLabel3
            // 
            this.xrLabel3.BorderColor = System.Drawing.Color.Black;
            this.xrLabel3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F);
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(93.33334F, 90.83334F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(54.99999F, 17.50005F);
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.Text = "Name:";
            // 
            // xrLabel4
            // 
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F);
            this.xrLabel4.ForeColor = System.Drawing.Color.Black;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(93.33334F, 123.3333F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(122.5001F, 17.50004F);
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.Text = "Date Survived:";
            // 
            // xrLabel5
            // 
            this.xrLabel5.BorderColor = System.Drawing.Color.Black;
            this.xrLabel5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F);
            this.xrLabel5.ForeColor = System.Drawing.Color.Black;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(93.33334F, 152.1666F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(103.3334F, 17.50003F);
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.Text = "Blood Type:";
            // 
            // OMEGABETA
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
        public DevExpress.XtraReports.UI.XRLabel lblname;
        public DevExpress.XtraReports.UI.XRPictureBox xrpic;
        public DevExpress.XtraReports.UI.XRLabel xrLabel4;
        public DevExpress.XtraReports.UI.XRLabel xrLabel3;
        public DevExpress.XtraReports.UI.XRLabel lblbloodtype;
        public DevExpress.XtraReports.UI.XRLabel lbldatesurvive;
        public DevExpress.XtraReports.UI.XRLabel xrLabel5;
    }
}
