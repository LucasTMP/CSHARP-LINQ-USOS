using System;
using System.Collections;
using System.Linq;

namespace OrderBy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OrderBy(); //Link para teste online: https://dotnetfiddle.net/QIiDSI
        }

        public static void OrderBy()
        {
            var arr = new[] {
            new {k="aaa", v = 4},
            new {k="bbb", v = 2},
            new {k="aaa", v = 2},
            new {k="ccc", v = 1},
        };

            var asc = arr.OrderBy(v => v.v).ToArray();
            var desc = arr.OrderByDescending(v => v.v).ToArray();

            Print(arr); // 		{ k = aaa, v = 4 } { k = bbb, v = 2 } { k = aaa, v = 2 } { k = ccc, v = 1 }
            Print(asc); //		{ k = ccc, v = 1 } { k = bbb, v = 2 } { k = aaa, v = 2 } { k = aaa, v = 4 }
            Print(desc);//		{ k = aaa, v = 4 } { k = bbb, v = 2 } { k = aaa, v = 2 } { k = ccc, v = 1 }
        }

        public static void Print(IEnumerable x)
        {
            foreach (var i in x)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}