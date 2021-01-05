using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = double.Parse(Console.ReadLine());
            if (n%2==0)
            {
                Console.WriteLine(Math.Truncate(n/2));
            }
            else
            {
                Console.WriteLine(Math.Truncate(n/2)-n);
            }           
        }
    }
}
