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
            if (low < 0 || high < 0 || high < low)
            {
                res = -1;
                return;
            }
            if (low == high)
            {
                res = low;
                return;
            }
            Random rnd = new Random();
            res = rnd.Next(low, high);
        }
        
        public static void Assignment3()
        {
            Console.WriteLine("GREETINGS MORTALS!\nTO WIN THIS CONTEST, YOU MUST SELECT YOUR WEAPON:\n" +
                "ROCK - designated by R\n PAPER - designated by P\n SCISSORS - designated by S");
            Console.WriteLine("PLAYER ONE! CHOOSE YOUR WEAPON!");
            RockPaperScissors.RPS player1 = Helper.determineInput();
            Console.WriteLine("PLAYER TWO! CHOOSE YOUR WEAPON!");
            RockPaperScissors.RPS player2 = Helper.determineInput();
            Helper.determineOutcome(player1, player2);
            Console.ReadLine();
        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            if (asc == false)
            {
                Helper.sortTopToBottom(nums);
            }
            else
            {
                Helper.sortBottomToTop(nums);
            }
            Console.ReadLine() ;
            return nums;
        }

        public static void Assignment5(string str, char[] letters)
        {
            String s = "";
            foreach(char c in str)
            {
                if (letters.Contains(c))
                {
                    s = s + Helper.shiftLetters(c);
                }
                else
                {
                    s = s + c;
                }
            }
            Console.WriteLine(s);
        }

        public static bool Assignment6(string str)
        {
            String formattedStr = Helper.formatStrLowerCase(str);
            //Console.WriteLine(formattedStr);
            //Console.ReadLine();
            int len = formattedStr.Length;
            if (len == 0)
            {
                return true;
            }
            for (int i = 0; i < len; i++)
            {
                if (formattedStr[i] != formattedStr[len - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static int Assignment7(int[] nums)
        {
            int sumWithoutDuplicates = Helper.sumRemoveDuplicates(nums);
            int sum = 0;
            foreach(int num in nums)
            {
                sum += num;
            }
            return -2 * sumWithoutDuplicates + sum;
        }

        public static void Assignment8(bool[,] board, int rows, int cols)
        {
            int numNeighbors = 0;
            bool[,] tempboard = new bool[rows, cols];
            int[,] intBoard = new int[rows, cols];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    tempboard[x, y] = false;
                }
            }
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (board[x, y] == false)
                    {
                        intBoard[x, y] = 0;
                    }
                    else
                    {
                        intBoard[x, y] = 1;
                    }
                }
            }
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    numNeighbors = Helper.numNeighbors(x, y, intBoard, rows, cols);
                    if (board[x, y] == true)
                    {
                        if (numNeighbors < 2)
                        {
                            tempboard[x, y] = false;
                        } else if (numNeighbors == 3 || numNeighbors == 2)
                        {
                            tempboard[x, y] = true;
                        }
                        else
                        {
                            tempboard[x, y] = false;
                        }
                    }
                    else if (numNeighbors == 3)
                    {
                        tempboard[x, y] = true;
                    }
                }
            }
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    board[x, y] = tempboard[x, y];
                }
            }
        }

        public static int Assignment9()
        {
            int num = 1;
            int amountOfJumpingNumbers = 0;
            double jumpingNumsPrecentage = 0;
            while (jumpingNumsPrecentage < 0.99)
            {
                if (Helper.isBouncingNumber(num))
                {
                    amountOfJumpingNumbers++;
                }
                jumpingNumsPrecentage = (double)amountOfJumpingNumbers / num;
                num++;
            }
            return num - 1;
        }
            #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            string[] firstUnits = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            string[] secondUnits = { "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] extras = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            int totalLetters = 0;
            foreach(string s1 in firstUnits)
            {
                foreach(string s2 in secondUnits)
                {
                    totalLetters = totalLetters + s1.Length + s2.Length;
                }
            }
            foreach(string u in extras)
            {
                totalLetters += u.Length;
            }
            foreach (string u in secondUnits)
            {
                totalLetters += u.Length;
            }
            return totalLetters;
        }

        //public static int Bonus2(uint[] hightMap)
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}
        #endregion
    }
}
