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
            res = -1;
            Random random = new Random();
            if (low < high)
                res = random.Next(low, high);
        }

        public static void Assignment3()
        {
            Console.WriteLine(RockPaperScissors.RPSFunc());
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
        //#endregion

        static void Main(string[] args)
        {
            Assignment3();
        }
        #endregion
    }
}
