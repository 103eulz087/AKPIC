using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraPrinting;
using System.Drawing.Imaging;

namespace IDProject
{
    public partial class TestForm : DevExpress.XtraEditors.XtraForm
    {
        public TestForm()
        {
            InitializeComponent();
        }

        void display()
        {
            //Database.display("SELECT * FROM dbo.SIAData ");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            previewChapterID();
            XtraMessageBox.Show("Successfully Updated");
        }
        void previewChapterID()
        {
            try
            {
                for (int i = 0; i <= gridView1.RowCount - 1; i++)
                {


                    string reportPath = "";

                    reportPath = "C:\\AKPExportChapterID\\SIA\\";
                    //reportPath = "C:\\AKPExportChapterID\\RHODELTA\\";
                    //reportPath = "C:\\AKPExportChapterID\\RHOGAMMA\\";
                    //reportPath = "C:\\AKPExportChapterID\\RHONU\\";
                    //reportPath = "C:\\AKPExportChapterID\\LAMBDAPHI\\";
                    //reportPath = "C:\\AKPExportChapterID\\LAMBDAOMEGA\\";
                    //reportPath = "C:\\AKPExportChapterID\\OMEGABETA\\";

                    string fname = gridView1.GetRowCellValue(i, "FirstName").ToString();
                    string idno = gridView1.GetRowCellValue(i, "ID").ToString();
                    string lname = gridView1.GetRowCellValue(i, "LastName").ToString().Replace(".", "");

                    createDirectoryFolder(reportPath);
                    //string imageFilename = fname + "_" + lname + "-F.png";
                    string imageFilename = idno + "-F.png";
                    string filetoprint = reportPath + imageFilename;


                    PictureBox pbox = new PictureBox();
                    byte[] img = null;
                    img = (byte[])gridView1.GetRowCellValue(i, "Photo");
                    MemoryStream ms = new MemoryStream(img);
                    ms.Seek(0, SeekOrigin.Begin);
                    pbox.Image = Image.FromStream(ms);

                    string id = gridView1.GetRowCellValue(i, "ID").ToString();
                    var rows = Database.getMultipleQuery("view_RetrieveMember2", $"ID='{id}'", "BDATE,CHAPTERNAME,MUNICIPALITY,PROVINCE,BLOODTYPE,DATESURVIVE,GiftName,GSName,MIName");
                    string BDATE = rows["BDATE"].ToString();
                    string CHAPTERNAME = rows["CHAPTERNAME"].ToString();
                    string MUNICIPALITY = rows["MUNICIPALITY"].ToString();
                    string BLOODTYPE = rows["BLOODTYPE"].ToString();
                    string DATESURVIVE = rows["DATESURVIVE"].ToString();
                    string GiftName = rows["GiftName"].ToString();
                    string PROVINCE = rows["PROVINCE"].ToString();
                    string GSName = rows["GSName"].ToString();
                    string MIName = rows["MIName"].ToString();

                    RHODELTA xct = new RHODELTA();
                    //RHONU xct = new RHONU();
                    //LAMBDAPHI xct = new LAMBDAPHI();
                    //LAMBDAOMEGA xct = new LAMBDAOMEGA();
                    //OMEGABETA xct = new OMEGABETA();

                    xct.lblname.Text = fname.Trim() + " " + " " + lname.Trim();//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "FirstName").ToString().ToUpper() + " " + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "LastName").ToString().ToUpper() ;
                    //xct.lblbloodtype.Text = BLOODTYPE;//txtchapter.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ChapterName").ToString();
                    xct.lbldatesurvive.Text = Convert.ToDateTime(DATESURVIVE).ToShortDateString();// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    xct.lblbirthdate.Text = Convert.ToDateTime(BDATE).ToShortDateString();// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    //xct.lblgiftname.Text = GiftName;// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    //xct.lblidno.Text = id;// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    //xct.xrmunicipality.Text = MUNICIPALITY;//txtchaptermunicipalites.Text; // gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MUNICIPALITY").ToString();
                    xct.xrBarCode1.Text = id;//"63600010600001";//txtid.Text; //gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
                    xct.lblgs.Text = GSName;//"63600010600001";//txtid.Text; //gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
                    xct.lblmasterinitiator.Text = MIName;//"63600010600001";//txtid.Text; //gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();


                    xct.xrpic.Image = (Bitmap)pbox.Image.Clone();


                    ImageExportOptions imageOptions = xct.ExportOptions.Image;
                    imageOptions.Format = ImageFormat.Png;
                    imageOptions.Resolution = 300;
                    // Export the report to Image.
                    xct.ExportToImage(filetoprint);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public void createDirectoryFolder(string filepath)
        {
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
        }
    }
}