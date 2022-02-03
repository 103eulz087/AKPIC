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

namespace IDProject.ChapterForms
{
    public partial class ShowAttendees : DevExpress.XtraEditors.XtraForm
    {
        public ShowAttendees()
        {
            InitializeComponent();
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        private void addAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAttendance adat = new AddAttendance();
            adat.ShowDialog(this);
        }
    }
}