﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        public static double[] ReverseArr(double[] nums)
        {
            double[] reverseArr = new double[nums.Length];
            int counter = 0;
            int arrLength = nums.Length;
            while (arrLength > 0)
            {
                reverseArr[counter] = nums[arrLength - 1];
                arrLength--;
                counter++;
            }
            return reverseArr;
        }

        public static void PrintArr(double[] nums)
        {
            Console.Write('{');
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                    Console.Write(nums[i]);
                else
                    Console.Write(nums[i] + ", ");
            }
            Console.WriteLine('}');
        }

        public static void GetRidOfPunctuation(ref string str)
        {
            const int UpperCaseA = 65;
            const int UpperCaseZ = 90;
            const int DiffBetweenUpperCaseAndLowerCase = 32;
            const int LowerCaseA = 97;
            const int LowerCaseZ = 122;

            char[] c = str.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                // Convert all uppercase letters to lowercase.
                int temp = Convert.ToInt32(c[i]);
                if (temp >= UpperCaseA && temp <= UpperCaseZ)
                {
                    temp += DiffBetweenUpperCaseAndLowerCase;
                    c[i] = Convert.ToChar(temp);
                }
                // Anything that is not a letter, convert to ' '.
                if (!(temp >= LowerCaseA && temp <= LowerCaseZ))
                {
                    c[i] = ' ';
                }
            }
            str = new string(c);
        }

        public static bool AppearsTwice(int num, int index, int[] numArr)
        {
            for (int i = 0; i < numArr.Length; i++)
            {
                if (num == numArr[i] && index != i)
                {
                    return true;
                }
            }
            return false;
        }

        public static int CountLettersInRange(int first, int second, string[] vocab)
        {
            int result = 0;
            for (int i = first; i < second; i++)
            {
                char[] letters = vocab[i].ToCharArray();
                result += letters.Length;
            }
            return result;
        }

        public static int[] GetMaxAndDup(int[] arr, int index)
        {
            int[] maxAndDouble = new int[2];
            int max = 0;
            int maxIndex = 0;
            int hasDouble = 0;
            for (int i = index; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
                if (i != maxIndex && max == arr[i])
                    hasDouble = 1;
            }
            maxAndDouble[0] = max;
            maxAndDouble[1] = hasDouble;
            return maxAndDouble;
        }
    }
}
