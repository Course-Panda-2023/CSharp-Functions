﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Solution
    {
        #region Assignment solutions
        public static void Assignment1(int low, int high, out int res)
        {
            if (low > high || high < 0)
            {
                res = -1;
            }
            else
            {
                Random rnd = new Random();
                res = rnd.Next(low, high + 1);
            }
        }
        public static void Assignment2()
        {
            double num1 = Helper.ReadDouble();
            Console.WriteLine("enter operand");
            string operand = Console.ReadLine();
            double num2 = Helper.ReadDouble();
            double answer = 0;
            if (operand == "+")
            {
                answer = num1 + num2;
            }
            else if (operand == "-")
            {
                answer = num1 - num2;
            }
            else if (operand == "*")
            {
                answer = num1 * num2;
            }
            else if (operand == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("cant divide by zero");
                    Helper.WaitForEnter();
                    return;
                }
                answer = num1 / num2;
            }
            else if (operand == "^")
            {
                answer = Math.Pow(num1, num2);
            }
            else
            {
                Console.WriteLine("unvalid operand");
                Helper.WaitForEnter();
                return;
            }
            Console.WriteLine(answer);
            Helper.WaitForEnter();
        }
        public static void Assignment3()
        {
            RockPaperScissors.RPS player1Sign = RockPaperScissors.ReadInput();
            int player1Num = RockPaperScissors.RPSToNumber(player1Sign);
            RockPaperScissors.RPS player2Sign = RockPaperScissors.ReadInput();
            int player2Num = RockPaperScissors.RPSToNumber(player2Sign);
            RockPaperScissors.RPSOutput(player1Num, player2Num);
            Helper.WaitForEnter();
        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            return new double[nums.Length];
        }

        public static void Assignment5(string str, char[] letters)
        {
            string siftedStr = "";
            for(int j = 0; j < str.Length; j++)
            {
                bool sifted = false;
                for(int i = 0; i < letters.Length; i++)
                {
                    if (str[j] == letters[i])
                    {
                        siftedStr += Helper.SiftLetter(str[j]);
                        sifted= true;
                    }
                }
                if (!sifted)
                {
                    siftedStr += str[j];
                }
                
            }
            Console.WriteLine(siftedStr);
        }

        public static bool Assignment6(string str)
        {
            string lowercase = Helper.ToLowerCase(str);
            return (lowercase == Helper.Reverse(lowercase));
        }

        public static int Assignment7(int[] nums)
        {
            int[] record = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                bool alreadyExists = false;
                for(int j = 0; j < i; j++)
                {
                    if(nums[i] == record[j])
                    {
                        record[j] = 0;
                        alreadyExists = true;
                    }
                }
                if(!alreadyExists)
                {
                    record[i] = nums[i];
                }
            }
            foreach (int num in record)
            {
                if(num!=0)
                {
                    return num;
                }
            }
            return 0;
        }

        public static bool[,] Assignment8(bool[,] board, int rows, int cols)
        {
            bool[,] nextBoard = new bool[rows, cols];
            for(int iRow = 0; iRow < rows; iRow++)
            {
                for(int iCol = 0; iCol < cols; iCol ++)
                {
                    int numlivingAdjacents = Helper.NumLivingAdjacents(iRow, iCol, rows, cols, board);
                    if (numlivingAdjacents <= 1) 
                    {
                        nextBoard[iRow, iCol] = false;
                    }
                    else if(numlivingAdjacents == 2) 
                    {
                        nextBoard[iRow, iCol] = board[iRow, iCol];
                    }
                    else if(numlivingAdjacents == 3)
                    {
                        nextBoard[iRow, iCol] = true;
                    }
                    else
                    {
                        nextBoard[iRow, iCol] = false;
                    }
                }
            }
            return nextBoard;
        }

        public static int Assignment9()
        {
            int lowering = 0;
            int uppering = 1;
            int jumping = 0;
            int num = 1;
            while (jumping < 99 * (lowering + uppering))
            {
                string digits = Helper.GetDigits(num);
                if (Helper.IsUppering(digits))
                {
                    uppering++;
                }
                else if(Helper.IsLowering(digits))
                {
                    lowering++;
                }
                else
                {
                    jumping++;
                }
                num++;
            }
            return num;
        }
        #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            return 1;
        }

        public static int Bonus2(uint[] hightMap)
        {
            return 1;
        }
        #endregion
        public static void Main(string[] args)
        {
            //int[] arr = { 1, 5, 7, 2, 3};
            //Helper.PrintIntArray(Helper.InsertionSort(arr, arr.Length));
            //
            //Assignment3();
            //Assignment2();
            string str = "hello world";
            char[] letters = { 'i', 'o' };
            int[] nums = { 6, 0, 6, 4, 3, 4, 3 };
            bool[,] board = { { false, true, false }, { false, false, true }, { true, true, true }, { false, false, false } };
            bool[,] board2 = { { true, false, false, false, true, false, false, true, true, false }, { false, true, true, false, false, true, false, false, true, false }, { true, true, false, true, true, false, true, false, false, true }, { false,  true, false, true, false, true, false, false, true, false } };
            bool[,] board3 = { { false, true },{ true, true} };
            Helper.PrintIntArrayArray(Helper.TurnBoolMatrixToIntArrayArray(board));
            Console.WriteLine("--------");
            bool[,] next = Assignment8(board, board.GetLength(0), board.GetLength(1));
            Helper.PrintIntArrayArray(Helper.TurnBoolMatrixToIntArrayArray(next));
            // Console.WriteLine(Helper.SiftLetter('z'));
            //Console.WriteLine(board.GetLength(0) + ", " + board.GetLength(1));
            //Console.WriteLine(Helper.NumLivingAdjacents(0, 0, 2, 2, board3));
            //Console.WriteLine(Helper.NumLivingAdjacents(0, 0, board.GetLength(0), board.GetLength(1), board));
            Helper.WaitForEnter();

        }
    }
}
