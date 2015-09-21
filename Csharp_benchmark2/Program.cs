using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_benchmark2
{
    class Program
    {
        static char[] charlist = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        static int times = 100000000;
        static IEnumerable<char> c;
        //static char[] rndword = new char[10];
        

        static void Main(string[] args)
        {
            Console.WriteLine(times + "回ループします。");
            //Random random = new Random();
            DateTime start = DateTime.Now;
            Console.WriteLine("start : " + start.ToString("mm:ss.fff"));
            
            
            while (times != 0)
            {
                c = charlist.OrderBy(a => Guid.NewGuid()).Take(10);

                /*１分30秒ぐらいかかる
                for (int i = 0; i < 10; i++)
                {
                    rndword[i] = charlist[random.Next(charlist.Length)];
                }
                 * */
                    
                //Console.WriteLine(c.ToArray());
                times--;
            }
            
            DateTime end = DateTime.Now;
            Console.WriteLine("end : " + end.ToString("mm:ss.fff"));

            TimeSpan margin = end - start;
            Console.WriteLine("margin : {0}:{1}.{2}", margin.Minutes, margin.Seconds, margin.Milliseconds);

            Console.WriteLine("何かのキーを押してください");
            Console.ReadLine();
        }
    }
}
