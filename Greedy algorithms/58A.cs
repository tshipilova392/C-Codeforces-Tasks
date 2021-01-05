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
            int pos = 0;
            int ind = s.IndexOf('h', pos);
            if (ind==-1)
            {
                Console.WriteLine("NO");
                return;
            }
            pos = ind;
            ind = s.IndexOf('e', pos+1);
            if (ind == -1)
            {
                Console.WriteLine("NO");
                return;
            }
            pos = ind;
            ind = s.IndexOf('l', pos+1);
            if (ind == -1)
            {
                Console.WriteLine("NO");
                return;
            }
            pos = ind;
            ind = s.IndexOf('l', pos+1);
            if (ind == -1)
            {
                Console.WriteLine("NO");
                return;
            }
            pos = ind;
            ind = s.IndexOf('o', pos+1);
            if (ind == -1)
            {
                Console.WriteLine("NO");
                return;
            }
            Console.WriteLine("YES");
        }
    }
}