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
    public partial class ChapterLiveTrends : Form
    {
        public ChapterLiveTrends()
        {
            InitializeComponent();
        }

        private void ChapterLiveTrends_Load(object sender, EventArgs e)
        {
            display();
        }

        void display()
        {
            //lbltotalfunds.Text = Database.getSingleQuery("ChapterAccounts", "AccountBalance is not null", "AccountBalance");
            double totalfunds = 0.0;
            //totalfunds = Database.getTotalSummation2("ChapterAccounts", "AccountBalance is not null", "AccountBalance");
            totalfunds = Database.getTotalSummation2("ChapterAccounts", "AccumAccountBalance is not null", "AccumAccountBalance");
            lbltotalfunds.Text = totalfunds.ToString();

            double totexpense = Database.getTotalSummation2("ExpenseMaster", "ExpenseID is not null", "TotalAmount");
            lbltotalexpense.Text = totexpense.ToString();
            double outstanding = 0.0;
            outstanding = Convert.ToDouble(lbltotalfunds.Text) - totexpense;
            lbloutstanding.Text = outstanding.ToString();

            int totmembers = Database.getCountData("Members", "ID is not null", "ID");
            lbltotmembers.Text = totmembers.ToString();
            int activemembers  = Database.getCountData("MembershipInfo", "ID is not null AND isActive=1", "ID");
            int inactivemembers = Database.getCountData("MembershipInfo", "ID is not null AND isActive=0", "ID");
            lbltotactive.Text = activemembers.ToString();
            lbltotinactive.Text = inactivemembers.ToString();
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
