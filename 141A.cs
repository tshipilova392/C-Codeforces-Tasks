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
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            s1 += s2;
            s1 = String.Concat(s1.OrderBy(c => c));
            s3 = String.Concat(s3.OrderBy(c => c));
            Console.WriteLine(s3 == s1 ? "YES" : "NO");
        }
    }
}
