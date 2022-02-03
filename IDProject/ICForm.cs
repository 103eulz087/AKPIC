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

namespace IDProject
{
    public partial class ICForm : DevExpress.XtraEditors.XtraForm
    {
        object chaptercountrycode;
        public ICForm()
        {
            InitializeComponent();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picimage.Image = Image.FromFile(dialog.FileName);

            }
        }

        private void ICForm_Load(object sender, EventArgs e)
        {
            populateCountry();
        }
        void populateCountry()
        {
            Database.displaySearchlookupEdit("SELECT COUNTRY_CODE,COUNTRY_NAME FROM Countries WHERE COUNTRY_CODE IN ('63','972','60','39','1')", txtchaptercountries, "COUNTRY_NAME", "COUNTRY_NAME");
        }

        private void txtchaptercountries_EditValueChanged(object sender, EventArgs e)
        {
            chaptercountrycode = SearchLookUpClass.getSingleValue(txtchaptercountries, "COUNTRY_CODE"); //get country code in gridview
            txtchaptercountrycode.Text = chaptercountrycode.ToString(); //country code textbox
            int id = IDGenerator.getIDNumber("MembershipInfo", "ChapterCountryCode='" + txtchaptercountrycode.Text + "'", "SEQ_NO");
            txtid.Text = Database.sequencePadding1(id.ToString(), 13);
            txtrollno.Text = id.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}