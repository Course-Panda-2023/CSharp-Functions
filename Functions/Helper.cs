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
                Console.Write(num + ", ");
            }
        }
        public static void PrintIntArrayArray(int[][] arrArr)
        {
            foreach (int[] arr in arrArr)
            {
                PrintIntArray(arr);
                Console.WriteLine();
            }
        }
        
        public static int[][] TurnBoolMatrixToIntArrayArray(bool[,] mat)
        {
            int[][] answer = new int[mat.GetLength(0)][];
            for(int i = 0; i<mat.GetLength(0); i++)
            {
                answer[i] = new int[mat.GetLength(1)];
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    answer[i][j] = Convert.ToInt32(mat[i, j]);
                }
            }
            return answer;
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
        
        public static void BubbleSort(int[] arr)
        {
            bool didMove = false;
            do
            {
                didMove = false;
                for (int i = 0; i < arr.Count() - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        var lower = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = lower;
                        didMove = true;
                    }
                }
            } while (didMove);
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
        public static string ToLowerCase(string str)
        {
            string lowercase = "";
            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                {
                    lowercase += c.ToString().ToLower();
                }
            }
            return lowercase;
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool IsInBoard(int row, int col, int m, int n)
        {
            return (0 <= row && row < m && 0 <= col && col < n);
        }

        public static int[][] GetAdjacents(int row, int col)
        {
            int[][] result = new int[8][];
            int[] temp0 = { row - 1, col - 1 };
            result[0] = temp0;
            int[] temp1 = { row - 1, col };
            result[1] = temp1;
            int[] temp2 = { row - 1, col + 1};
            result[2] = temp2;
            int[] temp3 = { row, col - 1 };
            result[3] = temp3;
            int[] temp4 = { row, col + 1};
            result[4] = temp4;
            int[] temp5 = { row + 1, col - 1 };
            result[5] = temp5;
            int[] temp6 = { row + 1, col };
            result[6] = temp6;
            int[] temp7 = { row + 1, col + 1 };
            result[7] = temp7;
            return result;
        }

        public static int NumLivingAdjacents(int row, int col, int m, int n, bool[,] board)
        {
            int numLivingAdjacents = 0;
            foreach (int[] adjacent in GetAdjacents(row, col))
            {
                if (IsInBoard(adjacent[0], adjacent[1], m, n))
                {
                    if (board[adjacent[0], adjacent[1]])
                    {
                        numLivingAdjacents++;
                    }
                }
            }
            return numLivingAdjacents;
        }

        public static string GetDigits(int num)
        {
            string digits = "";
            while (num > 0)
            {
                int digit = num % 10;
                digits = digit.ToString() + digits;
                num /= 10;
            }
            return digits;
        }
        public static bool IsUppering(string str)
        {
            bool isUppering = true;
            for(int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] > str[i+1])
                {
                    isUppering = false;
                }
            }
            return isUppering;
        }
        public static bool IsLowering(string str)
        {
            return IsUppering(Reverse(str));
        }
        /*
        public static string FirstLetter(string str)
        {
            foreach (char c in str) 
            {
                if (Char.IsLetter(c))
                {
                    return c.ToString().ToLower()
                }
            }
            return null;
        }
        public static string LastLetter(string str)
        {
            str = Reverse(str);
            return FirstLetter(str);
        }
        */



    }
}
