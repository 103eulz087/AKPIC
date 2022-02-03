using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDProject.Classes
{
    public class HelperFunction
    {
        public static string convertToNumericFormat(double value)
        {
            string str = "";
            str = String.Format("{0:0,0.00}", value);
            return str;
        }

        public static string numericFormat(double value)
        {
            string str = "";
            str = String.Format("{0:n2}", value);
            return str;
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
        public static byte[] GetImageDevEx(XRPictureBox pictureBox1, string tableName, string condition, string ImageColName)
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
    }
}
