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
            var s = Console.ReadLine();
            var s2 = "";
            var kol1 = 1;
            var kol2 = 0;
            for (int i=1;i<n;i++)
            {
                var s1 = Console.ReadLine();
                if (s==s1)
                {
                    kol1++;
                }
                else
                {
                    s2 = s1;
                    kol2++;
                }
            }
            Console.WriteLine(kol1 > kol2 ? s : s2);
        }
    }
}
