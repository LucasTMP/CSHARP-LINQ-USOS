using System;
using System.Collections;
using System.Linq;

namespace Select
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Select(); //Link para teste online: https://dotnetfiddle.net/ayV2G2
            SelectComIndex(); //Link para teste online: https://dotnetfiddle.net/6TdVa3
            SelectComVariosRetornos(); //Link para teste online: https://dotnetfiddle.net/CNyYUj
        }

        public static void Select()
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var res = arr.Select(n => n % 2 == 0 ? n + 1 : n).ToArray();
            Print(res); // 1 3 3 5 5
        }

        public static void SelectComIndex()
        {
            string N = "12354";
            string T = "Breon";

            N.Select((m, i) => new { K = m, V = T[i] })
            .OrderBy(g => g.K)
            .Select(g => g.V)
            .ToList().ForEach(Console.Write);
        }

        public static void SelectComVariosRetornos()
        {
            var arr = new[] {
            "aa aa aa aa",
            "aa",
            "aa aa",
            "aa aa aa",
            "aa aa aa aa",
        };
            arr.Select(n =>
            {
                if (n.Split().Length < 2) return "Uma Palavra\n";
                else if (n.Split().Length == 2) return "Duas Palavras\n";
                else if (n.Split().Length == 3) return "Três Palavras\n";
                else return "Mais de três palavras\n";
            }).ToList()
            .ForEach(Console.Write);
        }

        public static void Print(IEnumerable x)
        {
            foreach (var i in x)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}