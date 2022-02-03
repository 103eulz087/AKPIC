namespace IDProject.Reporting
{
    partial class MembersLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersLedger));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblidno = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblmembername = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbltotalfunds = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox2,
            this.xrPictureBox1});
            this.TopMargin.HeightF = 150F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Name = "Detail";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.ReportHeader.HeightF = 38.54167F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlbltotalfunds,
            this.xrLabel6,
            this.xrlblmembername,
            this.xrlblidno,
            this.xrLabel3,
            this.xrLabel2});
            this.PageHeader.HeightF = 86.45834F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleLeft;
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(150F, 150F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleLeft;
            this.xrPictureBox2.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox2.ImageSource"));
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(500F, 0F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(150F, 150F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(221.875F, 18.83334F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Members Transaction History";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 10.8F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(150F, 18.83334F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Member ID Number:";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 10.8F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 28.83336F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(122.9167F, 18.83334F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "Member Name:";
            // 
            // xrlblidno
            // 
            this.xrlblidno.Font = new System.Drawing.Font("Arial", 10.8F);
            this.xrlblidno.LocationFloat = new DevExpress.Utils.PointFloat(150F, 10.00001F);
            this.xrlblidno.Multiline = true;
            this.xrlblidno.Name = "xrlblidno";
            this.xrlblidno.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblidno.SizeF = new System.Drawing.SizeF(150F, 18.83334F);
            this.xrlblidno.StylePriority.UseFont = false;
            this.xrlblidno.Text = "Member ID Number:";
            // 
            // xrlblmembername
            // 
            this.xrlblmembername.Font = new System.Drawing.Font("Arial", 10.8F);
            this.xrlblmembername.LocationFloat = new DevExpress.Utils.PointFloat(150F, 28.83336F);
            this.xrlblmembername.Multiline = true;
            this.xrlblmembername.Name = "xrlblmembername";
            this.xrlblmembername.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblmembername.SizeF = new System.Drawing.SizeF(406.25F, 18.83334F);
            this.xrlblmembername.StylePriority.UseFont = false;
            this.xrlblmembername.Text = "Member Name:";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 10.8F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 47.66668F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(150F, 18.83334F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "Total Funds Given:";
            // 
            // xrlbltotalfunds
            // 
            this.xrlbltotalfunds.Font = new System.Drawing.Font("Arial", 10.8F);
            this.xrlbltotalfunds.LocationFloat = new DevExpress.Utils.PointFloat(150F, 47.66668F);
            this.xrlbltotalfunds.Multiline = true;
            this.xrlbltotalfunds.Name = "xrlbltotalfunds";
            this.xrlbltotalfunds.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbltotalfunds.SizeF = new System.Drawing.SizeF(406.25F, 18.83334F);
            this.xrlbltotalfunds.StylePriority.UseFont = false;
            this.xrlbltotalfunds.Text = "Member Name:";
            // 
            // MembersLedger
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 150, 100);
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        public DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        public DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        public DevExpress.XtraReports.UI.XRLabel xrlblmembername;
        public DevExpress.XtraReports.UI.XRLabel xrlblidno;
        public DevExpress.XtraReports.UI.XRLabel xrlbltotalfunds;
    }
}
