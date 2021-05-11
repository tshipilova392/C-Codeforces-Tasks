using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Program
    {
        

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            Array.Sort(s);
            int towerAmount = 1;
            int highestTower = 1;
            int kol = 1;
            for (int i=1;i<s.Length;i++)
            {
                if (s[i]==s[i-1])
                {
                    kol++;
                }
                else
                {
                    towerAmount++;
                    if (kol>highestTower)
                    {
                        highestTower = kol;
                    }
                    kol = 1;
                }
            }
            if (kol > highestTower)
            {
                highestTower = kol;
            }
            Console.WriteLine("{0} {1}", highestTower, towerAmount);
        }
    }
}
