using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basic
{
    internal class Helper
    {
        /*
         * TODO: Add any needed helper functions
         */
        public static void ManageAssignment1(int assignmentNum, Action assignment)//, string correctRes)
        {
            Console.WriteLine("Running assignment 1...");
            //Console.WriteLine($"Wanted solution: {correctRes}");
            Console.Write($"Your solution: ");
            assignment();
        }
    }
}
