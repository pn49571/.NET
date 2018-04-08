using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_min_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = -1;
            int max = 0;
            List<int> input = new List<int> {1,2,3,4,5,6,7,8,9,10 };
            foreach (var item in input)
            {
                min = Math.Min(min,item);
                if (min == -1)
                {
                    min = item;
                }
                max = Math.Max(max, item);
            }
            Console.WriteLine("The maximum is {0} and minimum is {1}",max,min);
            Console.ReadLine();
        }
    }
}
