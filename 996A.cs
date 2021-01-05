using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long kol = 0;
            long d = n / 100;
            kol += d;
            n -= d * 100;
            d = n / 20;
            kol += d;
            n -= d * 20;
            d = n / 10;
            kol += d;
            n -= d * 10;
            d = n / 5;
            kol += d;
            n -= d * 5;
            kol += n;
            Console.WriteLine(kol);
        }
    }
}
