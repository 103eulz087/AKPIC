using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDProject.Classes
{
    public static class Object
    {
        // advance
        public static string Str(this object source) { return (source ?? "").ToString(); }
        public static bool Bool(this object source) { try { return (bool)source; } catch { return false; } }

        public static bool IsEmpty(this String str)
        {
            return String.IsNullOrEmpty(str);
        }
    }
}
