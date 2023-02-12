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

        public static void Assignment5(ref string str, char[] letters)
        {
            string shiftedString = "";
            for (int letterIndex = 0; letterIndex < str.Length; letterIndex++)
            {
                if (Helper.IsCharInLetterArray(str[letterIndex], letters))
                {
                    shiftedString += (char) str[letterIndex]+10;
                }
                else
                {
                    shiftedString += str[letterIndex];
                }
            }
            str = shiftedString;
        }

        public static bool Assignment6(string str)
        {
            for ( int letterIndex = 0, letterFromTheEndIndex = str.Length - 1;
                letterIndex < str.Length || letterFromTheEndIndex >= 0; letterIndex++, letterFromTheEndIndex--)
            {
                while (Helper.IsSign(str[letterIndex]))
                {
                    letterIndex++;
                }

                while (Helper.IsSign(str[letterFromTheEndIndex]))
                {
                    letterFromTheEndIndex++;
                }

                if (!Helper.IsSameLetter(str[letterIndex], str[letterFromTheEndIndex]))
                {
                    return false;
                }
            }
            return true;
        }

        public static int Assignment7(int[] nums)
        {
            int singleNumber = nums[0];

            for (int arrIndex = 1; arrIndex < nums.Length; arrIndex++)
            {
                singleNumber ^= nums[arrIndex];
            }

            return singleNumber;
        }

        public static void Assignment8(bool[,] board, int rows, int cols)
        {
            while (true)
            {
                board = GameOfLife.CalcNextBoard(board);
                GameOfLife.PrintBoard(board);
                Console.WriteLine();
                Console.Clear();
            }
        }

        public static int Assignment9()
        {
            Console.WriteLine("starting calculation....");
            int number = BouncingNumbers.NumWithMostJumping();
            Console.WriteLine($"calculation ended, the number is: {number}");
            return number;
        }
        #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            string[] digits= new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] specials= new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens= new string[] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

            int numOfLetters = 0;

            foreach (string word in digits)
            {
                numOfLetters += word.Length;
            }

            foreach (string word in specials)
            {
                numOfLetters += word.Length;
            }

            for (int tensIndex = 0; tensIndex < tens.Length; tensIndex++)
            {
                numOfLetters += tens[tensIndex].Length;
                for (int digitsIndex = 0; digitsIndex < digits.Length; digitsIndex++)
                {
                    numOfLetters += tens[tensIndex].Length;
                    numOfLetters += digits[digitsIndex].Length;
                }
            }
            Console.WriteLine($"num of letters between one to 100 is: {numOfLetters}");
            return numOfLetters;


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
