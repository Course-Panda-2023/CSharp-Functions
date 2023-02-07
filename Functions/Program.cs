// See https://aka.ms/new-console-template for more information
using Basic;
using System;

namespace SolutionTest // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("question 1");
            Console.WriteLine("give me num 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("give me num 2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("give me num 3");
            int num3 = int.Parse(Console.ReadLine());
            Solution.Assignment1(num1, num2, out num3);
            Console.WriteLine("your new number 3 is:" + num3);
        }
    }
}
