using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDProject
{
    public class SearchLookUpClass
    {
        public static Object getSingleValue(SearchLookUpEdit searchLookUpEdit1, string fieldname)
        {
            object value;
            GridView view = searchLookUpEdit1.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName = fieldname; // or other field name
            value = view.GetRowCellValue(rowHandle, fieldName);
            return value;
        }
    }
}
