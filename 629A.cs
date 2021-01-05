using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s;
            int[] cols = new int[n];
            int[] rows = new int[n];
            for (int i=0;i<n;i++)
            {
                s = Console.ReadLine();
                int sum = 0;
                for (int j=0;j<s.Length;j++)
                {
                    if (s[j] == 'C')
                    {
                        cols[j]++;
                        sum++;
                    }
                }
                rows[i] = sum;
            }
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                res += rows[i] * (rows[i] - 1) / 2;
                res+= cols[i] * (cols[i] - 1) / 2;
            }
            Console.WriteLine(res);
        }
    }
}