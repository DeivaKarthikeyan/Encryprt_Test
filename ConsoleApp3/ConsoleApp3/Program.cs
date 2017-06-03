using System;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    static class Program
    {
        static void Main(string[] args)
        {
            //string strings =   "ABCDEF";
            // var res =  strings.Reverse();
            //  Console.Write(res);

            int[] arr = { 12, 13, 24, 45, 65, 27, 37, 43, 41, 50, 75, 68 };
            var q = arr.OrderByDescending(a => a).ToArray();
            for (int i = 0; i < q.Count(); i++)
            {
                if (i == 2)
                { Console.WriteLine(q[i].ToString()); break; }
            }
            

            Console.ReadKey();

        }

        private static string Reverse(this string s)
            {
            char[] chars = s.ToCharArray();

            StringBuilder str = new StringBuilder();

            for (int i = chars.Length-1;i>=0;i--)
            {
                str.Append(chars[i]);
            }

            return str.ToString();

            }

        public static int thirdLargestNumber(int[] numbers):Reverse
        {
            int[] arr = { 12, 13, 24, 45, 65, 27, 37, 43, 41, 50, 75, 68 };
            var q = arr.OrderByDescending(a => a).ToArray();
            for (int i = 0; i < q.Count(); i++)
            {
                if (i == 2)
                { Console.WriteLine(q[i].ToString()); break; }
            }
            return 0;
        }
    }
}

