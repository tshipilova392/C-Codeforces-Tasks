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
            int t = int.Parse(Console.ReadLine());
            
            for (int i=0;i<t;i++)
            {
                var n = int.Parse(Console.ReadLine());
                int[] s = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();
                int[] a = new int[5001];
                int[] b = new int[5001];
                bool f = true;
                for (int j=0;j<n;j++)
                {
                    if (a[s[j]]==0)
                    {
                        a[s[j]]++;
                        b[s[j]] = j;
                    }
                    else
                    {
                        if (a[s[j]]==1)
                        {
                            if (j-b[s[j]]>1)
                            {
                                Console.WriteLine("YES");
                                f = false;
                                break;
                            }
                        }
                    }
                }
                if (f)
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
