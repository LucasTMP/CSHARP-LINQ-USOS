using System;
using System.Collections;
using System.Linq;

namespace ThenBy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ThenBy(); //Link para teste online: https://dotnetfiddle.net/7dIb4o
        }

        public static void ThenBy()
        {
            var arr = new[] {
            new {a="b", b = 1, c = 7},
            new {a="b", b = 2, c = 6},
            new {a="b", b = 3, c = 5},
            new {a="a", b = 4, c = 4},
            new {a="a", b = 5, c = 3},
            new {a="a", b = 6, c = 2},
            new {a="a", b = 7, c = 1},
        };

            var asc = arr.OrderBy(v => v.a).ThenByDescending(v => v.c).ThenBy(v => v.b).ToArray();
            var desc = arr.OrderByDescending(v => v.a).ToArray();

            Print(arr); // 		{ a = b, b = 1, c = 7 } { a = b, b = 2, c = 6 } { a = b, b = 3, c = 5 } { a = a, b = 4, c = 4 }
                        //		{ a = a, b = 5, c = 3 } { a = a, b = 6, c = 2 } { a = a, b = 7, c = 1 }
            Print(asc); //		{ a = a, b = 4, c = 4 } { a = a, b = 5, c = 3 } { a = a, b = 6, c = 2 } { a = a, b = 7, c = 1 }
                        //		{ a = b, b = 1, c = 7 } { a = b, b = 2, c = 6 } { a = b, b = 3, c = 5 }
            Print(desc);//		{ a = b, b = 1, c = 7 } { a = b, b = 2, c = 6 } { a = b, b = 3, c = 5 } { a = a, b = 4, c = 4 }
                        //		{ a = a, b = 5, c = 3 } { a = a, b = 6, c = 2 } { a = a, b = 7, c = 1 }
        }

        public static void Print(IEnumerable x)
        {
            foreach (var i in x)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}