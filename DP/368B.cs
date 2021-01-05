using System;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split();
            int n = int.Parse(s1[0]);
            int m = int.Parse(s1[1]);
            string[] s2 = Console.ReadLine().Split();
            int[] a = new int[n];
            int[] l = new int[m];
            int[] b = new int[n];
            for (int i=0;i<n;i++)
            {
                a[i] = int.Parse(s2[i]);
            }
            /*  for (int i = 0; i < m; i++)
              {
                  l[i] = int.Parse(Console.ReadLine());
              }*/
            int kol = 1;
            b[n - 1] = kol;
            HashSet<int> h = new HashSet<int>();
            h.Add(a[n - 1]);
            for (int i=n-2;i>=0;i--)
            {
                if (!h.Contains(a[i]))
                {
                    h.Add(a[i]);
                    kol++;
                }
                b[i] = kol;
            }
            for (int i = 0; i < m; i++)
            {
                int ind = int.Parse(Console.ReadLine());
                Console.WriteLine(b[ind-1]);
            }
        }
    }
}
