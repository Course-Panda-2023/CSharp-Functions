using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
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

        public static bool[,] Assignment8(bool[,] board, int rows, int cols)
        {
            bool[,] result = new bool[rows, cols];
            const bool LIVE = true;
            const bool DIED = false;
            const int ZERO = 0;
            const int FORMER_CELL_IN_CLOUMN = -1;
            const int FORMER_CELL_IN_ROW = -1;
            const int NEXT_CELL_IN_COLUMN = 1;
            const int NEXT_CELL_IN_ROW = 1;
            const int THE_SAME_ROW = 0;
            const int THE_SAME_COLUMN = 0;
            const int MAXIMUM_NEIGHBORS_COUNT = 8;
            const int TWO_CELL_LIVES = 2;
            const int THREE_CELL_LIVES = 3;
            const int TWO_CELL_DIED = 2;
            int liveCount = 0, diedCount = 0;
            bool[] neighboors = new bool[MAXIMUM_NEIGHBORS_COUNT];
            bool currentState;
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < cols; ++j)
                {
                    // false neighboors
                    for (int index = 0; index < MAXIMUM_NEIGHBORS_COUNT; ++index)
                    {
                        neighboors[index] = false;
                    }
                    liveCount = diedCount = 0;
                    if (i + FORMER_CELL_IN_ROW >= ZERO && j + FORMER_CELL_IN_CLOUMN >= ZERO)
                    {
                        neighboors[0] = board[i + FORMER_CELL_IN_ROW, j + FORMER_CELL_IN_CLOUMN];
                    }
                    // I know j + THE_SAME_COLUMN is reduandant but for code to be readable
                    if (i + FORMER_CELL_IN_ROW >= ZERO && j + THE_SAME_COLUMN >= ZERO)
                    {
                        neighboors[1] = board[i + FORMER_CELL_IN_ROW, j];
                    }
                    if (i + FORMER_CELL_IN_ROW >= ZERO && j + NEXT_CELL_IN_COLUMN < cols)
                    {
                        neighboors[2] = board[i + FORMER_CELL_IN_ROW, j + NEXT_CELL_IN_COLUMN];
                    }
                    if (i + THE_SAME_ROW >= ZERO && j + NEXT_CELL_IN_COLUMN < cols)
                    {
                        neighboors[3] = board[i, j + NEXT_CELL_IN_COLUMN];
                    }
                    if (i + NEXT_CELL_IN_ROW < rows && j + NEXT_CELL_IN_COLUMN < cols)
                    {
                        neighboors[4] = board[i + NEXT_CELL_IN_ROW, j + NEXT_CELL_IN_COLUMN];
                    }
                    if (i + NEXT_CELL_IN_ROW < rows && j + THE_SAME_COLUMN < cols)
                    {
                        neighboors[5] = board[i + NEXT_CELL_IN_ROW, j];
                    }
                    if (i + NEXT_CELL_IN_ROW < rows && j + FORMER_CELL_IN_CLOUMN >= ZERO)
                    {
                        neighboors[6] = board[i + NEXT_CELL_IN_ROW, j + FORMER_CELL_IN_CLOUMN];
                    }
                    if (i + THE_SAME_ROW >= ZERO && j + FORMER_CELL_IN_CLOUMN >= ZERO)
                    {
                        neighboors[7] = board[i, j + FORMER_CELL_IN_CLOUMN];
                    }

                    neighboors.Select(cell => cell ? ++liveCount : ++diedCount).ToArray();

                    currentState = board[i, j];
                    result[i, j] = currentState;
                    if (currentState && liveCount < TWO_CELL_LIVES)
                    {
                        result[i, j] = DIED;
                    }
                    else if (currentState && (liveCount > THREE_CELL_LIVES))
                    {
                        result[i, j] = DIED;
                    }
                    else if (!currentState && (liveCount == THREE_CELL_LIVES))
                    {
                        result[i, j] = LIVE;
                    }
                    else if (currentState && (liveCount == TWO_CELL_LIVES || liveCount == THREE_CELL_LIVES))
                    {
                        result[i, j] = LIVE;
                    }
                    else
                    {
                        result[i, j] = DIED;
                    }
                }
            }
            return result;
        }

        public static int Assignment9()
        {
            const int BEGIN_WITH = 21780;
            const double THE_WANTED_PERCENT = 0.99;

            double numberOfBouncingNumbers = (double)(0.9 *  (double)BEGIN_WITH);
            int result = BEGIN_WITH;
            BouncingNumbers bouncingNumbers = new BouncingNumbers();
            
            while (!(numberOfBouncingNumbers).Equals(result * THE_WANTED_PERCENT))
            {
                if (bouncingNumbers.IsBouncingNumber(result))
                {
                    ++numberOfBouncingNumbers;
                }
                ++result;
            }
            return result;
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
