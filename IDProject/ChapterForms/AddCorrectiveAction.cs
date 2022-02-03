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
    public partial class AddCorrectiveAction : Form
    {
        object id = null;
        string memberid, remarks;
        public AddCorrectiveAction()
        {
            InitializeComponent();
        }

        private void AddCorrectiveAction_Load(object sender, EventArgs e)
        {
            populate(); display();
        }
        void clear()
        {
            txtmember.Text = "";
            txtremarks.Text = "";
        }
        void disablefields()
        {
            txtmember.Enabled = false;
            txtremarks.Enabled = false;
            
        }
        void enablefields()
        {
            txtmember.Enabled = true;
            txtremarks.Enabled = true;
        }
        void populate()
        {
            Database.displaySearchlookupEdit("SELECT ID,FirstName,LastName FROM Members", txtmember, "FirstName", "FirstName");
        }
        void display()
        {
            Database.display("SELECT * FROM vw_CorrectiveActions WHERE isClear=1", gridControl1, gridView1);
        }

        private void txtmember_EditValueChanged(object sender, EventArgs e)
        {
            id = SearchLookUpClass.getSingleValue(txtmember, "ID");
        }

        void Add()
        {
            
            Database.ExecuteQuery($"INSERT INTO CorrectiveActions VALUES ('{id.ToString()}','{txtremarks.Text}','{DateTime.Now.ToString()}','PENDING','0')","Successfully Added");
        }
      
        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
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
            if (String.IsNullOrEmpty(txtmember.Text) || String.IsNullOrEmpty(txtremarks.Text))
            {
                XtraMessageBox.Show("Fields must not Empty");
            }
            else
            {
                Add();
                display();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery($"UPDATE CorrectiveActions SET Remarks='{txtremarks.Text}'  " +
                $"WHERE ID='{memberid}'  ", "Successfully Updated!");
            clear();
            disablefields();
            btnnew.Enabled = true;
            btnadd.Enabled = false;
            btnupdate.Enabled = false;
            btncancel.Enabled = false;
            display();
        }

        private void resolvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery($"UPDATE CorrectiveActions SET isClear=1,Status='SOLVED'  " +
              $"WHERE ID='{memberid}'  ", "Successfully Updated!");
            display();
        }

        private void unresolvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery($"UPDATE CorrectiveActions SET isClear=0,Status='PENDING'  " +
            $"WHERE ID='{memberid}'  ", "Successfully Updated!");
            display();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberid = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            remarks = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Remarks").ToString();
            txtmember.Text = memberid;
            txtremarks.Text = remarks;
        }
    }
}
