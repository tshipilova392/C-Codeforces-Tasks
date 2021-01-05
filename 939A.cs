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
            string[] s = Console.ReadLine().Split();
            List<int> mas = new List<int>();
            List<bool> visited = new List<bool>();
            for (int i=0;i<n;i++)
            {
                mas.Add(int.Parse(s[i]));
                visited.Add(false);
            }
            int ind = visited.FindIndex(x => x == false);
            bool f = false;
            while (ind !=-1)
            {
                int ind1 = mas[ind]-1;
                int ind2 = mas[ind1]-1;
                int ind3 = mas[ind2]-1;
                if (ind==ind3)
                {
                    Console.WriteLine("YES");
                    f = true;
                    break;
                }
                visited[ind]=true;
                ind = visited.FindIndex(x => x == false);
            }
            if (!f)
            Console.WriteLine("NO");
        }
    }
}