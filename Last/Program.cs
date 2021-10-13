using System;
using System.Linq;

namespace Last
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Last(); //Link para teste online: https://dotnetfiddle.net/BVuOpD
        }

        public static void Last()
        {
            var arr = new int[] { 2, 4, 6, 8, 1, 3, 5 };
            Console.WriteLine(arr.Last()); // 5

            arr = new int[] { 2, 4, 6, 8, 1, 3, 5 };
            Console.WriteLine(arr.Last(n => n % 2 == 0)); // 8
        }
    }
}