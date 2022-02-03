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
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using System.IO;
using IDProject.Template;

namespace IDProject.ChapterForms
{
    public partial class Members : DevExpress.XtraEditors.XtraForm
    {
        PictureBox pbox, sbox;
        public Members()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtsearch.Text) && String.IsNullOrEmpty(txtsearchcat.Text)) //kung empty ang duha ka fields
            {
                Database.display("SELECT TOP(100) * FROM view_MembershipBasicInfoChapterData ", gridControl1, gridView1);
            }
            else if(!String.IsNullOrEmpty(txtsearchcat.Text) && !String.IsNullOrEmpty(txtsearch.Text))
            {
                Database.display($"SELECT TOP(100) * FROM view_MembershipBasicInfoChapterData " +
                    $"WHERE {txtsearchcat.Text} like '%{txtsearch.Text}%' ", gridControl1, gridView1);
            }
            else { Database.display("SELECT TOP(100) * FROM view_MembershipBasicInfoChapterData ", gridControl1, gridView1); }
            gridView1.Columns["Photo"].OptionsColumn.FixedWidth = true;
            gridView1.Columns["Photo"].Width = 100;
            gridView1.RowHeight = 100;
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { btnsearch.PerformClick(); }
           
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            //string width = "120";
            //string height = "120";
            //XtraReport3 xct = new XtraReport3();
            //xct.Landscape = false;

            //Database.GetImageDevEx(xct.xrPictureBox1, "ChapterLogo", "ChapterCountryCode <> '0' ", "ChapterLogo");



            ////xct.xrchaptername.Text = txtchapter.Text + " Chapter";
            //xct.xrchaptername.Text = "Masterlist File";
            //xct.xrPictureBox1.SizeF = new SizeF(float.Parse(width), float.Parse(height));
            //xct.xrPictureBox2.SizeF = new SizeF(float.Parse(width), float.Parse(height));
            //xct.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            //xct.PaperKind = System.Drawing.Printing.PaperKind.A4;

            //xct.Bands[BandKind.Detail].Controls.Add(Utilities.CopyGridControl(gridControl1));
            //xct.Bands[BandKind.Detail].Font = new System.Drawing.Font("Tahoma", 10);
            //ReportPrintTool report = new ReportPrintTool(xct);
            //report.ShowRibbonPreviewDialog();
            SAMPLE ss = new SAMPLE();

            SqlConnection con = Database.getConnection();
            con.Open();
            string query = "SELECT TOP(100) * FROM view_MembershipBasicInfoChapterData";
            SqlCommand com = new SqlCommand(query,con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataSet1 ds = new DataSet1();
            ds.Tables.Add(table);
            
            //gridControl1.DataSource = table;
            //adapter.Fill(table);
            ss.DataSource = table;
            ss.DataMember = "view_MembershipBasicInfoChapterData";
            ss.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            ReportPrintTool report = new ReportPrintTool(ss);
            report.ShowRibbonPreviewDialog();

        }

        private void BindToData(XtraReport report)
        {
            // Create a data source.
            SqlConnection con = Database.getConnection();
            con.Open();
            SqlCommand com = new SqlCommand("SELECT TOP(100) * FROM dbo.view_MembershipBasicInfoChapterData", con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            // Assign the data source to the report.
            report.DataSource = table;
        }

        private void btnprintcert_Click(object sender, EventArgs e)
        {

            SqlConnection con = Database.getConnection();
            con.Open();
            SqlCommand com = new SqlCommand("SELECT TOP(100) * FROM dbo.view_MembershipBasicInfoChapterData", con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            ChapterCertTemplate.CertTemp xct = new ChapterCertTemplate.CertTemp();
            xct.Landscape = true;
            xct.PaperKind = System.Drawing.Printing.PaperKind.A4;
            foreach (DataRow row in table.Rows)
            {
                string id = row["ID"].ToString();
                xct.xrname.Text = id;
            }
            ReportPrintTool report = new ReportPrintTool(xct);
            report.ShowRibbonPreviewDialog();


            //ReportPrintTool report = null;
            //Dictionary<string, List<DataRow>> members = new Dictionary<string, List<DataRow>>();
            //foreach (DataRow row in table.Rows)
            //{
            //    string id = row["ID"].ToString();

            //    if (!members.ContainsKey(id))
            //        members[id] = new List<DataRow>();
            //    members[id].Add(row);
            //}
            //foreach (KeyValuePair<string, List<DataRow>> kvp in members) //List<DataRow> receipt
            //{
            //    List<DataRow> receipt = kvp.Value;
            //    foreach (DataRow row in receipt)
            //    {
            //        xct.xrname.Text= row["FirstName"].ToString();
            //        report = new ReportPrintTool(xct);
            //    }
            //    report.ShowRibbonPreviewDialog();
            //    receipt.Clear();
            //}


            //xct.Landscape = false;
            //ReportPrintTool report = null;
            //ChapterCertTemplate.CertTemp xct = new ChapterCertTemplate.CertTemp();
            //for (int i = 0; i <= gridView1.RowCount - 1; i++)
            //{
            //    string fname = gridView1.GetRowCellValue(i, "FirstName").ToString();

            //    string lname = gridView1.GetRowCellValue(i, "LastName").ToString().Replace(".", "");
            //    xct.xrname.Text = fname + " " + lname;
            //    report = new ReportPrintTool(xct);
            //}
            ////ReportPrintTool report = new ReportPrintTool(xct);
            //report.ShowRibbonPreviewDialog();

            //xct.xrchaptername.Text = txtchapter.Text + " Chapter";

            //xct.xrPictureBox1.SizeF = new SizeF(float.Parse(width), float.Parse(height));
            //xct.xrPictureBox2.SizeF = new SizeF(float.Parse(width), float.Parse(height));
            //xct.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            //xct.PaperKind = System.Drawing.Printing.PaperKind.A4;

            //xct.Bands[BandKind.Detail].Controls.Add(Utilities.CopyGridControl(gridControl1));
            //xct.Bands[BandKind.Detail].Font = new System.Drawing.Font("Tahoma", 10);


        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        void retrievePhoto(ViewMemberDetails viewmem)
        {
           // viewmem = new ViewMemberDetails();
            SqlConnection con = Database.getConnection();
            con.Open();
            string query = "select TOP(1) Photo FROM Members WHERE ID='" + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString() + "'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader reader = com.ExecuteReader();
            if (reader != null)
            {
                if (reader.Read())
                {
                    if (reader["Photo"] == System.DBNull.Value)
                    {
                        viewmem.picimage.Image = null;
                    }
                    else
                    {
                        byte[] img = null;
                        img = (byte[])reader["Photo"];
                        MemoryStream ms = new MemoryStream(img);
                        ms.Seek(0, SeekOrigin.Begin);
                        viewmem.picimage.Image = Image.FromStream(ms);
                        pbox = new PictureBox();
                        pbox.Image = Image.FromStream(ms);
                    }

                }
            }
            else
            {
                viewmem.picimage.Image = null;
            }
            reader.Close();
            con.Close();
        }
        void retrievePhoto(ViewMembersLedger viewmem)
        {
           // viewmem = new ViewMemberDetails();
            SqlConnection con = Database.getConnection();
            con.Open();
            string query = "select TOP(1) Photo FROM Members WHERE ID='" + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString() + "'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader reader = com.ExecuteReader();
            if (reader != null)
            {
                if (reader.Read())
                {
                    if (reader["Photo"] == System.DBNull.Value)
                    {
                        viewmem.picimage.Image = null;
                    }
                    else
                    {
                        byte[] img = null;
                        img = (byte[])reader["Photo"];
                        MemoryStream ms = new MemoryStream(img);
                        ms.Seek(0, SeekOrigin.Begin);
                        viewmem.picimage.Image = Image.FromStream(ms);
                        pbox = new PictureBox();
                        pbox.Image = Image.FromStream(ms);
                    }

                }
            }
            else
            {
                viewmem.picimage.Image = null;
            }
            reader.Close();
            con.Close();
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery($"UPDATE MembershipInfo set isActive=1 WHERE ID='{gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString()}'", "Successfully Updated");
        }

        private void inactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery($"UPDATE MembershipInfo set isActive=0 WHERE ID='{gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString()}'", "Successfully Updated");
        }

        private void viewLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMembersLedger viewmemledge = new ViewMembersLedger();
            retrievePhoto(viewmemledge);
            var row = Database.getMultipleQuery("Members", $"ID='{gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString()}'", "FirstName,MiddleName,LastName");
            string FirstName = "",MiddleName="",LastName="";
            FirstName = row["FirstName"].ToString();
            MiddleName = row["MiddleName"].ToString();
            LastName = row["LastName"].ToString();
            string fullname = FirstName + " " + MiddleName + " " + LastName;
            viewmemledge.lblfullname.Text = fullname;
            viewmemledge.lblidno.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            Database.display($"SELECT DateAdded,ReferenceCode,BeginningBalance,Debit,Credit,EndingBalance FROM vw_MembersLedger WHERE MemberID='{gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString()}' ORDER BY DateAdded DESC", viewmemledge.gridControl1, viewmemledge.gridView1);
            var rowz = Database.getMultipleQuery("MembersAccounts", $"MemberID='{gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString()}'", "AccountBalance,LastMovementDate");
            string AccountBalance, LastMovementDate;
            AccountBalance = rowz["AccountBalance"].ToString();
            LastMovementDate = rowz["LastMovementDate"].ToString();
            viewmemledge.lblfundsamount.Text = AccountBalance;
            viewmemledge.lbltransdate.Text = LastMovementDate;
            viewmemledge.ShowDialog(this);
        }

        private void printIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BETASIGMA xct = new BETASIGMA();
            Classes.HelperFunction.GetImageDevEx(xct.xrpic,"Members",$"ID='{gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"ID").ToString()}'", "Photo");

            string fname = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FirstName").ToString();
            string mname = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MiddleName").ToString();
            string lname = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LastName").ToString();
            xct.lblname.Text = fname + " " + mname + " " + lname;
            xct.lblidno.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            xct.lblgiftname.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GiftName").ToString();
            xct.lbldatesurvive.Text= Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DateSurvive").ToString()).ToShortDateString();
            xct.lbldateofbirth.Text = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DateOfBirth").ToString()).ToShortDateString() ;
            xct.lblbloodtype.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BloodType").ToString();
            xct.xrBarCode1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            
            ReportPrintTool report = new ReportPrintTool(xct);
            report.ShowRibbonPreviewDialog();
        }

        private void recognitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BETASIGMACERTREC xct = new BETASIGMACERTREC();
            Classes.HelperFunction.GetImageDevEx(xct.xrpic, "Members", $"ID='{gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString()}'", "Photo");

            string fname = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FirstName").ToString();
            string mname = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MiddleName").ToString();
            string lname = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LastName").ToString();
            xct.xrname.Text = fname + " " + mname + " " + lname;
            //xct.lblidno.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            //xct.lblgiftname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GiftName").ToString();
            //xct.lbldatesurvive.Text = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DateSurvive").ToString()).ToShortDateString();
            //xct.lbldateofbirth.Text = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DateOfBirth").ToString()).ToShortDateString();
            //xct.lblbloodtype.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BloodType").ToString();
            //xct.xrBarCode1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();

            ReportPrintTool report = new ReportPrintTool(xct);
            report.ShowRibbonPreviewDialog();
        }

        private void showLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ViewMemberDetails viewmem = new ViewMemberDetails();
            retrievePhoto(viewmem);
            //personal information
            var row = Database.getMultipleQuery("Members", "ID='" + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString() + "' ",
                "TRANS_NO, " +
                "ID, " +
                "FirstName, " +
                "MiddleName, " +
                "LastName, " +
                "Address, " +
                "DateOfBirth, " +
                "PlaceOfBirth, " +
                "Religion, " +
                "CivilStatus, " +
                "Gender, " +
                "Citizenship, " +
                "EmailAddress, " +
                "Height, " +
                "Weight, " +
                "Skills, " +
                "Photo, " +
                "Signature, " +
                "RFID, " +
                "SSSNo, " +
                "TinNo, " +
                "PibigNo, " +
                "MobileNo, " +
                "BloodType, " +
                "ContactPersonFullName, " +
                "ContactPersonMobileNo, " +
                "ContactPersonAddress, " +
                "MothersFirstName, " +
                "MothersMiddleName, " +
                "MothersLastName, " +
                "FathersFirstName," +
                "FathersMiddleName, " +
                "FathersLastName, " +
                "PrimarySchool, " +
                "PrimarySchoolDateGraduate, " +
                "SecondarySchool, " +
                "SecondarySchoolDateGraduate, " +
                "TertiarySchool, " +
                "TertiarySchoolDateGraduate, " +
                "Course, " +
                "VocationalTradeCourse, " +
                "VocationalTradeCourseDateGraduate, " +
                "GraduateStudies, " +
                "GraduateStudiesDateGraduate, " +
                "OtherAchievements, " +
                "isPrinted, " +
                "Groups, " +
                "ReferredBy, " +
                "Agent");

            string TRANS_NO
                  , ID
                  , FirstName
                  , MiddleName
                  , LastName
                  , Address
                  , DateOfBirth
                  , PlaceOfBirth
                  , Religion
                  , CivilStatus
                  , Gender
                  , Citizenship
                  , EmailAddress
                  , Height
                  , Weight
                  , Skills
                  , Photo
                  , Signature
                  , RFID
                  , SSSNo
                  , TinNo
                  , PibigNo
                  , MobileNo
                  , BloodType
                  , ContactPersonFullName
                  , ContactPersonMobileNo
                  , ContactPersonAddress
                  , MothersFirstName
                  , MothersMiddleName
                  , MothersLastName
                  , FathersFirstName
                  , FathersMiddleName
                  , FathersLastName
                  , PrimarySchool
                  , PrimarySchoolDateGraduate
                  , SecondarySchool
                  , SecondarySchoolDateGraduate
                  , TertiarySchool
                  , TertiarySchoolDateGraduate
                  , Course
                  , VocationalTradeCourse
                  , VocationalTradeCourseDateGraduate
                  , GraduateStudies
                  , GraduateStudiesDateGraduate
                  , OtherAchievements
                  , isPrinted
                  , Groups
                  , ReferredBy
                  , Agent;

            TRANS_NO = row["TRANS_NO"].ToString();
            ID = row["ID"].ToString();
            FirstName = row["FirstName"].ToString();
            MiddleName = row["MiddleName"].ToString();
            LastName = row["LastName"].ToString();
            Address = row["Address"].ToString();
            DateOfBirth = row["DateOfBirth"].ToString();
            PlaceOfBirth = row["PlaceOfBirth"].ToString();
            Religion = row["Religion"].ToString();
            CivilStatus = row["CivilStatus"].ToString();
            Gender = row["Gender"].ToString();
            Citizenship = row["Citizenship"].ToString();
            EmailAddress = row["EmailAddress"].ToString();
            Height = row["Height"].ToString();
            Weight = row["Weight"].ToString();
            Skills = row["Skills"].ToString();
            Photo = row["Photo"].ToString();
            Signature = row["Signature"].ToString();
            RFID = row["RFID"].ToString();
            SSSNo = row["SSSNo"].ToString();
            TinNo = row["TinNo"].ToString();
            PibigNo = row["PibigNo"].ToString();
            MobileNo = row["MobileNo"].ToString();
            BloodType = row["BloodType"].ToString();
            ContactPersonFullName = row["ContactPersonFullName"].ToString();
            ContactPersonMobileNo = row["ContactPersonMobileNo"].ToString();
            ContactPersonAddress = row["ContactPersonAddress"].ToString();
            MothersFirstName = row["MothersFirstName"].ToString();
            MothersMiddleName = row["MothersMiddleName"].ToString();
            MothersLastName = row["MothersLastName"].ToString();
            FathersFirstName = row["FathersFirstName"].ToString();
            FathersMiddleName = row["FathersMiddleName"].ToString();
            FathersLastName = row["FathersLastName"].ToString();
            PrimarySchool = row["PrimarySchool"].ToString();
            PrimarySchoolDateGraduate = row["PrimarySchoolDateGraduate"].ToString();
            SecondarySchool = row["SecondarySchool"].ToString();
            SecondarySchoolDateGraduate = row["SecondarySchoolDateGraduate"].ToString();
            TertiarySchool = row["TertiarySchool"].ToString();
            TertiarySchoolDateGraduate = row["TertiarySchoolDateGraduate"].ToString();
            Course = row["Course"].ToString();
            VocationalTradeCourse = row["VocationalTradeCourse"].ToString();
            VocationalTradeCourseDateGraduate = row["VocationalTradeCourseDateGraduate"].ToString();
            GraduateStudies = row["GraduateStudies"].ToString();
            GraduateStudiesDateGraduate = row["GraduateStudiesDateGraduate"].ToString();
            OtherAchievements = row["OtherAchievements"].ToString();
            isPrinted = row["isPrinted"].ToString();
            Groups = row["Groups"].ToString();
            ReferredBy = row["ReferredBy"].ToString();
            Agent = row["Agent"].ToString();
            //membershipinfo
            string SEQ_NO
            , ChapterCountryCode
            , ChapterRegionCode
            , ChapterProvinceCode
            , ChapterMunicipalityCode
            , ChapterZipCode
            , ChapterCode
            , DateSurvive
            , GiftName
            , GodParent
            , GSDuringSurvive
            , DateIssued
            , DateExpiry
            , LastActiveDate
            , isActive
            , isPaid
            , withForm
            , isDeducted
            , isIC
            , CouncilName
            , ActiveCountry
            , MobileSerialKey
            , RollNumber
            , GroupOfAlumni
            , isChapterID
            , isMunID
            , isProvID
            , isReg
            , Position
            , GSName
            , MIName
            , isNatlID;

            var rowz = Database.getMultipleQuery("MembershipInfo", "ID='" + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString() + "' ",
            "SEQ_NO,ID,ChapterCountryCode,ChapterRegionCode,ChapterProvinceCode,ChapterMunicipalityCode,ChapterZipCode,ChapterCode," +
            "DateSurvive,GiftName,GodParent,DateIssued,DateExpiry,LastActiveDate,isActive,isPaid,withForm,isDeducted,MobileSerialKey,RollNumber,GroupOfAlumni,GSDuringSurvive,isIC,CouncilName,ActiveCountry,isChapterID,isMunID,isProvID,isReg,isNatlID,Position,GSName,MIName");

            SEQ_NO = rowz["SEQ_NO"].ToString();
            ChapterCountryCode = rowz["ChapterCountryCode"].ToString();
            ChapterRegionCode = rowz["ChapterRegionCode"].ToString();
            ChapterProvinceCode = rowz["ChapterProvinceCode"].ToString();
            ChapterMunicipalityCode = rowz["ChapterMunicipalityCode"].ToString();
            ChapterZipCode = rowz["ChapterZipCode"].ToString();
            ChapterCode = rowz["ChapterCode"].ToString();
            DateSurvive = rowz["DateSurvive"].ToString();
            GiftName = rowz["GiftName"].ToString();
            GodParent = rowz["GodParent"].ToString();
            GSDuringSurvive = rowz["GSDuringSurvive"].ToString();
            DateIssued = rowz["DateIssued"].ToString();
            DateExpiry = rowz["DateExpiry"].ToString();
            LastActiveDate = rowz["LastActiveDate"].ToString();
            isActive = rowz["isActive"].ToString();
            isPaid = rowz["isPaid"].ToString();
            withForm = rowz["withForm"].ToString();
            isDeducted = rowz["isDeducted"].ToString();
            RollNumber = rowz["RollNumber"].ToString();
            GroupOfAlumni = rowz["GroupOfAlumni"].ToString();
            MobileSerialKey = rowz["MobileSerialKey"].ToString();
            isIC = rowz["isIC"].ToString();
            CouncilName = rowz["CouncilName"].ToString();
            ActiveCountry = rowz["ActiveCountry"].ToString();
            isChapterID = rowz["isChapterID"].ToString();
            isMunID = rowz["isMunID"].ToString();
            isProvID = rowz["isProvID"].ToString();
            isReg = rowz["isReg"].ToString();
            Position = rowz["Position"].ToString();
            GSName = rowz["GSName"].ToString();
            MIName = rowz["MIName"].ToString();
            isNatlID = rowz["isNatlID"].ToString();
            //chapterinfo
            //personal info setters
            viewmem.lblfullname.Text = FirstName + " " + MiddleName + " " + LastName;
            viewmem.lbldateofbirth.Text = Convert.ToDateTime(DateOfBirth).ToShortDateString();
            viewmem.lblplaceofbirth.Text = PlaceOfBirth;
            viewmem.lblbloodtype.Text = BloodType;
            viewmem.lblmobileno.Text = MobileNo;
            viewmem.lbladdress.Text = Address;
            viewmem.lblreligion.Text = Religion;
            viewmem.lblcivilstatus.Text = CivilStatus;
            viewmem.lblgender.Text = Gender;
            viewmem.lblcitizenship.Text = Citizenship;
            viewmem.lblemailaddress.Text = EmailAddress;
            viewmem.lblcontactpersonfullname.Text = ContactPersonFullName;
            viewmem.lblcontactpersonaddress.Text = ContactPersonAddress;
            viewmem.lblcontactpersonmobileno.Text = ContactPersonMobileNo;
            //chapterinfo
            viewmem.lblidno.Text = ID;
            viewmem.lblrollno.Text = RollNumber;
            viewmem.lblgiftname.Text = GiftName;
            viewmem.lbldatesurvived.Text = Convert.ToDateTime(DateSurvive).ToShortDateString();
            viewmem.lblgroupofalumni.Text = GroupOfAlumni;

            string chaptercountryname, chapterregionname, chapterprovincename, chaptermunicipalityname, chaptername;
            var chapterfullnames = Database.getMultipleQuery("view_MembershipBasicInfo", "ID='" + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString() + "' ", "Country,Region,Province,MUNICIPALITY,ChapterName");
            chaptercountryname = chapterfullnames["Country"].ToString();
            chapterregionname = chapterfullnames["Region"].ToString();
            chapterprovincename = chapterfullnames["Province"].ToString();
            chaptermunicipalityname = chapterfullnames["MUNICIPALITY"].ToString();
            chaptername = chapterfullnames["ChapterName"].ToString();

            viewmem.lblchapterregion.Text = chapterregionname;
            viewmem.lblchapterprovince.Text = chapterprovincename;
            viewmem.lblchaptermunicipality.Text = chaptermunicipalityname;
            viewmem.lblchaptersurvived.Text = chaptername;
            viewmem.ShowDialog(this);
           
        }
    }
}