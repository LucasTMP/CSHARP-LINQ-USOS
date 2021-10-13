using System;
using System.Collections;
using System.Linq;

namespace GroupBy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GroupBy(); //Link para teste online: https://dotnetfiddle.net/asdtHy
        }

        public static void GroupBy()
        {
            var arr = "abbcccd";
            var asc = arr
                .GroupBy(n => n)
                .Select(n => new { k = n.Key, qt = n.Count() })
                .OrderByDescending(n => n.qt).ToArray();
            Print(asc); // { k = c, qt = 3 }
                        // { k = b, qt = 2 }
                        // { k = a, qt = 1 }
                        // { k = d, qt = 1 }
        }

        public static void Print(IEnumerable x)
        {
            foreach (var i in x)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}