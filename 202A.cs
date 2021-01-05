using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char maxC = 'A';
            int maxKol = 0;
            for (int i=0;i<s.Length;i++)
            {
                if (maxC<s[i])
                {
                    maxC = s[i];
                    maxKol = 0;
                }
                else
                {
                    if (maxC == s[i])
                        maxKol++;
                }
            }
            string res = new string(maxC, maxKol+1);
            Console.WriteLine(res);
        }
    }
}