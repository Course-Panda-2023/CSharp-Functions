﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Basic.Calculator;
using static RockPaperScissors;
using static BouncingNumbers;

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
            // assuming that low, high are non negative
            
            if (high < low)
            {
                
                res = -1;
                return;
            }
            Random r = new Random();
            res = r.Next(low, high + 1);
        }
        
        public static int Assignment2(double num1, double num2, Operation op)
        {
            double res = 0;  // initialization only needed for compilation

            switch (op)
            {
                case Operation.PLUS:
                    res = num1 + num2;
                    break;
                case Operation.MINUS:
                    res = num1 - num2;
                    break;
                case Operation.MULTIPLACTION:
                    res = num1 * num2;
                    break;
                case Operation.DIVISION:
                    if (num2 == 0)
                    {
                        return -1;
                    }

                    res = num1 / num2;
                    break;
                case Operation.POWER:
                    res = Math.Pow(num1, num2);
                    break;
            }

            Console.WriteLine($"Result is: {res}");
            
            return 0;
        }

        public static void Assignment3()
        {
            RPS firstUserChose = RockPaperScissors.ScanUserChoose("first user");
            RPS secondUserChose = RockPaperScissors.ScanUserChoose("second user");;

            int score = RockPaperScissors.CalculateScore(firstUserChose, secondUserChose);

            switch (score)
            {
                case 0: 
                    Console.WriteLine("It's a tie!");
                    break;
                case -1:
                    Console.WriteLine("First player wins!");
                    break;
                case 1:
                    Console.WriteLine("Second player wins!");
                    break;
            }
        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            // creating a copy of the array
            double[] numsCopy = new double[nums.Length];
            nums.CopyTo(numsCopy, 0);
            nums = numsCopy;
            
            // creating an array that will store the results
            double[] res = new double[nums.Length];

            // sorting (ignoring the case where the array includes int.MaxValue element)
            int minIndex = 0;
            for (int cnt = 0; cnt < nums.Length; cnt++)
            {
                for (int idx = 0; idx < nums.Length; idx++)
                {
                    if (nums[idx] < nums[minIndex])
                    {
                        minIndex = idx;
                    }
                }

                res[cnt] = nums[minIndex];
                nums[minIndex] = int.MaxValue;
            }

            if (!asc)
            {
                // sort in descending order
                Array.Reverse(res);
            }

            return res;
        }

        public static string Assignment5(string str, char[] letters)
        {
            int index = 0, maxLowerCaseAscii = 97, minLowerCaseAscii = 26;
            StringBuilder res = new StringBuilder(str);
            
            foreach (char c in str)
            {
                if (letters.Contains(c))
                {
                    res[index] = Convert.ToChar(((c - maxLowerCaseAscii) + 10) % minLowerCaseAscii + maxLowerCaseAscii);
                }
                index++;
            }

            return res.ToString();
        }

        public static bool Assignment6(string str)
        {
            str = new string(
                str.Where(c => char.IsLetter(c)).ToArray()
            );
            
            for (int i=0; i < str.Length / 2; i++)
            {
                if (!str[i].ToString().ToLower().Equals(str[str.Length - 1 -i].ToString().ToLower()))
                {
                    return false;
                }
            }

            return true;
        }

        public static int Assignment7(int[] nums)
        {
            Dictionary<int, int> cnt = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (cnt.ContainsKey(num))
                {
                    cnt[num]++;
                }
                else
                {
                    cnt[num] = 1;
                }
            }
            
            foreach (KeyValuePair<int, int> entry in cnt)
            {
                if (entry.Value == 1)
                {
                    return entry.Key;
                }
            }
            
            // for compilation (should not happen assuming that the array contains an element that appears twice)
            return -1;
        }

        public static void Assignment8(bool[,] board, int rows, int cols)
        {
            bool[,] nextBoard = new bool[rows, cols];
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    nextBoard[i, j] = GameOfLife.CalculateNextStateCoordinate(board, rows, cols, i, j);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = nextBoard[i, j];
                }
            }
        }

        public static int Assignment9()
        {
            int specialCnt = Convert.ToInt32(BouncingNumbers.IsNumberBouncing(1)), currNumber = 1;
            double targetPct = 99;

            while ((Convert.ToDouble(specialCnt) / Convert.ToDouble(currNumber)) * 100 != targetPct)
            {
                specialCnt += Convert.ToInt32(BouncingNumbers.IsNumberBouncing(currNumber));
                currNumber++;
            }

            return currNumber;
        }
        #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            int cnt = 0;
            
            string[] digits = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            string[] underTwenty =
            {
                "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen",
                "sixteen", "seventeen", "eighteen", "nineteen"
            };
            string[] dozens =
            {
                "twenty",
                "thirty",
                "forty",
                "fifty",
                "sixty",
                "seventy",
                "eighty",
                "ninety"
            };

            string hunderd = "hundred";

            foreach (string str in digits.Concat(underTwenty))
            {
                cnt += str.Length;
            }

            foreach (string dozen in dozens)
            {
                cnt += dozen.Length;
                foreach (string digit in digits)
                {
                    cnt += dozen.Length + digit.Length;
                }
            }

            cnt += hunderd.Length;

            return cnt;
        }

        public static int Bonus2(uint[] heightMap)
        {
            /*
             * TODO: Write code here
             */

            return 1;
        }
        #endregion
    }
}
