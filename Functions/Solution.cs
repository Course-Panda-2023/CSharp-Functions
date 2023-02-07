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

        //    public static void Assignment5(string str, char[] letters)
        //    {
        //        /*
        //         * TODO: Write code here
        //         */
        //    }

        //    public static bool Assignment6(string str)
        //    {
        //        /*
        //         * TODO: Write code here
        //         */
        //    }

        //    public static int Assignment7(int[] nums)
        //    {
        //        /*
        //         * TODO: Write code here
        //         */
        //    }

        //    public static void Assignment8(bool[,] board, int rows, int cols)
        //    {
        //        /*
        //         * TODO: Write code here
        //         */
        //    }

        //    public static int Assignment9()
        //    {
        //        /*
        //         * TODO: Write code here
        //         */
        //    }
        //    #endregion

        //    #region Bonus solutions
        //    public static int Bonus1()
        //    {
        //        /*
        //         * TODO: Write code here
        //         */
        //    }

        //    public static int Bonus2(uint[] hightMap)
        //    {
        //        /*
        //         * TODO: Write code here
        //         */
        //    }
        #endregion
    }
}
