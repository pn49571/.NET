using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringHelper.ReverseString("framework"));
            Console.WriteLine(StringHelper.ReverseString("samuel"));
            Console.WriteLine(StringHelper.ReverseString("example string"));
        }
        static class StringHelper
        {
            /// <summary>
            /// Receives string and returns the string with its letters reversed.
            /// </summary>
            public static string ReverseString(string s)
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr); //array to string convert
            }
        }
    }
}
