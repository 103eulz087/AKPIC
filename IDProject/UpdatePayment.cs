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
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;

namespace IDProject
{
    public partial class UpdatePayment : DevExpress.XtraEditors.XtraForm
    {
        public UpdatePayment()
        {
            InitializeComponent();
        }

        private void UpdatePayment_Load(object sender, EventArgs e)
        {
            display();
        }

        void display()
        {
            Database.display("SELECT ID,FirstName,LastName,Region,Province,MUNICIPALITY,ChapterName,isPrinted,isFree FROM view_MembershipBasicInfo WHERE isPaid=0 ORDER BY FirstName", gridControl1, gridView1);
        }

        void updatePay()
        {
            try
            {
                GridView view = gridControl1.FocusedView as GridView;
                view.SortInfo.Clear();

                int[] selectedRows = gridView1.GetSelectedRows();

                foreach (int rowHandle in selectedRows)
                {
                    string id = gridView1.GetRowCellValue(rowHandle, "ID").ToString();//dataGridView1.Rows[0].Cells["Product"].Value.ToString();
                    if (rowHandle >= 0)
                    {
                        Database.ExecuteQuery("Update MembershipInfo SET isPaid=1 WHERE ID='" + id + "'");
                        Database.ExecuteQuery("Update Members SET isPrinted=1 WHERE ID='" + id + "'");
                    }
                }
                XtraMessageBox.Show("Payment Successfully Updated!...");
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            updatePay();
            display();
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        private void isPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery("UPDATE MembershipInfo SET isPaid=1 WHERE ID='"+gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"ID").ToString()+"'","Successfully Updated!");
            display();
        }
    }
}