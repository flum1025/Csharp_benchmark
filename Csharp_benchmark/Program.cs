using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_benchmark
{
    class Program
    {
        private static int times = 100000000;
        private static readonly string Chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static void Main(string[] args)
        {
            Console.WriteLine(times + "回ループします");

            DateTime start = DateTime.Now;
            string starttime = start.ToString("mm:ss.fff");
            Console.WriteLine("start : " + starttime);

            string randchar = null;
            int len = 10;
            
            for(int i = 0; i < times; i++){
                randchar = RandomChars(len);
            }
            
            DateTime end = DateTime.Now;
            string endtime = end.ToString("mm:ss.fff");
            Console.WriteLine("end : " + endtime);

            TimeSpan margin = end - start;
            //string margin_c = margin.ToString("mm:ss.fff");
            Console.WriteLine("margin : {0}:{1}.{2}", margin.Minutes, margin.Seconds, margin.Milliseconds);

            
        }

        public static string RandomChars(int length)
        {
            StringBuilder sb = new StringBuilder(length);
            Random r = new Random();

            for (int i = 0; i < length; i++)
            {
                int pos = r.Next(Chars.Length);
                char c = Chars[pos];
                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
