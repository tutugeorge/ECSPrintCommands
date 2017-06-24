using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECSPrint
{
    public static class Command
    {
        private static char ESC = (char)27;

        public static string Reset = ESC + "@";
        public static string NewLine = (char)10 + "";        
        public static string LeftJustify = ESC + "a0";
        public static string CenterJustify = ESC + "a1";
        public static string RightJustify = ESC + "a2";
        public static string Bold = ESC + "E1";
        public static string Unbold = ESC + "E0";

        //Barcodes
        public static string CODE39 = ESC + "k4";
    }
}
