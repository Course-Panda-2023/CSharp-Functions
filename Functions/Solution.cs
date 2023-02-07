using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Random;


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
            if (low < high)
            {
                Random random = new Random();
                res = random.Next(low, high);
                if (res < 0)
                {
                    res = -1;
                }
            }
            else
            {
                res = -1;
            }
        }
        public static void Assignment3()
        {
            Console.WriteLine("rock paper or scissors? (player1): ");
            RockPaperScissors.Action p1choice = RockPaperScissors.handleActions(Console.ReadLine());
            Console.WriteLine("rock paper or scissors? (player2): ");
            RockPaperScissors.Action p2choice = RockPaperScissors.handleActions(Console.ReadLine());
            RockPaperScissors.handleResults(p1choice, p2choice);

        }

        public static int[] Assignment4(int asc, params int[] nums)
        {
            int[] newArr = nums;
            int temp = 0;
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        switch (asc)
                        {
                            case 0:
                                if (newArr[i] > newArr[j])
                                {
                                    temp = newArr[i];
                                    newArr[i] = newArr[j];
                                    newArr[j] = temp;
                                }
                                break;
                            case 1:
                                if (newArr[i] < newArr[j])
                                {
                                    temp = newArr[i];
                                    newArr[i] = newArr[j];
                                    newArr[j] = temp;
                                }
                                break;
                        }
                    }
                }
            }
            return newArr;
        }

        public static string Assignment5(string str, char[] letters)
        {
            char[] strChars = str.ToCharArray();
            for (int i = 0; i < strChars.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (strChars[i] == letters[j])
                    {
                        strChars[i] = (char)(strChars[i] + 10);
                    }
                }
            }
            return new string(strChars);
        }

        public static bool Assignment6(string str)
        {
            string newStr = str.ToLower();
            return newStr.SequenceEqual(newStr.Reverse());
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


        public static bool[,] Assignment8(bool[,] board, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i, j] == false)
                        Console.Write(".");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return GameOfLife.NextGeneration(board, rows, cols); //returns a new array
        }

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
        #endregion
    }
}
