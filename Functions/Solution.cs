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
                res = -1; //Return -1 if paramaters invalid
                Console.WriteLine(res);
            }
        }

        public static void Assignment3()
        {
            /*
             * TODO: Write code here
             */
        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            /*
             * TODO: Write code here
             */
        }

        public static void Assignment5(string str, char[] letters)
        {
            /*
             * TODO: Write code here
             */
        }

        public static bool Assignment6(string str)
        {
            /*
             * TODO: Write code here
             */
        }

        public static int Assignment7(int[] nums)
        {
            /*
             * TODO: Write code here
             */
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
