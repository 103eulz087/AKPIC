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

namespace IDProject.Councils
{
    public partial class ICCouncils : Form
    {
        string ID, CouncilName, Country;
        byte[] myPicbyte;
        PictureBox pbox;
        public ICCouncils()
        {
            InitializeComponent();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            enablefields();
            display();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
            btnupdate.Enabled = false;
            btncancel.Enabled = true;
           
        }
        void display()
        {
            Database.display($"SELECT * FROM vw_ICCouncils ORDER BY CouncilName", gridControl1, gridView1);
            gridView1.Columns["ImageLogo"].OptionsColumn.FixedWidth = true;
            gridView1.Columns["ImageLogo"].Width = 100;
            gridView1.RowHeight = 100;
        }
        void clear()
        {
            txtcouncilname.Text = "";
            txtcountry.Text = "";
           
        }
        void disablefields()
        {
            txtcouncilname.Enabled = false;
            txtcountry.Enabled = false;
            
        }
        void enablefields()
        {
            txtcouncilname.Enabled = true;
            txtcountry.Enabled = true;
           
        }
        void execAdd(string action)
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            try
            {
                string query = "spfunc_AddCouncils";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@parmid", ID); //for update only
                com.Parameters.AddWithValue("@parmcouncilname", txtcouncilname.Text);
                com.Parameters.AddWithValue("@parmcountry", txtcountry.Text);
                com.Parameters.AddWithValue("@parmdateadded", DateTime.Now.ToShortDateString());
                com.Parameters.AddWithValue("@parmaddedby", UserLogin.id);
                com.Parameters.AddWithValue("@action", action);
                com.CommandType = CommandType.StoredProcedure; 
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
            catch (SqlException exs)
            { XtraMessageBox.Show(exs.Message.ToString()); }
            finally { con.Close(); }

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            bool ok = Database.checkifExist("SELECT TOP(1) CouncilName FROM ICCouncils WHERE CouncilName='" + txtcouncilname.Text.Trim() + "' ");
            if (ok)
            {
                XtraMessageBox.Show("Already Exist in Donations Table.. Please use Edit Function");
                return;
            }
            else if (String.IsNullOrEmpty(txtcouncilname.Text) || String.IsNullOrEmpty(txtcountry.Text) )
            {
                XtraMessageBox.Show("Please input all fields.");
                return;
            }
            else
            {
                execAdd("ADD");
                clear();
                btnnew.Enabled = true;
                btnadd.Enabled = false;
                btnupdate.Enabled = false;
                btncancel.Enabled = false;

                disablefields();
                display();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();
            disablefields();

            btnnew.Enabled = true;
            btnadd.Enabled = false;
            btnupdate.Enabled = false;
            btncancel.Enabled = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtcouncilname.Text) || String.IsNullOrEmpty(txtcountry.Text))
            {
                XtraMessageBox.Show("Please input all fields.");
                return;
            }
            else
            {
                // Database.ExecuteQuery($"UPDATE ICCouncils SET CouncilName='{txtcouncilname.Text}',Country='{txtcountry.Text}',DateAdded='{DateTime.Now.ToShortDateString()}',AddedBy='{UserLogin.userid}' " +
                //$"WHERE ID='{ID}'  ", "Successfully Updated!");
                execAdd("UPDATE");
                clear();
                disablefields();
                btnnew.Enabled = true;
                btnadd.Enabled = false;
                btnupdate.Enabled = false;
                btncancel.Enabled = false;
                display();
            }
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

        private void ICCouncils_Load(object sender, EventArgs e)
        {
            populate();
            display();
       
        }
        void populate()
        {
            Database.displaySearchlookupEdit("SELECT COUNTRY_NAME FROM Countries", txtcountry, "COUNTRY_NAME", "COUNTRY_NAME");
        }

        private void showMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICMembers icmembers = new ICMembers();
            Database.display("SELECT Photo,ID,RollNumber,FirstName,LastName,BloodType,MobileNo,DateSurvive,ChapterCountryCode,ChapterRegionCode,ChapterProvinceCode " +
                          "FROM view_MasterlistIC WHERE CouncilName='" + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CouncilName").ToString()+"' "
                          , icmembers.gridControl2, icmembers.gridView1);
            icmembers.gridView1.Columns["ChapterCountryCode"].Visible = false;
            icmembers.gridView1.Columns["ChapterRegionCode"].Visible = false;
            icmembers.gridView1.Columns["ChapterProvinceCode"].Visible = false;
            icmembers.gridView1.Columns["Photo"].Width = 100;
            icmembers.ShowDialog(this);
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enablefields();
            ID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            CouncilName = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CouncilName").ToString();
            //Country = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Country").ToString();
            var rowz = Database.getMultipleQuery("ICCouncils", $"ID='{ID}'", "Country");
            string Country = rowz["Country"].ToString();

            populate();
            txtcountry.Text = Country;
            txtcouncilname.Text = CouncilName;
        
            btnnew.Enabled = false;
            btnadd.Enabled = false;
            btnupdate.Enabled = true;
            btncancel.Enabled = true;
        }
    }
}
