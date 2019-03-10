using System;
using System.Collections.Generic;

namespace CountingValleys
{
    class Program
    {
        static int CountingValleys(int n, string s)
        {
            int sea_level = 10;
            var sList = new List<char>(s.ToCharArray());
            int current_level = sea_level;
            int newLevel = current_level;
            bool isEnterValley = false;
            int valleyCount = 0;
            foreach(char c in sList)
            {
                newLevel = Step(current_level, c);
                if (!isEnterValley)
                {
                    isEnterValley = IsEnterValley(sea_level, current_level, newLevel);
                }
                if (isEnterValley)
                {
                    if (IsClimbSeaLevel(sea_level, newLevel, current_level))
                    {
                        valleyCount = valleyCount + 1;
                        isEnterValley = false;
                    }                    
                }
                current_level = newLevel;
            }
            return valleyCount;
        }

        static int UpDownValue(char s)
        {
            if (s == 'U')
                return 1;
            else if (s == 'D')
                return -1;
            return 0;
        }

        static int Step(int currentLevel, char s)
        {
            int newLevel = currentLevel + UpDownValue(s);
            return newLevel;
        }
        static bool IsEnterValley(int sealevel, int currentLevel,int newLevel)
        {
            return currentLevel == sealevel && newLevel < sealevel;                                   
        }

        static bool IsClimbSeaLevel(int sealevel, int newLevel, int currentLevel)
        {
            return (currentLevel < sealevel && newLevel == sealevel);       
        }

        static void Main(string[] args)
        {

            int n = 8;// Convert.ToInt32(Console.ReadLine());

            string s = "UDDDUDUU"; //Console.ReadLine();

            int result = CountingValleys(n, s);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
