using System;
using System.Linq;

namespace Any
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Any(); //Link para teste online: https://dotnetfiddle.net/AaBhTd
        }

        public static void Any()
        {
            var arr = new int[] { 1, 4, 6, 8 };
            Console.WriteLine(arr.Any(n => n > 10)); // False

            arr = new int[] { 1, 4, 6, 11 };
            Console.WriteLine(arr.Any(n => n > 10)); // True

            arr = new int[] { };
            Console.WriteLine(arr.Any()); // False

            arr = new int[] { 1 };
            Console.WriteLine(arr.Any()); // True
        }
    }
}