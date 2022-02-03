using DevExpress.XtraGrid.Views.Grid;
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
    public partial class ViewMeetingDetails : Form
    {
        public ViewMeetingDetails()
        {
            InitializeComponent();
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = (GridView)sender;
            string check = view.GetRowCellValue(e.RowHandle, "Status").ToString() ;
            if (check=="ABSENT")
            {
                //e.Appearance.Font = new System.Drawing.Font(e.Appearance.Font, FontStyle.Strikeout);
                e.Appearance.ForeColor = Color.Red;
                e.Appearance.BackColor = Color.LightYellow;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Reporting.MeetingAttendanceDetails xct = new Reporting.MeetingAttendanceDetails();
            xct.Landscape = false;

            //GetImageDevEx(xct.xrPictureBox1, "ChapterLogo", "ChapterCountryCode='" + txtchaptercountrycode.Text + "' " +
            //    "AND ChapterRegionCode='" + txtchapterregioncode.Text + "' " +
            //    "AND ChapterProvinceCode='" + txtchapterprovincecode.Text + "' " +
            //    "AND ChapterMunicipalityCode='" + txtchaptermunicipalitycode.Text + "' " +
            //    "AND ChapterZipCode='" + txtchapterzipcode.Text + "' " +
            //    "AND ChapterCode='" + txtchapterchaptercode.Text + "' ", "ChapterImageLogo");

            xct.xrid.Text = lblmeetingid.Text;
            xct.xrdate.Text = lblmeetingdate.Text;
            xct.xragenda.Text = lblagenda.Text;
            xct.xrdetails.Text = lblremarks.Text;
            xct.xrpresent.Text = lblpresent.Text;
            xct.xrabsent.Text = lblabsent.Text;
            xct.xrfunds.Text = lblfundscollected.Text;
           
            //xct.xrPictureBox1.SizeF = new SizeF(float.Parse(width), float.Parse(height));
            //xct.xrPictureBox2.SizeF = new SizeF(float.Parse(width), float.Parse(height));
            //xct.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            xct.PaperKind = System.Drawing.Printing.PaperKind.A4;

            xct.Bands[BandKind.Detail].Controls.Add(Classes.HelperFunction.CopyGridControl(gridControl1));
            xct.Bands[BandKind.Detail].Font = new System.Drawing.Font("Tahoma", 10);
            ReportPrintTool report = new ReportPrintTool(xct);
            report.ShowRibbonPreviewDialog();
        }

        private void ViewMeetingDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
