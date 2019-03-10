using System;
using System.Collections.Generic;

namespace MarkAndToys
{
    class Program
    {
        static int maximumToys(int[] prices, int k)
        {
            int result = 0;
            List<int> pricesList = new List<int>(prices);
            pricesList.Sort();

            foreach (var price in pricesList){
                if (price < k)
                {
                    result = result + 1;
                    k = k - price;
                }
                else
                {
                    return result;
                }
            }           
            return result;

        }
        static void Main(string[] args)
        {
            int k = 50;

            int[] prices = Array.ConvertAll("1 12 5 111 200 1000 10".Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))  ;
            int result = maximumToys(prices, k);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
