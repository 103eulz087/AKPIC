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

namespace IDProject  //EULZDESKTOP738
{
    //serial xps
    public partial class AddSerial : DevExpress.XtraEditors.XtraForm
    {
        string id, serialkey;
        public AddSerial()
        {
            InitializeComponent();
        }

        private void AddSerial_Load(object sender, EventArgs e)
        {
            populate();
            display();//display
        }

        void populate()
        {
            Database.displaySearchlookupEdit("SELECT ID,FirstName,LastName FROM Members", searchLookUpEdit1, "ID", "ID");
        }
        void add()
        {
            bool isexists = Database.checkifExist("SELECT MemberID FROM PhoneSerial WHERE MemberID='" + searchLookUpEdit1.Text + "'");
            if(String.IsNullOrEmpty(txtaddress.Text) && String.IsNullOrEmpty(searchLookUpEdit1.Text))
            {
                MessageBox.Show("Please Fill Out All Fields");
                return;
            }
            else if(isexists==true)
            {
                MessageBox.Show("This ID Already Exists");
                return;
            }
            else
            {
                Database.ExecuteQuery("INSERT INTO PhoneSerial VALUES('" + searchLookUpEdit1.Text + "','" + txtaddress.Text + "')", "Succesfully Added");
            }
        }
        void display()
        {
            Database.display("SELECT * FROM PhoneSerial", gridControl2,gridView2);
        }

        private void gridControl2_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(gridControl2, e.Location);
            }
        }

        private void editDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MemberID").ToString();
            serialkey = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SerialNo").ToString();
            searchLookUpEdit1.Text = id;
            txtaddress.Text = serialkey;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtaddress.Text) && String.IsNullOrEmpty(searchLookUpEdit1.Text))
            {
                MessageBox.Show("Please Fill Out All Fields");
                return;
            }
            else
            {
                Database.ExecuteQuery("UPDATE PhoneSerial SET SerialNo='" + txtaddress.Text + "' WHERE MemberID='" + id + "'", "Successfully Updated!!!...");
                searchLookUpEdit1.Text = "";
                txtaddress.Text = "";
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            add();
            display();
            searchLookUpEdit1.Text = "";
            txtaddress.Text = "";
        }
    }
}