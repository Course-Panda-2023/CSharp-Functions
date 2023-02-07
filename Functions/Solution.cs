﻿using System;
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
            if ((low <= high) && (low >= 0) && (high >= 0))
            {
                Random ran = new Random();
                res = ran.Next(low, high);
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("invalid parameters");
            }
        }

        public static void Assignment3()
        {
            Console.WriteLine("Enter player1's move (0 for rock, 1 for paper, 2 for scissors): ");
            RPS move1 = (RPS)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter player2's move (0 for rock, 1 for paper, 2 for scissors): ");
            RPS move2 = (RPS)Convert.ToInt32(Console.ReadLine());
            int result = winner(move1, move2);
            switch(result)
            {
                case 0:
                    Console.WriteLine("It's a tie!");
                    break;
                case 1:
                    Console.WriteLine("First player wins!");
                    break;
                case 2:
                    Console.WriteLine("Second player wins!");
                    break;
            }
        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            if (asc)
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
            }
            else
            {
                double temp;
                for (int j = 0; j <= nums.Length - 2; j++)
                {
                    for (int i = 0; i <= nums.Length - 2; i++)
                    {
                        if (nums[i] < nums[i + 1])
                        {
                            temp = nums[i + 1];
                            nums[i + 1] = nums[i];
                            nums[i] = temp;
                        }
                    }
                }
            }
            return nums;
        }

        public static void Assignment5(string str, char[] letters)
        {

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

        public static int Bonus2(uint[] hightMap)
        {
            /*
             * TODO: Write code here
             */
        }
        #endregion
    }
}
