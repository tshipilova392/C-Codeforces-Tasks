using System;
using System.Collections.Generic;
using System.Numerics;
 
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string s;
            long sum = 0;
            for (int i=0;i<n;i++)
            {
                s = Console.ReadLine();
                if (s == "Tetrahedron")
                    sum += 4;
                if (s == "Cube")
                    sum += 6;
                if (s == "Octahedron")
                    sum += 8;
                if (s == "Dodecahedron")
                    sum += 12;
                if (s == "Icosahedron")
                    sum += 20;
            }
            Console.WriteLine(sum);
        }
    }
}