using System;
using System.Linq;

namespace First
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            First(); //Link para teste online: https://dotnetfiddle.net/VxY2Xx
        }

        public static void First()
        {
            var arr = new int[] { 2, 4, 6, 8, 1, 3, 5 };
            Console.WriteLine(arr.First()); // 2

            arr = new int[] { 2, 4, 6, 8, 1, 3, 5 };
            Console.WriteLine(arr.First(n => n % 2 == 1)); // 1
        }
    }
}