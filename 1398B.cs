using System;

namespace ConsoleApp2
{
    class Program
    {
        static void FindLongestSequence(string s,out int a, out int b)
        {
            int max = 0;
            int k = 0;
            int endPos = 0;

            for (int i=0;i<s.Length;i++)
            {
                if (s[i] == '1')
                {
                    k++;
                }
                else
                {
                    if (k > max)
                    {
                        max = k;                      
                        endPos = i - 1;
                    }
                    k = 0;
                }
            }
            if (k > max)
            {
                max = k;
                endPos = s.Length - 1;
            }
            a = endPos - max+1;
            b = max;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i=0;i<n;i++)
            {
                int alice = 0;
                string s = Console.ReadLine();
                int j = 0;
                while (s.IndexOf('1')!=-1)
                {
                    int a, b;
                    FindLongestSequence(s, out a, out b);
                    s = s.Remove(a, b);
                    if (j % 2 == 0)
                        alice += b;
                    j++;
                }
                Console.WriteLine(alice);
            }
        }
    }
}
