using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            int[] a = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();
            Array.Sort(a);
            if (k == 0)
            {
                if (a[0]==1)
                    Console.WriteLine(-1);
                else
                    Console.WriteLine(1);
                return;
            }
            if (k==n)
            {
                Console.WriteLine(a[n-1]);
                return;
            }
            if (a[k-1]!=a[k])
            {
                Console.WriteLine(a[k - 1]);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
