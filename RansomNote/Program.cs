using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RansomNote
{
    class Program
    {
        static void checkMagazine(string[] magazine, string[] note)
        {

            IDictionary<string, int> magazineDictionary = StrToDictionary(magazine);
            IDictionary<string, int> noteDictionary = StrToDictionary(note);
            IDictionaryEnumerator en =(IDictionaryEnumerator) noteDictionary.GetEnumerator();
            string result = "Yes";
            while(en.MoveNext())
            {
                if(!magazineDictionary.ContainsKey(en.Key.ToString()))
                {
                    result = "No";
                    break;
                }
                if (magazineDictionary[en.Key.ToString()] < Convert.ToInt32(en.Value))
                {
                    result = "No";
                    break;
                }
            }            
            Console.WriteLine(result);         

        }
        static IDictionary<string,int> StrToDictionary(string[]arr)
        {
            List<string> words = new List<string>(arr);
            IDictionary<string, int> wordDictionary = arr.GroupBy(group => group).ToDictionary(g => g.Key, g => g.Count());
            return wordDictionary;
        }

        static void Main(string[] args)
        {
            string[] magazine = "ive got a lovely bunch of coconuts".Split(' ');

            string[] note = "ive got some coconuts".Split(' ');

            checkMagazine(magazine, note);
            Console.ReadLine();
        }
    }
}
