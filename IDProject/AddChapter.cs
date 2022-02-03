using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDProject //EULZDESKTOP738
{
    public partial class AddChapter : Form
    {
        public static bool isdone = false;
        public AddChapter()
        {
            InitializeComponent();
        }

        private void AddChapter_Load(object sender, EventArgs e)
        {
            display();
        }

        void display()
        {
            Database.display("SELECT ChapterID,ChapterName FROM Chapters ORDER BY ChapterID", gridControl2, gridView2);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            int id = Database.getLastID("Chapters", "ChapterID");
            int newvalid = id + 1;
            string newid = Database.sequencePadding1(newvalid.ToString(), 4);
            bool isexists = Database.checkifExist("SELECT TOP 1 ChapterName FROM Chapters WHERE ChapterName='" + txtaddress.Text.Trim() + "'");
            if (isexists)
            {
                MessageBox.Show("This Chapter Name is Already Exists");
                return;
            }
            else
            {
                Database.ExecuteQuery("INSERT INTO Chapters(ChapterName,ChapterID) VALUES('" + txtaddress.Text.Trim() + "','" + newid + "') ","Successfully Added");
                display();
                isdone = true;
                this.Close();
            }
        }

        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                simpleButton4.PerformClick();
        }
    }
}
