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
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int max = 0;
            for (int i=0;i<n;i++)
            {
                int k = int.Parse(Console.ReadLine());
                a[i] = k;  
            }
            for (int i = 0; i < n; i++)
            {
                int tmp = a[i];
                int kol = 1;
                while (tmp!=-1)
                {
                    kol++;
                    tmp = a[tmp-1];
                }
                if (kol > max)
                    max = kol;
            }
            Console.WriteLine(max);
        }
    }
}