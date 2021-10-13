using System;
using System.Linq;

namespace Aggregate
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Aggregate(); //Link para teste online: https://dotnetfiddle.net/JYIUD0
            AggregateComSeed(); //Link para teste online: https://dotnetfiddle.net/iDBkhi
        }

        public static void Aggregate()
        {
            var arr = new[]{
            "VaiVoa",
            "é",
            "10!!!"
        };
            arr.Aggregate((a, b) => a + " " + b)
            .ToList()
            .ForEach(Console.Write); // VaiVoa é 10!!!
        }

        public static void AggregateComSeed()
        {
            var arr = new int[] { 2, 2, 2 };
            var seed = 10;
            var res = arr.Aggregate(seed, (a, b) => a + b);
            Console.WriteLine(res); // 16

            var numeros = new int[] { 1, 2, 3 };
            var media = numeros.Aggregate(
                        seed: 0,
                        func: (a, b) => a + b,
                        resultSelector: a => a / numeros.Count());
            Console.WriteLine(media); // 2
        }
    }
}