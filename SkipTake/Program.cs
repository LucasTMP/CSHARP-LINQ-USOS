using System;
using System.Collections;
using System.Linq;

namespace SkipTake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SkipTake(); //Link para teste online: https://dotnetfiddle.net/6orzaR
        }

        public static void SkipTake()
        {
            var str = "0123456789";
            var res = str.Reverse().Skip(5).ToArray();
            Console.WriteLine(res); // 43210

            var arr = new int[] { 1, 2, 3, 4 };
            arr = arr.Reverse().Take(2).ToArray();
            Print(arr); // 4 3
        }

        public static void Print(IEnumerable x)
        {
            foreach (var i in x)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}