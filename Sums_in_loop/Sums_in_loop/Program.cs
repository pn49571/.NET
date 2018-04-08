using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums_in_loop
{
    class Program
    {
        private static List<Dynamic_sum> iList = new List<Dynamic_sum>();
        private static int count = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of sums to be calculated");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                iList.Add(new Dynamic_sum(count, 0));

                for (int j = 0; j < 2; j++)
                {
                    ((Dynamic_sum)iList[count]).Value += int.Parse(Console.ReadLine()) ;
                }
                count += 1;
            }
            Console.WriteLine("The total sum is:");
            iList.ForEach(item => Console.Write("{0} \n",item.Value));
        }
    }
}
