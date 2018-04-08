using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace list_dic_sort
{
    class Program
    {

        static void Main(string[] args)
        {
            Listexample();
        }

        public static void Listexample()
        {
            List<Player> lst = new List<Player>();
            lst.Add(new Player("John", 100));
            lst.Add(new Player("Smith", 120));
            lst.Add(new Player("Cait", 97));
            lst.Add(new Player("Irene", 100));
            lst.Add(new Player("Ben", 100));
            lst.Add(new Player("Deniel", 88));

            //sort ascending order
            lst.Sort(delegate (Player x, Player y)
            {
                return x.Total.CompareTo(y.Total);
            });
            lst.ForEach(x=> Console.WriteLine(x.Name));

            //sort descending order
            lst.Sort(delegate (Player x, Player y)
            {
                return y.Total.CompareTo(x.Total);
            });
            lst.ForEach(x => Console.WriteLine(x.Name));
            //sort multipl elements
            lst.Sort(delegate (Player x, Player y)
            {
                // Sort by total in descending order
                int a = y.Total.CompareTo(x.Total);

                // Both player has the same total.
                // Sort by name in ascending order
                if (a == 0)
                    a = x.Name.CompareTo(y.Name);

                return a;
            });
            lst.ForEach(x => Console.WriteLine(x.Name));

            //using Linq see examples
            var result1 = lst.OrderBy(a => a.Total);

            var result3 = lst.OrderBy(a => a.Total).ThenBy(a => a.Name);

            var result2 = lst.OrderByDescending(a => a.Total).ThenByDescending(a => a.Name);
        }

        public static void dicsortexample()
        {
            // Example dictionary.
            var dictionary = new Dictionary<string, int>(5);
            dictionary.Add("cat", 1);
            dictionary.Add("dog", 0);
            dictionary.Add("mouse", 5);
            dictionary.Add("eel", 3);
            dictionary.Add("programmer", 2);

            // Order by values.
            // ... Use LINQ to specify sorting by value.
            var items = from pair in dictionary
                orderby pair.Value ascending
                select pair;

            // Display results.
            foreach (KeyValuePair<string, int> pair in items)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

            // Reverse sort.
            // ... Can be looped over in the same way as above.
            items = from pair in dictionary
                orderby pair.Value descending
                select pair;
        }
    }
}
