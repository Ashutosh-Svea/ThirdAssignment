using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class Utils
    {
        public static int errNumberValue = -1;
        public static string errStringValue = "INVALID STRING";
        public static bool IsEmptyString(string str)
        {
            if (str.Equals(String.Empty))
                return true;
            else
                return false;
        }

        public static bool IsStringInBound(string str, int min, int max)
        {
            if (str.Length < min || str.Length > max)
                return false;
            else     
                return true;
        }
    }
}
