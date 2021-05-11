using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Program
    {
        public class Laptop : IComparable
        {
            public int price;
            public int quality;
            public Laptop(int price,int quality)
            {
                this.price = price;
                this.quality = quality;
            }

            public int CompareTo(object obj)
            {
                var t = (Laptop)obj;
                if (price>t.price)
                {
                    return 1;
                }
                else
                {
                    if (price == t.price)
                    {
                        if (quality>t.quality)
                        {
                            return 1;
                        }
                        else
                        {
                            if (quality == t.quality)
                            {
                                return 0;
                            }
                            else
                            {
                                return -1;
                            }
                        }
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[10001];
            int[] s;
            List<Laptop> laptopList = new List<Laptop>();
            for (int i=0;i<n;i++)
            {
                s = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();
                Laptop lap = new Laptop(s[0], s[1]);
                laptopList.Add(lap);
            }
            laptopList.Sort();
            bool f = false;
            for (int i=1;i<n;i++)
            {
                if (laptopList[i].price!=laptopList[i-1].price)
                {
                    if (laptopList[i].quality < laptopList[i - 1].quality)
                    {
                        Console.WriteLine("Happy Alex");
                        f = true;
                        break;
                    }
                }
            }
            if (!f)
            {
                Console.WriteLine("Poor Alex");
            }
        }
    }
}
