using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static bool IsPossible(string s1, string s2, string s3)
        {
            int startIndex = s1.IndexOf(s2);
            if (startIndex==-1)
            {
                return false;
            }
            else
            {
                startIndex += s2.Length;
                if (startIndex < s1.Length)
                {
                    startIndex = s1.IndexOf(s3, startIndex);
                    if (startIndex == -1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                    return false;
            }

            
        }
        public static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            bool f1 = IsPossible(s1, s2, s3);
            s1 = new string(s1.Reverse().ToArray());
            bool f2 = IsPossible(s1, s2, s3);
            if (f1 && !f2)
            {
                Console.WriteLine("forward");
            }
            if (!f1 && f2)
            {
                Console.WriteLine("backward");
            }
            if (f1 && f2)
            {
                Console.WriteLine("both");
            }
            if (!f1 && !f2)
            {
                Console.WriteLine("fantasy");
            }
        }
    }
}
