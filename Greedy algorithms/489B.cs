using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k1 = int.Parse(Console.ReadLine());
            string[] s1 = Console.ReadLine().Split();
            int k2 = int.Parse(Console.ReadLine());
            string[] s2 = Console.ReadLine().Split();
            List<int> mas1 = new List<int>();
            List<int> mas2 = new List<int>();
            
            foreach (var x in s1)
            {
                mas1.Add(int.Parse(x));
            }
            foreach (var x in s2)
            {
                mas2.Add(int.Parse(x));
            }
            mas1.Sort();
            mas2.Sort();
            int startPos = 0;
            int kol = 0;
            foreach(var x in mas1)
            {
                for (int i=startPos;i<k2;i++)
                {
                    int dif = x - mas2[i];
                    if (Math.Abs(dif) <= 1)
                    {
                        kol++;
                        startPos++;
                        break;
                    }
                    if (dif > 1)
                        startPos++;
                }
            }
            Console.WriteLine(kol);
        }
    }
}