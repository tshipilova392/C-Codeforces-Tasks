using System;
using System.Collections.Generic;
using System.Numerics;
 
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(new char[] { ',', '{', '}',' '});
            HashSet<string> set = new HashSet<string>();
            foreach(var k in s)
            {
                set.Add(k);
            }
            Console.WriteLine(set.Count-1);
        }
    }
}