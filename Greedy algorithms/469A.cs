using System;
using System.Collections.Generic;
using System.Numerics;
 
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s1 = Console.ReadLine().Split();
            string[] s2 = Console.ReadLine().Split();
            HashSet<string> set = new HashSet<string>();
 
            for(int i=1;i < s1.Length;i++)
            {
                set.Add(s1[i]);
            }
            for (int i = 1; i < s2.Length; i++)
            {
                set.Add(s2[i]);
            }
            if (set.Contains("0"))
                set.Remove("0");
            Console.WriteLine(set.Count == n ? "I become the guy." : "Oh, my keyboard!");
        }
    }
}