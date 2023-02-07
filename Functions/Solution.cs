using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Solution
    {
        #region Assignment solutions
        public static void Assignment1(int low, int high, out int res)
        {
            if (low > high || high < 0)
            {
                res = -1;
            }
            else
            {
                Random rnd = new Random();
                res = rnd.Next(low, high + 1);
            }
        }
        public static void Assignment2()
        {
            double num1 = Helper.ReadDouble();
            Console.WriteLine("enter operand");
            string operand = Console.ReadLine();
            double num2 = Helper.ReadDouble();
            double answer = 0;
            if (operand == "+")
            {
                answer = num1 + num2;
            }
            else if (operand == "-")
            {
                answer = num1 - num2;
            }
            else if (operand == "*")
            {
                answer = num1 * num2;
            }
            else if (operand == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("cant divide by zero");
                    Helper.WaitForEnter();
                    return;
                }
                answer = num1 / num2;
            }
            else if (operand == "^")
            {
                answer = Math.Pow(num1, num2);
            }
            else
            {
                Console.WriteLine("unvalid operand");
                Helper.WaitForEnter();
                return;
            }
            Console.WriteLine(answer);
            Helper.WaitForEnter();
        }
        public static void Assignment3()
        {
            RockPaperScissors.RPS player1Sign = RockPaperScissors.ReadInput();
            int player1Num = RockPaperScissors.RPSToNumber(player1Sign);
            RockPaperScissors.RPS player2Sign = RockPaperScissors.ReadInput();
            int player2Num = RockPaperScissors.RPSToNumber(player2Sign);
            RockPaperScissors.RPSOutput(player1Num, player2Num);
            Helper.WaitForEnter();
        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            return new double[nums.Length];
        }

        public static void Assignment5(string str, char[] letters)
        {
            string siftedStr = "";
            for(int j = 0; j < str.Length; j++)
            {
                bool sifted = false;
                for(int i = 0; i < letters.Length; i++)
                {
                    if (str[j] == letters[i])
                    {
                        siftedStr += Helper.SiftLetter(str[j]);
                        sifted= true;
                    }
                }
                if (!sifted)
                {
                    siftedStr += str[j];
                }
                
            }
            Console.WriteLine(siftedStr);
        }

        public static bool Assignment6(string str)
        {
            return true;
        }

        public static int Assignment7(int[] nums)
        {
            return nums.Length;
        }

        public static void Assignment8(bool[,] board, int rows, int cols)
        {
            /*
             * TODO: Write code here
             */
        }

        public static int Assignment9()
        {
            return 0;
        }
        #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            return 1;
        }

        public static int Bonus2(uint[] hightMap)
        {
            return 1;
        }
        #endregion
        public static void Main(string[] args)
        {
            //int[] arr = { 1, 5, 7, 2, 3};
            //Helper.PrintIntArray(Helper.InsertionSort(arr, arr.Length));
            //
            //Assignment3();
            //Assignment2();
            string str = "hello world";
            char[] letters = { 'i', 'o' };

            Assignment5(str, letters);
           // Console.WriteLine(Helper.SiftLetter('z'));
            Helper.WaitForEnter();

        }
    }
}
