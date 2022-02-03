using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using IDProject.Classes;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDProject.ChapterForms
{
    public partial class ChapterCertificates : Form
    {
        public ChapterCertificates()
        {
            InitializeComponent();
        }
      
        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        private void ChapterCertificates_Load(object sender, EventArgs e)
        {
            gridView1.IndicatorWidth = 50;
            Database.display($"select ID,LastName,FirstName,MiddleName,MothersMiddleName," +
                $"CONCAT(LastName,IIF(LastName is null or LastName='','',', '),FirstName,' ',IIF(MiddleName is null or MiddleName='','',CONCAT(SUBSTRING(MiddleName,1,1),'.'))) FLL_NM, " +
                $"MobileNo, BloodType, DateOfBirth, Address,ContactPersonFullName,ContactPersonMobileNo,ContactPersonAddress, CivilStatus " +
                $"from Members " +
                $"where LastName<>'??????????' and ((LastName is not null and LastName<>'') and (FirstName is not null and FirstName<>'' and ID is not null and ID<>'')) " +
                $"order by LastName asc",
                gridControl1, gridView1);
            
        }
        private Bitmap Generate_QRCode(string ID)
        {
            Bitmap fImage = new Bitmap(300, 5000);
            var strCode = ID;
            if (!ID.IsEmpty())
            {
                QRCodeGenerator QG = new QRCodeGenerator();
                QRCodeData QD = QG.CreateQrCode(strCode, QRCodeGenerator.ECCLevel.Q);
                QRCode QC = new QRCode(QD);
                fImage = QC.GetGraphic(20);


            }
            return fImage;
        }
        private Image Load_Photo(string ID, string LastName, string FirstName, string MiddleName)
        {
            Image fImage = null;
            DataTable dt = Database.GetDatatable("Select * from Members where ID='" + ID + "' and LastName='" + LastName + "' and FirstName='" + FirstName + "' and MiddleName='" + MiddleName + "'");
            string strPhoto = dt.Rows[0]["Photo"].Str().Trim();
            if (!dt.Rows[0]["Photo"].Str().IsEmpty())
            {
                try
                {
                    byte[] bytes = (byte[])dt.Rows[0]["Photo"];
                    MemoryStream ms = new MemoryStream(bytes);
                    fImage = Image.FromStream(ms);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return fImage;
        }
        private DataTable Selected_Account(GridControl cont)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("MiddleName", typeof(string));
            dt.Columns.Add("MothersMiddleName", typeof(string));
            dt.Columns.Add("FLL_NM", typeof(string));
            dt.Columns.Add("BloodType", typeof(string));
            dt.Columns.Add("MobileNo", typeof(string));
            dt.Columns.Add("DateOfBirth", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("ContactPersonFullName", typeof(string));
            dt.Columns.Add("ContactPersonMobileNo", typeof(string));
            dt.Columns.Add("ContactPersonAddress", typeof(string));
            dt.Columns.Add("CivilStatus", typeof(string));
            dt.Columns.Add("Photo", typeof(Image));
            dt.Columns.Add("QRCODE", typeof(Bitmap));
            if (gridView1.RowCount != 0)
            {
                foreach (int rowindex in this.gridView1.GetSelectedRows())
                {
                    DataRow DR = dt.NewRow();
                    DR["ID"] = (this.gridView1.GetRowCellDisplayText(rowindex, "ID").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "ID");
                    DR["LastName"] = (this.gridView1.GetRowCellDisplayText(rowindex, "LastName").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "LastName");
                    DR["FirstName"] = (this.gridView1.GetRowCellDisplayText(rowindex, "FirstName").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "FirstName");
                    DR["MiddleName"] = (this.gridView1.GetRowCellDisplayText(rowindex, "MiddleName").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "MiddleName");
                    DR["MothersMiddleName"] = (this.gridView1.GetRowCellDisplayText(rowindex, "MothersMiddleName").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "MothersMiddleName");
                    DR["FLL_NM"] = (this.gridView1.GetRowCellDisplayText(rowindex, "FLL_NM").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "FLL_NM");
                    DR["BloodType"] = (this.gridView1.GetRowCellDisplayText(rowindex, "BloodType").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "BloodType");
                    DR["MobileNo"] = (this.gridView1.GetRowCellDisplayText(rowindex, "MobileNo").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "MobileNo");
                    DR["DateOfBirth"] = (this.gridView1.GetRowCellDisplayText(rowindex, "DateOfBirth").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "DateOfBirth");
                    DR["Address"] = (this.gridView1.GetRowCellDisplayText(rowindex, "Address").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "Address");
                    DR["ContactPersonFullName"] = (this.gridView1.GetRowCellDisplayText(rowindex, "ContactPersonFullName").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "ContactPersonFullName");
                    DR["ContactPersonMobileNo"] = (this.gridView1.GetRowCellDisplayText(rowindex, "ContactPersonMobileNo").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "ContactPersonMobileNo");
                    DR["ContactPersonAddress"] = (this.gridView1.GetRowCellDisplayText(rowindex, "ContactPersonAddress").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "ContactPersonAddress");
                    DR["CivilStatus"] = (this.gridView1.GetRowCellDisplayText(rowindex, "CivilStatus").IsEmpty()) ? "" : this.gridView1.GetRowCellDisplayText(rowindex, "CivilStatus");
                    DR["Photo"] = Load_Photo(DR["ID"].Str(), DR["LastName"].Str(), DR["FirstName"].Str(), DR["MiddleName"].Str());
                    DR["QRCODE"] = Generate_QRCode(DR["ID"].Str());
                    dt.Rows.Add(DR);
                }
            }
            return dt;
        }

        private void cmsPrintIDbtn0a_Click(object sender, EventArgs e)
        {
            DataTable dt = Selected_Account(gridControl1);
            string chaptername = Database.getSingleQuery("IDTemplates", $"ChapterID='{UserLogin.chapterID}'", "ChapterName");
            if (dt.Rows.Count > 0)
            {
                ChapterCertTemplate.OMEGABETA report=null;
                if (chaptername == "OMEGABETA")
                {
                    report = new ChapterCertTemplate.OMEGABETA();
                }
                DataSet1 ds = new DataSet1();
                ds.Tables.Add(dt);
                report.DataSource = dt;
                report.DataMember = "Certificates";
                //report.PaperKind = System.Drawing.Printing.PaperKind.Custom;
                ReportPrintTool printIT = new ReportPrintTool(report);
                printIT.ShowPreviewDialog();
            }
        }
    }
}
