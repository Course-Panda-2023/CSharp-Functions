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
            Random rnd = new Random();
            res = rnd.Next(low, high);
            return res;
        }

        public static void Assignment3()
        {
            Console.WriteLine("Enter first player choice S / R / P");
            string firstPlayer = Console.ReadLine()!;
            Console.WriteLine("Enter second player choice S / R / P");
            string secondPlayer = Console.ReadLine()!;
            RockPaperScissors.RPS firstPlayerChoice = RockPaperScissors.RPS.Rock;
            RockPaperScissors.RPS secondPlayerChoice = RockPaperScissors.RPS.Rock;
            switch (firstPlayer)
            {
                case "S":
                    firstPlayerChoice = RockPaperScissors.RPS.Scissors;
                    break;
                case "R":
                    firstPlayerChoice = RockPaperScissors.RPS.Rock;
                    break;
                case "P":
                    firstPlayerChoice = RockPaperScissors.RPS.Paper;
                    break;
                default:
                    break;
            }
            switch (secondPlayer)
            {
                case "S":
                    firstPlayerChoice = RockPaperScissors.RPS.Scissors;
                    break;
                case "R":
                    firstPlayerChoice = RockPaperScissors.RPS.Rock;
                    break;
                case "P":
                    firstPlayerChoice = RockPaperScissors.RPS.Paper;
                    break;
                default:
                    break;
            }
            if (firstPlayerChoice == RockPaperScissors.RPS.Rock && secondPlayerChoice == RockPaperScissors.RPS.Paper) { Console.WriteLine("Second player wins!"); }
            else if (firstPlayerChoice == RockPaperScissors.RPS.Rock && secondPlayerChoice == RockPaperScissors.RPS.Rock) { Console.WriteLine("Its a tie!"); }
            else if (firstPlayerChoice == RockPaperScissors.RPS.Rock && secondPlayerChoice == RockPaperScissors.RPS.Scissors) { Console.WriteLine("First player wins!"); }
            else if (firstPlayerChoice == RockPaperScissors.RPS.Paper && secondPlayerChoice == SRP.Paper) { Console.WriteLine("Its a tie!"); }
            else if (firstPlayerChoice == RockPaperScissors.RPS.Paper && secondPlayerChoice == SRP.Rock) { Console.WriteLine("First player wins!"); }
            else if (firstPlayerChoice == RockPaperScissors.RPS.Paper && secondPlayerChoice == SRP.Scissors) { Console.WriteLine("Second player wins!"); }
            else if (firstPlayerChoice == RockPaperScissors.RPS.Scissors && secondPlayerChoice == SRP.Paper) { Console.WriteLine("First player wins!"); }
            else if (firstPlayerChoice == RockPaperScissors.RPS.Scissors && secondPlayerChoice == SRP.Rock) { Console.WriteLine("Second player wins!"); }
            else if (firstPlayerChoice == RockPaperScissors.RPS.Scissors && secondPlayerChoice == SRP.Scissors) { Console.WriteLine("Its a tie!"); }
        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            if (asc)
            {
                for (int j = 0; j <= nums.Length - 2; j++)
                {
                    for (int i = 0; i <= nums.Length - 2; i++)
                    {
                        if (nums[i] > nums[i + 1])
                        {
                            double temp = nums[i + 1];
                            nums[i + 1] = nums[i];
                            nums[i] = temp;
                        }
                    }
                }
                return nums;
            }
            else
            {
                for (int j = 0; j <= nums.Length - 2; j++)
                {
                    for (int i = 0; i <= nums.Length - 2; i++)
                    {
                        if (nums[i] < nums[i + 1])
                        {
                            double temp = nums[i + 1];
                            nums[i + 1] = nums[i];
                            nums[i] = temp;
                        }
                    }
                }
                return nums;
            }
        }

        public static void Assignment5(string str, char[] letters)
        {
            foreach (char l in letters)
            {
                int asc = (int)(l + 10);
                if (asc > 122)
                    asc -= 26;
                str = str.Replace(l, (char)(asc));
            }
        }

        public static bool Assignment6(string str)
        {
            string text = Regex.Replace(str, "[^a-zA-Z0-9]", String.Empty);
            string ret = text.ToLower();
            string reverseString = string.Empty;
            for (int i = ret.Length - 1; i >= 0; i--)
            {
                reverseString += ret[i];
            }
            if (ret == reverseString)
                return true;
            return false;
        }

        public static int Assignment7(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int occ = nums.Count(x => x == nums[i]);
                if (occ == 1)
                    return nums[i];
            }
            return -1;
        }

        /*public static void Assignment8(bool[,] board, int rows, int cols)
        {
            
        }*/

        public static int Assignment9(int num)
        {
            int starting = 1;
            double per = 0;
            int counter = 0;
            while (per < 0.99)
            {
                if (BouncingNumbers.CheckIfNumberIsBouncing(starting))
                    counter++;
                per = (double)counter / (double)starting;
                starting++;
                Console.WriteLine("Number: " + starting + " , Per " + per);
            }
            return starting;
        }
        #endregion
        
        /*#region Bonus solutions
        public static int Bonus1()
        {

        }

        public static int Bonus2(uint[] hightMap)
        {

        }
        #endregion
        */
    }
}
