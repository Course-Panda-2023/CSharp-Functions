﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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

        static void Main(string[] args)
        {
            string str = "A man, a plan, a canal: Panama";
            string str1 = "lan, a canal";
            Console.WriteLine(Assignment6(str));
        }
        #endregion
    }
}
    