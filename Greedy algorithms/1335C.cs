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
            for (int i=0;i<n;i++)
            {
                int k = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split();
                List<int> mas = new List<int>();
                //HashSet<int> h = new HashSet<int>();
                foreach(var s1 in s)
                {
                    mas.Add(int.Parse(s1));
                }
                mas.Sort();
                int kolDif = 0;
                int kolEq = 0;
                int max = 0;
                for (int j=0; j<mas.Count-1;j++)
                {                  
                    if (mas[j]!=mas[j+1])
                    {
                        kolDif++;
                        if (kolEq > max)
                            max = kolEq;
                        kolEq = 0;
                    }
                    else
                    {
                        kolEq++;
                    }
                }
                if (kolEq > max)
                    max = kolEq;
                kolDif++;
                max++;
                if (kolDif<max)
                    Console.WriteLine(kolDif);
                if (kolDif == max)
                    Console.WriteLine(kolDif-1);
                if (kolDif > max)
                    Console.WriteLine(max);
            }
        }
    }
}