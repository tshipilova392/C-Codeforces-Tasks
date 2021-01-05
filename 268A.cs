using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int kol = 0;
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                a.Add(int.Parse(s[0]));
                b.Add(int.Parse(s[1]));
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i != j) && (a[i] == b[j]))
                        kol++;
                }
            }
            Console.WriteLine(kol);
        }
    }
}
