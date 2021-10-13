using System;
using System.Linq;

namespace SumAverageCount
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SumAverageCount(); //Link para teste online: https://dotnetfiddle.net/zGxHxX
            SACComCondicoes(); //Link para teste online: https://dotnetfiddle.net/iaByTK
        }

        public static void SumAverageCount()
        {
            var arr = new int[] { 1, 2, 3 };

            Console.WriteLine(arr.Sum()); // 6
            Console.WriteLine(arr.Average()); // 2
            Console.WriteLine(arr.Count()); // 3
        }

        public static void SACComCondicoes()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(arr.Where(n => n % 2 == 0).Sum()); // 12
            Console.WriteLine(arr.Sum(n => n % 2 == 0 ? n : 0)); // 12
            Console.WriteLine(arr.Count(n => n < 4)); // 3
        }
    }
}