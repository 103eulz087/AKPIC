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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using System.IO;
using DevExpress.XtraGrid;
using System.Threading;
using DevExpress.XtraPrinting;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace IDProject
{
    public partial class PracticeForm : DevExpress.XtraEditors.XtraForm
    {
        struct DataParameter
        {
            public int Process;
            public int Delay;
        }

         
        object chaptercountrycode;
        object chapterregioncode;
        object chapterprovinceccode;
        object chaptermunicipalitycode;
        object chapterzipcode;
        object chapterid;
        public PracticeForm()
        {
            InitializeComponent();
        }

        private void PracticeForm_Load(object sender, EventArgs e)
        {
           
            populateCountry();
        }
        void populateCountry()
        {
            Database.displaySearchlookupEdit("SELECT COUNTRY_CODE,COUNTRY_NAME FROM Countries WHERE COUNTRY_CODE='63'", txtchaptercountries, "COUNTRY_NAME", "COUNTRY_NAME");
        }
        private void gridView2_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            int dx = 5;
            //Rectangle r = e.Bounds;
            //r.X += e.Bounds.Height + dx * 2;
            //r.Width -= (e.Bounds.Height + dx * 3);
            //e.Graphics.DrawImage(DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(
            //    (byte[])gridView1.GetDataRow(e.RowHandle)["PhotoImage"]), e.Bounds.X + dx,
            //    e.Bounds.Y, e.Bounds.Height, e.Bounds.Height);
            ////e.Appearance.DrawString(e.Cache, gridView1.GetRow(e.RowHandle), r);
            //e.Handled = true;

            //GridView currentView = sender as GridView;
            //if (e.RowHandle == currentView.FocusedRowHandle) return;
            //Rectangle r = e.Bounds;
            //if (e.Column.FieldName == "PhotoImage")
            //{

            //    r.X += e.Bounds.Height + dx * 2;
            //    r.Width -= (e.Bounds.Height + dx * 3);
            //    e.Graphics.DrawImage(DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(
            //        (byte[])gridView1.GetDataRow(e.RowHandle)["Photo"]), e.Bounds.X + dx,
            //        e.Bounds.Y, e.Bounds.Height, e.Bounds.Height);
            //    //e.Appearance.DrawString(e.Cache, gridView1.GetRow(e.RowHandle), r);
            //    e.Handled = true;
            //}
        }

        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            //if (e.Column.FieldName == "Photo")
            //    e.RepositoryItem = repositoryItemPictureEdit1;
        }
        public byte[] GetImageDevEx(XRPictureBox pictureBox1, string tableName, string condition, string ImageColName)
        {
            byte[] img = null;
            pictureBox1.Image = null;
            SqlConnection con = Database.getConnection();
            con.Open();
            try
            {
                string query = "select * FROM " + tableName + " WHERE " + condition + " ";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        if (reader[ImageColName] == System.DBNull.Value)
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            img = (byte[])reader[ImageColName];
                            MemoryStream ms = new MemoryStream(img);
                            ms.Seek(0, SeekOrigin.Begin);
                            pictureBox1.Image = Image.FromStream(ms);
                        }

                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return img;
        }
        public static WinControlContainer CopyGridControl(GridControl grid)
        {

            // Create a WinControlContainer object.
            WinControlContainer winContainer = new WinControlContainer();
            // Set its location and size.
            winContainer.Location = new Point(0, 0);
            winContainer.Size = new Size(200, 100);
            // Set the grid as a wrapped object.
            winContainer.WinControl = grid;
            return winContainer;
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string width = "150";
            string height = "150";
            XtraReport3 xct = new XtraReport3();
            xct.Landscape = false;

            GetImageDevEx(xct.xrPictureBox1, "ChapterLogo", "ChapterCountryCode='"+txtchaptercountrycode.Text+ "' " +
                "AND ChapterRegionCode='"+txtchapterregioncode.Text+ "' " +
                "AND ChapterProvinceCode='"+txtchapterprovincecode.Text+ "' " +
                "AND ChapterMunicipalityCode='"+txtchaptermunicipalitycode.Text+"' " +
                "AND ChapterZipCode='"+txtchapterzipcode.Text+ "' " +
                "AND ChapterCode='"+txtchapterchaptercode.Text+"' ", "ChapterImageLogo");

            xct.xrchaptername.Text = txtchapter.Text+" Chapter";
            xct.xrPictureBox1.SizeF = new SizeF(float.Parse(width), float.Parse(height));
            xct.xrPictureBox2.SizeF = new SizeF(float.Parse(width), float.Parse(height));
            xct.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            xct.PaperKind = System.Drawing.Printing.PaperKind.A4;

            xct.Bands[BandKind.Detail].Controls.Add(CopyGridControl(gridControl2));
            xct.Bands[BandKind.Detail].Font = new System.Drawing.Font("Tahoma", 10);
            ReportPrintTool report = new ReportPrintTool(xct);
            report.ShowRibbonPreviewDialog();
        }

        private void txtchaptercountries_EditValueChanged(object sender, EventArgs e)
        {
            chaptercountrycode = SearchLookUpClass.getSingleValue(txtchaptercountries, "COUNTRY_CODE"); //get country code in gridview
            txtchaptercountrycode.Text = chaptercountrycode.ToString(); //country code textbox
            Database.displaySearchlookupEdit("SELECT REGION_CODE,REGION_NAME,REGION_INSTANCE FROM Regions WHERE COUNTRY_CODE='" + txtchaptercountrycode.Text + "'", txtchapterregions, "REGION_NAME", "REGION_NAME");

        }
        private void txtchapterregions_EditValueChanged(object sender, EventArgs e)
        {
            chapterregioncode = SearchLookUpClass.getSingleValue(txtchapterregions, "REGION_CODE");
            txtchapterregioncode.Text = chapterregioncode.ToString();
            Database.displaySearchlookupEdit("SELECT PROVINCE_CODE,PROVINCE FROM Provinces WHERE REGION_CODE='" + txtchapterregioncode.Text + "'", txtchapterprovinces, "PROVINCE", "PROVINCE");

        }

        private void txtchapterprovinces_EditValueChanged(object sender, EventArgs e)
        {
            chapterprovinceccode = SearchLookUpClass.getSingleValue(txtchapterprovinces, "PROVINCE_CODE");
            txtchapterprovincecode.Text = chapterprovinceccode.ToString();

            Database.displaySearchlookupEdit("SELECT MUNICIPALITY_CODE,MUNICIPALITY,ZIPCODE FROM Municipalities WHERE PROVINCE_CODE='" + txtchapterprovincecode.Text + "' " +
                    "and REGION_CODE='" + txtchapterregioncode.Text + "' and COUNTRY_CODE='" + txtchaptercountrycode.Text + "'", txtchaptermunicipalites, "MUNICIPALITY", "MUNICIPALITY");

        }

        private void txtchaptermunicipalites_EditValueChanged(object sender, EventArgs e)
        {
            chapterzipcode = SearchLookUpClass.getSingleValue(txtchaptermunicipalites, "ZIPCODE");
            chaptermunicipalitycode = SearchLookUpClass.getSingleValue(txtchaptermunicipalites, "MUNICIPALITY_CODE");
            txtchaptermunicipalitycode.Text = chaptermunicipalitycode.ToString();
            txtchapterzipcode.Text = chapterzipcode.ToString();

            Database.displaySearchlookupEdit("SELECT ChapterID,ChapterName FROM Chapters ", txtchapter, "ChapterName", "ChapterName");

        }

        private void txtchapter_EditValueChanged(object sender, EventArgs e)
        {
            chapterid = SearchLookUpClass.getSingleValue(txtchapter, "ChapterID");
            txtchapterchaptercode.Text = chapterid.ToString();
        }

        void extractList(bool ischapter)
        {
            progressBarControl1.Position = 0;
            if (!chckisByGroup.Checked) //WLA GI CHECKAN ANG ISGROUP
            {
                if (String.IsNullOrEmpty(txtchapterchaptercode.Text) && String.IsNullOrEmpty(txtchaptermunicipalitycode.Text) && String.IsNullOrEmpty(txtchapterzipcode.Text))
                {
                    if (ischapter == false)
                    {


                        Database.display("SELECT Photo,ID,FirstName,LastName,BloodType,MobileNo,DateSurvive,ChapterCountryCode,ChapterRegionCode,ChapterProvinceCode " +
                           "FROM view_Masterlist WHERE ChapterCountryCode='" + txtchaptercountrycode.Text + "' AND ChapterRegionCode='" + txtchapterregioncode.Text + "' " +
                           "AND ChapterProvinceCode='" + txtchapterprovincecode.Text + "'  ORDER BY RIGHT(ID,5) ASC", gridControl2, gridView1);
                        gridView1.Columns["ChapterCountryCode"].Visible = false;
                        gridView1.Columns["ChapterRegionCode"].Visible = false;
                        gridView1.Columns["ChapterProvinceCode"].Visible = false;
                    }
                    else
                    {
                        Database.display("SELECT Photo,ID,FirstName,LastName,BloodType,MobileNo,DateSurvive,ChapterCountryCode,ChapterRegionCode,ChapterProvinceCode " +
                           "FROM view_Masterlist WHERE ChapterCountryCode='" + txtchaptercountrycode.Text + "' AND ChapterRegionCode='" + txtchapterregioncode.Text + "' " +
                           "AND isChapterID='"+ischapter+"' AND ChapterProvinceCode='" + txtchapterprovincecode.Text + "'  ORDER BY RIGHT(ID,5) ASC", gridControl2, gridView1);
                        gridView1.Columns["ChapterCountryCode"].Visible = false;
                        gridView1.Columns["ChapterRegionCode"].Visible = false;
                        gridView1.Columns["ChapterProvinceCode"].Visible = false;
                    }
                }
                else if (!String.IsNullOrEmpty(txtchaptermunicipalitycode.Text) && String.IsNullOrEmpty(txtchapterchaptercode.Text) && !String.IsNullOrEmpty(txtchapterzipcode.Text))
                {
                    if (ischapter == false)
                    {
                        Database.display("SELECT Photo,ID,FirstName,LastName,BloodType,MobileNo,DateSurvive,ChapterCountryCode,ChapterRegionCode,ChapterProvinceCode " +
                       "FROM view_Masterlist WHERE ChapterCountryCode='" + txtchaptercountrycode.Text + "' " +
                       "AND ChapterRegionCode='" + txtchapterregioncode.Text + "' " +
                       "AND ChapterProvinceCode='" + txtchapterprovincecode.Text + "' " +
                       "AND ChapterMunicipalityCode='" + txtchaptermunicipalitycode.Text + "'  ORDER BY RIGHT(ID,5) ASC", gridControl2, gridView1);
                        gridView1.Columns["ChapterCountryCode"].Visible = false;
                        gridView1.Columns["ChapterRegionCode"].Visible = false;
                        gridView1.Columns["ChapterProvinceCode"].Visible = false;
                    }
                    else
                    {
                        Database.display("SELECT Photo,ID,FirstName,LastName,BloodType,MobileNo,DateSurvive,ChapterCountryCode,ChapterRegionCode,ChapterProvinceCode " +
                      "FROM view_Masterlist WHERE ChapterCountryCode='" + txtchaptercountrycode.Text + "' " +
                      "AND ChapterRegionCode='" + txtchapterregioncode.Text + "' " +
                      "AND ChapterProvinceCode='" + txtchapterprovincecode.Text + "' " +
                      "AND isChapterID='" + ischapter + "' " +
                      "AND ChapterMunicipalityCode='" + txtchaptermunicipalitycode.Text + "'  ORDER BY RIGHT(ID,5) ASC", gridControl2, gridView1);
                        gridView1.Columns["ChapterCountryCode"].Visible = false;
                        gridView1.Columns["ChapterRegionCode"].Visible = false;
                        gridView1.Columns["ChapterProvinceCode"].Visible = false;
                    }
                }
                else
                {
                    string id = txtchaptercountrycode.Text + txtchapterzipcode.Text + chapterid.ToString();
                    if (ischapter == false)
                    {
                        Database.display("SELECT Photo,ID,FirstName,LastName,BloodType,MobileNo,DateSurvive " +
                        "FROM view_Masterlist WHERE ID like '" + id + "%' ORDER BY RIGHT(ID,5) ASC", gridControl2, gridView1);
                    }
                    else
                    {
                        Database.display("SELECT Photo,ID,FirstName,LastName,BloodType,MobileNo,DateSurvive,GiftName " +
                       "FROM view_Masterlist WHERE isChapterID='" + ischapter + "' AND ID like '" + id + "%' ORDER BY RIGHT(ID,5) ASC", gridControl2, gridView1);
                    }
                }
            }
            else //GI CHECKAN ANG IS GROUP
            {
                Database.display("SELECT Photo,ID,FirstName,LastName,BloodType,MobileNo,DateSurvive,ChapterCountryCode,ChapterRegionCode,ChapterProvinceCode " +
                      "FROM view_Masterlist WHERE Groups like '%"+txtgroupname.Text+"%'  ORDER BY RIGHT(ID,5) ASC", gridControl2, gridView1);
                gridView1.Columns["ChapterCountryCode"].Visible = false;
                gridView1.Columns["ChapterRegionCode"].Visible = false;
                gridView1.Columns["ChapterProvinceCode"].Visible = false;
            }
            //Database.display("SELECT * FROM view_Masterlist", gridControl2, gridView1);
            gridView1.Columns["Photo"].OptionsColumn.FixedWidth = true;
            gridView1.Columns["Photo"].Width = 100;
            gridView1.RowHeight = 100;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            extractList(chckischapterid.Checked);
            //if (!backgroundWorker1.IsBusy)
            //{
            //    _inputParameter.Delay = 100;
            //    _inputParameter.Process = 1200;
            //    backgroundWorker1.RunWorkerAsync(_inputParameter);
            //}
            //Utilities.ClearFields(groupBox1);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParameter)e.Argument).Process;
            int delay = ((DataParameter)e.Argument).Delay;
            int index = 1;
            try
            {
                //extractList();
                for (int i = 0; i < process; i++)
                {
                    if (!backgroundWorker1.CancellationPending)
                    {

                        backgroundWorker1.ReportProgress(index++ * 100 / process, String.Format("Process data {0}", i));


                        Thread.Sleep(delay);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker1.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarControl1.EditValue = e.ProgressPercentage;
            progressBarControl1.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            XtraMessageBox.Show("Process has been Completed!");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            preview();
            XtraMessageBox.Show("Successfully Updated");
        }
        public Image stringToImage(string inputString)
        {
            string text = inputString.Trim();

            Bitmap bmp = new Bitmap(1, 1);

            //Set the font style of output image
            Font font = new Font("Free 3 of 9", 25, FontStyle.Regular, GraphicsUnit.Pixel);
            Font font2 = new Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel);

            Graphics graphics = Graphics.FromImage(bmp);

            int width = (int)graphics.MeasureString(text, font).Width;
            int height = (int)graphics.MeasureString(text, font).Height;

            int height2 = (int)graphics.MeasureString(text, font2).Height;

            bmp = new Bitmap(bmp, new Size(width, height + height2));
            graphics = Graphics.FromImage(bmp);



            //Specify the background color of the image
            graphics.Clear(Color.Cyan);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;



            //Specify the text, font, Text Color, X position and Y position of the image
            graphics.DrawString(text, font, new SolidBrush(Color.Black), 0, 0);
            graphics.DrawString(text, font2, new SolidBrush(Color.Black), 0, height);

            graphics.Flush();
            graphics.Dispose();

            //if you want to save the image  uncomment the below line.
            //bmp.Save(@"d:\myimage.jpg", ImageFormat.Jpeg);

            return bmp;
        }
        void preview()
        {
            try
            {
                for (int i = 0; i <= gridView1.RowCount - 1; i++)
                {
                     

                    string reportPath = "";

                    reportPath = "C:\\AKPExportImagesMasterList\\";

                    string fname = gridView1.GetRowCellValue(i, "FirstName").ToString();
                    string lname = gridView1.GetRowCellValue(i, "LastName").ToString().Replace(".","");

                    createDirectoryFolder(reportPath);
                    string imageFilename = fname + "_" + lname + "-F.png";
                    string filetoprint = reportPath + imageFilename;


                    PictureBox pbox = new PictureBox();
                    byte[] img = null;
                    img = (byte[])gridView1.GetRowCellValue(i, "Photo");
                    MemoryStream ms = new MemoryStream(img);
                    ms.Seek(0, SeekOrigin.Begin);
                    pbox.Image = Image.FromStream(ms);

                    string id=gridView1.GetRowCellValue(i, "ID").ToString();
                    var rows = Database.getMultipleQuery("view_RetrieveMember2", $"ID='{id}'", "CHAPTERNAME,MUNICIPALITY,PROVINCE");
                    string CHAPTERNAME = rows["CHAPTERNAME"].ToString();
                    string MUNICIPALITY = rows["MUNICIPALITY"].ToString();
                    string PROVINCE = rows["PROVINCE"].ToString();

                    XtraReport1 xct = new XtraReport1();

                    xct.lblname.Text = fname.Trim() + " " + " " + lname.Trim();//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "FirstName").ToString().ToUpper() + " " + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "LastName").ToString().ToUpper() ;
                    xct.lblchapter.Text = CHAPTERNAME;//txtchapter.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ChapterName").ToString();
                    xct.lblprovince.Text = PROVINCE;// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    xct.xrmunicipality.Text = MUNICIPALITY;//txtchaptermunicipalites.Text; // gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MUNICIPALITY").ToString();
                    xct.xrBarCode1.Text = "1234567890";//txtid.Text; //gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
                                                   
                    xct.xrPictureBox2.Image = (Bitmap)pbox.Image.Clone();


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
        void previewChapterID()
        {
            try
            {
                for (int i = 0; i <= gridView1.RowCount - 1; i++)
                {
                     

                    string reportPath = "";

                    reportPath = "C:\\AKPExportChapterID\\BETANU\\";
                    //reportPath = "C:\\AKPExportChapterID\\RHODELTA\\";
                    //reportPath = "C:\\AKPExportChapterID\\RHOGAMMA\\";
                    //reportPath = "C:\\AKPExportChapterID\\RHONU\\";
                    //reportPath = "C:\\AKPExportChapterID\\LAMBDAPHI\\";
                    //reportPath = "C:\\AKPExportChapterID\\LAMBDAOMEGA\\";
                    //reportPath = "C:\\AKPExportChapterID\\OMEGABETA\\";

                    string fname = gridView1.GetRowCellValue(i, "FirstName").ToString();
                    string idno = gridView1.GetRowCellValue(i, "ID").ToString();
                    string lname = gridView1.GetRowCellValue(i, "LastName").ToString().Replace(".","");

                    createDirectoryFolder(reportPath);
                    //string imageFilename = fname + "_" + lname + "-F.png";
                    string imageFilename = idno+"-F.png";
                    string imageFilenameBack = idno+"-B.png";
                    string filetoprint = reportPath + imageFilename;
                    string filetoprintBack = reportPath + imageFilenameBack;


                    PictureBox pbox = new PictureBox();
                    byte[] img = null;
                    img = (byte[])gridView1.GetRowCellValue(i, "Photo");
                    MemoryStream ms = new MemoryStream(img);
                    ms.Seek(0, SeekOrigin.Begin);
                    pbox.Image = Image.FromStream(ms);

                    string id=gridView1.GetRowCellValue(i, "ID").ToString();
                    var rows = Database.getMultipleQuery("view_RetrieveMember2", $"ID='{id}'", "BDATE,CHAPTERNAME,MUNICIPALITY,PROVINCE,BLOODTYPE,DATESURVIVE,GiftName,GSName,MIName,Position,ContactPersonFullName,ContactPersonMobileNo,ContactPersonAddress");
                    string BDATE = rows["BDATE"].ToString();
                    string CHAPTERNAME = rows["CHAPTERNAME"].ToString();
                    string MUNICIPALITY = rows["MUNICIPALITY"].ToString();
                    string BLOODTYPE = rows["BLOODTYPE"].ToString();
                    string DATESURVIVE = rows["DATESURVIVE"].ToString();
                    string GiftName = rows["GiftName"].ToString();
                    string PROVINCE = rows["PROVINCE"].ToString();
                    string GSName = rows["GSName"].ToString();
                    string MIName = rows["MIName"].ToString();  
                    string POSITION = rows["Position"].ToString();
                    string ContactPersonFullName = rows["ContactPersonFullName"].ToString();
                    string ContactPersonMobileNo = rows["ContactPersonMobileNo"].ToString();
                    string ContactPersonAddress = rows["ContactPersonAddress"].ToString();

                     BETANU xct = new BETANU();
                     
                    //RHODELTA xct = new RHODELTA();
                    //RHONU xct = new RHONU();
                    //LAMBDAPHI xct = new LAMBDAPHI();
                    //LAMBDAOMEGA xct = new LAMBDAOMEGA();
                    //OMEGABETA xct = new OMEGABETA();

                    xct.lblname.Text = fname.Trim() + " " + " " + lname.Trim();//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "FirstName").ToString().ToUpper() + " " + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "LastName").ToString().ToUpper() ;
                    //xct.lblbloodtype.Text = BLOODTYPE;//txtchapter.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ChapterName").ToString();
                    xct.lbldatesurvive.Text = Convert.ToDateTime(DATESURVIVE).ToShortDateString();// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    //xct.lblbirthdate.Text = Convert.ToDateTime(BDATE).ToShortDateString();// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    xct.lblgiftname.Text = GiftName;// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    //xct.lblidno.Text = id;// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    xct.lblid.Text = id;// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    //xct.xrmunicipality.Text = MUNICIPALITY;//txtchaptermunicipalites.Text; // gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MUNICIPALITY").ToString();
                    xct.xrBarCode1.Text = id;//"63600010600001";//txtid.Text; //gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
                    //xct.lblgs.Text = GSName.ToUpper();//"63600010600001";//txtid.Text; //gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
                    //xct.lblmasterinitiator.Text = MIName.ToUpper();//"63600010600001";//txtid.Text; //gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
                    xct.lblposition.Text = POSITION;

                   

                    //xct.lblgs.TextFitMode = TextFitMode.ShrinkAndGrow;
                    //xct.lblmasterinitiator.TextFitMode = TextFitMode.ShrinkAndGrow;
                    //xct.lblname.TextFitMode = TextFitMode.ShrinkAndGrow;

                    xct.xrpic.Image = (Bitmap)pbox.Image.Clone();


                    //BACK
                    BETANU_BACK xctB = new BETANU_BACK();
                    xctB.xrlabelcontactperson.Text = ContactPersonFullName;
                    xctB.xrcontactpersonadd.Text = ContactPersonAddress;
                    xctB.xrcontactmobno.Text = ContactPersonMobileNo; 
                    xctB.ExportToImage(filetoprintBack);

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

        private void chckisByGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (chckisByGroup.Checked == true)
                txtgroupname.Enabled = true;
            else
                txtgroupname.Enabled = false;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            previewChapterID();
            XtraMessageBox.Show("Successfully Updated");
        }
    }
}