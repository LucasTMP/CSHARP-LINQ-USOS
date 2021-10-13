using System;
using System.Linq;

namespace All
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            All(); //Link para teste online: https://dotnetfiddle.net/WXAOzf
        }

        public static void All()
        {
            var arr = new int[] { 2, 4, 6, 8 };
            Console.WriteLine(arr.All(n => n % 2 == 0)); // True

            arr = new int[] { 1, 4, 6, 8 };
            Console.WriteLine(arr.All(n => n % 2 == 0)); // False
        }
    }
}