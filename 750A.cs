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
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            int sum = 0;
            int i = 1;
            while (sum<=(240-k))
            {
                sum += 5 * i;
                i++;
            }
            Console.WriteLine((i-2)<n ? i-2 : n);
        }
    }
}
