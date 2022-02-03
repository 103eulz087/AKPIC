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
using System.Data.SqlClient;
using System.IO;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

using System.Diagnostics;
using System.Drawing.Imaging;

namespace IDProject
{
    public partial class FormRetrieve : DevExpress.XtraEditors.XtraForm
    {
        //static string constring = "Data Source=127.0.0.1;Initial Catalog=akpidproject;User ID=eulz;Password=123456;";

        static string constring = "Data Source=43.226.6.184;Initial Catalog=QRDB2;User ID=enduser;Password=1234567890;";
        SqlConnection con;
        SqlCommand com;
        MemoryStream ms,ms2;
        object municipalitycode;
        string countrycode, zipcode;
        public FormRetrieve()
        {
            InitializeComponent();
           
        }

        private void FormRetrieve_Load(object sender, EventArgs e)
        {
            Database.displaySearchlookupEdit("SELECT * FROM view_MasterListInfo", txtchaptercountries, "MUNICIPALITY", "MUNICIPALITY");
            Database.displayComboBoxItems("SELECT * FROM Chapters", "ChapterName", comboBox1);
            pictureBox1.Image = null;
            //con = new SqlConnection(constring);
            //com = new SqlCommand("SELECT * FROM Members", con);
            //con.Open();
            //SqlDataReader reader = com.ExecuteReader();
            //try
            //{
            //    while (reader.Read())
            //    {
            //        listBox1.Items.Add(reader["ID"].ToString());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.StackTrace.ToString());
            //}
            //finally
            //{
            //    con.Close();
            //}
        }

