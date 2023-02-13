using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        public static void AscendSort(ref double[] nums)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                for (int j = nums.Length - 1; j >= 0; j--)
                {
                    if (nums[i] > nums[j])
                    {
                        double temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                    }
                }
            }
        }

        public static void DescendSort(ref double[] nums) 
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        double temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                    }
                }
            }
        }

        public static void PrintArr(double[] nums)
        {
            Console.Write('{');
            for (int i = 0; i < nums.Length - 1; i++)
            {
                Console.Write(nums[i] + ", ");
            }
            Console.WriteLine(nums[nums.Length - 1] + "}");
        }

        public static void GetRidOfPunctuation(ref string str)
        {
            const int UpperCaseA = 65;
            const int LowerCaseZ = 122;

            char[] c = str.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                int temp = Convert.ToInt32(c[i]);
                if (!(temp >= UpperCaseA && temp <= LowerCaseZ))
                {
                    c[i] = ' ';
                }
            }
            str = new string(c);
            str = str.Replace(" ", string.Empty);
        }

        public static bool LettersEqual(char c1, char c2)
        {
            const int Difference = 32;
            return (c1 == c2 || c1 - c2 == Difference || c2 - c1 == Difference);
        }

        public static int LettersInRangeCounter(List<string> vocab)
        {
            int result = 0;
            for (int i = 0; i < vocab.Count; i++)
            {
                char[] letters = vocab[i].ToCharArray();
                result += letters.Length;
            }
            return result;
        }

        public static int[] GetMaxAndDouble(int[] arr, int index)
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
