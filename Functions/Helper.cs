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

        public static int[,] GameOfLife (int[,] board, int rows, int cols)
        {
            int[,] newBoard = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int current = board[row, col];
                    int amountOfNeighbors = AmountOfNeighbors(board, row, col, rows, cols);

                    if (amountOfNeighbors + current == 3 || amountOfNeighbors == 3)
                        newBoard[row, col] = 1;
                    else
                        newBoard[row, col] = 0;
                }
            }
            return newBoard;
        }

        public static int AmountOfNeighbors (int[,] board, int row, int col, int rows, int cols)
        {
            int[] currentRow = { -1, -1, row };
            int[] currentCol = { -1, -1, col };
            int neighborCounter = 0;

            if (row > 0)
                currentRow[0] = row - 1;
            if (col > 0)
                currentCol[0] = col - 1;
            if (row < rows - 1)
                currentRow[1] = row + 1;
            if (col < cols - 1)
                currentCol[1] = col + 1;

            for (int i = 0; i < currentRow.Length; i++)
            {
                for (int j = 0; j < currentCol.Length; j++)
                {
                    if (!(i == 2 && j == 2))
                        if (currentRow[i] != -1 && currentCol[j] != -1)
                            neighborCounter += board[currentRow[i], currentCol[j]];
                }
            }
            return neighborCounter;
        }

        public static int AmountOfJumpingNums (int num)
        {
            int counter = 0;
            for (int i = 0; i < num + 1 ; i++)
            {
                if (IsJumpingNumber(i))
                    counter++;
            }
            return counter;
        }

        public static bool IsJumpingNumber (int num)
        {
            const int SingleDigit = 9;

            bool IsAscending = true;
            bool IsDescending = true;
            int tempNum = num;


            while (tempNum > SingleDigit)
            {
                int lastDig = tempNum % 10;
                int beforeLastDig = tempNum % 100;
                beforeLastDig /= 10;

                if(lastDig < beforeLastDig)
                    IsAscending = false;
                else if (lastDig > beforeLastDig)
                    IsDescending = false;
                
                tempNum /= 10;
            }
            if (IsAscending == false && IsDescending == false)
                return true;
            return false;
        }

        public static int Half (int num1, int num2)
        {
            double half = (num1 + num2) / 2;
            return (int)half;
        }

        public static int countLettersInRange(int first, int second, string[] vocab)
        {
            int result = 0;
            for (int i = first; i < second; i++)
            {
                char[] letters = vocab[i].ToCharArray();
                result += letters.Length;
            }
            return result;
        }
    }
}
