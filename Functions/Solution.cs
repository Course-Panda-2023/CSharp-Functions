using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
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
            try
            {
                Random random = new Random();
                res = random.Next(low, high);
            }
            catch (Exception)
            {
                res = -1;
            }
            
        }

        
        public static void Assignment3()
        {
            Console.WriteLine("Player 1, enter the your action:");
            RockPaperScissors.RPS player1 = Helper.GetRPSType(Console.ReadLine()!);

            Console.WriteLine("Player 2, enter the your action:");
            RockPaperScissors.RPS player2 = Helper.GetRPSType(Console.ReadLine()!);

            Console.WriteLine(Helper.CheckWinner(player1, player2));
        }
        
        public static double[] Assignment4(bool asc, params double[] nums)
        {
            double[] sortedNums = Helper.SortArray(nums);
            if (asc)
            {
                return sortedNums;
            }
            else
            {
                return Helper.ReverseArray(sortedNums);
            }
        }
        
        public static void Assignment5(string str, char[] letters)
        {
            int jump = 10;
            foreach (char c in letters)
            {
                int newCASCII = (int)c + jump;
                if (newCASCII > (int)'z')
                {
                    newCASCII -= 26;
                }
                str = str.Replace(c, (char)newCASCII);
            }
            Console.WriteLine(str);
        }
        
        public static bool Assignment6(string str)
        {
            str = Regex.Replace(str, "[^a-zA-Z]", String.Empty);
            str = str.ToLower();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);
            return str.Equals(reversedStr);
        }

        public static int Assignment7(int[] nums)
        {
            foreach (int num in nums)
            {
                if (nums.Count(iterNum => iterNum == num) == 1)
                {
                    return num;
                }
            }
            return -1;
        }
        
        public static void Assignment8(bool[,] board, int rows, int cols)
        {
            bool[,] nextBoard = new bool[rows, cols];
            for (int row=0; row < rows; row++)
            {
                for (int col=0; col < cols; col++)
                {
                    bool[] neighbors = GameOfLife.GetNeighbors(board, row, col, rows, cols);
                    int numAlive = neighbors.Count(nbor => nbor == true);
                    if (board[row,col])
                    {
                        if (numAlive < 2 || numAlive > 3)
                            nextBoard[row,col] = false;
                        else
                            nextBoard[row, col] = true;
                    }
                    else
                    {
                        if (numAlive == 3)
                            nextBoard[row, col] = true;
                        else
                            nextBoard[row, col] = false;
                    }
                }
            }
            GameOfLife.PrintBoard(nextBoard, rows, cols);
        }
        
        public static int Assignment9()
        {
            int num = 0;
            int bounceNumsCounter = 0;
            double percent = 0;
            while(percent < 0.99)
            {
                num++;

                if (BouncingNumbers.IsBouncingNum(num))
                {
                    bounceNumsCounter++;
                }
                percent = bounceNumsCounter / (double)num;
            }
            return num;
        }
        #endregion

        
        #region Bonus solutions
        public static int Bonus1()
        {
            int sum = 0;
            string[] numsNames = Helper.GetNumsNames();
            foreach (string numStr in numsNames)
            {
                sum += numStr.Length;
            }
            return sum;
        }
        #endregion
        /*
        public static int Bonus2(uint[] hightMap)
        {
        
        }
        #endregion
        */
    }
}
