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
            if (n%4==0)
            {
                Console.WriteLine("{0} {1}",n/2, n/2);
                return;
            }
            if (((n-1)%4==0)||((n - 3) % 4 == 0))
            {
                Console.WriteLine("{0} {1}",9, n-9);
            }
            else
            {
                Console.WriteLine("{0} {1}", 10, n - 10);
            }
        }
    }
}
