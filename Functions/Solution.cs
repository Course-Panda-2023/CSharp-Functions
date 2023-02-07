using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            // the sort is Bubble Sort
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
                Helper.reversArray(nums);
            }
            return nums;
        }
        

        public static void assignment5(string str, char[] letters)
        {
            foreach (Char c in letters)
            {
                int temp = c + 10;
                temp = temp > 122 ? temp - 122 + 'a' - 1 - 32 : temp;//Changes the letter to the appropriate capital letter
                str = str.Replace(c, (char)(temp));
            }
            str = str.ToLower();
        }

        public static bool Assignment6(string str)
        {
            str = str.ToLower();
            str = Regex.Replace(str, "[^a-zA-Z0-9]", String.Empty);
            return str.SequenceEqual(str.Reverse());
        }

        public static int Assignment7(int[] nums)
        {
            int i = 0;
            foreach (int x in nums)
            {
                i ^= x;
            }
            return i;
        }

        public static void Assignment8(int[,] board, int rows, int cols)
        {
            int[,] ints = (int[,])board.Clone();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    board[row, col] = Helper.isAlive(ints, row, col);
                }
            }
        }

        public static int Assignment9()
        {
            int i = 1;
            int counter = 0;
            while (true)
            {

                if (!BouncingNumbers.up(i) && !BouncingNumbers.down(i))
                {
                    counter++;
                    if ((double)counter / i >= 0.99)
                    {
                        return i;
                    }
                }
                i++;
            }
            return 1;
        }
        //#endregion




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
