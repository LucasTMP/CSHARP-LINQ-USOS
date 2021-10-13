using System;
using System.Collections;
using System.Linq;

namespace Prints
{
    public static class Program
    {
        public static void Main()
        {
            //Link para teste online: https://dotnetfiddle.net/fwhFk9

            // extensão
            "1a2b3c4d5e6f".Where(n => char.IsLetter(n)).ToArray().Print();

            //função
            var conteudo = "1a2b3c4d5e6f".Where(n => char.IsLetter(n)).ToArray();
            Print2(conteudo);

            //linq
            "1a2b3c4d5e6f".Where(n => char.IsLetter(n)).ToList().ForEach(Console.Write);
            Console.WriteLine();
            "1a2b3c4d5e6f".Where(n => char.IsLetter(n)).ToList().ForEach(x => Console.Write($"{x} "));
        }

        public static void Print(this IEnumerable x)
        {
            foreach (var i in x)
                Console.Write($"{i} ");
            Console.WriteLine();
        }

        public static void Print2(IEnumerable x)
        {
            foreach (var i in x)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}