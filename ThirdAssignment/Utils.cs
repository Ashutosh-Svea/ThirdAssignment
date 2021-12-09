using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class Utils
    {
        public enum BirdColor {Blue,Gree,Black };

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
        public static bool IsValidAge(int age)
        {
            if (age < 0)
                return false;
            else
                return true;
        }

        public static bool IsValidWeight(double weight)
        {
            if (weight < 0)
                return false;
            else
                return true;
        }
        public static bool IsValidHeight(double height)
        {
            if (height < 0)
                return false;
            else
                return true;
        }

    }
}
