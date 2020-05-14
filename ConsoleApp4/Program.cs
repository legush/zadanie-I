using System;

namespace ConsoleApp4
{
        public class lib1
        {
            public string stpow(string a, int b)
            {

                string result = "";

                for (int i = 0; i < b; i++)
                {

                    result += a;
                }
                return result;
            }

            public string rev(string a)
            {

                string result = "";

                for (int i = a.Length - 1; i >= 0; i--)
                {

                    result += a[i];
                }
                return result;
            }

            public string remov(string str, string s)
            {

                return str.Replace(s, "");
            }

            public int leng(string str)
            {

                return str.Length;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {

                lib1 n = new lib1();

                Console.WriteLine(n.stpow("la", 3));
                Console.WriteLine(n.rev("shrek"));
                Console.WriteLine(n.remov("wlsldall", "l"));
                Console.WriteLine(n.leng("wpeoiualdfs"));
            }
        }
    }


