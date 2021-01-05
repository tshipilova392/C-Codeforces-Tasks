using System;
using System.Text;
 
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            StringBuilder st = new StringBuilder();
            int pos = 0;
            while (pos<s.Length)
            {
                if (s[pos] == '.')
                {
                    st.Append('0');
                    pos++;
                }
                else
                {
                    int i = pos;
                    if ((s[i] == '-') && (s[i + 1] == '.'))
                    {
                        st.Append('1');
                        pos += 2;
                    }
                    if ((s[i] == '-') && (s[i + 1] == '-'))
                    {
                        st.Append('2');
                        pos += 2;
                    }
                }
            }
            Console.WriteLine(st.ToString());
        }
    }
}