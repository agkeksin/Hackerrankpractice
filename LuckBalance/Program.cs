using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckBalance
{
 
    class Program
    {
        static int luckBalance(int k, int[][] contests)
        {
            int rowsize = contests.GetUpperBound(0)+1;                       
            int importantContestCount = 0;
            List<int> importantItemList = new List<int>();
            int total = 0;
            for (int x = 0; x < rowsize; x++)
            {
                total = contests[x][0] + total;
                if (contests[x][1] == 1)
                {
                    importantContestCount++;
                    importantItemList.Add(contests[x][0]);
                }
            }
            int losableContestCount = importantContestCount - k;
            int result = total - (from item in importantItemList
                                  select item).OrderBy(x => x).Take(losableContestCount).Sum()*2;
            
            return result;             
       }

       

        static void Main(string[] args)
        {
            int n = 6;
            int k = 3;

            int[][] contests = new int[][]
                { new int[]{5 , 1 },
                  new  int[]{2, 1 },
                  new  int[]{1, 1},
                  new  int[]{ 8, 1},
                  new  int[]{10, 0 },
                  new  int[]{5, 0 }
                };
            int result = luckBalance(k, contests);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
