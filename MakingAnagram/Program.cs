using System;
using System.Collections.Generic;
using System.Linq;

namespace MakingAnagram
{
    class Program
    {
        static int makeAnagram(string a, string b)
        {
            var aList = new List<char>(a.ToCharArray());
            var bList = new List<char>(b.ToCharArray());

            var result = aList.Count() - (from aItem in aList
                          where bList.Any(bItem => bItem == aItem)
                          select aItem).Count() +
                         bList.Count() -(from cItem in bList
                          where aList.Any(dItem => dItem == cItem)
                          select cItem).Count();

            var l1 = (from aItem in aList
                      where bList.Any(bItem => bItem == aItem)
                      select aItem).GroupBy(x => x).ToDictionary(x => x.Key,x=>x.Count());
            var l2 = (from cItem in bList
                      where aList.Any(dItem => dItem == cItem)
                      select cItem).GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());



            result=result + (from aItem in l1
                      join bItem in l2 on aItem.Key equals bItem.Key
                      select Math.Abs(aItem.Value - bItem.Value)).Sum();


                        
                
                
                


            return result;

        }
        static void Main(string[] args)
        {
            string a = "fcrxzwscanmligyxyvym";


            string b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";

            int res = makeAnagram(a, b);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
