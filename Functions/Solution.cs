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

        //#region Assignment solutions
        public static void Assignment1(int low, int high, out int res)
        {
            if (low > high)
            {
                res = -1;
                return;
            };
            Random rnd = new Random();
            res = rnd.Next(low, high);
        }

        public static void Assignment3()
        {
            RockPaperScissors.RPS firstPlayer = getMove();
            RockPaperScissors.RPS secondPlayer = getMove()
            if (firstPlayer == secondPlayer)
            {
                Console.WriteLine("It's a tie!");
                return;
            }
            int i = firstPlayer - secondPlayer;
            string win;
            if (i == -1 || i == 1)
            {
                win = firstPlayer > secondPlayer ? "First player wins!" : "Second player wins!";

            }
            else
            {
                win = firstPlayer > secondPlayer ? "Second player wins!" : "First player wins!";
            }
            Console.WriteLine(win);
        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {

            double temp;
            for (int j = 0; j <= nums.Length - 2; j++)
            {
                for (int i = 0; i <= nums.Length - 2; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        temp = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = temp;
                    }
                }
            }
            if (!asc)
            {
                reversArray(nums);
            }
            return nums;
        }

        public static void assignment5(string str, char[] letters)
        {
            
        }

        //public static bool Assignment6(string str)
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}

        //public static int Assignment7(int[] nums)
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}

        //public static void Assignment8(bool[,] board, int rows, int cols)
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}

        //public static int Assignment9()
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}
        //#endregion
        ////ex1
        //void getRand(int minNum, int maxNum, out int temp)
        //{
        //    if (minNum > maxNum)
        //    {
        //        temp = -1;
        //        return;
        //    };
        //    Random rnd = new Random();
        //    temp = rnd.Next(minNum, maxNum);
        //}



        //#region Bonus solutions
        //public static int Bonus1()
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}

        //public static int Bonus2(uint[] hightMap)
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}
        //#endregion
    }
}
