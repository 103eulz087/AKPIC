using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDProject.ChapterForms
{
    public partial class ChapterLogo : Form
    {
        byte[] myPicbyte;
        PictureBox pbox;
        public ChapterLogo()
        {
            InitializeComponent();
        }

        private void ChapterLogo_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picimage.Image = Image.FromFile(dialog.FileName);

            }
        }

        void execute()  
        {
            //SqlConnection con = new SqlConnection(constring);
            SqlConnection con = Database.getConnection();
            con.Open();
            try
            { 
                string query = "spfunc_uploadChapterLogo";
                SqlCommand com = new SqlCommand(query, con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@parmchapterid", UserLogin.chapterID); //concat regcode,provcode,muncode,zipcode,chaptercode
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
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            execute();
            XtraMessageBox.Show("Success");
        }
    }
}
