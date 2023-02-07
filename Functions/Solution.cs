using System;
using System.Collections.Generic;
using System.Linq;
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
            if (high < low) // input is invalid
            {
                res = -1;
            }
            else
            {
                Random rnd = new Random();
                res = rnd.Next(low, high);
            }
        }

        public static void Assignment3()
        {            
            var strToMove = new Dictionary<string, RockPaperScissors.RPS>()
            {
                {"Rock", RockPaperScissors.RPS.Rock},
                {"Paper", RockPaperScissors.RPS.Paper},
                {"Scissors", RockPaperScissors.RPS.Scissors},
            };
            
            try
            {
                Console.WriteLine("Enter player 1 move.");
                // string input1 = Console.ReadLine();
                RockPaperScissors.RPS move1 = strToMove[Console.ReadLine()];
                Console.WriteLine("Enter player 2 move.");
                // string input2 = Console.ReadLine();
                RockPaperScissors.RPS move2 = strToMove[Console.ReadLine()];

                if (move1 == move2)
                    Console.WriteLine("Tie.");
                else if ((move1 == RockPaperScissors.RPS.Rock && move2 == RockPaperScissors.RPS.Paper)
                        || move1 == RockPaperScissors.RPS.Paper && move2 == RockPaperScissors.RPS.Scissors
                        || move1 == RockPaperScissors.RPS.Scissors && move2 == RockPaperScissors.RPS.Rock
                        )
                    Console.WriteLine("Player 2 wins.");
                else
                    Console.WriteLine("Player 1 wins.");
            }
            catch (System.Collections.Generic.KeyNotFoundException e)
            {
                Console.WriteLine("Not a legal move.");
            }
        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            int n = nums.Length;
            double[] arr = new double[n];
            
            nums.CopyTo(arr, 0);

            double tmp;
            for(int i=0; i<n; i++)
            {
                for(int j=i+1; j<n; j++)
                {
                    if(arr[j] < arr[i])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

            // change sort direction if needed
            if (asc == false)
            {
                double[] final = new double[n];
                for(int i=0; i<n; i++)
                    final[i] = arr[n-1-i];
                return final;
            }
            else
                return arr;
        }

        public static void Assignment5(string str, char[] letters)
        {
            var newStr = new StringBuilder();
            foreach (char c in str)
            {
                bool charInLetters = false;
                Console.WriteLine();
                foreach (char letter in letters)
                {
                    if (c == letter)
                    {
                        charInLetters = true;
                        if (c + 10 > 'z')
                            {
                                newStr.Append((char)('a' + 'z' - c));
                                break;
                            }
                        else
                            newStr.Append((char)(c+10));
                    }
                }
                if (!charInLetters)
                    newStr.Append(c);
            }
            string changedStr = newStr.ToString();
            Console.WriteLine(changedStr);
        }

        public static bool Assignment6(string str)
        {   
            Regex rgx = new Regex("[^a-zA-Z]");
            str = rgx.Replace(str, "");
            string sentence = str.ToLower();
            int n = sentence.Length - 1;
            bool isPalindrome = true;
            int i = 0;
            while(i < n-i)
            {
                if (sentence[i] != sentence[n-i])
                {
                    isPalindrome = false;
                    break;
                }
                i++;
            }
            return isPalindrome;
        }

        public static int Assignment7(int[] nums)
        {
            var histogram = new Dictionary<int, int>();
            foreach(int num in nums)
            {
                if (histogram.ContainsKey(num))
                    histogram[num]++;
                else
                    histogram[num] = 1;
            }
            foreach(KeyValuePair<int, int> entry in histogram)
            {
                if (entry.Value == 1)
                    return entry.Key;
            }
            Console.WriteLine("No number in array with only 1 input");
            return -1;
        }

        // public static void Assignment8(bool[,] board, int rows, int cols)
        // {
        //     /*
        //      * TODO: Write code here
        //      */
        // }

        // public static int Assignment9()
        // {
        //     /*
        //      * TODO: Write code here
        //      */
        // }
        // #endregion

        // #region Bonus solutions
        // public static int Bonus1()
        // {
        //     /*
        //      * TODO: Write code here
        //      */
        // }

        // public static int Bonus2(uint[] hightMap)
        // {
        //     /*
        //      * TODO: Write code here
        //      */
        // }
        #endregion
    }
}
