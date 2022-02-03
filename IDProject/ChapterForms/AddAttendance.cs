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

namespace IDProject.ChapterForms
{
    public partial class AddAttendance : DevExpress.XtraEditors.XtraForm
    {
        public static bool isdone = false;
        public AddAttendance()
        {
            InitializeComponent();
        }

        private void AddAttendance_Load(object sender, EventArgs e)
        {
            int attid = IDGenerator.getIDNumber("Attendance", "AttendanceID is not null","AttendanceID");
            txtattendanceid.Text = attid.ToString();
           
        }

       

        void execute()
        {
            try
            {
                GridView view = gridControl2.FocusedView as GridView;
                view.SortInfo.Clear();

                int[] selectedRows = gridView2.GetSelectedRows();
                
                foreach (int rowHandle in selectedRows)
                {
                    string ID = gridView2.GetRowCellValue(rowHandle, "ID").ToString();//dataGridView1.Rows[0].Cells["Barcode"].Value.ToString(); 
                    string fundamount = gridView2.GetRowCellValue(rowHandle, "FundsAmount").ToString();//dataGridView1.Rows[0].Cells["Barcode"].Value.ToString(); 
                    if (rowHandle >= 0)
                    {
                        //Database.ExecuteQuery($"INSERT INTO Attendance VALUES('{txtattendanceid.Text}','{txtattendanceid.Text}','{txtreferenceid.Text}','{ID}','{fundamount}')");
                        Database.ExecuteQuery($"UPDATE Attendance SET isPresent=1,FundsAmount='{fundamount}' WHERE MembersID='{ID}' AND AttendanceID='{txtattendanceid.Text}' AND ReferenceID='{txtreferenceid.Text}'");
                        //Database.ExecuteQuery($"INSERT INTO MembersLedger VALUES('{ID}','0','{fundamount}','0','0','{fundamount}','MTNG-{txtattendanceid.Text}',' ','{DateTime.Now.ToString()}')");
                        Database.ExecuteQuery($"INSERT INTO MembersLedger VALUES('{ID}','0','{fundamount}','0','0','{fundamount}','{txtreferencecode.Text}',' ','{DateTime.Now.ToString()}')");
                    }
                }
                execSP();
                isdone = true;
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }

        void execSP()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            string query = "spfunc_AddAttendance";
            SqlCommand com = new SqlCommand(query, con);
            com.Parameters.AddWithValue("@parmattid", txtattendanceid.Text);
            com.Parameters.AddWithValue("@parmrefid", txtreferenceid.Text);
            com.Parameters.AddWithValue("@parmrefcode", txtreferencecode.Text);
            com.Parameters.AddWithValue("@parmchapterid", UserLogin.chapterID);
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = query; 
            com.ExecuteNonQuery();
            con.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery($"INSERT INTO Attendance(AttendanceID,ReferenceID,MembersID,isPresent,FundsAmount,AttendanceType) " +
                $"SELECT '{txtattendanceid.Text}','{txtreferenceid.Text}',ID,0,0,'1' FROM Members with(nolock) ");
            execute();
            XtraMessageBox.Show("Successfully Executed");
            this.Close();
        }

        private void gridView2_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName != "FundsAmount")
                e.Cancel = true;
        }
    }
}