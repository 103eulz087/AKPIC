using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using IDProject.ChapterForms;
using DevExpress.LookAndFeel;

namespace IDProject
{
    public partial class MainDashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void btnmeetingsandactivities_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Meetings))
                {
                    form.Activate();
                    return;
                }
            }
            Meetings pcusatfsmr = new Meetings();
            pcusatfsmr.MdiParent = this;
            pcusatfsmr.Show();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Office2019Black);

            UserLookAndFeel.Default.SetSkinStyle("DevExpress Dark Style");

            UserLookAndFeel.Default.SetStyle(LookAndFeelStyle.Skin, false, true);
            btnStats.PerformClick();
        }

        private void btnStats_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ChapterLiveTrends))
                {
                    form.Activate();
                    return;
                }
            }
            ChapterLiveTrends pcusatfsmr = new ChapterLiveTrends();
            pcusatfsmr.MdiParent = this;
            pcusatfsmr.Show();
        }

        private void btnmembersmasterlist_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Members))
                {
                    form.Activate();
                    return;
                }
            }
            Members pcusatfsmr = new Members();
            pcusatfsmr.MdiParent = this;
            pcusatfsmr.Show();
        }

        private void btnExpense_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(AddExpense))
                {
                    form.Activate();
                    return;
                }
            }
            AddExpense pcusatfsmr = new AddExpense();
            pcusatfsmr.MdiParent = this;
            pcusatfsmr.Show();
        }

        private void barbtnCorrectiveAction_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(AddCorrectiveAction))
                {
                    form.Activate();
                    return;
                }
            }
            AddCorrectiveAction pcusatfsmr = new AddCorrectiveAction();
            pcusatfsmr.MdiParent = this;
            pcusatfsmr.Show();
        }

        private void btnAnnouncement_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(AddAnnouncement))
                {
                    form.Activate();
                    return;
                }
            }
            AddAnnouncement pcusatfsmr = new AddAnnouncement();
            pcusatfsmr.MdiParent = this;
            pcusatfsmr.Show();
        }

        private void btnactivities_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(AddActivities))
                {
                    form.Activate();
                    return;
                }
            }
            AddActivities pcusatfsmr = new AddActivities();
            pcusatfsmr.MdiParent = this;
            pcusatfsmr.Show();
        }

        private void btnLedger_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ChapterLedger))
                {
                    form.Activate();
                    return;
                }
            }
            ChapterLedger pcusatfsmr = new ChapterLedger();
            pcusatfsmr.MdiParent = this;
            pcusatfsmr.Show();
        }

        private void btnChapterLogo_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChapterLogo chaplog = new ChapterLogo();
            chaplog.ShowDialog(this);
        }

        private void btnattendancedashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            RetrieveMember chaplog = new RetrieveMember();
            chaplog.Show();
        }

        private void btnMemo_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnDonations_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(AddDonation))
                {
                    form.Activate();
                    return;
                }
            }
            AddDonation pcusatfsmr = new AddDonation();
            pcusatfsmr.MdiParent = this;
            pcusatfsmr.Show();
        }

        private void btnAttendanceSummary_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnCertificates_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ChapterCertificates))
                {
                    form.Activate();
                    return;
                }
            }
            ChapterCertificates cs = new ChapterCertificates();
            cs.MdiParent = this;
            cs.Show();
        }

        private void btnCouncilMasterlist_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Councils.ICCouncils))
                {
                    form.Activate();
                    return;
                }
            }
            Councils.ICCouncils pcusatfsmr = new Councils.ICCouncils();
            pcusatfsmr.MdiParent = this;
            pcusatfsmr.Show();
        }
    }
}