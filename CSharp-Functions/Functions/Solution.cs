using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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

        public static double[] Assignment4(bool asc, params double[] nums)
        {
            if (asc)
                Helper.AscendSort(ref nums);
            else
                Helper.DescendSort(ref nums);
            return nums;
        }

        public static void Assignment5(ref string str, char[] letters)
        {
            const int LowerCaseZ = 122;
            const int LowerCaseA = 97;
            const int ValueToAddToLetters = 10;

            int minIndex = -1;
            char[] c = str.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (c[i] == letters[j] && i > minIndex)
                    {
                        int temp = Convert.ToInt32(c[i]);
                        if (temp <= LowerCaseZ - ValueToAddToLetters)
                            temp += ValueToAddToLetters;
                        else
                        {
                            int difference = LowerCaseZ - temp;
                            temp = LowerCaseA - 1 + difference + ValueToAddToLetters;
                        }
                        c[i] = Convert.ToChar(temp);
                        minIndex = i;
                        continue;
                    }
                }
            }
            str = new string(c);
        }

        public static bool Assignment6(string str)
        {
            Helper.GetRidOfPunctuation(ref str);
            char[] c = str.ToCharArray();
            for (int i = 0; i <= c.Length / 2; i++)
            {
                if (!Helper.LettersEqual(c[i], c[c.Length - 1 - i]))
                    return false;
            }
            return true;
        }

        public static int Assignment7(int[] nums)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();
            foreach(int num in nums)
            {
                if (numDict.ContainsKey(num))
                    numDict[num]++;
                else
                    numDict.Add(num, 1);
            }
            foreach(KeyValuePair<int, int> entry in numDict)
            {
                if (entry.Value == 1)
                    return entry.Key;
            }
            return -1;
        }

        public static void Assignment8(int[,] board, int rows, int cols)
        {
            int[,] newBoard = GameOfLife.UpdatedBoard(board, rows, cols);
            
            // Prints the output of game of life.
            Console.WriteLine('{');
            for (int row = 0; row < rows; row++)
            {
                Console.Write('{');
                for (int col = 0; col < cols - 1; col++)
                {
                    Console.Write(newBoard[row, col] + ", ");
                }
                Console.WriteLine(newBoard[row, cols - 1] + "}");
            }
            Console.WriteLine('}');
        }

        public static int Assignment9()
        {
            // 90% density of jumping numbers.
            int min = 21780;
            int max = 10000000;
            int current = (min + max) / 2;
            double temp = BouncingNumbers.AmountOfBouncingNums(current) / 0.99;

            while (temp != current)
            {
                if (temp < current)
                    min = current;
                else
                    max = current;

                current = (min + max) / 2;
                temp = BouncingNumbers.AmountOfBouncingNums(current) / 0.99;
            }
            return current;
        }
        #endregion

        #region Bonus solutions
        public static int Bonus1()
        {
            string[] vocab = {"One", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy",
                "eighty", "ninety"};

            List<string> stringList = vocab.ToList();
            int letterCount = 0;
            int oneToNine = Helper.LettersInRangeCounter(stringList.GetRange(0, 9));
            int tenToNineteen = Helper.LettersInRangeCounter(stringList.GetRange(9, 10));
            int twentyToNinety = Helper.LettersInRangeCounter(stringList.GetRange(19, 8));

            letterCount += oneToNine * 9;
            letterCount += tenToNineteen;
            letterCount += twentyToNinety * 10;
            
            return letterCount;
        }

        public static int Bonus2(uint[] hightMap)
        {
            uint currentHeight = 0;
            uint waterCounter = 0;
            uint maxHeightInRange = Helper.GetMaxInRange(hightMap, 0);

            for (uint i = 0; i < hightMap.Length; i++)
            {
                if (hightMap[i] < maxHeightInRange)
                { 
                    if (hightMap[i] >= currentHeight)
                        currentHeight = hightMap[i];
                    else
                        waterCounter += currentHeight - hightMap[i];
                }
                else if (hightMap[i] == maxHeightInRange && i < hightMap.Length - 1)
                    maxHeightInRange = Helper.GetMaxInRange(hightMap, i + 1);
            }
            return (int)waterCounter;
        }
        #endregion
    }
}
