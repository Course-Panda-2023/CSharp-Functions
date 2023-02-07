using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Solution
    {
        /*
         * Notice: Write helper functions in `Helper` class unless there is a special class for it
         */

        #region Assignment solutions
        public static void Assignment1(int low, int high, out int res)
        {
            Random rnd = new Random();
            if (low < high)
            {
                res = rnd.Next(low, high);
            }
            else 
            {
                throw new Exception("input is not valid");
            }
        }

        public static void Assignment3()
        {
            RockPaperScissors.runGame();
        }

        public static double[] Assignment4(bool isAsc, params double[] nums)
        {
            double[] arr = isAsc ? Helper.MinSort(nums) : Helper.MaxSort(nums);
            return arr;
            
        }

        public static void Assignment5(string str, char[] letters)
        {
            /*
             * TODO: Write code here
             */
        }

        public static bool Assignment6(string str)
        {
            /*
             * TODO: Write code here
             */
        }

        public static int Assignment7(int[] nums)
        {
            /*
             * TODO: Write code here
             */
        }

        public static void Assignment8(bool[,] board, int rows, int cols)
        {
            /*
             * TODO: Write code here
             */
        }

        public static int Assignment9()
        {
            /*
             * TODO: Write code here
             */
        }
        #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            /*
             * TODO: Write code here
             */
        }

        public static int Bonus2(int[] hightMap)
        {
            int index = 0;
            int sumWaterCubes = 0;
            int currHight = hightMap[index];
            int maxHight;

            while (currHight == 0 && index<hightMap.Length)
            {
                currHight = hightMap[index];
                index++;

            }
            maxHight = currHight;

            while (index < hightMap.Length) {

                currHight = hightMap[index];

                if (findWall(hightMap, index, maxHight) && maxHight != 0)
                {
                    if (currHight <= maxHight)
                    {
                        sumWaterCubes += maxHight - currHight;
                        index++;

                    }
                    else
                    {
                        maxHight = currHight;
                        index++;
                    }
                }
                else
                {
                    maxHight--;
                    if (maxHight == 0)
                    {
                        break;
                    }
                }
            }

            return sumWaterCubes;

        }

        public static Boolean findWall(int[] hightMap, int startIndex, int wallHight)
        {
            for (int currIndex=startIndex ; currIndex < hightMap.Length; currIndex++)
            {
                if (hightMap[currIndex] >= wallHight)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
