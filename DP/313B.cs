using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int len = s.Length;
            int[] a = new int[len];
            int kol = 0;
            for (int i=0;i<len-1;i++)
            {
                if (s[i] == s[i + 1])
                    kol++;
                a[i+1] = kol;
            }
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s1 = Console.ReadLine().Split();
                int a1 = int.Parse(s1[0]);
                int b1 = int.Parse(s1[1]);

                Console.WriteLine(a[b1-1]-a[a1-1]);
            }

        }
    }
}