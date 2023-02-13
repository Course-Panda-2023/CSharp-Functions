using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        public static Boolean findWall(int[] hightMap, int startIndex, int wallHight)
        {
            for (int currIndex = startIndex; currIndex < hightMap.Length; currIndex++)
            {
                if (hightMap[currIndex] >= wallHight)
                {
                    return true;
                }
            }
            return false;
        }
        public static int findIndexOfMax(double[] arr)
        {
            int maxIndex = 0;
            double currMax = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (currMax < arr[i])
                {
                    maxIndex = i;
                    currMax = arr[i];
                }
            }

            return maxIndex;
        }

        public static int findIndexOfMin(double[] arr)
        {
            int minIndex = 0;
            double currMin = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (currMin > arr[i])
                {
                    minIndex = i;
                    currMin = arr[i];
                }
            }

            return minIndex;
        }
        public static double[] MaxSort(double[] arr)
        {
            double[] sortedArr = new double[arr.Length];
            double[] dupArr = arr;
            int currMaxIndex;

            for (int i = 0; i < arr.Length ; i++)
            {
                currMaxIndex = findIndexOfMax(dupArr);
                sortedArr[i] = dupArr[currMaxIndex];
                dupArr[currMaxIndex] = Int32.MinValue;
            }
            return sortedArr;
        }

        public static double[] MinSort(double[] arr)
        {
            double[] sortedArr = new double[arr.Length];
            double[] dupArr = arr;
            int currMinIndex;

            for (int i = 0; i < dupArr.Length; i++)
            {
                currMinIndex = findIndexOfMin(dupArr);
                sortedArr[i] = dupArr[currMinIndex];
                dupArr[currMinIndex] = Int32.MaxValue;
            }
            return sortedArr;
        }

        public static void PrintArray(double[] arr)
        {
            foreach (double number in arr)
            {
                Console.Write($"{number}, ");
            }
        }

        public static bool IsCharInLetterArray(char ch, char[] letters)
        {
            foreach (char letter in letters)
            {
                if (letter == ch)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsSameLetter(char char1, char char2)
        {
            return char.ToUpperInvariant(char1) == char.ToUpperInvariant(char2);
        }

        public static bool IsSign(char ch)
        {
            int MAX_SIGN_VALUE_LOW_BOUND = 64;
            int MAX_SIGN_VALUE_HIGH_BOUND = 123;
            int SIGN_RANGE_LOW_BOUND = 91;
            int SIGN_RANGE_HIGH_BOUND = 96;

            return ch <= MAX_SIGN_VALUE_LOW_BOUND ||
                (ch >= SIGN_RANGE_LOW_BOUND && ch <= SIGN_RANGE_HIGH_BOUND) ||
                ch > MAX_SIGN_VALUE_HIGH_BOUND;
        }
    }
}
