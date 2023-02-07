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

        // public static double[] Assignment4(bool asc, params double[] nums)
        // {
        //     /*
        //      * TODO: Write code here
        //      */
        // }

        // public static void Assignment5(string str, char[] letters)
        // {
        //     /*
        //      * TODO: Write code here
        //      */
        // }

        // public static bool Assignment6(string str)
        // {
        //     /*
        //      * TODO: Write code here
        //      */
        // }

        // public static int Assignment7(int[] nums)
        // {
        //     /*
        //      * TODO: Write code here
        //      */
        // }

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
