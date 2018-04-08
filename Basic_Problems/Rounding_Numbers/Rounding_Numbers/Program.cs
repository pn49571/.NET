using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of test cases");
            foreach (var item in Console.ReadLine())
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                double div = num1 / num2;
                Console.WriteLine("rounded {0}",Math.Round(div));
            }
            Console.ReadLine();
        }
    }
}
