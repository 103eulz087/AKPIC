using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDProject.ChapterForms
{
    public partial class AddAnnouncement : Form
    {

        string mtngagenda, mtngdate, mtngremarks,id;
        public AddAnnouncement()
        {
            InitializeComponent();
        }

        private void AddAnnouncement_Load(object sender, EventArgs e)
        {
            display(); disablefields();
        }
        void clear()
        {
            txtmainagenda.Text = "";
            txtmeetingdate.Text = "";

            txtremarks.Text = "";
        }
        void disablefields()
        {
            txtmainagenda.Enabled = false;
            txtmeetingdate.Enabled = false;

            txtremarks.Enabled = false;
        }
        void enablefields()
        {
            txtmainagenda.Enabled = true;
            txtmeetingdate.Enabled = true;

            txtremarks.Enabled = true;
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtmainagenda.Text) || String.IsNullOrEmpty(txtmeetingdate.Text) || String.IsNullOrEmpty(txtremarks.Text))
            {
                XtraMessageBox.Show("Please input all fields...");
                return;
            }
            else
            {
                Database.ExecuteQuery($"INSERT INTO Announcements VALUES('{txtmainagenda.Text}','{txtremarks.Text}','{txtmeetingdate.Text}','{UserLogin.id}','{DateTime.Now.ToShortDateString()}','','{UserLogin.id}','')", "Successfully Added");
                clear();

                btnnew.Enabled = true;
                btnadd.Enabled = false;
                btnupdate.Enabled = false;
                btncancel.Enabled = false;

                disablefields();
                display();
            }
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        private void editDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SeqNo").ToString();
            mtngagenda = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Subject").ToString();
            mtngremarks = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BodyOfMessage").ToString();
            mtngdate = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DateFiled").ToString();
            txtmainagenda.Text = mtngagenda;
            txtmeetingdate.Text = mtngdate;
            txtremarks.Text = mtngremarks;

            btnnew.Enabled = false;
            btnadd.Enabled = false;
            btnupdate.Enabled = true;
            btncancel.Enabled = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtmainagenda.Text) || String.IsNullOrEmpty(txtmeetingdate.Text) || String.IsNullOrEmpty(txtremarks.Text))
            {
                XtraMessageBox.Show("Please input all fields...");
                return;
            }
            else
            {
                Database.ExecuteQuery($"UPDATE Announcements SET Subject='{txtmainagenda.Text}',BodyOfMessage='{txtremarks.Text}',DateFiled='{txtmeetingdate.Text}',UpdatedBy='{UserLogin.id}',DateUpdated='{DateTime.Now.ToShortDateString()}' " +
              $"WHERE ID='{id}'  ", "Successfully Updated!");
                clear();
                disablefields();
                btnnew.Enabled = true;
                btnadd.Enabled = false;
                btnupdate.Enabled = false;
                btncancel.Enabled = false;
                display();
            }
        }

        void display()
        {
            Database.display($"SELECT * FROM vw_Announcements ORDER BY DateFiled", gridControl1, gridView1);
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
    }
}
