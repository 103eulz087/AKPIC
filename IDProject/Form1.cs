using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDProject
{
    public partial class Form1 : Form
    {
        string action = "";
        //static string constring = "Data Source=127.0.0.1;Initial Catalog=QRDB2;User ID=sa;Password=123456;";
        int ctrupdate1 = 0, ctrupdate2 = 0, ctrupdate3 = 0, ctrupdate4 = 0,ctrupdate5=0; 
        private byte[] imagedata;
        VideoCaptureDevice videoSource;
        FilterInfoCollection videoDevices;
        ResizeNearestNeighbor size = new ResizeNearestNeighbor(100, 100);
        Bitmap imagepic, imagesig;
        string photofilename,sigfilename;
        byte[] mySigbyte;
        byte[] myPicbyte;
        public static object countrycode, regioncode, provinceccode,municipalitycode,zipcode,chapterid;
        public static object chaptercountrycode, chapterregioncode, chapterprovinceccode, chaptermunicipalitycode, chapterzipcode;
        bool ispaid=false, withform=false,isprinted=false,isdeducted=false;
        string globaloldid="";
        bool isIC = false;
        PictureBox pbox,sbox;

        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool functionReturnValue = false;
            
            if (keyData == (Keys.X | Keys.Control)) //FOCUS TO SKU TEXTFIELD
            {
                //textEdit3.Focus();
                simpleButton2.Enabled = true;
            }
            
            return functionReturnValue;
        }


        private void updateImageData(Image image)
        {
            using (var stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Jpeg);
                imagedata = stream.ToArray();
            }
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public byte[] ImageData
        {
            get { return imagedata; }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //cameraControl1.Stop();
            Application.Exit();
            //this.Dispose();
        }

        void preview(string id)
        {
            try
            {
                string str = id;
                string reportPath = "C:\\ImageFile\\PHOTOS\\";

                createDirectoryFolder(reportPath);
                string imageFilename = id+".jpg";
                string filetoprint = reportPath + imageFilename;
                IDPIC xct = new IDPIC();

                xct.xrPictureBox2.Image = (Bitmap)picimage.Image.Clone();
                ImageExportOptions imageOptions = xct.ExportOptions.Image;
                imageOptions.Format = ImageFormat.Jpeg;
                imageOptions.Resolution = 300;
                // Export the report to Image.
                xct.ExportToImage(filetoprint);

                // Show the result.
                //StartProcess(filetoprint);
                MessageBox.Show("Successfully Save to Image File");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        void exportimage()
        {
            try
            {
               
                string reportPath = "C:\\AKPPHOTOS\\";
                createDirectoryFolder(reportPath);
              
                string imageFilename = txtid.Text+".jpg";
                string filetoprint = reportPath + imageFilename;
                IDPIC xct = new IDPIC();

                xct.xrPictureBox2.Image = (Bitmap)picimage.Image.Clone();

                //xct.xrname.Text = txtfname.Text + " " + txtlname.Text;
                //xct.xrbirthdate.Text = txtbdate.Text;
                //xct.xrchapter.Text = comboBox2.Text;
                //xct.xrdatesurvived.Text = txtdatesurvive.Text;
                //xct.xrPictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
                //xct.xrBarCode1.Text = txtid.Text;

                ImageExportOptions imageOptions = xct.ExportOptions.Image;
                imageOptions.Format = ImageFormat.Jpeg;
                imageOptions.Resolution = 300;
                // Export the report to Image.
                xct.ExportToImage(filetoprint);

                // Show the result.
                //StartProcess(filetoprint);
                MessageBox.Show("Successfully Save to Image File");
                //xct.xrBarCode3.Text = txtregion.Text + txtchapter.Text + txtid.Text;
                //xct.xrBarCode2.Text = txtregion.Text + txtchapter.Text + txtid.Text;

                //ReportPrintTool report = new ReportPrintTool(xct);

                //report.ShowRibbonPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        void exportimage(string id)
        {
            try
            {
               
                string reportPath = "C:\\AKPPHOTOS\\";
                createDirectoryFolder(reportPath);
              
                string imageFilename = id + ".jpg";
                string filetoprint = reportPath + imageFilename;
                IDPIC xct = new IDPIC();
                xct.xrPictureBox2.Image = (Bitmap)pbox.Image.Clone();
                ImageExportOptions imageOptions = xct.ExportOptions.Image;
                imageOptions.Format = ImageFormat.Jpeg;
                imageOptions.Resolution = 300; 
                xct.ExportToImage(filetoprint);
                //MessageBox.Show("Successfully Save to Image File");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        void exportimageSig(string id)
        {
            try
            {

                string reportPath = "C:\\AKPSIGNATURES\\";
                createDirectoryFolder(reportPath);

                string imageFilename = id + ".jpg";
                string filetoprint = reportPath + imageFilename;
                
                if (sbox.Image != null)
                {
                    IDPIC xct = new IDPIC();
                    xct.xrPictureBox2.Image = (Bitmap)sbox.Image.Clone();
                    ImageExportOptions imageOptions = xct.ExportOptions.Image;
                    imageOptions.Format = ImageFormat.Jpeg;
                    imageOptions.Resolution = 300;
                    xct.ExportToImage(filetoprint);
                }
                //MessageBox.Show("Successfully Save to Image File");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        void execute(int ctr) //1 for ADD 2 UPDATE
        {
            

            //SqlConnection con = new SqlConnection(constring);
            SqlConnection con = Database.getConnection();
            con.Open();
            try
            {
                string query = "sp_insertidbasicinfo";
                //string query = "INSERT INTO Members VALUES('" + txtid.Text + "','" + txtfname.Text + "','" + txtmname.Text + "','" + txtlname.Text + "','" + txtaddress.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + txtbdate.Text + "','" + txtdateissued.Text + "','" + txtdateexpired.Text + "','" + myPicbyte + "','" + mySigbyte + "')";
                SqlCommand com = new SqlCommand(query, con);
                com.CommandType = CommandType.StoredProcedure;
                //com.Parameters.AddWithValue("@parmseqno", Convert.ToInt32(txtrollno.Text));
                com.Parameters.AddWithValue("@parmseqno", txtrollno.Text);
                com.Parameters.AddWithValue("@parmoldid", globaloldid);
                com.Parameters.AddWithValue("@parmid", txtid.Text);
                com.Parameters.AddWithValue("@parmfname", txtfname.Text);
                com.Parameters.AddWithValue("@parmmname", txtmname.Text);
                com.Parameters.AddWithValue("@parmlname", txtlname.Text);
                com.Parameters.AddWithValue("@parmaddress", txtaddress.Text);
                 
                com.Parameters.AddWithValue("@parmbdate", txtbdate.Text);
                
                com.Parameters.AddWithValue("@parmmobileno", txtmobileno.Text);
              
                com.Parameters.AddWithValue("@parmbloodtype", txtbloodtype.Text);
                com.Parameters.AddWithValue("@parmcontactpersonfullname", txtcontactpersonfullname.Text);
                com.Parameters.AddWithValue("@parmcontactpersonaddress", txtcontactpersonaddress.Text);
                com.Parameters.AddWithValue("@parmcontactpersonmobileno", txtcontactpersonmobileno.Text);
 
                com.Parameters.AddWithValue("@parmchaptercode", txtchapterchaptercode.Text);
                com.Parameters.AddWithValue("@parmchaptercountrycode", txtchaptercountrycode.Text);
                com.Parameters.AddWithValue("@parmchapterregioncode", txtchapterregioncode.Text);
                com.Parameters.AddWithValue("@parmchapterprovincecode", txtchapterprovincecode.Text);
                com.Parameters.AddWithValue("@parmchaptermunicipalitycode", txtchaptermunicipalitycode.Text);
                com.Parameters.AddWithValue("@parmchapterzipcode", txtchapterzipcode.Text);
                com.Parameters.AddWithValue("@parmdatesurvive", txtdatesurvived.Text);
                com.Parameters.AddWithValue("@parmgiftname", txtgiftname.Text);

                //com.Parameters.AddWithValue("@parmmasterinitiator", txtmasterinitiator.Text);
                //com.Parameters.AddWithValue("@parmchapterwelcomed", txtchapterwelcomed.Text);
                //com.Parameters.AddWithValue("@parmchapterdatewelcomed", txtdatewelcomed.Text);
                //com.Parameters.AddWithValue("@parmmobileserialkey", txtmobileserialkey.Text);
                com.Parameters.AddWithValue("@parmposition", txtposition.Text);

                //com.Parameters.AddWithValue("@parmgodparent", txtgodparent.Text);
                //com.Parameters.AddWithValue("@parmgsduringsurvive", txtgsduringsurvive.Text);
                com.Parameters.AddWithValue("@parmdateissued", DateTime.Now.ToShortDateString());
                com.Parameters.AddWithValue("@parmdateexpired", DateTime.Now.AddYears(1).ToShortDateString());
                com.Parameters.AddWithValue("@parmrfid", "");
                com.Parameters.AddWithValue("@parmispaid", ispaid);
                com.Parameters.AddWithValue("@parmwithform", withform);
                com.Parameters.AddWithValue("@parmisdeducted", isdeducted);
                com.Parameters.AddWithValue("@parmisprinted", isprinted);
                com.Parameters.AddWithValue("@parmaction", ctr);
                com.Parameters.AddWithValue("@parmuser", UserLogin.id);
                com.Parameters.AddWithValue("@parmagent", UserLogin.id);
                com.Parameters.AddWithValue("@parmisIC", chckisic.Checked);
                com.Parameters.AddWithValue("@parmcouncilname", txtcouncilname.Text);
                com.Parameters.AddWithValue("@parmactivecountry", txtactivecountry.Text);
                com.Parameters.AddWithValue("@parmgroups", txtgroups.Text);
                com.Parameters.AddWithValue("@parmreferredby", txtreferredby.Text);
                com.Parameters.AddWithValue("@parmischapterid", chckchapterid.Checked);
                com.Parameters.AddWithValue("@parmismunid", chckmunid.Checked);
                com.Parameters.AddWithValue("@parmisprovid", chckprovid.Checked);
                com.Parameters.AddWithValue("@parmisregid", chckregid.Checked);
                com.Parameters.AddWithValue("@parmisnatlid", chcknatlid.Checked); 
                com.Parameters.AddWithValue("@parmgsname", txtgs.Text); 
                com.Parameters.AddWithValue("@parmminame", txtmasterinitiator.Text); 
                if (picimage.Image != null)
                {
                    MemoryStream ms11 = new MemoryStream();
                    picimage.Image.Save(ms11, ImageFormat.Jpeg);
                    myPicbyte = new byte[ms11.Length];
                    ms11.Position = 0;
                    ms11.Read(myPicbyte, 0, myPicbyte.Length);
                    com.Parameters.AddWithValue("@photo", myPicbyte);
                }
                if (sigimage.Image != null)
                {
                    MemoryStream ms12 = new MemoryStream();
                    sigimage.Image.Save(ms12, ImageFormat.Jpeg);
                    mySigbyte = new byte[ms12.Length];
                    ms12.Position = 0;
                    ms12.Read(mySigbyte, 0, mySigbyte.Length);
                    com.Parameters.AddWithValue("@sig", mySigbyte);
                }
                //if (picsig.Image != null)
                //{
                //    MemoryStream ms12 = new MemoryStream();
                //    picsig.Image.Save(ms12, ImageFormat.Png);
                //    mySigbyte = new byte[ms12.Length];
                //    ms12.Position = 0;
                //    ms12.Read(mySigbyte, 0, mySigbyte.Length);
                //    com.Parameters.AddWithValue("@sig", mySigbyte);
                //}
                com.CommandText = query;
                com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            //preview(txtid.Text);
            exportimage();
            //clear();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            if ( String.IsNullOrEmpty(txtchaptercountries.Text) || String.IsNullOrEmpty(txtchapterregions.Text) || String.IsNullOrEmpty(txtchapterprovinces.Text) || String.IsNullOrEmpty(txtchaptermunicipalites.Text) || String.IsNullOrEmpty(txtchapter.Text))
            {
                XtraMessageBox.Show("Some fields are empty, please filled out all the fields.");
                return;
            }
            else if(String.IsNullOrEmpty(txtgroups.Text) && chckchapterid.Checked==true)
            {
                XtraMessageBox.Show("Groups must not Empty");
                return;
            }
            else
            {
                execute(1);
                preview();
                preview2();
                Utilities.ClearFields(panel1);
                //Utilities.ClearFields(panelMembershipInfo);
                Utilities.ClearFields(groupBox2);
                Utilities.ClearFields(groupBox3);
                txtid.Text = "";
                txtrollno.Text = "";
                txtgroups.Text = "";
                txtreferredby.Text = "";
                chcknatlid.Checked = true;

                //exportDatabase();
            }
            
        }

        void clear()
        {
            txtaddress.Text = "";
            txtbdate.Text = "";
            txtchapter.Text = "";
            //txtcountry.Text = "";
            //txtcountry.Text = "";
         
            //txtdatesurvive.Text = "";
            txtfname.Text = "";
            txtid.Text = "";
            txtlname.Text = "";
            txtmname.Text = "";
            //txtregioncode.Text = "";
         
            txtrollno.Text = "";
            //txtregion.Text = "";
            txtchapter.Text = "";
         
            //comboBox3.Text = "";
            picimage.Image = null;
            sigimage.Image = null;
            //picsig.Image = null;
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FormRetrieve formretrieve = new FormRetrieve();
            formretrieve.Show();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            //Database.displayComboBoxItems("SELECT * FROM Regions", "Municipality", txtreg);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtregioncode.Text = Database.getSingleQuery("Regions", "Municipality='" + txtregionname.Text + "'", "RegionCode");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //picsig.Image = (Bitmap)pictureBox1.Image.Clone();
            //imagesig = (Bitmap)pictureBox1.Image.Clone();
            //sigfilename = txtid.Text + "_sig" + ".png";
            //imagesig.Save(sigfilename);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            Database.displaySearchlookupEdit("SELECT ChapterID,ChapterName FROM Chapters", txtchapter, "ChapterName", "ChapterName"); //populate chapter name
            if(UserLogin.userid != "eulz")
            {
                fileToolStripMenuItem.Visible = false;
            }
            populateCountry();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            //if (videoSource.IsRunning)
            //{
            //    videoSource.Stop();
            //    pictureBox1.Image = null;
            //    pictureBox1.Invalidate();
            //}
            //else
            //{
            //    videoSource = new VideoCaptureDevice(videoDevices[comboBox3.SelectedIndex].MonikerString);
            //    videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            //    videoSource.Start();
            //}
        }

        void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            //pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        public void createDirectoryFolder(string filepath)
        {
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                string reportPath = "C:\\ImageFile\\";
                string imageFilename = txtfname.Text+txtid.Text+".png";
                string filetoprint = reportPath + imageFilename;
                
                IDPrinting xct = new IDPrinting();
                xct.Landscape = false;
                //xct.PaperKind = System.Drawing.Printing.PaperKind.A4;
                //xct.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 100);
                xct.xrname.Text = txtfname.Text + " " + txtlname.Text;
                xct.xrbirthdate.Text = txtbdate.Text;
                xct.xrchapter.Text = txtchapter.Text;
                //xct.xrdatesurvived.Text = txtdatesurvive.Text;
                //xct.xrsignature.Image = (Bitmap)pictureBox1.Image.Clone();

                // xct.xrPictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();

                //xct.xrLabel2.Text = txtid.Text;
                //xct.xrPictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
                // xct.xrPictureBox3.Image = (Bitmap)pictureBox5.Image.Clone();
                xct.xrBarCode1.Text = txtid.Text;

                ImageExportOptions imageOptions = xct.ExportOptions.Image;
                imageOptions.Format = ImageFormat.Png;
                imageOptions.Resolution = 300;
                // Export the report to Image.

                createDirectoryFolder(reportPath);
                xct.ExportToImage(filetoprint);

                // Show the result.
                StartProcess(filetoprint);
                MessageBox.Show("Successfully Save to Image File");
                //xct.xrBarCode3.Text = txtregion.Text + txtchapter.Text + txtid.Text;
                //xct.xrBarCode2.Text = txtregion.Text + txtchapter.Text + txtid.Text;

                //ReportPrintTool report = new ReportPrintTool(xct);

                //report.ShowRibbonPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void StartProcess(string path)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = path;
                process.Start();
                process.WaitForInputIdle();
            }
            catch { }
        }

        private void txtcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtcountrycode.Text = Database.getSingleQuery("Countries", "CountryName='" + txtcountry.Text + "'", "CountryCode");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void retrieveMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetrieveMember retmem = new RetrieveMember();
            retmem.Show();
        }
        void exporttoexcel(GridView view, string title)
        {
            if (view.RowCount == 0)
            {
                XtraMessageBox.Show("No Data to Import!..");
                return;
            }
            else
            {
                string filepath = "C:\\AKPID\\";
                //if (chckisIC.Checked==false)
                //{
                //    filepath = "C:\\AKPID\\";
                //}
                //else
                //{
                //    filepath = "C:\\AKPIDIC\\";
                //}
               
                createDirectoryFolder(filepath);
                string filename = title + ".xls";
                string file = filepath + filename;
                view.ExportToXls(file);
                XtraMessageBox.Show("Successfully Exported.. Please Check your Drive C://MyFiles/folder");
            }
        }

        void GetImage(string id)
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            pbox = new PictureBox();
            string query = "select Photo FROM Members WHERE ID='" + id + "'";
            SqlCommand com = new SqlCommand(query, con);
            com.CommandTimeout = 3600;
            SqlDataReader reader = com.ExecuteReader();
            if (reader != null)
            {
                if (reader.Read())
                {
                    if (reader["Photo"] == System.DBNull.Value)
                    {
                        pbox.Image = null;
                    }
                    else
                    {
                        byte[] img = null;
                        img = (byte[])reader["Photo"];
                        MemoryStream ms = new MemoryStream(img);
                        ms.Seek(0, SeekOrigin.Begin);
                       
                        pbox.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                pbox.Image = null;
            }
            reader.Close();
            con.Close();
        }

        void GetSignature(string id)
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            sbox = new PictureBox();
            string query = "select Signature FROM Members WHERE ID='" + id + "'";
            SqlCommand com = new SqlCommand(query, con);
            com.CommandTimeout = 3600;
            SqlDataReader reader = com.ExecuteReader();
            if (reader != null)
            {
                if (reader.Read())
                {
                    if (reader["Signature"] == System.DBNull.Value)
                    {
                        sbox.Image = null;
                    }
                    else
                    {
                        byte[] img = null;
                        img = (byte[])reader["Signature"];
                        MemoryStream ms = new MemoryStream(img);
                        ms.Seek(0, SeekOrigin.Begin);

                        sbox.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                sbox.Image = null;
            }
            reader.Close();
            con.Close();
        }

        void checkIfPictureExists()
        {
            createDirectoryFolder(@"C:\AKPPHOTOS\");
            for(int i=0;i<=gridView1.RowCount-1;i++)
            {
                string id = gridView1.GetRowCellValue(i, "ID").ToString();
                string dir = @"C:\AKPPHOTOS\" + gridView1.GetRowCellValue(i, "ID").ToString() + ".jpg";
                if (File.Exists(dir) == false)
                {
                    GetImage(gridView1.GetRowCellValue(i, "ID").ToString());
                    exportimage(gridView1.GetRowCellValue(i, "ID").ToString());
                }
            }
            
        }

        void checkIfSignatureExists()
        {
            createDirectoryFolder(@"C:\AKPSIGNATURES\");
            for (int i = 0; i <= gridView1.RowCount - 1; i++)
            {
                string id = gridView1.GetRowCellValue(i, "ID").ToString();
                string dir = @"C:\AKPSIGNATURES\" + gridView1.GetRowCellValue(i, "ID").ToString() + ".jpg";
                if (File.Exists(dir) == false)
                {
                    GetSignature(gridView1.GetRowCellValue(i, "ID").ToString());
                    exportimageSig(gridView1.GetRowCellValue(i, "ID").ToString()); 
                }
            }

        }

        void exportDatabase()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            string query = "select * FROM view_RetrieveMember WHERE isPrinted=0 ORDER BY FNAME";
            SqlCommand com = new SqlCommand(query, con);
            com.CommandTimeout = 3600;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //GridControl control = new GridControl();
            //GridView v = new GridView();
            gridView1.Columns.Clear();
            gridControl1.DataSource = null;
            gridControl1.DataSource = table;
            gridView1.BestFitColumns();
            con.Close();

            string filename = "AKPDB";
            exporttoexcel(gridView1, filename);
            checkIfPictureExists();
        }
        void exportDatabaseChapter()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            string query = "select * FROM view_RetrieveChapterMemberID WHERE isPrinted=0 and isChapterID=1 ORDER BY FNAME";
            SqlCommand com = new SqlCommand(query, con);
            com.CommandTimeout = 3600;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //GridControl control = new GridControl();
            //GridView v = new GridView();
            gridView1.Columns.Clear();
            gridControl1.DataSource = null;
            gridControl1.DataSource = table;
            gridView1.BestFitColumns();
            con.Close();

            string filename = "AKPDBCHAPTER";
            exporttoexcel(gridView1, filename);
            checkIfPictureExists();
        }

        void exportDatabaseIC()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            string query = "select * FROM view_RetrieveMemberIC WHERE isPrinted=0 ORDER BY FNAME";
            SqlCommand com = new SqlCommand(query, con);
            com.CommandTimeout = 3600;
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //GridControl control = new GridControl();
            //GridView v = new GridView();
            gridControl1.DataSource = table;
            gridView1.BestFitColumns();
            con.Close();

            string filename = "AKPDBIC";
            exporttoexcel(gridView1, filename);
            checkIfSignatureExists();
        }

        private void exportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportDatabase();
            exportDatabaseChapter();
            //exportDatabaseIC();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            CaptureImage cap = new CaptureImage();
            cap.ShowDialog(this);
            if (CaptureImage.isdone == true)
            {
                picimage.Image = CaptureImage.b1;//(Bitmap)pictureBox1.Image.Clone();

                //imagepic = (Bitmap)pictureBox1.Image.Clone();
                //imagepic = size.Apply(imagepic);
                CaptureImage.isdone = false;
                this.Dispose();
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picimage.Image = Image.FromFile(dialog.FileName);

            }
        }

      
        private void txtchapter_EditValueChanged(object sender, EventArgs e)
        {
            if(action== "cancel") { txtid.Text = "";txtrollno.Text = ""; }
            
            else if (action != "update")
            {
                chapterid = SearchLookUpClass.getSingleValue(txtchapter, "ChapterID");
                //Object val = Database.getSingleValue(txtchapter, "ChapterID");
                //txtchaptercode.Text = val.ToString();

                int ctr = IDGenerator.getIDNumber("MembershipInfo", "ChapterCountryCode='" + chaptercountrycode + "' and ChapterZipCode='" + chapterzipcode + "' " +
                "and ChapterCode='" + chapterid + "' ", "SEQ_NO");
                //int ctr = IDGenerator.getIDNumber("MembershipInfo", "ID like SUBSTRING(ID,1,8)%", "SEQ_NO");
                string newmemberid = Database.sequencePadding1(ctr.ToString(), 6);
                txtrollno.Text = newmemberid;
                txtid.Text = chaptercountrycode.ToString() + chapterzipcode.ToString() + chapterid.ToString() + txtrollno.Text;
                txtchapterchaptercode.Text = chapterid.ToString();
            }
            else if (action == "update" && ctrupdate5==1)
            {
                chapterid = txtchapterchaptercode.Text;//SearchLookUpClass.getSingleValue(txtchapter, "ChapterID");
                if (chapterid == null)
                {
                    chapterid = txtchapterchaptercode.Text;
                }
                else
                {
                    chapterid = txtchapterchaptercode.Text; ; //SearchLookUpClass.getSingleValue(txtchapter, "ChapterID");
                    int ctr = IDGenerator.getIDNumber("MembershipInfo", "ChapterCountryCode='" + txtchaptercountrycode.Text + "' and ChapterZipCode='" + txtchapterzipcode.Text + "' " +
                    "and ChapterCode='" + chapterid + "' ", "SEQ_NO");
                    string newmemberid = Database.sequencePadding1(ctr.ToString(), 6);
                    txtrollno.Text = newmemberid;
                    txtid.Text = txtchaptercountrycode.Text + txtchapterzipcode.Text + chapterid.ToString() + txtrollno.Text;
                    txtchapterchaptercode.Text = chapterid.ToString();
                }
                ctrupdate5 += 1;
            }
            else if (action == "update" && ctrupdate5 > 1)
            {
                chapterid = SearchLookUpClass.getSingleValue(txtchapter, "ChapterID");
                if (chapterid == null)
                {
                    chapterid = txtchapterchaptercode.Text;
                }
                else
                {
                    chapterid = SearchLookUpClass.getSingleValue(txtchapter, "ChapterID");
                    int ctr = IDGenerator.getIDNumber("MembershipInfo", "ChapterCountryCode='" + txtchaptercountrycode.Text + "' and ChapterZipCode='" + txtchapterzipcode.Text + "' " +
                    "and ChapterCode='" + chapterid + "' ", "SEQ_NO");
                    string newmemberid = Database.sequencePadding1(ctr.ToString(), 6);
                    txtrollno.Text = newmemberid;
                    txtid.Text = txtchaptercountrycode.Text + txtchapterzipcode.Text + chapterid.ToString() + txtrollno.Text;
                    txtchapterchaptercode.Text = chapterid.ToString();
                }
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtsearchcat.Text) && String.IsNullOrEmpty(txtsearchkeyword.Text)) //kung empty ang duha ka fields
            {
                Database.display("SELECT TOP(100) * FROM view_MembershipBasicInfo ", gridControl2, gridView2);

            }
            else if (String.IsNullOrEmpty(txtsearchcat.Text) && !String.IsNullOrEmpty(txtsearchkeyword.Text)) //kung empty ang category og dili empty ang searchname
            {
                Database.display("SELECT TOP(100) * FROM view_MembershipBasicInfo WHERE (FirstName like '%" + txtsearchkeyword.Text + "%' OR MiddleName like '%" + txtsearchkeyword.Text + "%' OR LastName like '%" + txtsearchkeyword.Text + "%' OR ChapterName like '%" + txtsearchkeyword.Text + "%') ", gridControl2, gridView2);
            }
            else //kung specific like dili empty ang category og dli empty ang searchname
            {
                Database.display("SELECT TOP(100) * FROM view_MembershipBasicInfo WHERE " + txtsearchcat.Text + " like '%" + txtsearchkeyword.Text + "%' ", gridControl2, gridView2);
            }
            gridView2.Columns["Photo"].OptionsColumn.FixedWidth = true;
            gridView2.Columns["Photo"].Width = 100;
            gridView2.RowHeight = 100;
        }

        private void btnaddchapter_Click(object sender, EventArgs e)
        {
            AddChapter addchap = new AddChapter();
            addchap.ShowDialog(this);
            if (AddChapter.isdone == true)
            {
                Database.displaySearchlookupEdit("SELECT BarangayName,ChapterName,ChapterID FROM Chapters", txtchapter, "ChapterName", "ChapterName");
                AddChapter.isdone = false;
                addchap.Dispose();
            }
        }

        private void gridControl2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(gridControl2, e.Location);
                if(UserLogin.isglobalUserID != "eulz")
                {
                    contextMenuStrip1.Items[1].Visible = false;
                    contextMenuStrip1.Items[2].Visible = false;
                    contextMenuStrip1.Items[4].Visible = false;
                    contextMenuStrip1.Items[5].Visible = false;
                }
            }
                
        }

        private void editDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simpleButton2.Enabled = false;
            btnupdate.Enabled = true;
            btncancel.Enabled = true;
            globaloldid = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
            action = "update";
            ctrupdate1 = 1;
            ctrupdate2 = 1;
            ctrupdate3 = 1;
            ctrupdate4 = 1;
            ctrupdate5 = 1;
            SqlConnection con = Database.getConnection();
            con.Open();
            string query = "select TOP(1) Photo FROM Members WHERE ID='" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString() + "'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader reader = com.ExecuteReader();
            if (reader != null)
            {
                if (reader.Read())
                {
                    if (reader["Photo"] == System.DBNull.Value)
                    {
                        picimage.Image = null;
                    }
                    else
                    {
                        byte[] img = null;
                        img = (byte[])reader["Photo"];
                        MemoryStream ms = new MemoryStream(img);
                        ms.Seek(0, SeekOrigin.Begin);
                        picimage.Image = Image.FromStream(ms);
                        pbox = new PictureBox();
                        pbox.Image = Image.FromStream(ms);
                    }

                }
            }
            else
            {
                picimage.Image = null;
            }
            reader.Close();
            con.Close();
            /*
            SqlConnection con1 = Database.getConnection();
            con1.Open();
            string query1 = "select Signature FROM Members WHERE ID='" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString() + "'";
            SqlCommand com1 = new SqlCommand(query1, con1);
            SqlDataReader reader1 = com1.ExecuteReader();
            if (reader1 != null)
            {
                if (reader1.Read())
                {
                    if (reader1["Signature"] == System.DBNull.Value)
                    {
                        sigimage.Image = null;
                    }
                    else
                    {
                        byte[] img1 = null;
                        img1 = (byte[])reader1["Signature"];
                        MemoryStream ms = new MemoryStream(img1);
                        ms.Seek(0, SeekOrigin.Begin);
                        sigimage.Image = Image.FromStream(ms);
                        sbox = new PictureBox();
                        sbox.Image = Image.FromStream(ms);
                    }

                }
            }
            else
            {
                sigimage.Image = null;
            }
            reader1.Close();
            con1.Close();
            */
            var row = Database.getMultipleQuery("Members", "ID='" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString() + "' ",
                "TRANS_NO, " +
                "ID, " +
                "FirstName, " +
                "MiddleName, " +
                "LastName, " +
                "Address, " +
                "DateOfBirth, " +
                "PlaceOfBirth, " +
                "Religion, " +
                "CivilStatus, " +
                "Gender, " +
                "Citizenship, " +
                "EmailAddress, " +
                "Height, " +
                "Weight, " +
                "Skills, " +
                "Photo, " +
                "Signature, " +
                "RFID, " +
                "SSSNo, " +
                "TinNo, " +
                "PibigNo, " +
                "MobileNo, " +
                "BloodType, " +
                "ContactPersonFullName, " +
                "ContactPersonMobileNo, " +
                "ContactPersonAddress, " +
                "MothersFirstName, " +
                "MothersMiddleName, " +
                "MothersLastName, " +
                "FathersFirstName," +
                "FathersMiddleName, " +
                "FathersLastName, " +
                "PrimarySchool, " +
                "PrimarySchoolDateGraduate, " +
                "SecondarySchool, " +
                "SecondarySchoolDateGraduate, " +
                "TertiarySchool, " +
                "TertiarySchoolDateGraduate, " +
                "Course, " +
                "VocationalTradeCourse, " +
                "VocationalTradeCourseDateGraduate, " +
                "GraduateStudies, " +
                "GraduateStudiesDateGraduate, " +
                "OtherAchievements, " +
                "isPrinted, "+
                "Groups, "+
                "ReferredBy, "+
                "Agent");


            //string ID, TRANS_NO, FirstName, MiddleName, LastName, Address, Country, Region, Chapter, DateSurvive, DateOfBirth, DateIssued, DateExpired, SSSNo, TinNo, MobileNo, BloodType, ContactPersonFullName, ContactPersonMobileNo, ContactPersonAddress;

            string TRANS_NO
                  , ID
                  , FirstName
                  , MiddleName
                  , LastName
                  , Address
                  , DateOfBirth
                  , PlaceOfBirth
                  , Religion
                  , CivilStatus
                  , Gender
                  , Citizenship
                  , EmailAddress
                  , Height
                  , Weight
                  , Skills
                  , Photo
                  , Signature
                  , RFID
                  , SSSNo
                  , TinNo
                  , PibigNo
                  , MobileNo
                  , BloodType
                  , ContactPersonFullName
                  , ContactPersonMobileNo
                  , ContactPersonAddress
                  , MothersFirstName
                  , MothersMiddleName
                  , MothersLastName
                  , FathersFirstName
                  , FathersMiddleName
                  , FathersLastName
                  , PrimarySchool
                  , PrimarySchoolDateGraduate
                  , SecondarySchool
                  , SecondarySchoolDateGraduate
                  , TertiarySchool
                  , TertiarySchoolDateGraduate
                  , Course
                  , VocationalTradeCourse
                  , VocationalTradeCourseDateGraduate
                  , GraduateStudies
                  , GraduateStudiesDateGraduate
                  , OtherAchievements
                  , isPrinted
                  , Groups
                  , ReferredBy
                  , Agent;

            TRANS_NO = row["TRANS_NO"].ToString();
            ID = row["ID"].ToString();
            FirstName = row["FirstName"].ToString();
            MiddleName = row["MiddleName"].ToString();
            LastName = row["LastName"].ToString();
            Address = row["Address"].ToString();
            DateOfBirth = row["DateOfBirth"].ToString();
            PlaceOfBirth = row["PlaceOfBirth"].ToString();
            Religion = row["Religion"].ToString();
            CivilStatus = row["CivilStatus"].ToString();
            Gender = row["Gender"].ToString();
            Citizenship = row["Citizenship"].ToString();
            EmailAddress = row["EmailAddress"].ToString();
            Height = row["Height"].ToString();
            Weight = row["Weight"].ToString();
            Skills = row["Skills"].ToString();
            Photo = row["Photo"].ToString();
            Signature = row["Signature"].ToString();
            RFID = row["RFID"].ToString();
            SSSNo = row["SSSNo"].ToString();
            TinNo = row["TinNo"].ToString();
            PibigNo = row["PibigNo"].ToString();
            MobileNo = row["MobileNo"].ToString();
            BloodType = row["BloodType"].ToString();
            ContactPersonFullName = row["ContactPersonFullName"].ToString();
            ContactPersonMobileNo = row["ContactPersonMobileNo"].ToString();
            ContactPersonAddress = row["ContactPersonAddress"].ToString();
            MothersFirstName = row["MothersFirstName"].ToString();
            MothersMiddleName = row["MothersMiddleName"].ToString();
            MothersLastName = row["MothersLastName"].ToString();
            FathersFirstName = row["FathersFirstName"].ToString();
            FathersMiddleName = row["FathersMiddleName"].ToString();
            FathersLastName = row["FathersLastName"].ToString();
            PrimarySchool = row["PrimarySchool"].ToString();
            PrimarySchoolDateGraduate = row["PrimarySchoolDateGraduate"].ToString();
            SecondarySchool = row["SecondarySchool"].ToString();
            SecondarySchoolDateGraduate = row["SecondarySchoolDateGraduate"].ToString();
            TertiarySchool = row["TertiarySchool"].ToString();
            TertiarySchoolDateGraduate = row["TertiarySchoolDateGraduate"].ToString();
            Course = row["Course"].ToString();
            VocationalTradeCourse = row["VocationalTradeCourse"].ToString();
            VocationalTradeCourseDateGraduate = row["VocationalTradeCourseDateGraduate"].ToString();
            GraduateStudies = row["GraduateStudies"].ToString();
            GraduateStudiesDateGraduate = row["GraduateStudiesDateGraduate"].ToString();
            OtherAchievements = row["OtherAchievements"].ToString();
            isPrinted = row["isPrinted"].ToString();
            Groups = row["Groups"].ToString();
            ReferredBy = row["ReferredBy"].ToString();
            Agent = row["Agent"].ToString();

            string SEQ_NO
            , ChapterCountryCode
            , ChapterRegionCode
            , ChapterProvinceCode
            , ChapterMunicipalityCode
            , ChapterZipCode
            , ChapterCode
            , DateSurvive
            , GiftName
            , GodParent
            , GSDuringSurvive
            , DateIssued
            , DateExpiry
            , LastActiveDate
            , isActive
            , isPaid
            , withForm
            , isDeducted
            , isIC
            , CouncilName
            , ActiveCountry
            , MobileSerialKey
            , isChapterID
            , isMunID
            , isProvID
            , isReg
            , Position
            , GSName
            , MIName
            , isNatlID;

            var rowz = Database.getMultipleQuery("MembershipInfo", "ID='" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString() + "' ",
            "SEQ_NO,ID,ChapterCountryCode,ChapterRegionCode,ChapterProvinceCode,ChapterMunicipalityCode,ChapterZipCode,ChapterCode," +
            "DateSurvive,GiftName,GodParent,DateIssued,DateExpiry,LastActiveDate,isActive,isPaid,withForm,isDeducted,MobileSerialKey,GSDuringSurvive,isIC,CouncilName,ActiveCountry,isChapterID,isMunID,isProvID,isReg,isNatlID,Position,GSName,MIName");

            SEQ_NO = rowz["SEQ_NO"].ToString();  
            ChapterCountryCode = rowz["ChapterCountryCode"].ToString();
            ChapterRegionCode = rowz["ChapterRegionCode"].ToString();
            ChapterProvinceCode = rowz["ChapterProvinceCode"].ToString();
            ChapterMunicipalityCode = rowz["ChapterMunicipalityCode"].ToString();
            ChapterZipCode = rowz["ChapterZipCode"].ToString();
            ChapterCode = rowz["ChapterCode"].ToString();
            DateSurvive = rowz["DateSurvive"].ToString();
            GiftName = rowz["GiftName"].ToString();
            GodParent = rowz["GodParent"].ToString();
            GSDuringSurvive = rowz["GSDuringSurvive"].ToString();
            DateIssued = rowz["DateIssued"].ToString();
            DateExpiry = rowz["DateExpiry"].ToString();
            LastActiveDate = rowz["LastActiveDate"].ToString();
            isActive = rowz["isActive"].ToString();
            isPaid = rowz["isPaid"].ToString();
            withForm = rowz["withForm"].ToString();
            isDeducted = rowz["isDeducted"].ToString();
            MobileSerialKey = rowz["MobileSerialKey"].ToString();
            isIC = rowz["isIC"].ToString();
            CouncilName = rowz["CouncilName"].ToString();
            ActiveCountry = rowz["ActiveCountry"].ToString();
            isChapterID = rowz["isChapterID"].ToString();
            isMunID = rowz["isMunID"].ToString();
            isProvID = rowz["isProvID"].ToString();
            isReg = rowz["isReg"].ToString();
            Position = rowz["Position"].ToString();
            GSName = rowz["GSName"].ToString();
            MIName = rowz["MIName"].ToString();
            isNatlID= rowz["isNatlID"].ToString();
            if (Convert.ToBoolean(isChapterID) == true) { chckchapterid.Checked = true; } else { chckchapterid.Checked = false; }
            if (Convert.ToBoolean(isMunID) == true) { chckmunid.Checked = true; } else { chckmunid.Checked = false; }
            if (Convert.ToBoolean(isProvID) == true) { chckprovid.Checked = true; } else { chckprovid.Checked = false; }
            if (Convert.ToBoolean(isReg) == true) { chckregid.Checked = true; } else { chckregid.Checked = false; }
            if (Convert.ToBoolean(isNatlID) == true) { chcknatlid.Checked = true; } else { chcknatlid.Checked = false; }


            txtchaptercountrycode.Text = ChapterCountryCode;
            txtchapterregioncode.Text = ChapterRegionCode;
            txtchapterprovincecode.Text = ChapterProvinceCode;
            txtchaptermunicipalitycode.Text = ChapterMunicipalityCode;
            txtchapterzipcode.Text = ChapterZipCode;
            txtchapterchaptercode.Text = ChapterCode;

            string chaptercountryname, chapterregionname, chapterprovincename, chaptermunicipalityname, chaptername;
            var chapterfullnames = Database.getMultipleQuery("view_MembershipBasicInfo", "ID='" + ID + "' ", "Country,Region,Province,MUNICIPALITY,ChapterName");
            chaptercountryname = chapterfullnames["Country"].ToString();  
            chapterregionname = chapterfullnames["Region"].ToString();  
            chapterprovincename = chapterfullnames["Province"].ToString();
            chaptermunicipalityname = chapterfullnames["MUNICIPALITY"].ToString();
            chaptername = chapterfullnames["ChapterName"].ToString();


            txtfname.Text = FirstName;
            txtmname.Text = MiddleName;
            txtlname.Text = LastName;
            txtaddress.Text = Address;
            //txtcountry.Text = countryname;
            //txtregion.Text = regionname;
            //txtprovinces.Text = provincename;
            //txtmunicipalities.Text = municipalityname;
            //txtregionname.Text = Region;
            txtbdate.Text = DateOfBirth;
            //txtbplace.Text = PlaceOfBirth;
            //txtreligion.Text = Religion;
            //txtcivilstatus.Text = CivilStatus;
            //txtgender.Text = Gender;
            //txtcitizenship.Text = Citizenship;
            //txtemailaddress.Text = EmailAddress;
            //txtheight.Text = Height;
            //txtweight.Text = Weight;
            //txtskills.Text = Skills;
           

            txtmobileno.Text = MobileNo;
         
            txtbloodtype.Text = BloodType;

            txtcontactpersonfullname.Text = ContactPersonFullName;
            txtcontactpersonaddress.Text = ContactPersonAddress;
            txtcontactpersonmobileno.Text = ContactPersonMobileNo;

            txtgroups.Text = Groups;
            txtreferredby.Text = ReferredBy;
            txtgiftname.Text = GiftName;
            txtdatesurvived.Text = DateSurvive;

            txtposition.Text = Position;
            txtgs.Text = GSName;
            txtmasterinitiator.Text = MIName;


            if (Convert.ToBoolean(isIC) == true)
            {
                chckisic.Checked = true;
            }
            else
            {
                chckisic.Checked = false;
            }

            //if (Convert.ToBoolean(isPaid) == true)
            //{
            //    chckispaid.Checked = true;
            //}
            //else
            //{
            //    chckispaid.Checked = false;
            //}

            //if (Convert.ToBoolean(withForm) == true)
            //{
            //    chckwithform.Checked = true;
            //}
            //else
            //{
            //    chckwithform.Checked = false;
            //}
            //if (Convert.ToBoolean(isDeducted) == true)
            //{
            //    checkisdeducted.Checked = true;
            //}
            //else
            //{
            //    checkisdeducted.Checked = false;
            //}


            Database.displaySearchlookupEdit("SELECT REGION_CODE,REGION_NAME,REGION_INSTANCE FROM Regions WHERE COUNTRY_CODE = '" + txtchaptercountrycode.Text + "' ", txtchapterregions, "REGION_NAME", "REGION_NAME");
            Database.displaySearchlookupEdit("SELECT PROVINCE_CODE,PROVINCE FROM Provinces WHERE REGION_CODE = '" + txtchapterregioncode.Text + "' ", txtchapterprovinces, "PROVINCE", "PROVINCE");
            Database.displaySearchlookupEdit("SELECT MUNICIPALITY_CODE,MUNICIPALITY,ZIPCODE FROM Municipalities WHERE PROVINCE_CODE = '" + txtchapterprovincecode.Text + "' ", txtchaptermunicipalites, "MUNICIPALITY", "MUNICIPALITY");
            Database.displaySearchlookupEdit("SELECT ChapterID,ChapterName FROM Chapters WHERE ChapterID = '"+txtchapterchaptercode.Text+"' ", txtchapter, "ChapterName", "ChapterName");

            txtchaptercountries.Text = chaptercountryname;
            txtchapterregions.Text = chapterregionname;
            txtchapterprovinces.Text = chapterprovincename;
            txtchaptermunicipalites.Text = chaptermunicipalityname;
            txtchapter.Text = chaptername;

            txtcouncilname.Text = CouncilName;
            txtactivecountry.Text = ActiveCountry;
         
            txtid.Text = ID;
            txtrollno.Text = Database.sequencePadding1(SEQ_NO, 6);
            //txtmobileserialkey.Text = MobileSerialKey;
            //txtgsduringsurvive.Text = GSDuringSurvive;
        }

        void updateInfo()
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (chckisic.Checked==false && (String.IsNullOrEmpty(txtchaptercountries.Text) || String.IsNullOrEmpty(txtchapterregions.Text) || String.IsNullOrEmpty(txtchapterprovinces.Text) || String.IsNullOrEmpty(txtchaptermunicipalites.Text) || String.IsNullOrEmpty(txtchapter.Text)))
            {
                XtraMessageBox.Show("Some fields are empty, please filled out all the fields.");
                return;
            }
            else
            {
                execute(2);
                preview();
                preview2();
                Utilities.ClearFields(panel1);
                //Utilities.ClearFields(panelMembershipInfo);
                Utilities.ClearFields(groupBox2);
                Utilities.ClearFields(groupBox3);
                //Utilities.ClearFields(groupBox4);
             
                btnupdate.Enabled = false;
                btncancel.Enabled = false;
            }
        }
        void preview()
        {
            try
            {
                string middlename = "";
                if(String.IsNullOrEmpty(txtmname.Text))
                {
                    middlename = "";
                }
                else
                {
                    middlename = txtmname.Text.Substring(0, 1).ToUpper() + ".";
                }
                string reportPath = "";
                //string reportPathChapter = "";
                string reportPath2 = "";
                reportPath = "C:\\AKPExportImages\\";
                //reportPathChapter = "C:\\AKPExportImages\\Chapter\\"+txtchapter.Text+"\\";
                reportPath2 = "C:\\ImageFile\\" + txtfname.Text.ToUpper() + "_" + txtlname.Text.ToUpper() + "\\";
                //if (chckisIC.Checked==false)
                //{
                //    reportPath = "C:\\AKPExportImages\\";
                //    reportPath2 = "C:\\ImageFile\\" + txtfname.Text.ToUpper() + "_" + txtlname.Text.ToUpper() + "\\";
                //}
                //else
                //{
                //    reportPath = "C:\\AKPExportImagesIC\\";
                //    reportPath2 = "C:\\ImageFileIC\\" + txtfname.Text.ToUpper() + "_" + txtlname.Text.ToUpper() + "\\";
                //}

                createDirectoryFolder(reportPath);
                //createDirectoryFolder(reportPathChapter);
                string imageFilename = txtfname.Text.ToUpper() + "_" + txtlname.Text.ToUpper() + "-F.png";
                string filetoprint = reportPath + imageFilename;

                if(!chckchapterid.Checked)
                {
                    XtraReport1 xct = new XtraReport1();

                    xct.lblname.Text = txtfname.Text.ToUpper().Trim() + " " + middlename.Trim() + " " + txtlname.Text.ToUpper().Trim();//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "FirstName").ToString().ToUpper() + " " + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "LastName").ToString().ToUpper() ;
                    xct.lblchapter.Text = txtchapter.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ChapterName").ToString();
                    xct.lblprovince.Text = txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    xct.xrmunicipality.Text = txtchaptermunicipalites.Text; // gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MUNICIPALITY").ToString();
                    xct.xrBarCode1.Text = "1234567890";//txtid.Text; //gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
                    xct.xrPictureBox2.Image = (Bitmap)picimage.Image.Clone();

                    ImageExportOptions imageOptions = xct.ExportOptions.Image;
                    imageOptions.Format = ImageFormat.Png;
                    imageOptions.Resolution = 300;
                    // Export the report to Image.
                    xct.ExportToImage(filetoprint);
                }
                
                //if (chckisIC.Checked == false)
                //{
                //    XtraReport1 xct = new XtraReport1();

                //    xct.lblname.Text = txtfname.Text.ToUpper().Trim() + " " + middlename.Trim() + " " + txtlname.Text.ToUpper().Trim();//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "FirstName").ToString().ToUpper() + " " + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "LastName").ToString().ToUpper() ;
                //    xct.lblchapter.Text = txtchapter.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ChapterName").ToString();
                //    xct.lblprovince.Text = txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                //    xct.xrmunicipality.Text = txtchaptermunicipalites.Text; // gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MUNICIPALITY").ToString();
                //    xct.xrBarCode1.Text = "1234567890";//txtid.Text; //gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
                //    xct.xrPictureBox2.Image = (Bitmap)picimage.Image.Clone();

                //    ImageExportOptions imageOptions = xct.ExportOptions.Image;
                //    imageOptions.Format = ImageFormat.Png;
                //    imageOptions.Resolution = 300;
                //    // Export the report to Image.
                //    xct.ExportToImage(filetoprint);
                //}
                //else
                //{
                //    XtraReportIC ixct = new XtraReportIC();

                //    ixct.lblname.Text = txtfname.Text.ToUpper().Trim() + " " + middlename.Trim() + " " + txtlname.Text.ToUpper().Trim();//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "FirstName").ToString().ToUpper() + " " + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "LastName").ToString().ToUpper() ;
                //    ixct.lblchapter.Text = txtchapter.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ChapterName").ToString();
                //    ixct.xrcouncil.Text = txtcouncil.Text;
                //    ixct.xractivecountry.Text = txtactivecountry.Text;
                //    //ixct.lblprovince.Text = txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                //    //ixct.xrmunicipality.Text = txtchaptermunicipalites.Text; // gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MUNICIPALITY").ToString();
                //    //ixct.xrBarCode1.Text = "1234567890";//txtid.Text; //gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
                //    ixct.xrPictureBox2.Image = (Bitmap)picimage.Image.Clone();

                //    ImageExportOptions imageOptions = ixct.ExportOptions.Image;
                //    imageOptions.Format = ImageFormat.Png;
                //    imageOptions.Resolution = 300;
                //    // Export the report to Image.
                //    ixct.ExportToImage(filetoprint);
                //}
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        void preview2()
        {
            try
            {
                string reportPath = "";
                string reportPath2 = "";
                reportPath = "C:\\AKPExportImages\\";
                reportPath2 = "C:\\ImageFile\\" + txtfname.Text.ToUpper() + "_" + txtlname.Text.ToUpper() + "\\";
                //if (chckisIC.Checked == false)
                //{
                //    reportPath = "C:\\AKPExportImages\\";
                //    reportPath2 = "C:\\ImageFile\\" + txtfname.Text.ToUpper() + "_" + txtlname.Text.ToUpper() + "\\";
                //}
                //else
                //{
                //    reportPath = "C:\\AKPExportImagesIC\\";
                //    reportPath2 = "C:\\ImageFileIC\\" + txtfname.Text.ToUpper() + "_" + txtlname.Text.ToUpper() + "\\";
                //}

                createDirectoryFolder(reportPath);
                string imageFilename = txtfname.Text.ToUpper() + "_" + txtlname.Text.ToUpper() + "-B.png";
                string filetoprint = reportPath + imageFilename;
                XtraReport2 xct = new XtraReport2();



                xct.xrmobileno.Text = txtmobileno.Text;
                xct.xrbloodtype.Text = txtbloodtype.Text;
                xct.xrbdate.Text = Convert.ToDateTime(txtbdate.Text).ToShortDateString();
                xct.xraddress.Text = txtaddress.Text;

                xct.xrcontactpersonfullname.Text = txtcontactpersonfullname.Text;
                xct.xrcontactpersonaddress.Text = txtcontactpersonaddress.Text;
                xct.xrcontactpersonmobileno.Text = txtcontactpersonmobileno.Text;

                ImageExportOptions imageOptions = xct.ExportOptions.Image;
                imageOptions.Format = ImageFormat.Png;
                imageOptions.Resolution = 300;
                // Export the report to Image.
                xct.ExportToImage(filetoprint);
                //if (chckisIC.Checked == false)
                //{
                //    XtraReport2 xct = new XtraReport2();
                   
                   

                //    xct.xrmobileno.Text = txtmobileno.Text;
                //    xct.xrbloodtype.Text = txtbloodtype.Text;
                //    xct.xrbdate.Text = Convert.ToDateTime(txtbdate.Text).ToShortDateString();
                //    xct.xraddress.Text = txtaddress.Text;

                //    xct.xrcontactpersonfullname.Text = txtcontactpersonfullname.Text;
                //    xct.xrcontactpersonaddress.Text = txtcontactpersonaddress.Text;
                //    xct.xrcontactpersonmobileno.Text = txtcontactpersonmobileno.Text;

                //    ImageExportOptions imageOptions = xct.ExportOptions.Image;
                //    imageOptions.Format = ImageFormat.Png;
                //    imageOptions.Resolution = 300;
                //    // Export the report to Image.
                //    xct.ExportToImage(filetoprint);
                //}
                //else
                //{
                //    XtraReportICBack xct1 = new XtraReportICBack();
                //    if (String.IsNullOrEmpty(txtrfid.Text))
                //    {
                //        xct1.xrLabel1.Text = "";//txtid.Text;
                //    }
                //    else
                //    {
                //        xct1.xrLabel1.Text = txtrfid.Text;//txtid.Text;
                //    }
                //    xct1.xrmobileno.Text = txtmobileno.Text;
                //    xct1.xrbdate.Text = Convert.ToDateTime(txtbdate.Text).ToShortDateString();
                //    xct1.xraddress.Text = txtaddress.Text;

                //    //xct1.xrcontactpersonfullname.Text = txtcontactpersonfullname.Text;
                //    //xct1.xrcontactpersonaddress.Text = txtcontactpersonaddress.Text;
                //    //xct1.xrcontactpersonmobileno.Text = txtcontactpersonmobileno.Text;

                //    ImageExportOptions imageOptions = xct1.ExportOptions.Image;
                //    imageOptions.Format = ImageFormat.Png;
                //    imageOptions.Resolution = 300;
                //    // Export the report to Image.
                //    xct1.ExportToImage(filetoprint);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void extractSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            preview();
            preview2();
            MessageBox.Show("Successfully Save to Image File");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            preview();
            preview2();
            MessageBox.Show("Successfully Save to Image File");
        }

        private void isEulzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery("UPDATE MembershipInfo set isEulz=1 WHERE ID='" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString() + "'", "Successfully Updated!");
        }

        private void isFreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery("UPDATE MembershipInfo set isFree=1 WHERE ID='" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString() + "'", "Successfully Updated!");
        }

        private void updatePrintedIDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePrintedID updpauy = new UpdatePrintedID();
            updpauy.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            action = "cancel";
            simpleButton2.Enabled = true;
            btnupdate.Enabled = false;
            btncancel.Enabled = false;
            Utilities.ClearFields(panel1); 
            Utilities.ClearFields(groupBox2);
            //Utilities.ClearFields(groupBox3);
            chcknatlid.Checked = true;
            txtchapter.Text = "";
            txtchapterchaptercode.Text = "";
            txtchapterzipcode.Text = "";
            txtchaptermunicipalites.Text = "";
            txtchaptermunicipalitycode.Text = "";
            txtchapterprovinces.Text = "";
            txtchapterprovincecode.Text = "";
            txtchapterregions.Text = "";
            txtchapterregioncode.Text = "";
            txtchaptercountries.Text = "";
            txtchaptercountrycode.Text = "";
            action = "";
            
        }

        private void isPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery("UPDATE MembershipInfo SET isPaid=1 WHERE ID='" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString() + "'", "Successfully Updated!!!..");
        }

        private void isNotPrintedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery("UPDATE Members SET isPrinted=0 WHERE ID='" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString() + "'", "Successfully Updated!!!..");
        }

        private void extractMasterlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PracticeForm frmpc = new PracticeForm();
            frmpc.Show();
        }

        private void addChapterLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChapterLogo chplog = new ChapterLogo();
            chplog.ShowDialog(this);
        }

        private void exportDatabaseICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportDatabaseIC();
        }

        private void isPrnPdElzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Database.ExecuteQuery("UPDATE MembershipInfo SET isPaid=1 WHERE ID='" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString() + "'");
            Database.ExecuteQuery("UPDATE Members SET isPrinted=1 WHERE ID='" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString() + "'");
            Database.ExecuteQuery("UPDATE MembershipInfo set isPaid=1,isEulz=1 WHERE ID='" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString() + "'", "Successfully Updated!");
        }

        private void chcksameasabove_CheckedChanged(object sender, EventArgs e)
        {
            if (chcksameasabove.Checked == true)
                txtcontactpersonaddress.Text = txtaddress.Text;
            else
                txtcontactpersonaddress.Text = "";
        }

        private void internationCouncilIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICForm icfrm = new ICForm();
                icfrm.Show();
        }

        private void txtlname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                Database.display("SELECT TOP(100) * FROM view_MembershipBasicInfo WHERE (FirstName like '%" + txtsearchkeyword.Text + "%' OR MiddleName like '%" + txtsearchkeyword.Text + "%' OR LastName like '%" + txtsearchkeyword.Text + "%' OR ChapterName like '%" + txtsearchkeyword.Text + "%') ", gridControl2, gridView2);
        }

        private void exportChapterIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            previewChapterIDBETANU();
        }
        void previewChapterIDBETANU()
        {
            try
            {
                //for (int i = 0; i <= gridView1.RowCount - 1; i++)
                //{


                    string reportPath = "";

                    reportPath = "C:\\AKPExportChapterIDBETANU\\";

                    string fname = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "FirstName").ToString();
                    string lname = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "LastName").ToString().Replace(".", "");

                    createDirectoryFolder(reportPath);
                    string imageFilename = fname + "_" + lname + "-F.png";
                    string filetoprint = reportPath + imageFilename;


                    PictureBox pbox = new PictureBox();
                    byte[] img = null;
                    img = (byte[])gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Photo");
                    MemoryStream ms = new MemoryStream(img);
                    ms.Seek(0, SeekOrigin.Begin);
                    pbox.Image = Image.FromStream(ms);

                    string id = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
                    var rows = Database.getMultipleQuery("view_RetrieveMember2", $"ID='{id}'", "CHAPTERNAME,MUNICIPALITY,PROVINCE,BLOODTYPE,DATESURVIVE,GiftName,Position");
                    string CHAPTERNAME = rows["CHAPTERNAME"].ToString();
                    string MUNICIPALITY = rows["MUNICIPALITY"].ToString();
                    string BLOODTYPE = rows["BLOODTYPE"].ToString();
                    string DATESURVIVE = rows["DATESURVIVE"].ToString();
                    string GiftName = rows["GiftName"].ToString();
                    string PROVINCE = rows["PROVINCE"].ToString();
                    string Position = rows["Position"].ToString();

                    BETANU xct = new BETANU();

                    xct.lblname.Text = fname.Trim() + " " + " " + lname.Trim();//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "FirstName").ToString().ToUpper() + " " + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "LastName").ToString().ToUpper() ;
                    //xct.lblbloodtype.Text = BLOODTYPE;//txtchapter.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ChapterName").ToString();
                    xct.lbldatesurvive.Text = Convert.ToDateTime(DATESURVIVE).ToShortDateString();// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    xct.lblgiftname.Text = GiftName;// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    xct.lblposition.Text = Position;// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    xct.lblid.Text = id;// txtchapterprovinces.Text;//gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Province").ToString();
                    //xct.xrmunicipality.Text = MUNICIPALITY;//txtchaptermunicipalites.Text; // gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MUNICIPALITY").ToString();
                    xct.xrBarCode1.Text = "6360010600001";//txtid.Text; //gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();

                    xct.xrpic.Image = (Bitmap)pbox.Image.Clone();


                    ImageExportOptions imageOptions = xct.ExportOptions.Image;
                    imageOptions.Format = ImageFormat.Png;
                    imageOptions.Resolution = 300;
                    // Export the report to Image.
                    xct.ExportToImage(filetoprint);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sigimage.Image = Image.FromFile(dialog.FileName);

            }
        }

        private void txtsearchkeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            { simpleButton10.PerformClick(); }
           
        }

        private void addSerialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSerial addser = new AddSerial();
            addser.ShowDialog(this);
        }

        private void isPrintedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery("UPDATE Members SET isPrinted=1 WHERE ID='" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString() + "'", "Successfully Updated!!!..");
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = "C:\\QRDBBackup";
            createDirectoryFolder(filepath);
            SqlConnection con = Database.getConnection();
            con.Open();
            string query = "sp_Backup";
            try
            {
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@parmLogin", UserLogin.isglobalUserID);
                com.Parameters.AddWithValue("@BaseLocation", filepath);
                com.Parameters.AddWithValue("@BackupType", "FULL");
                com.CommandType = CommandType.StoredProcedure;
                com.CommandTimeout = 3600;
                com.CommandText = query;
                com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void clearPhoneSerialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery("Delete FROM PhoneSerial WHERE MemberID='" + gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString() + "'", "Successfully Updated!!!..");
        }

        private void updatePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePayment updpauy = new UpdatePayment();
            updpauy.Show();
        }

       
        private void txtchaptercode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmunicipalities_EditValueChanged(object sender, EventArgs e)
        {
            //zipcode = SearchLookUpClass.getSingleValue(txtchaptermunicipalites, "ZIPCODE");
            //municipalitycode = SearchLookUpClass.getSingleValue(txtchaptermunicipalites, "MUNICIPALITY_CODE");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtcountry_EditValueChanged(object sender, EventArgs e)
        {
            //countrycode = SearchLookUpClass.getSingleValue(txtcountry, "COUNTRY_CODE");
            //Database.displaySearchlookupEdit("SELECT REGION_CODE,REGION_INSTANCE FROM Regions WHERE COUNTRY_CODE='" + countrycode + "'", txtregion, "REGION_INSTANCE", "REGION_INSTANCE");
        }

        private void txtregion_EditValueChanged(object sender, EventArgs e)
        {
            //regioncode = SearchLookUpClass.getSingleValue(txtregion, "REGION_CODE");
            //Database.displaySearchlookupEdit("SELECT PROVINCE_CODE,PROVINCE FROM Provinces WHERE REGION_CODE='" + regioncode + "'", txtprovinces, "PROVINCE", "PROVINCE");
        }

        private void txtprovinces_EditValueChanged(object sender, EventArgs e)
        {
            //provinceccode = SearchLookUpClass.getSingleValue(txtprovinces, "PROVINCE_CODE");
            //Database.displaySearchlookupEdit("SELECT MUNICIPALITY_CODE,MUNICIPALITY,ZIPCODE FROM Municipalities WHERE PROVINCE_CODE='" + provinceccode + "' " +
            //   "and REGION_CODE='" + regioncode + "' and COUNTRY_CODE='" + countrycode + "'", txtmunicipalities, "MUNICIPALITY", "MUNICIPALITY");
        }

        private void picimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picimage.Image = Image.FromFile(dialog.FileName);

            }
        }

        private void txtchaptercountries_EditValueChanged(object sender, EventArgs e)
        {
            if (action == "cancel") { txtid.Text = ""; txtrollno.Text = ""; }
            else if(action != "update")
                {
                    chaptercountrycode = SearchLookUpClass.getSingleValue(txtchaptercountries, "COUNTRY_CODE"); //get country code in gridview
                    txtchaptercountrycode.Text = chaptercountrycode.ToString(); //country code textbox
                }
                else if (action == "update" && ctrupdate1 == 1)
                {
                    chaptercountrycode = txtchaptercountrycode.Text; 
                    txtchaptercountrycode.Text = chaptercountrycode.ToString(); //country code textbox
                    ctrupdate1 += 1;

                }
                else if (action == "update" && ctrupdate1 > 1)
                {
                    //chaptercountrycode = "63";//SearchLookUpClass.getSingleValue(txtchaptercountries, "COUNTRY_CODE"); //get country code in gridview}
                    txtchaptercountrycode.Text = "63";//chaptercountrycode.ToString(); //country code textbox
                }
                Database.displaySearchlookupEdit("SELECT REGION_CODE,REGION_NAME,REGION_INSTANCE FROM Regions WHERE COUNTRY_CODE='" + txtchaptercountrycode.Text + "'", txtchapterregions, "REGION_NAME", "REGION_NAME");
        }

        private void txtchaptermunicipalites_EditValueChanged(object sender, EventArgs e)
        {
            if (action == "cancel") { txtid.Text = ""; txtrollno.Text = ""; }
            else if (action != "update")
            {
                chapterzipcode = SearchLookUpClass.getSingleValue(txtchaptermunicipalites, "ZIPCODE");
                chaptermunicipalitycode = SearchLookUpClass.getSingleValue(txtchaptermunicipalites, "MUNICIPALITY_CODE");
                txtchaptermunicipalitycode.Text = chaptermunicipalitycode.ToString();
                txtchapterzipcode.Text = chapterzipcode.ToString();
            }
            else if (action == "update" && ctrupdate4 ==1)
            {
                chaptermunicipalitycode = txtchaptermunicipalitycode.Text; //SearchLookUpClass.getSingleValue(txtchaptermunicipalites, "MUNICIPALITY_CODE");
                chapterzipcode = txtchapterzipcode.Text; //SearchLookUpClass.getSingleValue(txtchaptermunicipalites, "ZIPCODE");
                
                txtchaptermunicipalitycode.Text = chaptermunicipalitycode.ToString(); //country code textbox
                txtchapterzipcode.Text = chapterzipcode.ToString();
                ctrupdate4 += 1;
            }
            else if (action == "update" && ctrupdate4 > 1)
            {
                chaptermunicipalitycode = SearchLookUpClass.getSingleValue(txtchaptermunicipalites, "MUNICIPALITY_CODE");
                chapterzipcode = SearchLookUpClass.getSingleValue(txtchaptermunicipalites, "ZIPCODE");
                txtchaptermunicipalitycode.Text = chaptermunicipalitycode.ToString(); //country code textbox
                txtchapterzipcode.Text = chapterzipcode.ToString();
            }
                Database.displaySearchlookupEdit("SELECT ChapterID,ChapterName FROM Chapters ", txtchapter, "ChapterName", "ChapterName");

        }

        private void txtchapterregions_EditValueChanged(object sender, EventArgs e)
        {
            if (action == "cancel") { txtid.Text = ""; txtrollno.Text = ""; }
            else if (action != "update")
            {
                chapterregioncode = SearchLookUpClass.getSingleValue(txtchapterregions, "REGION_CODE");
                txtchapterregioncode.Text = chapterregioncode.ToString();
            }
            else if (action == "update" && ctrupdate2 == 1)
            {
                chapterregioncode = txtchapterregioncode.Text;// SearchLookUpClass.getSingleValue(txtchapterregions, "REGION_CODE");
              
                txtchapterregioncode.Text = chapterregioncode.ToString(); //country code textbox
                ctrupdate2 += 1;

            }
            else if (action == "update" && ctrupdate2 > 1)
            {
                chapterregioncode = SearchLookUpClass.getSingleValue(txtchapterregions, "REGION_CODE");
                txtchapterregioncode.Text = chapterregioncode.ToString(); //country code textbox
            }
            Database.displaySearchlookupEdit("SELECT PROVINCE_CODE,PROVINCE FROM Provinces WHERE REGION_CODE='" + txtchapterregioncode.Text + "' AND COUNTRY_CODE='"+txtchaptercountrycode.Text+"'", txtchapterprovinces, "PROVINCE", "PROVINCE");

        }

        private void txtchapterprovinces_EditValueChanged(object sender, EventArgs e)
        {
            if (action == "cancel") { txtid.Text = ""; txtrollno.Text = ""; }
            else if (action != "update")
            {
                chapterprovinceccode = SearchLookUpClass.getSingleValue(txtchapterprovinces, "PROVINCE_CODE");
                txtchapterprovincecode.Text = chapterprovinceccode.ToString();
            }
            else if (action == "update" && ctrupdate3==1)
            {
                chapterprovinceccode = txtchapterprovincecode.Text; //SearchLookUpClass.getSingleValue(txtchapterprovinces, "PROVINCE_CODE");
               
                txtchapterprovincecode.Text = chapterprovinceccode.ToString(); //country code textbox
                ctrupdate3 += 1;

            }
            else if (action == "update" && ctrupdate3 > 1)
            {
                chapterprovinceccode = SearchLookUpClass.getSingleValue(txtchapterprovinces, "PROVINCE_CODE");
                txtchapterprovincecode.Text = chapterprovinceccode.ToString(); //country code textbox

            }
            Database.displaySearchlookupEdit("SELECT MUNICIPALITY_CODE,MUNICIPALITY,ZIPCODE FROM Municipalities WHERE PROVINCE_CODE='" + txtchapterprovincecode.Text + "' " +
                    "and REGION_CODE='" + txtchapterregioncode.Text + "' and COUNTRY_CODE='" + txtchaptercountrycode.Text + "'", txtchaptermunicipalites, "MUNICIPALITY", "MUNICIPALITY");

        }

    

        void populateCountry()
        {
            Database.displaySearchlookupEdit("SELECT COUNTRY_CODE,COUNTRY_NAME FROM Countries WHERE COUNTRY_CODE IN ('63','972','60','39','1','973')", txtchaptercountries, "COUNTRY_NAME", "COUNTRY_NAME"); 
        }


    }
}
