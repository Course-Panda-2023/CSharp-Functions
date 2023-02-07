using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Basic.Calculator;

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
            // assuming that low, high are non negative
            
            if (high < low)
            {
                
                res = -1;
                return;
            }
            Random r = new Random();
            res = r.Next(low, high + 1);
        }
        
        public static int Assignment2(double num1, double num2, Operation op)
        {
            double res = 0;  // initialization only needed for compilation

            switch (op)
            {
                case Operation.PLUS:
                    res = num1 + num2;
                    break;
                case Operation.MINUS:
                    res = num1 - num2;
                    break;
                case Operation.MULTIPLACTION:
                    res = num1 * num2;
                    break;
                case Operation.DIVISION:
                    if (num2 == 0)
                    {
                        return -1;
                    }

                    res = num1 / num2;
                    break;
                case Operation.POWER:
                    res = Math.Pow(num1, num2);
                    break;
            }

            Console.WriteLine($"Result is: {res}");
            
            return 0;
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
