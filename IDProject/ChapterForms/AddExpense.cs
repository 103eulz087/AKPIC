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
    public partial class AddExpense : Form
    {

        string ExpenseID
        , ExpenseName
        , ExpenseDate
        , Particulars
        , TotalAmount;
    

        public AddExpense()
        {
            InitializeComponent();
        }

        private void AddExpense_Load(object sender, EventArgs e)
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

        private void btnnew_Click(object sender, EventArgs e)
        {
            enablefields();
            display();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
            btnupdate.Enabled = false;
            btncancel.Enabled = true;
            int newid = IDGenerator.getIDNumber("ExpenseMaster", "ExpenseID is not null", "ExpenseID");
            txtid.Text = newid.ToString();
        }
        void display()
        {
            Database.display($"SELECT * FROM ExpenseMaster ORDER BY ExpenseDate", gridControl1, gridView1);
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
                string query = "spfunc_AddExpense";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@parmid", txtid.Text);
                com.Parameters.AddWithValue("@parmchapterid", UserLogin.chapterID);
                com.Parameters.AddWithValue("@parmexpname", txtname.Text);
                com.Parameters.AddWithValue("@parmexpdate", txtdate.Text);
                com.Parameters.AddWithValue("@parmremarks", txtparticulars.Text);
                com.Parameters.AddWithValue("@parmtotamount", txtamount.Text);
                com.Parameters.AddWithValue("@parmaddedby", UserLogin.id);
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = query;
                com.ExecuteNonQuery();
            }
            catch(SqlException exs)
            { XtraMessageBox.Show(exs.Message.ToString()); }
            finally { con.Close(); }
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            bool ok = Database.checkifExist("SELECT TOP(1) ExpenseID FROM ExpenseMaster WHERE ExpenseID='" + txtid.Text.Trim() + "' ");
            if (ok)
            {
                XtraMessageBox.Show("Already Exist in ExpenseMaster Table.. Please use Edit Function");
                return;
            }
            else if(String.IsNullOrEmpty(txtid.Text) || String.IsNullOrEmpty(txtamount.Text) || String.IsNullOrEmpty(txtdate.Text) || String.IsNullOrEmpty(txtname.Text) || String.IsNullOrEmpty(txtparticulars.Text))
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
                Database.ExecuteQuery($"UPDATE ExpenseMaster SET ExpenseName='{txtname.Text}',Particulars='{txtparticulars.Text}',ExpenseDate='{txtdate.Text}',TotalAmount='{txtamount.Text}' " +
               $"WHERE ExpenseID='{txtid.Text}'  ", "Successfully Updated!");
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
            ExpenseID   = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ExpenseID").ToString();
            ExpenseName = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ExpenseName").ToString();
            ExpenseDate = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ExpenseDate").ToString();
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
    }
}
