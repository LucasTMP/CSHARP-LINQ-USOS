using System;
using System.Collections;
using System.Linq;

namespace Reverse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Reverse(); //Link para teste online: https://dotnetfiddle.net/c5HOqm
        }

        public static void Reverse()
        {
            var str = "0123456789";
            var res = str.Reverse().ToArray();
            Console.WriteLine(res); // 9876543210

            var arr = new int[] { 1, 2, 3, 4 };
            arr = arr.Reverse().ToArray();
            Print(arr); // 4 3 2 1
        }

        public static void Print(IEnumerable x)
        {
            foreach (var i in x)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}