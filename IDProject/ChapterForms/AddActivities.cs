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
    public partial class AddActivities : Form
    {
        string mtngid;
        string mtngagenda, mtngdate, mtngremarks;

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        public AddActivities()
        {
            InitializeComponent();
        }

        private void AddActivities_Load(object sender, EventArgs e)
        {
            display(); disablefields();
        }
        void clear()
        {
            txtmainagenda.Text = "";
            txtmeetingdate.Text = "";
            txtmeetingid.Text = "";
            txtremarks.Text = "";
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            enablefields();
            display();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
            btnupdate.Enabled = false;
            btncancel.Enabled = true;
            int newid = IDGenerator.getIDNumber("Activities", "ID is not null", "ID");
            txtmeetingid.Text = newid.ToString();
        }
        void display()
        {
            Database.display($"SELECT * FROM vw_Activities ORDER BY ActivityDate", gridControl1, gridView1);
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
            bool ok = Database.checkifExist("SELECT TOP(1) ID FROM Activities WHERE ID='" + txtmeetingid.Text.Trim() + "' ");
            if (ok)
            {
                XtraMessageBox.Show("Already Exist in Activities Table.. Please use Edit Function");
                return;
            }
            else if (String.IsNullOrEmpty(txtmainagenda.Text) || String.IsNullOrEmpty(txtmeetingdate.Text) || String.IsNullOrEmpty(txtmeetingid.Text) || String.IsNullOrEmpty(txtremarks.Text))
            {
                XtraMessageBox.Show("Please input all fields...");
                return;
            }
            else
            {
                Database.ExecuteQuery($"INSERT INTO Activities VALUES('{txtmeetingid.Text}','{txtmainagenda.Text}','{txtremarks.Text}','{txtmeetingdate.Text}',0,0,0,'{DateTime.Now.ToShortDateString()}','{UserLogin.userid}')", "Successfully Added");
                clear();

                btnnew.Enabled = true;
                btnadd.Enabled = false;
                btnupdate.Enabled = false;
                btncancel.Enabled = false;

                disablefields();
                display();
            }
        }

        private void showAttendeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAttendance addtt = new AddAttendance();
            Database.display("SELECT * FROM vw_Attendance", addtt.gridControl2, addtt.gridView2);
            addtt.txtreferenceid.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            addtt.txtreferencecode.Text = "ACTVTY-" + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            addtt.ShowDialog(this);
            if (AddAttendance.isdone == true)
            {
                addtt.Dispose();
                display();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtmainagenda.Text) || String.IsNullOrEmpty(txtmeetingdate.Text) || String.IsNullOrEmpty(txtmeetingid.Text) || String.IsNullOrEmpty(txtremarks.Text))
            {
                XtraMessageBox.Show("Please input all fields...");
                return;
            }
            else
            {
                Database.ExecuteQuery($"UPDATE Activities SET ActivitySubject='{txtmainagenda.Text}',Particulars='{txtremarks.Text}',ActivityDate='{txtmeetingdate.Text}' " +
              $"WHERE ID='{txtmeetingid.Text}'  ", "Successfully Updated!");
                clear();
                disablefields();
                btnnew.Enabled = true;
                btnadd.Enabled = false;
                btnupdate.Enabled = false;
                btncancel.Enabled = false;
                display();
            }
        }

        private void showMeetingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mtngid = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            mtngagenda = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ActivitySubject").ToString();
            mtngremarks = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Particulars").ToString();
            txtmeetingid.Text = mtngid;
            txtmainagenda.Text = mtngagenda;
            txtmeetingdate.Text = mtngdate;
            txtremarks.Text = mtngremarks;
            enablefields();

            btnnew.Enabled = false;
            btnadd.Enabled = false;
            btnupdate.Enabled = true;
            btncancel.Enabled = true;
        }

        private void viewMeetingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        void disablefields()
        {
            txtmainagenda.Enabled = false;
            txtmeetingdate.Enabled = false;
            txtmeetingid.Enabled = false;
            txtremarks.Enabled = false;
        }
        void enablefields()
        {
            txtmainagenda.Enabled = true;
            txtmeetingdate.Enabled = true;
            txtmeetingid.Enabled = true;
            txtremarks.Enabled = true;
        }
    }
}
