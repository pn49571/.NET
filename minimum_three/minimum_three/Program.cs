using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimum_three
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            Console.WriteLine("Enter 3 numbers");
            for (int i = 0; i < 3; i++)
            {
                max = Math.Max(max, int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("The maximum of 3 numbers is: {0}",max);
            Console.ReadLine();
        }
    }
}
