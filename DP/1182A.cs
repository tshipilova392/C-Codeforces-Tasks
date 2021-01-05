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
            if (n%2==1)
            {
                Console.WriteLine(0);
                return;
            }
            int k = n / 2;
            Console.WriteLine(Math.Pow(2, k));
        }
    }
}