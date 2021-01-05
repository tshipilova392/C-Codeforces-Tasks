using System;
using System.Collections.Generic;
using System.Numerics;
 
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            for (int i=0;i<s1.Length;i++)
            {
                if (s1[i] != s2[i])
                    Console.Write('1');
                else
                    Console.Write('0');
            }
        }
    }
}