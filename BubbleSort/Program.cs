using System;

namespace BubbleSort
{
    class Program
    {

        static void countSwaps(int[] arr)        
        {
            int endPoint = arr.Length - 1;
            int swapCount = 0;
            int swapPosition = 0;
            while(endPoint>0)
            {
                swapPosition = 0;
                for (int i = 0; i < endPoint; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapPosition = i;
                        swapCount += 1;
                    }
                }
                endPoint = swapPosition;
            }
            Console.WriteLine($"Array is sorted in {swapCount} swaps.\nFirst Element: {arr[0]}\nLast Element: {arr[arr.Length - 1]}");
        }

        static void Main(string[] args)
        {
            int[] a =new int[] { 3, 2, 1 };
            countSwaps(a);
            Console.ReadLine();
        }
    }
}
