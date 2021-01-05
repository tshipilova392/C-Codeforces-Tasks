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
            for (int i=0;i<n;i++)
            {
                long x = long.Parse(Console.ReadLine());
                Console.WriteLine(x % 4 == 0 ? "YES" : "NO");
            }
        }
    }
}
