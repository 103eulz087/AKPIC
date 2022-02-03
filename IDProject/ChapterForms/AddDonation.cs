using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDProject.ChapterForms
{
    public partial class AddDonation : Form
    {
        string ExpenseID
          , ExpenseName
          , ExpenseDate
          , Particulars
          , TotalAmount;

        public AddDonation()
        {
            InitializeComponent();
        }
        void display()
        {
            Database.display($"SELECT * FROM Donations ORDER BY DonationDate", gridControl1, gridView1);
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            enablefields();
            display();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
            btnupdate.Enabled = false;
            btncancel.Enabled = true;
            int newid = IDGenerator.getIDNumber("Donations", "DonationID is not null", "DonationID");
            txtid.Text = newid.ToString();
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
        void execAdd()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            try
            {
                string query = "spfunc_AddDonations";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@parmid", txtid.Text);
                com.Parameters.AddWithValue("@parmchapterid", UserLogin.chapterID);
                com.Parameters.AddWithValue("@parmdonname", txtname.Text);
                com.Parameters.AddWithValue("@parmdondate", txtdate.Text);
                com.Parameters.AddWithValue("@parmremarks", txtparticulars.Text);
                com.Parameters.AddWithValue("@parmtotamount", txtamount.Text);
                com.Parameters.AddWithValue("@parmaddedby", UserLogin.id);
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = query;
                com.ExecuteNonQuery();
            }
            catch (SqlException exs)
            { XtraMessageBox.Show(exs.Message.ToString()); }
            finally { con.Close(); }

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            bool ok = Database.checkifExist("SELECT TOP(1) DonationID FROM Donations WHERE DonationID='" + txtid.Text.Trim() + "' ");
            if (ok)
            {
                XtraMessageBox.Show("Already Exist in Donations Table.. Please use Edit Function");
                return;
            }
            else if (String.IsNullOrEmpty(txtid.Text) || String.IsNullOrEmpty(txtamount.Text) || String.IsNullOrEmpty(txtdate.Text) || String.IsNullOrEmpty(txtname.Text) || String.IsNullOrEmpty(txtparticulars.Text))
            {
                XtraMessageBox.Show("Please input all fields.");
                return;
            }
            else
            {
                execAdd();
                clear();
                btnnew.Enabled = true;
                btnadd.Enabled = false;
                btnupdate.Enabled = false;
                btncancel.Enabled = false;

                disablefields();
                display();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtid.Text) || String.IsNullOrEmpty(txtamount.Text) || String.IsNullOrEmpty(txtdate.Text) || String.IsNullOrEmpty(txtname.Text) || String.IsNullOrEmpty(txtparticulars.Text))
            {
                XtraMessageBox.Show("Please input all fields.");
                return;
            }
            else
            {
                Database.ExecuteQuery($"UPDATE Donations SET DonationName='{txtname.Text}',Particulars='{txtparticulars.Text}',DonationDate='{txtdate.Text}',TotalAmount='{txtamount.Text}' " +
               $"WHERE DonationID='{txtid.Text}'  ", "Successfully Updated!");
                clear();
                disablefields();
                btnnew.Enabled = true;
                btnadd.Enabled = false;
                btnupdate.Enabled = false;
                btncancel.Enabled = false;
                display();
            }
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseID = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DonationID").ToString();
            ExpenseName = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DonationName").ToString();
            ExpenseDate = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DonationDate").ToString();
            Particulars = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Particulars").ToString();
            TotalAmount = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TotalAmount").ToString();
            txtid.Text = ExpenseID;
            txtname.Text = ExpenseName;
            txtdate.Text = ExpenseDate;
            txtparticulars.Text = Particulars;
            txtamount.Text = TotalAmount;
            enablefields();

            btnnew.Enabled = false;
            btnadd.Enabled = false;
            btnupdate.Enabled = true;
            btncancel.Enabled = true;
        }

        private void AddDonation_Load(object sender, EventArgs e)
        {
            display();
            disablefields();

        }
        void clear()
        {
            txtname.Text = "";
            txtamount.Text = "";
            txtdate.Text = "";
            txtparticulars.Text = "";
            txtid.Text = "";
        }
        void disablefields()
        {
            txtname.Enabled = false;
            txtamount.Enabled = false;
            txtdate.Enabled = false;
            txtparticulars.Enabled = false;
            txtid.Enabled = false;
        }
        void enablefields()
        {
            txtname.Enabled = true;
            txtamount.Enabled = true;
            txtdate.Enabled = true;
            txtparticulars.Enabled = true;
            txtid.Enabled = true;
        }
    }
}
