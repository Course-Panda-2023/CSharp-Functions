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
    }
}