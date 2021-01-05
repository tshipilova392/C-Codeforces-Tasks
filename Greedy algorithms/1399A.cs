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
                string[] s = Console.ReadLine().Split();
                List<int> nums = new List<int>();
                for(int j=0;j<s.Length;j++)
                {
                    nums.Add(int.Parse(s[j]));
                }
                nums.Sort();
                int kol = 0;
                for (int j = 0; j < nums.Count-1; j++)
                {
                    if (Math.Abs(nums[j]-nums[j+1])>1)
                    {
                        kol++;
                    }
                }
                Console.WriteLine(kol == 0 ? "YES" : "NO");
            }          
        }
    }
}
