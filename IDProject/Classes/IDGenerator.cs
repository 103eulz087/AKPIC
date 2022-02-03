using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDProject
{
    class IDGenerator
    {
        public static int getIDNumber(string chapter)
        {
            int id = Database.getLastID("Members", "SEQNO","Chapter='"+chapter+"'");
            if (id != 0)
                return ++id;
            else
                return 1;
        }
        public static int getIDNumber(string tablename,string condition,string value)
        {
            int id = Database.getLastID(tablename, value, condition);
            if (id != 0)
                return ++id;
            else
                return 1;
        }
        //public static int getSequenceNumber()
        //{
        //    int id = Database.getLastID("TempInventory", "SequenceNumber");
        //    if (id != 0)
        //        return ++id;
        //    else
        //        return 1;
        //}
    }
}
