using System;
using System.Collections;
using System.Linq;

namespace Where
{
    internal class Program
    {
        public static void Main()
        {
            Where(); //Link para teste online: https://dotnetfiddle.net/Q9fN8W
            WhereComIndex(); //Link para teste online: https://dotnetfiddle.net/eRaRFO
        }

        public static void Where()
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var res = arr.Where(n => n % 2 == 0).ToArray();
            Print(res);

            var str = "1a2b3c4d5e6f".Where(n => char.IsLetter(n)).ToArray();
            Print(str);
        }

        public static void WhereComIndex()
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var res = arr.Where((n, i) => i % 2 == 0).ToArray();
            Print(res); // 1 3 5

            var str = "1a2b3c4d5e6f".Where((n, i) => i < 4).ToArray();
            Print(str); // 1 a 2 b
        }

        public static void Print(IEnumerable x)
        {
            foreach (var i in x)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}