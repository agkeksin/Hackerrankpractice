using System;


namespace TwoDimensionalArrayDs
{
    class Program
    {

        static int hourglassSum(int[][] arr)
        {
            int rowsize = arr.GetLength(0);
            int colsize = arr[0].GetLength(0);
            int maxTotal = 0;
            bool firstCalculation = true;
            for (int x = 0; x < rowsize - 2; x++)
            {
                for (int y = 0; y < colsize - 2; y++)
                {
                    int[,] hourglass = createHourGlass(x, y, arr);
                    int hourglassTotal = calculateHourGlass(hourglass);
                    //  Console.WriteLine($"start poiint({x},{y})");
                    //  Console.WriteLine($"Max Total: {maxTotal} HourGlass Total: {hourglassTotal}");
                    if (maxTotal < hourglassTotal || firstCalculation)
                    {
                        maxTotal = hourglassTotal;
                    }
                    if (x== 0 && y == 0)
                    {
                        firstCalculation = false;
                    }
                   
                    
                }
            }
              
            
            return maxTotal;
        }

        static int[,] createHourGlass(int startx, int starty, int[][] sourceArr)
        {
            int[,] resultArr = new int[3,3];
            int i = 0;
            int k = 0;
            for (int x = startx; x < startx + 3; x++)
            {
                for (int y = starty; y < starty + 3; y++)
                {
                    resultArr[i,k] = sourceArr[x][y];
                    k = k + 1;
                }
                i = i + 1;
                k = 0;
            }

            return resultArr;
        }

        static int calculateHourGlass(int[,] arr)
        {
            int result = 0;
            for(int x=0; x<3; x++)
                for(int y=0; y < 3; y++)
                {
                    
                    if (!isInvalidPoint(x,y))
                    {
                        result = result + arr[x,y];
                    }
                }           
            return result;
        }

        static bool isInvalidPoint(int x,int y)
        {
            return ((x== 1 && y == 0) || (x==1&&y== 2));
        }

        static void Main(string[] args)
        {
            int[][] arr = new int[][] { new int[]{1, 1, 1, 0, 0, 0 },
                           new int[]{0,1,0,0,0,0},
                           new int[]{1,1,1,0,0,0},
                           new int[]{0,0,2,4,4,0},
                           new int[]{0,0,0,2,0,0},
                           new int[]{0,0,1,2,4,0} };

            int result = hourglassSum(arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
