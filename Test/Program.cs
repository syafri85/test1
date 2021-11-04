using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Test3(30, 0));
            //Console.WriteLine(Test3(25, 5));
            //Console.WriteLine(Test3(20, 30));
            //Console.WriteLine(Test3(20, 25));
            //Console.ReadLine();

            //Console.WriteLine(Test4(103));
            //Console.WriteLine(Test4(90));
            //Console.WriteLine(Test4(89));
            //Console.ReadLine();

            //Console.WriteLine(Test5("IF else"));
            //Console.WriteLine(Test5("else"));
            //Console.ReadLine();

            //Console.WriteLine(Test7("abcde"));
            //Console.WriteLine(Test7("abcd"));
            //Console.WriteLine(Test7("a"));
            //Console.WriteLine(Test7("xy"));
            //Console.ReadLine();

            //Console.WriteLine(Test8("C Sharp"));
            //Console.WriteLine(Test8("JS"));
            //Console.WriteLine(Test8("a"));
            //Console.ReadLine();

            Console.WriteLine(Test9("Red"));
            Console.WriteLine(Test9("Green"));
            Console.WriteLine(Test9("1"));
            Console.ReadLine();
        }
        
        public static int Test2(int a)
        {
            int v = 51;
            if (a > v)
            {
                return (a - v) * 3;
            }
            return v - a;
        }

        public static bool Test3(int a, int b)
        {
            return a == 30 || b == 30 || (a + b == 30);
        }

        //to check a given integer and return true if it is within 10 of 100 or 200
        //it is within 10 = mencapai 10 dari 100 atau 200
        public static bool Test4(int x)//int Test4(int a)
        {
            //return Math.Abs(a - 100);
            if (Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10)
                return true;
            return false;
        }

        public static string Test5(string a)
        {
            //if (!a.ToLower().StartsWith("if"))
            //{
            //    return "if " + a;
            //}
            if (a.Length > 2 && a.Substring(0, 2).Equals("if"))
            {
                return a;
            }

            return a;
        }

        public static string Test7(string str)
        {
            return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }

        public static string Test8(string str)
        {
            return str.Length < 2 ? str : str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
        }

        public static string Test9(string str)
        {
            return str.Substring(str.Length - 1) + str + str.Substring(str.Length - 1);
        }

        public static bool Test10(int a)
        {
            return a % 3 == 0 || a % 7 == 0;
        }
    }
}
