using System;
using System.Collections;
using System.Linq;

namespace Union
{
    class Program
    {
        static void Main(string[] args)
        {
            Union();
        }

        public static void Union()
        {
            int[] v1 = { 1,2,3 };
            int[] v2 = { 3,4,5 };

            var res = v1.Union(v2);
            Print(res);

            var p1 = "exemplo";
            var p2 = "coisa";

            Print(p1.Union(p2));
        }

        public static void Print(IEnumerable x)
        {
            foreach (var i in x)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
