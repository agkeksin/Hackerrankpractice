using System;
using System.Collections.Generic;

namespace AbsoluteDifference
{
    class Program
    {
        static int minimumAbsoluteDifference(int[] arr)
        {
            List<int> l = new List<int>(arr);
            l.Sort();
            int remain = 0;


            remain = Math.Abs(l[l.Count - 1] - l[l.Count - 2]);
            for(int i = l.Count-2; i>0; i--)
            {
                int temp = Math.Abs( l[i] - l[i - 1]);
                if (remain > temp)
                    remain = temp;
            }

            return remain;
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll("3 -7 0".Split(' '), arrTemp => Convert.ToInt32(arrTemp))
    ;
            int result = minimumAbsoluteDifference(arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
