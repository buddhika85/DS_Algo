using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DS_Algo
{
    public static class Extensions
    {        
        public static string Display(this int[] array)
        {
            var str = "[";
            str += string.Join(',', array);
            str += "]";
            return str;
        }        

        public static string Display(this object[] array)
        {
            var str = "[";
            str += string.Join(',', array);
            str += "]";
            return str;
        }

        public static string DisplayYesNo(this bool? value)
        {
            return value == null ? "Unknown" : value.Value ? "Yes" : "No";
        }

        public static string DisplayYesNo(this bool value)
        {
            return value ? "Yes" : "No";
        }
    }
}