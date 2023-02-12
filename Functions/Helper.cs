using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basic
{
    internal class Helper
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Choose an assignment to run:");
            Console.WriteLine("1. Assignment 1");
            Console.WriteLine("2. Assignment 2 Please run from MathProgram");
            Console.WriteLine("3. Assignment 3");
            Console.WriteLine("4. Assignment 4");
            Console.WriteLine("5. Assignment 5");
            Console.WriteLine("6. Assignment 6");
            Console.WriteLine("7. Assignment 7");
            Console.WriteLine("8. Assignment 8");
            Console.WriteLine("9. Assignment 9");
            Console.WriteLine("10. Bonus 1");
            Console.WriteLine("11. Bonus 2");
            Console.WriteLine("12. Exit");            
        }
        public static void RunAssignment1()
        {
            int res;           
            Solution.Assignment1(10, 20, out res);

        }
        public static void RunAssignment4()
        {
            double[] nums = { 1, 10, 9, 3, 100, 12 };
            Solution.Assignment4(true, nums);

        }
        public static void RunAssignment5()
        {
            char[] letters = { 'i', 'o' };
            string str = Console.ReadLine();
            Solution.Assignment5(str, letters);

        }
        public static void RunAssignment6()
        {
            string str = Console.ReadLine();
            Console.WriteLine($"Assignment 6 output: {Solution.Assignment6(str)}");

        }
        public static void RunAssignment7()
        {
            int[] nums = { 10, 2, 2, 3, 3, 3, 1, 200 };
            Console.WriteLine($"Assignment 7 output: {Solution.Assignment7(nums)}");

        }
        public static void RunAssignment8()
        {
            bool[,] array2Da = new bool[4, 3] { { false, true, false }, { false, false, true }, { true, true, true }, { false, false, false } };
            Solution.Assignment8(array2Da, 4, 3);

        }
        public static void RunBonus2()
        {
            uint[] highMap = new uint[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Console.WriteLine($"The solution of bonus 2 is {Solution.Bonus2(highMap)}");

        }
        public static void Menu() {
            {
            int choice = 0;
            while (choice != 12)
                {
                PrintMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                    {
                    case 1:
                        RunAssignment1();
                        break;
                    case 2:
                        Console.WriteLine("Please run from MathProgram!");
                        break;
                    case 3:
                        Solution.Assignment3();
                        break;
                    case 4:
                        RunAssignment4();
                        break;
                    case 5:
                        RunAssignment5();
                        break;
                    case 6:
                        RunAssignment6();   
                        break;
                    case 7:
                            RunAssignment7();
                        break;
                    case 8:
                        RunAssignment8();
                        break;
                    case 9:
                        Solution.Assignment9();
                        break;
                    case 10:
                        Console.WriteLine($"The solution of bonus 1 is {Solution.Bonus1()}");
                        break;
                    case 11:
                        RunBonus2();    
                        break;
                    case 12:                       
                        return;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                }
            }
        } }
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