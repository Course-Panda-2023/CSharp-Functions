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
            /*
             * TODO: Write code here
             */
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
