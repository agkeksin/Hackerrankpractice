using System;
using System.Collections.Generic;
using System.Linq;

namespace KocSistem
{
    class Program
    {
        class Result {
            public static int SumOfPrimePalindromeNumbersDigits(int maxValue)
            {
                int total = 0;
                for (int i = 2; i <= maxValue; i++)
                {
                    if (IsAsal(i))
                    {
                        if (IsPalindrom(i))
                            total = total + i;
                    }
                }
                return SumOfDigits(total);
            }

            private static string GetPalindrom(string value)
            {
                string s1 = value;
                string s2 = "";

                for (int i = s1.Length - 1; i > -1; i--)
                {
                    s2 = s2 + s1[i];
                }
                return s2;
            }

            private static bool IsPalindrom(int number)
            {
                string s1 = number.ToString();
                string s2 = GetPalindrom(s1);


                return s2 == s1;
            }

            private static bool IsAsal(int number)
            {
                if (number == 2)
                    return true;
                int kalan = 0;
                for (int i = 2; i < number; i++)
                {
                    kalan = number % i;
                    if (kalan == 0)
                        return false;
                    
                }
                return true;
            }

            private static int SumOfDigits(int total)
            {
                int sum = 0;
                string s = total.ToString();
                foreach (var c in s)
                {
                    sum = sum + Int32.Parse(c.ToString());
                }

                return sum;
            }

        }
     
        static void Main(string[] args)
        {
            int result = Result.SumOfPrimePalindromeNumbersDigits(200);
            Console.WriteLine(result);
            Console.ReadLine();



            //List<List<int>> scheduleList = new List<List<int>>();
            
            //        scheduleList.Add(new List<int>(new int[] { 1, 2 }));
            //        scheduleList.Add(new List<int>(new int[] { 3, 5 }));
            //        scheduleList.Add(new List<int>(new int[] { 4, 8 }));                    
            //        scheduleList.Add(new List<int>(new int[] { 9, 10 }));
            //        scheduleList.Add(new List<int>(new int[] { 10, 12 }));

            //MergeSchedule(scheduleList);

            //List<string> salesManager = new List<string>(new string[] { "Oya", "Ahmet", "Mehmet", "Osman", "Ayşe", "Fatma", "Ozan", "Caner", "Hakan", "Ayşe" });
            //List<int> salesCount = new List<int>(new int[] { 7, 5, 3, 7, 3, 6, 5, 30, 7, 5 });


            //string result = FindRepetitiveMaximumNumber(salesManager, salesCount);
            //Console.WriteLine(result);
            //Console.ReadLine();
        }

        public static List<List<int>> MergeSchedule(List<List<int>> scheduleList)
        {
            List<List<int>> newScheduleList = new List<List<int>>();
            for (int i = 0; i < scheduleList.Count - 1; i++)
            {
                List<int> s = scheduleList[i];
                bool f = false;
                for (int k = i + 1; k < scheduleList.Count(); k++)
                {

                    List<int> s1 = scheduleList[k];
                    if (s[1] >= s1[0])
                    {
                        f = true;
                        newScheduleList.Add(new List<int>(new int[] { s[0], s1[1] }));
                        i = k;
                    }
                }
                if (!f) newScheduleList.Add(s);
            }
            return newScheduleList;
        }
        public static string FindRepetitiveMaximumNumber(List<string> salesManager, List<int> salesCount)
        {
            var d = (from a in salesCount.GroupBy(x => x).OrderByDescending(a => a.Key).OrderByDescending(b => b.Count())
                     select a.Key).ToList()[0];
            List<string> s = new List<string>();

            for (int i = 0; i < salesCount.Count; i++)
            {

                if (d == salesCount[i])
                {
                    s.Add(salesManager[i]);
                }
            }

            var s1 = (from a in s.OrderBy(x => x) select a).ToList()[0];
            return $"{s1} {d}";

        }
    }
}
