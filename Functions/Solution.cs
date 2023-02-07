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
            /*
             * TODO: Write code here
             */
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
