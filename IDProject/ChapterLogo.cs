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
using System.Drawing.Imaging;
using DevExpress.XtraPrinting;

namespace IDProject
{
    public partial class ChapterLogo : DevExpress.XtraEditors.XtraForm
    {
        static string constring = "Data Source=43.226.6.184;Initial Catalog=QRDB2;User ID=enduser;Password=1234567890;";
        object chaptercountrycode;
        object chapterregioncode;
        object chapterprovinceccode;
        object chaptermunicipalitycode;
        object chapterzipcode;
        object chapterid;
        byte[] myPicbyte;
        public ChapterLogo()
        {
            InitializeComponent();
        }

        private void ChapterLogo_Load(object sender, EventArgs e)
        {
            populateCountry();
        }
        void populateCountry()
        {
            Database.displaySearchlookupEdit("SELECT COUNTRY_CODE,COUNTRY_NAME FROM Countries WHERE COUNTRY_CODE='63'", txtchaptercountries, "COUNTRY_NAME", "COUNTRY_NAME");
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            execute();
            Utilities.ClearFields(groupBox3);
        }

        void execute() //1 for ADD 2 UPDATE
        {

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            try
            {
                string query = "sp_insertchapterlogo";
                SqlCommand com = new SqlCommand(query, con);
                com.CommandType = CommandType.StoredProcedure;
                //com.Parameters.AddWithValue("@parmseqno", Convert.ToInt32(txtrollno.Text));
                com.Parameters.AddWithValue("@parmcountry", txtchaptercountrycode.Text);
                com.Parameters.AddWithValue("@parmregion", txtchapterregioncode.Text);
                com.Parameters.AddWithValue("@parmprov", txtchapterprovincecode.Text);
                com.Parameters.AddWithValue("@parmmun", txtchaptermunicipalitycode.Text);
                com.Parameters.AddWithValue("@parmzip", txtchapterzipcode.Text);
                com.Parameters.AddWithValue("@parmchapcode", chapterid.ToString());
                if (picimage.Image != null)
                {
                    MemoryStream ms11 = new MemoryStream();
                    picimage.Image.Save(ms11, ImageFormat.Jpeg);
                    myPicbyte = new byte[ms11.Length];
                    ms11.Position = 0;
                    ms11.Read(myPicbyte, 0, myPicbyte.Length);
                    com.Parameters.AddWithValue("@photo", myPicbyte);
                }
              
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
        public void createDirectoryFolder(string filepath)
        {
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
        }
        void exportimage()
        {
            try
            {
                string id = txtchaptercountrycode.Text + txtchapterregioncode.Text + txtchapterprovincecode.Text + txtchaptermunicipalitycode.Text + txtchapterzipcode.Text + chapterid.ToString();

                string reportPath = "C:\\AKPCHAPTERLOGOS\\";
                createDirectoryFolder(reportPath);

                string imageFilename = id + ".jpg";
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

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picimage.Image = Image.FromFile(dialog.FileName);

            }
        }
    }
}