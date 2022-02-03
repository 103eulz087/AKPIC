using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDProject.ChapterForms
{
    public partial class ViewMembersLedger : Form
    {
        public ViewMembersLedger()
        {
            InitializeComponent();
        }

        private void ViewMembersLedger_Load(object sender, EventArgs e)
        {
             
        }
        

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
          
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Reporting.MembersLedger xct = new Reporting.MembersLedger();
            xct.Landscape = false;

            //GetImageDevEx(xct.xrPictureBox1, "ChapterLogo", "ChapterCountryCode='" + txtchaptercountrycode.Text + "' " +
            //    "AND ChapterRegionCode='" + txtchapterregioncode.Text + "' " +
            //    "AND ChapterProvinceCode='" + txtchapterprovincecode.Text + "' " +
            //    "AND ChapterMunicipalityCode='" + txtchaptermunicipalitycode.Text + "' " +
            //    "AND ChapterZipCode='" + txtchapterzipcode.Text + "' " +
            //    "AND ChapterCode='" + txtchapterchaptercode.Text + "' ", "ChapterImageLogo");

            xct.xrlblidno.Text = lblidno.Text;
            xct.xrlblmembername.Text = lblfullname.Text;
            xct.xrlbltotalfunds.Text = lblfundsamount.Text;
            //xct.xrPictureBox1.SizeF = new SizeF(float.Parse(width), float.Parse(height));
            //xct.xrPictureBox2.SizeF = new SizeF(float.Parse(width), float.Parse(height));
            xct.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            xct.PaperKind = System.Drawing.Printing.PaperKind.A4;

            xct.Bands[BandKind.Detail].Controls.Add(Classes.HelperFunction.CopyGridControl(gridControl1));
            xct.Bands[BandKind.Detail].Font = new System.Drawing.Font("Tahoma", 10);
            ReportPrintTool report = new ReportPrintTool(xct);
            report.ShowRibbonPreviewDialog();
        }
    }
}
