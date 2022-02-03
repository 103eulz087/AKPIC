namespace IDProject
{
    partial class XtraReport1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport1));
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lblname = new DevExpress.XtraReports.UI.XRLabel();
            this.lblchapter = new DevExpress.XtraReports.UI.XRLabel();
            this.lblprovince = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrmunicipality = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(213.875F, 337.2883F);
            // 
            // lblname
            // 
            this.lblname.BorderColor = System.Drawing.Color.Black;
            this.lblname.Font = new System.Drawing.Font("Arial", 7.25F, System.Drawing.FontStyle.Bold);
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.LocationFloat = new DevExpress.Utils.PointFloat(10.41667F, 226.25F);
            this.lblname.Name = "lblname";
            this.lblname.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblname.SizeF = new System.Drawing.SizeF(190.625F, 13.625F);
            this.lblname.StylePriority.UseBorderColor = false;
            this.lblname.StylePriority.UseFont = false;
            this.lblname.StylePriority.UseForeColor = false;
            this.lblname.Text = "Eulz Avancena";
            // 
            // lblchapter
            // 
            this.lblchapter.BorderColor = System.Drawing.Color.Black;
            this.lblchapter.Font = new System.Drawing.Font("Arial", 7.25F, System.Drawing.FontStyle.Bold);
            this.lblchapter.ForeColor = System.Drawing.Color.White;
            this.lblchapter.LocationFloat = new DevExpress.Utils.PointFloat(10.41667F, 239.8749F);
            this.lblchapter.Name = "lblchapter";
            this.lblchapter.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblchapter.SizeF = new System.Drawing.SizeF(190.625F, 13.625F);
            this.lblchapter.StylePriority.UseBorderColor = false;
            this.lblchapter.StylePriority.UseFont = false;
            this.lblchapter.StylePriority.UseForeColor = false;
            this.lblchapter.Text = "RHO DELTA";
            // 
            // lblprovince
            // 
            this.lblprovince.BackColor = System.Drawing.Color.Transparent;
            this.lblprovince.BorderColor = System.Drawing.Color.Black;
            this.lblprovince.Font = new System.Drawing.Font("Arial", 7.25F, System.Drawing.FontStyle.Bold);
            this.lblprovince.ForeColor = System.Drawing.Color.Red;
            this.lblprovince.LocationFloat = new DevExpress.Utils.PointFloat(10.41667F, 306.375F);
            this.lblprovince.Name = "lblprovince";
            this.lblprovince.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblprovince.SizeF = new System.Drawing.SizeF(190.625F, 13.625F);
            this.lblprovince.StylePriority.UseBackColor = false;
            this.lblprovince.StylePriority.UseBorderColor = false;
            this.lblprovince.StylePriority.UseFont = false;
            this.lblprovince.StylePriority.UseForeColor = false;
            this.lblprovince.Text = "Eulz Avancena";
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.AutoModule = true;
            this.xrBarCode1.BackColor = System.Drawing.Color.Transparent;
            this.xrBarCode1.ForeColor = System.Drawing.Color.Black;
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(123.4466F, 135.5783F);
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrBarCode1.ShowText = false;
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(80.55335F, 78.57838F);
            this.xrBarCode1.StylePriority.UseBackColor = false;
            this.xrBarCode1.StylePriority.UseForeColor = false;
            this.xrBarCode1.StylePriority.UsePadding = false;
            this.xrBarCode1.StylePriority.UseTextAlignment = false;
            this.xrBarCode1.Symbology = qrCodeGenerator1;
            this.xrBarCode1.Text = "636000000100001";
            this.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.xrPictureBox2.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox2.ImageSource"));
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(10.41667F, 124.1199F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(104.8634F, 102.13F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // ReportHeader
            // 
            this.ReportHeader.BackColor = System.Drawing.Color.Black;
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode1,
            this.lblname,
            this.lblchapter,
            this.xrPictureBox2,
            this.lblprovince,
            this.xrmunicipality,
            this.xrPictureBox1});
            this.ReportHeader.HeightF = 337.2884F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseBackColor = false;
            // 
            // xrmunicipality
            // 
            this.xrmunicipality.BorderColor = System.Drawing.Color.Black;
            this.xrmunicipality.Font = new System.Drawing.Font("Arial", 7.25F, System.Drawing.FontStyle.Bold);
            this.xrmunicipality.ForeColor = System.Drawing.Color.White;
            this.xrmunicipality.LocationFloat = new DevExpress.Utils.PointFloat(10.41667F, 253.4999F);
            this.xrmunicipality.Name = "xrmunicipality";
            this.xrmunicipality.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrmunicipality.SizeF = new System.Drawing.SizeF(190.625F, 13.62F);
            this.xrmunicipality.StylePriority.UseBorderColor = false;
            this.xrmunicipality.StylePriority.UseFont = false;
            this.xrmunicipality.StylePriority.UseForeColor = false;
            this.xrmunicipality.Text = "Cebu City";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DesignerOptions.ShowDesignerHints = false;
            this.DesignerOptions.ShowExportWarnings = false;
            this.DesignerOptions.ShowPrintingWarnings = false;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 337;
            this.PageWidth = 214;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Version = "19.2";
            this.Watermark.Font = new System.Drawing.Font("Verdana", 30F);
            this.Watermark.ForeColor = System.Drawing.Color.Crimson;
            this.Watermark.ShowBehind = false;
            this.Watermark.Text = "UNOFFICIAL";
            this.Watermark.TextDirection = DevExpress.XtraPrinting.Drawing.DirectionMode.BackwardDiagonal;
            this.Watermark.TextTransparency = 84;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        public DevExpress.XtraReports.UI.XRLabel lblname;
        public DevExpress.XtraReports.UI.XRLabel lblchapter;
        public DevExpress.XtraReports.UI.XRLabel lblprovince;
        public DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        public DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        public DevExpress.XtraReports.UI.XRLabel xrmunicipality;
    }
}
