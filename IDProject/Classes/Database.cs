using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDProject
{
    class Database
    {
        //static string constring = "Data Source=127.0.0.1;Initial Catalog=QRDB2;User ID=sa;Password=123456;";
        static RegistryKey regkey;
        static string constring = "";
        //static string constring = "Data Source=dc.esatpt.com;Initial Catalog=QRDBRHONU;User ID=enduser;Password=1234567890;";
        //static string constring = "Data Source=dc.esatpt.com;Initial Catalog=QRDB2;User ID=enduser;Password=1234567890;";
        //static string constring; = "Data Source=127.0.0.1;Initial Catalog=QRDB2_TEST_IC;User ID=eulz;Password=123123;";
        //static string constring = "Data Source=itcore-apps.com;Initial Catalog=QRDB2;User ID=enduser;Password=1234567890;";
        //static string constring = "Data Source=itcore-apps.com;Initial Catalog=QRDB2_TEST;User ID=enduser;Password=1234567890;";
        //public static SqlConnection getConnection()
        //{
        //    SqlConnection con;
        //    try
        //    {
        //        con = new SqlConnection(constring);
        //    }
        //    catch (SqlException sex)
        //    {
        //        sex.StackTrace.ToString();
        //        return null;
        //    }
        //    return con;
        //}
        public static SqlConnection getConnection()
        {
            //regkey = Registry.CurrentUser.CreateSubKey(@"Enzo\ConnSettings");
            regkey = Registry.CurrentUser.CreateSubKey(@"AIS\ConnSettings");
            constring = regkey.GetValue("dbconn").ToString();
            SqlConnection con;
            try
            {
                con = new SqlConnection(constring);
            }
            catch (SqlException sex)
            {
                sex.StackTrace.ToString();
                return null;
            }
            return con;
        }
        public static void displayComboBoxItems(string query, string col, System.Windows.Forms.ComboBox box)
        {
            box.Items.Clear();
            SqlConnection con = getConnection();
            con.Open();
            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        box.Items.Add(reader[col].ToString());
                    }
                }
            }
            catch (SqlException sex)
            {
                MessageBox.Show(sex.StackTrace.ToString());
            }
            finally
            {
                reader.Close();
                con.Close();
            }
        }

        public static String getSingleQuery(string tablename, string condition, string returnval)
        {
            string str = "";
            SqlConnection con = getConnection();
            con.Open();
            string query = "SELECT TOP(1) "+ returnval + " FROM " + tablename + " with(nolock) WHERE " + condition + " ";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader reader = com.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    str = reader[returnval].ToString();
                }
            }
            return str;
        }

        public static int getLastID(string tableName, string id,string condition)
        {
            int i = 0;
            SqlConnection con = getConnection();
            con.Open();
            string query = "SELECT TOP(1) ISNULL(MAX(CAST(" + id + " as int)),0) AS CC FROM " + tableName+ " with(nolock) WHERE " + condition;
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        i = Convert.ToInt32(reader["CC"].ToString());
                    }
                }
                else
                { i = 1; }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.StackTrace.ToString());
                // throw new Exception(ex.StackTrace.ToString());
            }
            finally
            {
                con.Close();
            }
            return i;
        }
        public static int getLastID(string tableName, string id)
        {
            int i = 0;
            SqlConnection con = getConnection();
            con.Open();
            string query = "SELECT TOP(1) CAST(MAX(" + id + ") as int) AS CC FROM " + tableName;
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        i = Convert.ToInt32(reader["CC"].ToString());
                    }
                }else
                { i = 1; }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.StackTrace.ToString());
                // throw new Exception(ex.StackTrace.ToString());
            }
            finally
            {
                con.Close();
            }
            return i;
        }
        public static void displaySearchlookupEdit(string query, SearchLookUpEdit searchEdit, string displaymember, string valuemember)
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            try
            {
                SqlCommand com = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataTable table = new DataTable();

                searchEdit.Properties.View.Columns.Clear();
                adapter.Fill(table);
                searchEdit.Properties.DataSource = null;
                searchEdit.Properties.DataSource = table;
                searchEdit.Properties.DisplayMember = displaymember;
                searchEdit.Properties.ValueMember = valuemember;
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
        public static int getCountData(string tablename, string condition, string id)
        {
            int ctr = 0;
            SqlConnection con = getConnection();
            con.Open();
            try
            {
                string query = "SELECT TOP(1) COUNT(" + id + ") AS Counter FROM " + tablename + " with(nolock) WHERE " + condition + " ";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        ctr = Convert.ToInt32(reader["Counter"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                con.Close();
            }
            return ctr;
        }
        public static double getTotalSummation2(string tablename, string condition, string id)
        {
            double ctr = 0.0;
            SqlConnection con = getConnection();
            con.Open();
            string query = "SELECT TOP(1) ISNULL(SUM(" + id + "),0) AS Totals FROM " + tablename + " with(nolock) WHERE " + condition + " ";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        ctr = Convert.ToDouble(reader["Totals"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace.ToString());
            }
            finally
            {
                con.Close();
            }

            return ctr;
            // con.Close();
        }
        public static Object getSingleValue(SearchLookUpEdit searchLookUpEdit1, string fieldname)
        {
            object value;
            GridView view = searchLookUpEdit1.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName = fieldname; // or other field name
            value = view.GetRowCellValue(rowHandle, fieldName);
            return value;
        }
        public static void display(string query, GridControl cont, GridView view)
        {
            SqlConnection con = getConnection();
            con.Open();
            //  cont.BeginUpdate();
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            try
            {
                com.CommandTimeout = 180;
                view.Columns.Clear();
                cont.DataSource = null;
                adapter.Fill(table);
                //table.Columns.Add("OvertimeType");
                cont.DataSource = table;
                view.BestFitColumns();
            }
            catch (SqlException ee)
            {
                XtraMessageBox.Show(ee.ToString());
            }
            finally
            {
                //cont.EndUpdate();
                con.Close();
            }
        }

        public static bool checkifExist(string query)
        {
            bool result = false;
            SqlConnection con = getConnection();
            con.Open();
            //try
            //{
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            //}
            //catch(SqlException ex)
            //{
            //    XtraMessageBox.Show(ex.Message.ToString());
            //}
            //finally
            //{
            con.Close();
            //}

            return result;
        }
        public static void ExecuteQuery(string query, string msg)
        {
            SqlConnection con = getConnection();
            con.Open();
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            XtraMessageBox.Show(msg);
            con.Close();
        }
        public static void ExecuteQuery(string query)
        {
            SqlConnection con = getConnection();
            con.Open();
            try
            {
                SqlCommand com = new SqlCommand(query, con);
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
        public static String sequencePadding1(string reference, int max)
        {
            string isnum = "";
            string str = reference;
            for (int i = 1; i <= max - str.Length - 1; i++)
            {
                isnum = isnum + "0";
            }

            return isnum + str;
        }
        public static Dictionary<string, object> getMultipleQuery(string tablename, string condition, string returnval) // ID, Name
        {
            string str = "";
            SqlConnection con = getConnection();
            con.Open();
            string query = "SELECT TOP(1) " + returnval + " FROM " + tablename + " with(nolock) WHERE " + condition + " ";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader reader = com.ExecuteReader();

            Dictionary<string, object> dic = new Dictionary<string, object>();
            if (reader != null)
            {
                while (reader.Read())
                {
                    //str = reader[returnval].ToString();
                    dic = ToDictionary(reader);
                }
                reader.Close();
            }
            con.Close();
            return dic;
        }

        public static Dictionary<string, object> ToDictionary(System.Data.SqlClient.SqlDataReader row)
        {
            string name = "";
            lock (name)
            {
                var dic = new Dictionary<string, object>();
                for (int i = 0; i < row.FieldCount; i++)
                {
                    name = row.GetName(i); dic[name] = (object)row[name];
                }
                return dic;
            }
        }

        public static byte[] GetImageDevEx(XRPictureBox pictureBox1, string tableName, string condition, string ImageColName)
        {
            byte[] img = null;
            pictureBox1.Image = null;
            SqlConnection con = Database.getConnection();
            con.Open();
            try
            {
                string query = "select TOP(1) "+ ImageColName + " FROM " + tableName + " with(nolock) WHERE " + condition + " ";
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
        public static DataTable GetDatatable(string query)
        {
            SqlConnection con = getConnection();
            con.Open();
            SqlCommand com = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            try
            {
                com.CommandTimeout = 180;
                adapter.Fill(table);
            }
            catch (SqlException ee)
            {
                XtraMessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }
            return table;
        }

    }
}
