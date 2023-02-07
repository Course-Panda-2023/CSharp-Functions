using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            if(low<0 || high < 0)
            {
                int failFlag = -1;
                res = failFlag;
            }
            else if (low <= high)
            {
                Random ran = new Random();
                res = ran.Next(low,high);
            }
            else
            {
                Random ran = new Random();
                res = ran.Next(high,low);
            }

        }

        public static void Assignment3()
        {
            Console.WriteLine("enter 0 for rock, 1 for paper and 2 for scissors");
            int firstPlayerInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 0 for rock, 1 for paper and 2 for scissors");
            int secondPlayerInt = Convert.ToInt32(Console.ReadLine());
            if ((firstPlayerInt < 0 || firstPlayerInt > 2) || (secondPlayerInt < 0 || secondPlayerInt > 2))
            {
                Console.WriteLine("not valid inputs");
            }
            else
            {
                RockPaperScissors.RPS firstPlayer = (RockPaperScissors.RPS)firstPlayerInt;
                RockPaperScissors.RPS secondPlayer = (RockPaperScissors.RPS)secondPlayerInt;
                if (firstPlayer == secondPlayer)
                {
                    Console.WriteLine("it's a tie!");
                }
                else if ((firstPlayer == RockPaperScissors.RPS.Paper && secondPlayer == RockPaperScissors.RPS.Rock) ||
                    (firstPlayer == RockPaperScissors.RPS.Rock && secondPlayer == RockPaperScissors.RPS.Scissors) ||
                        (firstPlayer == RockPaperScissors.RPS.Scissors && secondPlayer == RockPaperScissors.RPS.Paper))
                {
                    Console.WriteLine("First Player Wins!");
                }
                else
                {
                    Console.WriteLine("Second player wins!");
                }
            }
        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            double temp = 0;
            for (int write = 0; write < nums.Length; write++)
            {
                for (int sort = 0; sort < nums.Length - 1; sort++)
                {
                    if (nums[sort] > nums[sort + 1])
                    {
                        temp = nums[sort + 1];
                        nums[sort + 1] = nums[sort];
                        nums[sort] = temp;
                    }
                }
            }
            if (asc == false)
            {
                int startInd = 0;
                int endInd = nums.Length - 1;
                while (startInd < endInd)
                {
                    temp = nums[startInd];
                    nums[startInd] = nums[endInd];
                    nums[endInd] = temp;
                    startInd++;
                    endInd--;
                }
            }

            return nums;
        }

        public static void Assignment5(string str, char[] letters)
        {
            int len = str.Length;
            char[] newString = new char[len];
            int plusValue = 10;
            for (int i = 0; i < len; i++)
            {

                if (letters.Contains(str[i]))
                {
                    if (Convert.ToInt32(str[i]) + plusValue > 'z')
                    {
                        newString[i] = Convert.ToChar(Convert.ToInt32(plusValue - 1 - ('z' - str[i]) + 'a'));
                    }
                    else
                    {
                        newString[i] = Convert.ToChar(Convert.ToInt32(str[i]) + plusValue);
                    }
                }
                else
                {
                    newString[i] = str[i];
                }
            }
            Console.WriteLine(newString);
        }

        public static bool Assignment6(string str)
        {
            bool isPolindrom = true;
            int startInd = 0;
            int endInd = str.Length - 1;
            while (startInd < endInd)
            {
                int asciiFirst = Convert.ToInt32(str[startInd]);
                int asciiLast = Convert.ToInt32(str[endInd]);
                int maxVal = Math.Max(asciiFirst, asciiLast);
                int minVal = Math.Min(asciiFirst, asciiLast);
                if ((asciiFirst >= 65 && asciiFirst <= 90) || (asciiFirst >= 97 && asciiFirst <= 122))
                {
                    if ((asciiLast >= 65 && asciiLast <= 90) || (asciiLast >= 97 && asciiLast <= 122))
                    {
                        if (maxVal == minVal || maxVal == minVal + 32)
                        {
                            startInd++;
                            endInd--;
                        }
                        else
                        {
                            isPolindrom = false;
                            break;
                        }
                    }
                    else
                    {
                        endInd--;
                    }
                }
                else
                {
                    startInd++;
                }
            }
            return isPolindrom;
        }

        public static int Assignment7(int[] nums)
        {
            int lonelyNum = 0;
            if (nums.Length == 0)
            {
                return 0;
            }
            int indicatorForValidInput = 0;
            foreach (int num in nums)
            {
                if (Occurences(num, nums) == 1)
                {
                    lonelyNum = num;
                    indicatorForValidInput++;
                }
            }
            if (indicatorForValidInput == 1)
            {
                return lonelyNum;
            }
            return 0;
        }

        public static void Assignment8(bool[,] board, int rows, int cols)
        {
            Console.WriteLine("before");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{Convert.ToInt32(board[i, j])} ");
                }
                Console.Write("\n");
            }
            bool[,] newMat = board;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int leftTop = 0;
                    int left = 0;
                    int leftBottom = 0;
                    int top = 0;
                    int bottom = 0;
                    int rightTop = 0;
                    int right = 0;
                    int rightBottom = 0;
                    if (i > 0 && i < rows - 1)
                    {
                        if (j > 0 && j < cols - 1)
                        {
                            leftTop = Convert.ToInt32(board[i - 1, j - 1]);
                            left = Convert.ToInt32(board[i, j - 1]);
                            leftBottom = Convert.ToInt32(board[i + 1, j - 1]);
                            top = Convert.ToInt32(board[i - 1, j]);
                            bottom = Convert.ToInt32(board[i + 1, j]);
                            rightTop = Convert.ToInt32(board[i - 1, j + 1]);
                            right = Convert.ToInt32(board[i, j + 1]);
                            rightBottom = Convert.ToInt32(board[i + 1, j + 1]);
                        }
                        else
                        {
                            if (j == 0)
                            {
                                top = Convert.ToInt32(board[i - 1, j]);
                                bottom = Convert.ToInt32(board[i + 1, j]);
                                rightTop = Convert.ToInt32(board[i - 1, j + 1]);
                                right = Convert.ToInt32(board[i, j + 1]);
                                rightBottom = Convert.ToInt32(board[i + 1, j + 1]);
                            }
                            else
                            {
                                leftTop = Convert.ToInt32(board[i - 1, j - 1]);
                                left = Convert.ToInt32(board[i, j - 1]);
                                leftBottom = Convert.ToInt32(board[i + 1, j - 1]);
                                top = Convert.ToInt32(board[i - 1, j]);
                                bottom = Convert.ToInt32(board[i + 1, j]);
                            }
                        }
                    }
                    else if (i == 0 && j > 0 && j < cols - 1)
                    {
                        left = Convert.ToInt32(board[i, j - 1]);
                        leftBottom = Convert.ToInt32(board[i + 1, j - 1]);
                        bottom = Convert.ToInt32(board[i + 1, j]);
                        right = Convert.ToInt32(board[i, j + 1]);
                        rightBottom = Convert.ToInt32(board[i + 1, j + 1]);
                    }
                    else if (i == rows - 1 && j > 0 && j < cols - 1)
                    {
                        leftTop = Convert.ToInt32(board[i - 1, j - 1]);
                        left = Convert.ToInt32(board[i, j - 1]);
                        top = Convert.ToInt32(board[i - 1, j]);
                        rightTop = Convert.ToInt32(board[i - 1, j + 1]);
                        right = Convert.ToInt32(board[i, j + 1]);
                    }
                    else if (j == 0 && i == rows - 1)
                    {
                        top = Convert.ToInt32(board[i - 1, j]);
                        rightTop = Convert.ToInt32(board[i - 1, j + 1]);
                        right = Convert.ToInt32(board[i, j + 1]);
                    }
                    else if (i == 0 && j == 0)
                    {
                        bottom = Convert.ToInt32(board[i + 1, j]);
                        right = Convert.ToInt32(board[i, j + 1]);
                        rightBottom = Convert.ToInt32(board[i + 1, j + 1]);
                    }
                    else if (i == 0 && j == cols - 1)
                    {
                        left = Convert.ToInt32(board[i, j - 1]);
                        leftBottom = Convert.ToInt32(board[i + 1, j - 1]);
                        bottom = Convert.ToInt32(board[i + 1, j]);
                    }
                    else
                    {
                        leftTop = Convert.ToInt32(board[i - 1, j - 1]);
                        left = Convert.ToInt32(board[i, j - 1]);
                        top = Convert.ToInt32(board[i - 1, j]);
                    }


                    int neighborsAlive = leftTop + left + leftBottom + top + bottom + rightTop + right + rightBottom;
                    if (board[i, j] == false)
                    {
                        if (neighborsAlive == 3)
                        {
                            newMat[i, j] = true;
                        }
                    }
                    else
                    {
                        if (neighborsAlive > 3 || neighborsAlive < 2)
                        {
                            newMat[i, j] = false;
                        }
                    }
                }
            }


            Console.WriteLine("\nafter\n");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{Convert.ToInt32(newMat[i, j])} ");
                }
                Console.Write("\n");
            }
        }

        public static int Assignment9()
        {
            double density = 0;//90;
    int starter =100;//21780
    int bouncingNumbers = 0; //0.9*21780
    while (density < 99)
    {
        starter++;
        bouncingNumbers += IsBouncing(starter);
        density = ((double)bouncingNumbers / (double)starter) *100;
    }
    Console.WriteLine(starter);
    return starter;
        }
        #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            int[] arr = { 3, 3, 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8, 8, 7, 7, 9, 8, 8, 6, 6, 5, 5, 5, 7, 6, 6 };
            int sum = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i <= 20)
                {
                    sum += arr[i - 1];
                }
                else
                {

                    int right = i % 10;
                    int left = i / 10;
                    if (right == 0)
                    {
                        sum += arr[left + 17];
                    }
                    else
                    {
                        sum += arr[right - 1] + arr[left + 17];
                    }
                }
            }


            return sum;
        }

        public static int Bonus2(uint[] hightMap)
        {
            /*
             * TODO: Write code here
             */
            return 5;
        }
        #endregion
    }
}
