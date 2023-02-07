using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
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

        public static void printArr(double[] arr)
        {
            foreach (double number in arr)
            {
                Console.Write($"{number}, ");
            }
        }

        public static bool DoesCharExistInArr(char ch, char[] letters)
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
            const int DIFFERENCE_UPPERCASE_LOWERCASE = 32;
            if (char1 > char2 && char1 - DIFFERENCE_UPPERCASE_LOWERCASE == char2)
            {
                return true;
            }
            else
            {
                if (char2 > char1 && char2 - DIFFERENCE_UPPERCASE_LOWERCASE == char1)
                {
                    return true;
                }
                else
                {
                    if (char1 == char2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool IsSign(char ch)
        {
            //numbers are according to the question and
            //the ascci value of signs to take into account (spaces and so).
            if (ch <= 64 || (ch >= 91 && ch <= 96) || ch > 123)
            {
                return true;
            }
            return false;
        }
    }
}
