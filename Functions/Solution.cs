﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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
            res = -1;
            Random random = new Random();
            if (low < high)
                res = random.Next(low, high);
        }

        public static void Assignment3()
        {
            Console.WriteLine(RockPaperScissors.RPSFunc());
        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                for (int j = nums.Length - 1; j >= 0; j--)
                {
                    if (nums[i] > nums[j])
                    {
                        double temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                    }
                }
            }
            if (!asc)
                return nums;
            return Helper.ReverseArr(nums);
        }

        public static void Assignment5(ref string str, char[] letters)
        {
            const int TenLettersBeforeLowerCaseZ = 113;
            const int LowerCaseZ = 122;
            const int LowerCaseA = 97;

            char[] c = str.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (c[i] == letters[j])
                    {
                        int temp = Convert.ToInt32(c[i]);
                        if (temp < TenLettersBeforeLowerCaseZ)
                            temp = temp + 10;
                        else
                        {
                            int difference = LowerCaseZ - temp + 9;
                            temp = LowerCaseA + difference;
                        }
                        c[i] = Convert.ToChar(temp);
                    }
                }
            }
            str = new string(c);
        }

        public static bool Assignment6(string str)
        {
            Helper.GetRidOfPunctuation(ref str);
            str = str.Replace(" ", string.Empty);

            char[] c = str.ToCharArray();
            for (int i = 0; i < c.Length / 2; i++)
            {
                if (!(c[i] == c[c.Length - 1 - i]))
                    return false;
            }
            return true;
        }

        public static int Assignment7(int[] nums)
        {
            int appearseOnceCounter = 0;
            int appearsOnce = 0;

            if(nums.Length == 0)
                return -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!Helper.AppearsTwice(nums[i],i , nums))
                {
                    appearsOnce = nums[i];
                    appearseOnceCounter++;
                }
            }

            if (appearseOnceCounter == 1)
                return appearsOnce;

            return -1;
        }

        public static void Assignment8(int[,] board, int rows, int cols)
        {
            int[,] newBoard = GameOfLife.UpdatedBoard(board, rows, cols);
            
            // Prints the output of game of life.
            Console.WriteLine('{');
            for (int row = 0; row < rows; row++)
            {
                Console.Write('{');
                for (int col = 0; col < cols; col++)
                {
                    if (col == cols - 1)
                        Console.Write(newBoard[row, col]);
                    else
                        Console.Write(newBoard[row, col] + ", ");
                }
                Console.WriteLine('}');
            }
            Console.WriteLine('}');
        }

        public static int Assignment9()
        {
            // 90% density of jumping numbers.
            int min = 21780;
            int max = 10000000;
            int current = BouncingNumbers.Half(min, max);
            double temp = BouncingNumbers.AmountOfBouncingNums(current) / 0.99;

            while (temp != current)
            {
                if (temp < current)
                    min = current;
                else
                    max = current;

                current = BouncingNumbers.Half(min, max);
                temp = BouncingNumbers.AmountOfBouncingNums(current) / 0.99;
            }
            return current;
        }
        #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            string[] vocab = {"One", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy",
                "eighty", "ninety"};

            int letterCount = 0;

            int oneToNine = Helper.CountLettersInRange(0, 9, vocab);
            int tenToNineteen = Helper.CountLettersInRange(9, 19, vocab);
            int twentyToNinety = Helper.CountLettersInRange(19, vocab.Length, vocab);

            letterCount += oneToNine * 9;
            letterCount += tenToNineteen;
            letterCount += twentyToNinety * 10;
            
            return letterCount;
        }

        public static int Bonus2(int[] hightMap)
        {
            int currentHeight = 0;
            int waterCounter = 0;
            int maxCounter = 0;
            int maxHeightInRange = Helper.GetMaxAndDup(hightMap, 0)[0];
            int hasDuplicate = Helper.GetMaxAndDup(hightMap, 0)[1];

            for (int i = 0; i < hightMap.Length; i++)
            {
                if (hightMap[i] < maxHeightInRange || hasDuplicate == 1)
                {
                    if (hightMap[i] >= currentHeight)
                        currentHeight = hightMap[i];
                    else
                        waterCounter += currentHeight - hightMap[i];
                }
                if (hightMap[i] == maxHeightInRange)
                {
                    if ((hasDuplicate == 1 && maxCounter == 1) || hasDuplicate == 0)
                    {
                        if (i < hightMap.Length - 1)
                        {
                            maxHeightInRange = Helper.GetMaxAndDup(hightMap, i + 1)[0];
                            hasDuplicate = Helper.GetMaxAndDup(hightMap, i + 1)[1];
                            maxCounter = 0;
                        }
                    }
                    else
                        maxCounter++;
                }
            }
            return waterCounter;
        }
        #endregion
    }
}
    