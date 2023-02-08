using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basic
{
    internal class Helper
    {
        public static void ManageAssignment(int assignmentNum, Action assignment, string correctRes)
        {
            Console.WriteLine("Running assignment 1...");
            Console.WriteLine($"Wanted solution: {correctRes}");
            Console.Write($"Your solution: ");
            assignment();
        }
        public static void ShiftLetters(ref string str, char[] letters)
        {
            const int shift = 10;
            char[] temp_str = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (letters.Contains(str[i]))
                {                    
                    int charASCII = (int)temp_str[i];
                    temp_str[i] = (char)(charASCII + shift);
                }                
            }     
            
            str = string.Concat(temp_str);
            Console.Write(str);
        }
        public static double[] MergeSort(params double[] unsorted)
        {            
            if (unsorted.Length <= 1){ 
                return unsorted;
            }
            int middle = unsorted.Length / 2;
            double[] left_buffer = new double[middle];
            double[] right_buffer = new double[unsorted.Length - middle];
            Array.Copy(unsorted, 0, left_buffer, 0, middle);
            Array.Copy(unsorted, middle, right_buffer, 0, unsorted.Length - middle);
            left_buffer = MergeSort(left_buffer);
            right_buffer = MergeSort(right_buffer);
            return Merge(left_buffer, right_buffer);
        }
        public static double[] Merge(double[] left, double[] right)
        {
            double[] sorted = new double[left.Length + right.Length];
            int left_i = 0, right_i = 0, i = 0;
            while (left_i < left.Length || right_i < right.Length)
            {
                if (i == left.Length + right.Length)
                {                    
                    return sorted;
                    //break;
                }
                if (left_i < left.Length && right_i < right.Length)
                {
                    if (left[left_i] < right[right_i])
                    {
                        sorted[i] = left[left_i];
                        i++;
                        left_i++;
                    }
                    else
                    {
                        sorted[i] = right[right_i];
                        i++;
                        right_i++;
                    }
                }
                else if (left_i < left.Length)
                {
                    sorted[i] = left[left_i];
                    i++;
                    left_i++;
                }
                else if (right_i < right.Length)
                {
                    sorted[i] = right[right_i];
                    i++;
                    right_i++;
                }
            }
            return sorted;
        }
    }
}