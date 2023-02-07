using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        public static void WaitForEnter()
        {
            int stopASecToLetMeRead = Console.Read();
        }
        public static double ReadDouble()
        {
            Console.WriteLine("enter double");
            string str = Console.ReadLine();
            bool isNumeric = double.TryParse(str, out double n);
            if (isNumeric)
            {
                return Convert.ToDouble(str);
            }
            Console.WriteLine("not a double,");
            return ReadDouble();
        }
        public static void PrintIntArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
        public static int[] CopyArray(int[] original)
        {
            int[] copy = new int[original.Length];
            for(int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }
            return copy;
        }
        public static int[] InsertionSort(int[] arr, int num)
        {
            if (num > 1)
            {
                arr = CopyArray(InsertionSort(arr, num - 1));
                int last = arr[num-1];
                int counter = num - 2;
                while (counter > 1 && arr[counter] > last)
                {
                    arr[counter - 1] = arr[counter];
                    counter--;
                }
                arr[counter] = last;
            }
            return arr;
        }

        public static char SiftLetter(char c)
        {
            int shiftAmount = 10;
            char newChar = (char)(c + shiftAmount);
            if (newChar > 'z')
            {
                newChar -= (char)26;
            }
            char result = newChar;
            return result;
        }

    }
}
