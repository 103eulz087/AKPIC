using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class RetrieveMember : Form
    {
        //static string constring = "Data Source=127.0.0.1;Initial Catalog=akpidproject;User ID=eulz;Password=123456;";

        static string constring = "Data Source=(local);Initial Catalog=QRDB2;User ID=eulz;Password=123123;";
        SqlConnection con;
        SqlCommand com;
        MemoryStream ms, ms2;
        int isStart = 0;
        public RetrieveMember()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void RetrieveMember_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (DateTime.Now.ToString("tt") == "AM")
            {
                greetings.Text = "Good Morning! :-)";
            }
            else if (DateTime.Now.ToString("tt") == "PM")
            {
                greetings.Text = "Good Afternoon!";
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                retrieve();
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        void retrieve()
        {
            string stat = ""; 
            con = new SqlConnection(constring);
            com = new SqlCommand("SELECT a.ID,a.FirstName" +
                ",a.MiddleName" +
                ",a.LastName" +
                ",b.ChapterName" +
                ",a.Photo" +
                ",b.isActive" +
                ",b.LastActiveDate " +
                " FROM Members as a " +
                " INNER JOIN view_MembershipBasicInfo as b " +
                " ON a.ID=b.ID" +
                " WHERE a.ID = '" + textBox1.Text+ "' ", con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    if (reader["Photo"] == System.DBNull.Value)
                    {
                        //pictureBox1.Image = null;
                        pictureBox3.Image = null;
                    }
                    else
                    {
                        //if(isStart==4)
                        //{
                        //    isStart = 0;
                        //}

                        if (isStart == 1 && pictureBox3.Image != null)
                        {
                            pictureBox4.Image = pictureBox3.Image;
                        }
                        else if (isStart == 2 && pictureBox4.Image != null)
                        {
                            pictureBox5.Image = pictureBox4.Image;
                            pictureBox4.Image = pictureBox3.Image;
                        }
                        else if (isStart == 3 && pictureBox5.Image != null)
                        {
                            pictureBox6.Image = pictureBox5.Image;
                            pictureBox5.Image = pictureBox4.Image;
                            pictureBox4.Image = pictureBox3.Image;
                        }
                        else if (isStart > 3 && pictureBox5.Image != null)
                        {
                            pictureBox6.Image = pictureBox5.Image;
                            pictureBox5.Image = pictureBox4.Image;
                            pictureBox4.Image = pictureBox3.Image;
                        }


                        //if (pictureBox5.Image != null && isStart >= 3)
                        //{
                        //    pictureBox6.Image = pictureBox5.Image;

                        //}
                        //if (pictureBox4.Image != null && isStart >= 2)
                        //{
                        //    pictureBox5.Image = pictureBox4.Image;

                        //}
                        //if (pictureBox3.Image != null && isStart > 0)
                        //{
                        //    pictureBox4.Image = pictureBox6.Image;

                        //}

                        byte[] picarr = (byte[])reader["Photo"];
                        //byte[] sigarr = (byte[])reader["Signature"];

                        ms = new MemoryStream(picarr);
                        ms.Seek(0, SeekOrigin.Begin);
                        //ms2 = new MemoryStream(sigarr);
                        //ms2.Seek(0, SeekOrigin.Begin);

                        this.pictureBox3.Size = new System.Drawing.Size(400, 400);
                        pictureBox3.Image = Image.FromStream(ms);
                        //pictureBox1.Image = Image.FromStream(ms2);
                        isStart += 1;
                     
                    }
                   
                    if (Convert.ToBoolean(reader["isActive"].ToString()) == true)
                    {
                        stat = "ACTIVE";
                    }
                    else
                    {
                        stat = "INACTIVE";
                    }
                    //chaptername = getChapterName(reader["ChapterName"].ToString());
                    
                    txtname.Text = UppercaseFirst(reader["FirstName"].ToString()) + " " + UppercaseFirst(reader["LastName"].ToString());
                    txtchapter.Text = reader["ChapterName"].ToString();
                    txtstatus.Text = stat; 
                    txtdateexpired.Text = Convert.ToDateTime(reader["LastActiveDate"].ToString()).ToShortDateString();  

                }
                else
                {
                    MessageBox.Show("Records Not Found!..");
                    pictureBox3.Image = null;
                    //pictureBox1.Image = null; 
                    txtname.Text = "";
                    txtchapter.Text = "";
                    txtstatus.Text = "";
                    txtdateexpired.Text = "";
                  
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

        private String getChapterName(string val)
        {
            string str = Database.getSingleQuery("Chapters", "ChapterID='" + val + "'", "ChapterName");
            return str;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time;
            DateTime datetime = DateTime.Now;
            time = datetime.ToLongTimeString();
            lblTime.Text = time;

            DateTime now = DateTime.Now;
            datekron.Text = now.ToLongDateString();
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
    }
}
