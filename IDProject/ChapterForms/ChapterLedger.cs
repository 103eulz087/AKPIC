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
    public partial class ChapterLedger : Form
    {
        public ChapterLedger()
        {
            InitializeComponent();
        }

        void display()
        {
            Database.display($"SELECT * FROM vw_ChapterLedger WHERE ChapterID='{UserLogin.chapterID}' ORDER BY DateAdded ASC", gridControl1, gridView1);
        }

        private void ChapterLedger_Load(object sender, EventArgs e)
        {
            display();
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
