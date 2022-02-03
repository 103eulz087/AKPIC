using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDProject
{
   public class Utilities
    {
        public static void ClearFields(Control ctrl)
        {
            foreach (Control ctl in ctrl.Controls)
            {
                if (ctl is TextBox) { ctl.Text = string.Empty; }
                else if (ctl is TextEdit) { ctl.Text = string.Empty; }
                //else if (ctl is ComboBox) { ((ComboBox)ctl).SelectedIndex = -1; }
                else if (ctl is ComboBoxEdit) { ((ComboBoxEdit)ctl).SelectedIndex = -1; }
                else if (ctl is DateTimePicker) { ((DateTimePicker)ctl).Value = DateTime.Today; }
                //else if (ctl is DateTimePicker){((DateTimePicker)ctl).Checked  = false;}
                else if (ctl is PictureBox) { ((PictureBox)ctl).Image = null; }
                else if (ctl is CheckBox) { ((CheckBox)ctl).Checked = false; }
                else if (ctl is ListView) { ((ListView)ctl).Items.Clear(); }
                else if (ctl is SearchLookUpEdit) { ctl.Text = string.Empty; }
            }
        }

        public static WinControlContainer CopyGridControl(GridControl grid)
        {

            // Create a WinControlContainer object.
            WinControlContainer winContainer = new WinControlContainer();
            // Set its location and size.
            winContainer.Location = new Point(0, 0);
            winContainer.Size = new Size(200, 100);
            // Set the grid as a wrapped object.
            winContainer.WinControl = grid;
            return winContainer;
        }
    }
}
