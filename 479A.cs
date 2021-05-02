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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = a + b + c;
            if (a+b*c>max)
            {
                max = a + b * c;
            }
            if ((a + b) * c > max)
            {
                max = (a + b) * c;
            }
            if (a * b + c > max)
            {
                max = a * b + c;
            }
            if (a *( b + c) > max)
            {
                max = a * (b + c);
            }
            if (a * b * c > max)
            {
                max = a * b * c;
            }
            Console.WriteLine(max);
        }
    }
}
