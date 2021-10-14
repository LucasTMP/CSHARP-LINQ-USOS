using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;

namespace ExemploCodingame
{
    class Program
    {
        static void Main(string[] args)
        {
            var entrada = "-2 4 -654 345 108 -109";

            var a = entrada.Split()
                .Select(n => n[0] == '-' ? n.Substring(1) : n)
                .Select(n => int.Parse(new string(n.Reverse().ToArray())))
                .OrderByDescending(n => n).First();

            Console.WriteLine(a);


        }
    }
}
