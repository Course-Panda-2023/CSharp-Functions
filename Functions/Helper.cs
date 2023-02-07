using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        public static void ManageAssignment1()
        {
            Console.WriteLine($"Running assignment 1...");
            int res; 
            Solution.Assignment1(5, 1, out res);
            Console.WriteLine($"Result is {res}");
        }

        public static void ManageAssignment3()
        {
            Solution.Assignment3();
        }
    }
}
