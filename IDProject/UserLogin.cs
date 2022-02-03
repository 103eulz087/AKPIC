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
using Microsoft.Win32;
using System.Data.SqlClient;

namespace IDProject
{
    public partial class UserLogin : DevExpress.XtraEditors.XtraForm
    {
        public static string assignedBranch, Fullname, isMaker, isChecker, isglobalPOS, isglobalAccounting, iscashBegin, isglobalUserID, isglobalAdmin, isglobalOfficer, isglobalBranchOfficer, isglobalWarehouseOfficer, isCashier, isglobalApprover, glacctcode, cashinlimit, cashendlimit;
        public static string id, fname, lname, chptrcntrycode, chptrregcode, chptrprovcode, chptrmuncode, chptrzipcode, chptrcode,isIC,chapterID;
       
        RegistryKey regkey;
        string password;


        string encryptedpassword;

        private void txtuserid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
            }
        }

        string decryptedpassword;
        //string strmenuInventory;
        String constr;
        public static string userid;
        public static string serverpassword;
        public static string servername;
        public static string dbname;
        public static string connsettings;
        public UserLogin()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool functionReturnValue = false;
            if (keyData == (Keys.O | Keys.Control)) //PAYMENT
            {
                Connection C = new Connection();
                C.ShowDialog(this);
                this.Opacity = 0;
            }
            return functionReturnValue;
        }
        private void UserLogin_Load(object sender, EventArgs e)
        {
            try
            {

                regkey = Registry.CurrentUser.CreateSubKey(@"AIS\ConnSettings");
                if (regkey.GetValue("dbconn") == null)
                {
                    Connection C = new Connection();
                    C.ShowDialog();
                    this.Opacity = 0;
                    return;
                }
                else
                {
                    constr = regkey.GetValue("dbconn").ToString();
                    userid = regkey.GetValue("serverid").ToString();
                    serverpassword = regkey.GetValue("serverpassword").ToString();
                    dbname = regkey.GetValue("dbname").ToString();
                    servername = regkey.GetValue("servername").ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtuserid.Text.Trim() == "")
            {
                XtraMessageBox.Show("User id is required.");
                return;
            }
            if (txtpassword.Text.Trim() == "")
            {
                XtraMessageBox.Show("Password is required.");
                return;
            }
            get_password();
            //validate_user();
        }

        private void get_password()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            SqlCommand com = new SqlCommand("Select Password from vw_Users where Username = '" + txtuserid.Text + "'", con);
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        password = reader["Password"].ToString();
                        decrypt_password();
                        return;
                    }
                }
                XtraMessageBox.Show("Invalid user id or password given.", "IT Core Solutions Inc.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtpassword.Focus();
                txtpassword.SelectionStart = 0;
                txtpassword.SelectionLength = txtpassword.Text.Length;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void decrypt_password()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            SqlCommand com = new SqlCommand("declare @pwd varchar(50) exec master..xp_aes_decrypt '" + password + "','0123456789ABCDEF0123456789ABCDEF',@pwd output select @pwd result", con);
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        decryptedpassword = reader["result"].ToString();
                        validate_user();
                    }
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
        }
        private void encrypt()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            SqlCommand com = new SqlCommand("exec master..xp_aes_encrypt '" + txtpassword.Text + "','0123456789ABCDEF0123456789ABCDEF'", con);
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        encryptedpassword = reader["result"].ToString();
                        validate_user();
                    }
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
        }
        private void validate_user()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            SqlCommand com = new SqlCommand("Select * from vw_Users where Username= '" + txtuserid.Text + "' and Password = '" + password + "'", con);
            SqlDataReader reader = com.ExecuteReader();


            try
            {
                
               // string company = Database.getSingleQuery("CompanyProfile", "CompanyName <> ''", "CompanyName");
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        id = reader["UserID"].ToString();
                        userid = reader["Username"].ToString();
                        fname = reader["FirstName"].ToString();
                        lname = reader["LastName"].ToString();
                        chptrcntrycode = reader["ChapterCountryCode"].ToString();
                        chptrregcode = reader["ChapterRegionCode"].ToString();
                        chptrprovcode = reader["ChapterProvinceCode"].ToString();
                        chptrmuncode = reader["ChapterMunicipalityCode"].ToString();
                        chptrzipcode = reader["ChapterZipCode"].ToString();
                        chptrcode = reader["ChapterCode"].ToString();
                        isIC = reader["isIC"].ToString();
                        chapterID = reader["ChapterID"].ToString();
                        if (txtpassword.Text != decryptedpassword)
                        {
                            XtraMessageBox.Show("Invalid user id or password given.", "IT Core Solutions Inc.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            txtuserid.Focus();
                            return;
                        }
                        else
                        {
                            this.Hide();
                            //MainDashboard m = new MainDashboard();
                            Form1 m = new Form1();
                            m.Show();
                            return;
                        }


                    }
                }
                else
                {
                    XtraMessageBox.Show("Invalid user id or password given.", "IT Core Solutions Inc.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtpassword.Focus();
                    txtpassword.SelectionStart = 0;
                    txtpassword.SelectionLength = txtpassword.Text.Length;
                    return;
                }
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


        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                     if (txtuserid.Text.Trim() == "")
                    {
                        XtraMessageBox.Show("User id is required.", "ITCore Solutions Inc.");
                        return;
                    }
                    if (txtpassword.Text.Trim() == "")
                    {
                        XtraMessageBox.Show("Password is required.", "ITCore Solutions Inc.");
                        return;
                    }
                    get_password();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }
        
    }
}