        private String getChapterID()
        {
            string str = Database.getSingleQuery("Chapters", "ChapterName='" + comboBox1.Text + "'", "ChapterID");
            return str;
        }
      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            con = new SqlConnection(constring);
            com = new SqlCommand("SELECT * FROM view_RetrieveMember2 WHERE ID = '" + listBox1.SelectedItem + "'", con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    
                    //pictureBox3.Image = Image.FromStream(ms);
                    //pictureBox4.Image = Image.FromStream(ms2);
                    //label1.Text = UppercaseFirst(reader["FirstName"].ToString()) + " " + UppercaseFirst(reader["LastName"].ToString());
                    lblname.Text = UppercaseFirst(reader["FNAME"].ToString()) + " " + UppercaseFirst(reader["LNAME"].ToString());
                    //lblchapter.Text = reader["ChapterName"].ToString();
                    label2.Text = reader["ID"].ToString();
                    //lblprovince.Text = reader["Region"].ToString();
                    //barCodeControl1.Text = reader["Barcode"].ToString();
                    //qrcode.Text = reader["Barcode"].ToString();

                    txtid.Text = reader["ID"].ToString();
                    txtfname.Text = reader["FNAME"].ToString();
                    txtmname.Text = reader["MNAME"].ToString();
                    txtlname.Text = reader["LNAME"].ToString();
                    txtregion.Text = reader["Region"].ToString();
                    txtchapter.Text = reader["CHAPTERNAME"].ToString();
                    txtaddress.Text = reader["ADDRSS"].ToString();
                    txtbdate.Text = Convert.ToDateTime(reader["BDATE"].ToString()).ToShortDateString();
                    //txtdateissued.Text = reader["DateIssued"].ToString();
                    //txtdatesurvived.Text = Convert.ToDateTime(reader["DateSurvive"].ToString()).ToShortDateString() ;
                    txtmobileno.Text = reader["MOBILENO"].ToString();
                    txtprovince.Text = reader["PROVINCE"].ToString();
                    txtsssno.Text = reader["SSSNO"].ToString();
                    txttinno.Text = reader["TINNO"].ToString();
                    txtbloodtype.Text = reader["BLOODTYPE"].ToString();
                    txtcontactpersonfullname.Text = reader["CONTACTPERSONNAME"].ToString();
                    txtcontactpersonmobileno.Text = reader["CONTACTPERSONMOBILENO"].ToString();
                    txtcontactpersonaddress.Text = reader["CONTACTPERSONADD"].ToString();

                    byte[] picarr = null;
                    byte[] sigarr = null;

                    if (String.IsNullOrEmpty(Convert.ToString(reader["Photo"])))
                    {
                        picarr = null;
                    }
                    else
                    {
                        picarr = (byte[])reader["Photo"];
                        ms = new MemoryStream(picarr);
                        ms.Seek(0, SeekOrigin.Begin);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    if (String.IsNullOrEmpty(Convert.ToString(reader["Signature"])))
                    {
                        sigarr = null;
                    }
                    else
                    {
                        sigarr = (byte[])reader["Signature"];
                        ms2 = new MemoryStream(sigarr);
                        ms2.Seek(0, SeekOrigin.Begin);
                        pictureBox5.Image = Image.FromStream(ms2);
                    }
                    pic1by1.Image = Image.FromStream(ms);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            con = new SqlConnection(constring);
            com = new SqlCommand("SELECT * FROM Members WHERE Chapter = '" + comboBox1.Text + "'", con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["Barcode"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public void createDirectoryFolder(string filepath)
        {
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
        }
        void preview()
        {
            try
            {
                string reportPath = "C:\\ImageFile\\"+txtid.Text+"\\";

                createDirectoryFolder(reportPath);
                string imageFilename = txtid.Text + "-F.png";
                string filetoprint = reportPath + imageFilename;
                XtraReport1 xct = new XtraReport1();

                xct.lblname.Text = txtfname.Text.ToUpper() + " " + txtlname.Text.ToUpper();
                xct.lblchapter.Text = txtchapter.Text.ToUpper();
                xct.lblprovince.Text = txtprovince.Text.ToUpper();
                xct.xrBarCode1.Text = txtid.Text;
                xct.xrPictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();

                //xct.xrname.Text = txtfname.Text + " " + txtlname.Text;
                //xct.xrbirthdate.Text = txtbdate.Text;
                //xct.xrchapter.Text = comboBox2.Text;
                //xct.xrdatesurvived.Text = txtdatesurvive.Text;
                //xct.xrPictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
                //xct.xrBarCode1.Text = txtid.Text;

                ImageExportOptions imageOptions = xct.ExportOptions.Image;
                imageOptions.Format = ImageFormat.Png;
                imageOptions.Resolution = 300;
                // Export the report to Image.
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

        void preview2()
        {
            try
            {
                string reportPath = "C:\\ImageFile\\" + txtid.Text+"\\";

                createDirectoryFolder(reportPath);
                string imageFilename = txtid.Text + "-B.png";
                string filetoprint = reportPath + imageFilename;
                XtraReport2 xct = new XtraReport2();

                xct.xridno.Text = txtid.Text;
                //xct.xrsssno.Text = txtsssno.Text;
                //xct.xrtinno.Text = txttinno.Text;
                xct.xrmobileno.Text = txtmobileno.Text;
                xct.xrbloodtype.Text = txtbloodtype.Text;
                xct.xrbdate.Text = Convert.ToDateTime(txtbdate.Text).ToShortDateString();
                xct.xraddress.Text = txtaddress.Text;

                xct.xrcontactpersonfullname.Text = txtcontactpersonfullname.Text;
                xct.xrcontactpersonaddress.Text = txtcontactpersonaddress.Text;
                xct.xrcontactpersonmobileno.Text = txtcontactpersonmobileno.Text;

                //xct.xrname.Text = txtfname.Text + " " + txtlname.Text;
                //xct.xrbirthdate.Text = txtbdate.Text;
                //xct.xrchapter.Text = comboBox2.Text;
                //xct.xrdatesurvived.Text = txtdatesurvive.Text;
                //xct.xrPictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
                //xct.xrBarCode1.Text = txtid.Text;

                ImageExportOptions imageOptions = xct.ExportOptions.Image;
                imageOptions.Format = ImageFormat.Png;
                imageOptions.Resolution = 300;
                // Export the report to Image.
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
        private void button1_Click(object sender, EventArgs e)
        {
            preview();
            //string reportPath = "c:\\Test.png";
            //IDPrinting xct = new IDPrinting();
            //xct.Landscape = false;
            ////xct.PaperKind = System.Drawing.Printing.PaperKind.A4;
            ////xct.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 100);


            //xct.xrname.Text = txtfname.Text+" "+txtlname.Text;
            //xct.xrLabel2.Text = txtid.Text;
            //xct.xrPictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
            //xct.xrsignature.Image = (Bitmap)pictureBox5.Image.Clone();
            //xct.xrBarCode1.Text = "0";

            //ImageExportOptions imageOptions = xct.ExportOptions.Image;
            //imageOptions.Format = ImageFormat.Png;
            //imageOptions.Resolution = 300;
            //// Export the report to Image.
            //xct.ExportToImage(reportPath);

            //// Show the result.
            //StartProcess(reportPath);
            ////xct.xrBarCode3.Text = txtregion.Text + txtchapter.Text + txtid.Text;
            ////xct.xrBarCode2.Text = txtregion.Text + txtchapter.Text + txtid.Text;
            //ReportPrintTool report = new ReportPrintTool(xct);
            
            //report.ShowRibbonPreviewDialog();
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

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            object chaptercode = SearchLookUpClass.getSingleValue(searchLookUpEdit1, "ChapterID");
            listBox1.Items.Clear();
            con = new SqlConnection(constring);
            com = new SqlCommand("SELECT ID FROM MembershipInfo WHERE ChapterCode = '" + chaptercode + "'", con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void txtchaptercountries_EditValueChanged(object sender, EventArgs e)
        {
            municipalitycode = SearchLookUpClass.getSingleValue(txtchaptercountries, "MUNICIPALITY_CODE");
            var row = Database.getMultipleQuery("view_MasterListInfo", "MUNICIPALITY_CODE='" + municipalitycode.ToString() + "'", "COUNTRY_CODE,ZIPCODE");
            countrycode = row["COUNTRY_CODE"].ToString();
            zipcode = row["ZIPCODE"].ToString();
            Database.displaySearchlookupEdit("SELECT distinct a.ChapterID" +
                ",a.ChapterName " +
                "FROM Chapters as a " +
                "INNER JOIN MembershipInfo as b " +
                "ON b.ChapterCode=a.ChapterID " +
                "WHERE a.ChapterName is not null " +
                "AND b.ChapterCountryCode='"+countrycode+"' " +
                "AND b.ChapterZipCode='"+zipcode+"' ", searchLookUpEdit1, "ChapterName", "ChapterName");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            preview2();
        }
    }
}