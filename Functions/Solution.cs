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

        //public static double[] Assignment4(bool asc, params double[] nums)
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}

        //public static void Assignment5(string str, char[] letters)
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}

        //public static bool Assignment6(string str)
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}

        //public static int Assignment7(int[] nums)
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}

        //public static void Assignment8(bool[,] board, int rows, int cols)
        //{
        //    /*
        //     * TODO: Write code here
        //     */
        //}

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
