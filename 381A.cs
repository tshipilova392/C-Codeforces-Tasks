using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] mas = new int[n];
            for(int i=0;i<n;i++)
            {
                mas[i] = int.Parse(s[i]);
            }
            int startPos = 0;
            int endPos = s.Length-1;
            int kol = n;
            bool f = true;
            int ser = 0;
            int dm = 0;
            while (kol>0)
            {
                if (mas[startPos]>mas[endPos])
                {
                    if (f)
                    {
                        ser += mas[startPos];
                    }
                    else
                    {
                        dm += mas[startPos];
                    }
                    startPos++;
                }
                else
                {
                    if (f)
                    {
                        ser += mas[endPos];
                    }
                    else
                    {
                        dm += mas[endPos];
                    }
                    endPos--;
                }
                f = !f;
                kol--;
            }
            Console.WriteLine("{0} {1}", ser, dm);
        }
    }
}
