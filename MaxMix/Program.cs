using System;
using System.Linq;

namespace MaxMix
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MaxMin(); //Link para teste online: https://dotnetfiddle.net/8xcvkW
        }

        public static void MaxMin()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(arr.Max()); // 6
            Console.WriteLine(arr.Min()); // 1
        }
    }
}