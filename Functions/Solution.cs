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
            int result = Winner(move1, move2);
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
            char[] charList = new char[str.Length];
            char[] updatedList = new char[str.Length];
            int i = 0;
            foreach (char c in letters)
            {
                if ((!charList.Contains(c)) && (str.Contains(c)))
                {
                    charList[i] = c;
                    i++;
                    str = str.Replace(c, (char)(((int)c) + 10));
                }
            }
            Console.WriteLine(str);
        }

        public static bool Assignment6(string str)
        {
            str = Regex.Replace(str, "[^a-zA-Z0-9]", String.Empty);
            str = str.ToLower();
            char[] charArray = str.ToCharArray();
            int length = charArray.Length - 1;
            for (int i = 0; i <= length / 2; i++)
            {
                if (charArray[i] != charArray[length - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static int Assignment7(int[] nums)
        {
            /*
             * TODO: Write code here
             */
        }

        public static void Assignment8(bool[,] board, int rows, int cols)
        {
            bool[,] newMatrix = new bool[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    bool changed = GameOfLife.change(board, rows, cols, i, j, board[i, j]);
                    newMatrix[i, j] = changed;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                Console.Write("[");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(newMatrix[i, j] + ", ");
                }
                Console.WriteLine("]");
            }
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
