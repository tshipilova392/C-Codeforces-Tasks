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
            int x = int.Parse(Console.ReadLine());
            for (int q=0;q<x;q++)
            {
                string[] s1 = Console.ReadLine().Split();
                int n = int.Parse(s1[0]);
                int m = int.Parse(s1[1]);
                int k = int.Parse(s1[2]);
                string[] s2 = Console.ReadLine().Split();
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(s2[i]);
                }
                bool b = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (a[i + 1]<=a[i])
                    {
                        m+=Math.Min(a[i]-a[i+1]+k,a[i]);
                        continue;
                    }
                    if ((a[i+1]-a[i])<k)
                    {
                        m += Math.Min(k - (a[i + 1] - a[i]),a[i]);
                        continue;
                    }
                    if ((a[i + 1] - a[i]) > k)
                    {
                        if (m>= (a[i + 1] - a[i] - k))
                        {
                            m -= (a[i + 1] - a[i] - k);
                        }
                        else
                        {
                            b = true;
                            Console.WriteLine("NO");
                            break;
                        }                       
                    }
                }
                if (b) continue;
                Console.WriteLine("YES");
            }
            
        }
    }
}
