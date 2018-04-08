using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicates_in_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listOfItems = new[] { 4, 2, 3, 1, 6, 4, 3 };
            display_duplicates(listOfItems);
            check_duplicates(listOfItems);
        }

        public static void display_duplicates(int[] listOfItems)
        {
            var duplicates = listOfItems
                .GroupBy(i => i)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);
            foreach (var d in duplicates)
                Console.WriteLine(d);
        }

        public static void check_duplicates(int[] list1)
        {
            if (list1.Length != list1.Distinct().Count())
            {
                Console.WriteLine("Duplciates exist");
            }
        }
    }
}
