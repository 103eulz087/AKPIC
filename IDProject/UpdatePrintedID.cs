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
    public partial class UpdatePrintedID : DevExpress.XtraEditors.XtraForm
    {
        public UpdatePrintedID()
        {
            InitializeComponent();
        }

        private void UpdatePrintedID_Load(object sender, EventArgs e)
        {
            display();
        }

        void display()
        {
            Database.display("SELECT ID,FirstName,LastName,Region,Province,MUNICIPALITY,ChapterName,isPrinted,isFree FROM view_MembershipBasicInfo WHERE isPrinted=0", gridControl1, gridView1);
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
                        Database.ExecuteQuery("Update Members SET isPrinted=1 WHERE ID='" + id + "'");
                    }
                }
                XtraMessageBox.Show("Successfully Updated!...");
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
    }
}