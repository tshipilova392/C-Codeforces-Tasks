using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i=0;i<n;i++)
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine((a - 1) / 2);
            }
        }
    }
}
