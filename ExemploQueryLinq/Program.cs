using System;
using System.Linq;

namespace ExemploQueryLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = { 1, 2, 3, 4, 5, 6 };
            var x = from a in i
                where a % 2 == 0
                select a;

            Console.WriteLine(string.Join(" ", x));
        }
    }
}
