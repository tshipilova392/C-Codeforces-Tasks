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
            string[] s = Console.ReadLine().Split();
            int[] a = new int[100];
            int[,] b = new int[n,100];
            for (int i=0;i<n;i++)
            {
                int k = int.Parse(s[i]);
                for (int j=0;j<k;j++)
                {
                    a[j]++;
                }
            }
            for (int j = 0; j < 100; j++)
            {
                int kol = a[j];
                for (int i = 0; i < kol; i++)
                {
                    b[i, j]++;
                }
            }
            for (int i = n-1; i >=0; i--)
            {
                int sum = 0;
                for (int j=0;j<100;j++)
                {
                    sum+=b[i,j];
                }
                Console.Write("{0} ", sum);
            }
        }
    }
}