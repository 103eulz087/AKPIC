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

namespace IDProject.ChapterForms
{
    public partial class Meetings : DevExpress.XtraEditors.XtraForm
    {
        string mtngid;
        string mtngagenda,mtngdate, mtngremarks;
        public Meetings()
        {
            InitializeComponent();
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }
        void clear()
        {
            txtmainagenda.Text = "";
            txtmeetingdate.Text = "";
            txtmeetingid.Text = "";
            txtremarks.Text = "";
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
        private void btnnew_Click(object sender, EventArgs e)
        {
            enablefields();
            display();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
            btnupdate.Enabled = false;
            btncancel.Enabled = true;
            int newid = IDGenerator.getIDNumber("Meetings", "ID is not null", "ID");
            txtmeetingid.Text = newid.ToString();
        }
        void display()
        {
            Database.display($"SELECT * FROM vw_Meetings ORDER BY MeetingDate", gridControl1, gridView1);
        }

        private void Meetings_Load(object sender, EventArgs e)
        {
            display(); disablefields();
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

            bool ok = Database.checkifExist("SELECT TOP(1) ID FROM Meetings WHERE ID='" + txtmeetingid.Text.Trim() + "' ");
            if (ok)
            {
                XtraMessageBox.Show("Already Exist in Meetings Table.. Please use Edit Function");
                return;
            }
            else if(String.IsNullOrEmpty(txtmainagenda.Text) || String.IsNullOrEmpty(txtmeetingdate.Text) || String.IsNullOrEmpty(txtmeetingid.Text) || String.IsNullOrEmpty(txtremarks.Text))
            {
                XtraMessageBox.Show("Please input all fields...");
                return;
            }
            else
            {
                Database.ExecuteQuery($"INSERT INTO Meetings VALUES('{txtmeetingid.Text}','{txtmainagenda.Text}','{txtremarks.Text}','{txtmeetingdate.Text}',0,0,0,'{DateTime.Now.ToShortDateString()}','{UserLogin.userid}')", "Successfully Added");
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
            addtt.txtreferenceid.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"ID").ToString();
            addtt.txtreferencecode.Text = "MTNG-"+gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"ID").ToString();
            addtt.ShowDialog(this);
            if(AddAttendance.isdone == true)
            {
                addtt.Dispose();
                display();
            }
        }

        private void viewMeetingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMeetingDetails viewmetdet = new ViewMeetingDetails();
            Database.display($"SELECT ID,LastName, FirstName, FundsAmount,Status FROM vw_MeetingAndAttendanceDetails WHERE MeetingID='{gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString()}'", viewmetdet.gridControl1, viewmetdet.gridView1);
            var rowz = Database.getMultipleQuery("Meetings", $"ID='{gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString()}'", "Particulars");
            string remarks = rowz["Particulars"].ToString();
            viewmetdet.lblmeetingid.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            viewmetdet.lblmeetingdate.Text = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MeetingDate").ToString()).ToShortDateString();
            viewmetdet.lblagenda.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MainAgenda").ToString();
            viewmetdet.lblremarks.Text = remarks;
            viewmetdet.lblpresent.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TotalPresent").ToString();
            viewmetdet.lblabsent.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TotalAbsent").ToString();
            viewmetdet.lblfundscollected.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TotalFunds").ToString();
            viewmetdet.ShowDialog(this);
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
                Database.ExecuteQuery($"UPDATE Meetings SET MainAgenda='{txtmainagenda.Text}',Particulars='{txtremarks.Text}',MeetingDate='{txtmeetingdate.Text}' " +
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
            mtngagenda = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MainAgenda").ToString();
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
    }
}