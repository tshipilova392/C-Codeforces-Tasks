using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            int x = Math.Max(n, m);
            int y = 6 - x + 1;
            if (y == 6)
                Console.WriteLine("1/1");
            if (y == 5)
                Console.WriteLine("5/6");
            if (y == 4)
                Console.WriteLine("2/3");
            if (y == 3)
                Console.WriteLine("1/2");
            if (y == 2)
                Console.WriteLine("1/3");
            if (y == 1)
                Console.WriteLine("1/6");
        }
    }
}
