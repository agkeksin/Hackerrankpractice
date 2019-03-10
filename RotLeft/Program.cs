using System;

namespace RotLeft
{
    class Program
    {
        static int[] rotLeft(int[] a, int d)
        {
            int lastIndex = a.GetUpperBound(0);
            int rotatioCount = d % a.Length;            
            for (int i = 0; i < rotatioCount; i++)
            {
                int first = a[0];
                Array.Copy(a, 1, a, 0, a.Length-1);
                a[lastIndex] = first;
            }

            return a;

        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int count = 4;
            int[] result = rotLeft(a, count);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
