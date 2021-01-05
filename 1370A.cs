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
            for (int i=0;i<x;i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n / 2);
            }          
        }
    }
}
