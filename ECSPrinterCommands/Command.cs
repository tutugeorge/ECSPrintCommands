using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECSPrint
{
    public static class Command
    {
        public static string NewLine = (char)10 + "";        
        public static string LeftJustify = (char)27 + "a0";
        public static string CenterJustify = (char)27 + "a1";
        public static string RightJustify = (char)27 + "a2";
        public static string Bold = (char)27 + "E1";
        public static string Unbold = (char)27 + "E0";
    }
}
