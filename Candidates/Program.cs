using System;

namespace Candidates
{
    class Program
    {
        static long candies(int n, int[] arr)
        {
            int[] dp = new int[n];

            int nextValue = 0;
            dp[0] = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (i + 1 < arr.Length)
                    nextValue = arr[i + 1];
                else
                    nextValue = Int32.MaxValue;

                if (arr[i - 1] >= arr[i] && arr[i] <= nextValue)
                    dp[i] = 1;

            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (i + 1 < arr.Length)
                    nextValue = arr[i + 1];
                else
                    nextValue = Int32.MaxValue;

                if (arr[i - 1] < arr[i] && arr[i] <= nextValue)
                    dp[i] = dp[i - 1] + 1;
            }
            for (int i = arr.Length - 1; i > 0; i--)
            {

                if (i + 1 < arr.Length)
                    nextValue = arr[i + 1];
                else
                    nextValue = Int32.MaxValue;


                if (arr[i - 1] >= arr[i] && arr[i] > nextValue)
                    dp[i] = dp[i + 1] + 1;
            }
            for (int i = 1; i < arr.Length; i++)
            {

                if (i + 1 < arr.Length)
                    nextValue = arr[i + 1];
                else
                    nextValue = Int32.MaxValue;

                if (arr[i - 1] < arr[i] && arr[i] > nextValue)
                    dp[i] = Math.Max(dp[i - 1], dp[i + 1]) + 1;

            }
            long sum = 0;
            Array.ForEach(dp, element => sum = sum + element);
            return sum;
        }
        static void Main(string[] args)
        {
            int n = 10;

            int[] arr = new int[] //{ 1, 2, 2 };
            {2,4,2,6,1,7,8,9,2,1};    

            long result = candies(n, arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
