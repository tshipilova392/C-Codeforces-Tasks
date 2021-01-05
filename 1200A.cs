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
            string s = Console.ReadLine();
            List<bool> b = new List<bool>();
            for (int i = 0; i < 10; i++)
            {
                b.Add(false);
            }
            for (int i = 0; i < n; i++)
            {
                if (s[i]=='L')
                {
                    int ind = b.FindIndex(x => x == false);
                    b[ind] = true;
                }
                else
                {
                    if (s[i] == 'R')
                    {
                        int ind = b.FindLastIndex(x => x == false);
                        b[ind] = true;
                    }
                    else
                    {
                        int c = int.Parse(s[i].ToString());
                        b[c] = false;
                    }
                }
            }
            foreach(var x in b)
            {
                Console.Write(x ? 1 : 0);
            }
        }
    }
}