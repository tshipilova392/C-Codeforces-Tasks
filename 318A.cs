using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            long n = long.Parse(s[0]);
            long k = long.Parse(s[1]);
            long x;
            if (n%2==0)
            {
                if (k<=n/2)
                {
                    x = k * 2 - 1;
                }
                else
                {
                    x = (k - n / 2) * 2;
                }
            }
            else
            {
                if (k <= n / 2+1)
                {
                    x = k * 2 - 1;
                }
                else
                {
                    x = (k - n / 2-1) * 2;
                }
            }
            Console.WriteLine(x);
        }
    }
}
