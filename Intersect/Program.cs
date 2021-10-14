using System;
using System.Collections;
using System.Linq;

namespace Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            Intersect(); //Link para teste online: https://dotnetfiddle.net/r8r7t2
        }

        public static void Intersect()
        {
            int[] v1 = { 1, 2, 3 };
            int[] v2 = { 3, 4, 5 };

            var res = v1.Intersect(v2);
            Print(res);

            var p1 = "exemplo";
            var p2 = "coisa";

            Print(p1.Intersect(p2));
        }

        public static void Print(IEnumerable x)
        {
            foreach (var i in x)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
