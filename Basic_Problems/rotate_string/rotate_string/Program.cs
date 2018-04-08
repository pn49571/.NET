using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotate_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "icecream";
            Console.WriteLine(ShiftString(example,4));
            Console.WriteLine(ShiftString("verycomplexnumber", -6));
        }
        public static string ShiftString(string t, int s)
        {
            if (s > t.Length)
            {
                return "Cannot convert";
            }
            if (s < 0)
            {
                s = t.Length - Math.Abs(s);
            }
            return t.Substring(s, t.Length - s) + t.Substring(0, s);
        }
    }
}
