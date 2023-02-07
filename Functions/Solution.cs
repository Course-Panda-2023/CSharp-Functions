using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            const int ERROR_OCCURED = -1;
            const int ZERO = 0;
            if (low < ZERO)
            {
                Console.WriteLine("Negative low bound of range");
                res = ERROR_OCCURED;
                return;
            }
            if (low > high)
            {
                Console.WriteLine("Low is bigger than high");
                res = ERROR_OCCURED;
                return;
            }
            Random random = new Random();
            res = random.Next(low, high);
        }

        public static void Assignment3()
        {            
            Console.WriteLine("Welcome to rock paper scissors game!");

            Console.WriteLine("2Players game");
            Console.WriteLine("Player one");
            Console.WriteLine("Enter P for papers, R for rock, S for scissors");

            string p1Choice = Console.ReadLine();
            if (p1Choice is null)
            {
                return;
            }
            
            char charP1Choice = (char)p1Choice[0];

            Console.WriteLine("Player two");
            Console.WriteLine("Enter P for papers, R for rock, S for scissors");

            string p2Choice = Console.ReadLine();
            char charP2Choice = (char)p2Choice[0];
            int score;

            int p1 = charP1Choice == 'P' ?
                    ((int)RockPaperScissors.RPS.PAPER) :
                        charP1Choice == 'R' ?
                        ((int)RockPaperScissors.RPS.ROCK) : ((int)RockPaperScissors.RPS.SCISSORS);

            int p2 = charP2Choice == 'P' ?
                    ((int)RockPaperScissors.RPS.PAPER) :
                        charP2Choice == 'R' ?
                        ((int)RockPaperScissors.RPS.ROCK) : ((int)RockPaperScissors.RPS.SCISSORS);
            int difference = p1 - p2;
            if (difference == 0)
            {
                Console.WriteLine("It is tie!");
            }
            if (difference == 1)
            {
                Console.WriteLine("Player one wins!");
            }
            if (difference == -1)
            {
                Console.WriteLine("Player two wins!");
            }
            if (difference == -2)
            {
                Console.WriteLine("Player one wins!");
            }
            if (difference == 2)
            {
                Console.WriteLine("Player two wins!");
            }


        }

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            double[] result = new double[nums.Length];
            Span<double> numbersAsSpan = nums.AsSpan();
            const int SECOND_INDEX = 1;
            int j;
            double key;
           
            for (int i = SECOND_INDEX; i < numbersAsSpan.Length; ++i)
            {
                key = numbersAsSpan[i];
                j = i - 1;
                while (j >= 0 && numbersAsSpan[j] > key)
                {
                    numbersAsSpan[j + 1] = numbersAsSpan[j];
                    j = j - 1;
                }
                numbersAsSpan[j + 1] = key;
            }
            result = nums;
            if (asc)
            {
                return result;
            }

            for (int i = 0; i < numbersAsSpan.Length / 2; ++i)
            {
                Helper.swap(result, i, numbersAsSpan.Length - i - 1);
            }
            
            return result;
        }

        public static void Assignment5(string str, char[] letters)
        {
            string result = "";
            HashSet<int> lettersSet = new HashSet<int>();
            Span<char> lettersAsSpan = letters.AsSpan();
            for (int i = 0; i < lettersAsSpan.Length; ++i)
            {
                lettersSet.Add(lettersAsSpan[i]);
            }
            
            const int CYCLIC_LETTER_OFFSET = 10;
            const int BORDER_LOWERCASE_LETTER_UPPER_BOUND = 122;
            const int BORDER_LOWERCASE_LETTER_LOWER_BOUND = 96;
            const int ZERO = 0;
            int ch;
            int difference;
            int with_offset;
            for (int i = 0; i < str.Length; ++i)
            {
                ch = str[i];
                if (lettersSet.Contains(ch))
                {
                    with_offset = ch + CYCLIC_LETTER_OFFSET;
                    difference = BORDER_LOWERCASE_LETTER_UPPER_BOUND - with_offset;
                    if (difference > ZERO)
                    {
                        result += (char)with_offset;
                    }
                    else
                    {
                        result += (char)(BORDER_LOWERCASE_LETTER_LOWER_BOUND - difference);
                    }
                }
                else
                {
                    result += (char)ch;
                }
                
            }
            str = result;
            Console.WriteLine(result);
        }

        public static bool Assignment6(string str)
        {
            if (str is null)
            {
                return false;
            }
            int middle = str.Length / 2;
            for (int i = 1; i < middle; ++i)
            {
                if (str[i] != str[str.Length - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static int Assignment7(int[] nums)
        {
            const int APPEARS_ONCE = 1;
            const int NOT_FOUND = -1;
            int result = NOT_FOUND;
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            Span<int> arrayAsSpan = nums.AsSpan();
            
            for (var i = 0; i < arrayAsSpan.Length; ++i)
            {

                if (frequency.ContainsKey(arrayAsSpan[i]))
                {
                    frequency[arrayAsSpan[i]] += 1;
                }
                else
                {
                    frequency.Add(arrayAsSpan[i], 1);
                }
            }

            for (var i = 0; i < arrayAsSpan.Length; ++i)
            {
                if (arrayAsSpan[i] == APPEARS_ONCE)
                {
                    result = arrayAsSpan[i];
                    return result;
                }
                
            }
            return result;
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
            /*
             * TODO: Write code here
             */
        }
        #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            return 0;
            /*
             * TODO: Write code here
             */
        }

        public static int Bonus2(uint[] hightMap)
        {
            return 0;
            /*
             * TODO: Write code here
             */
        }
        #endregion
    }
}
