using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankPractice
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            List<int> l = new List<int>(ar);
            int result =l.GroupBy(a => a).Select(grp => grp.Count()).Sum(x => ((x - (x % 2)) / 2));
            return result;                        
        }
        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = 9; //Convert.ToInt32(Console.ReadLine());
            var inp = "10 20 20 10 10 30 50 10 20";
            int[] ar = Array.ConvertAll(inp.Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
            Console.ReadLine();

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
