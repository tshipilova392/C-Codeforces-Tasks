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
            int n = int.Parse(s[0]);
            int a = int.Parse(s[1]);
            int b = int.Parse(s[2]);
            int c = int.Parse(s[3]);
            if ((a==1)||(b==1)||(c==1))
            {
                Console.WriteLine(n);
                return;
            }
            int x = Math.Min(a, Math.Min(b, c));
            int[] mas = new int[n + 1];
            mas[0] = 0;
            for (int i = 1; i < x; i++)
            {
                mas[i] = int.MinValue;
            }
            for (int i=x;i<=n;i++)
            {
                int max = int.MinValue;
                if ((i - a >= 0) && (mas[i - a]+1 > max))
                    max = mas[i - a]+1;
                if ((i - b >= 0) && (mas[i - b]+1 > max))
                    max = mas[i - b]+1;
                if ((i - c >= 0) && (mas[i - c]+1 > max))
                    max = mas[i - c]+1;
                mas[i] = max;
            }
            Console.WriteLine(mas[n]);
        }
    }
}
