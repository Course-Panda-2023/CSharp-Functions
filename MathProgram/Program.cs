using System;

namespace MathProgram
{
    class MathProgram
    {
        public static void MathCalculator(int x, int y, string op) {
            try
            {
                switch (op)
                {
                    case "+":
                        Console.WriteLine($"{x} + {y} = {Convert.ToDouble(x) + Convert.ToDouble(y)}");
                        break;
                    case "-":
                        Console.WriteLine($"{x} - {y} = {Convert.ToDouble(x) - Convert.ToDouble(y)}");
                        break;
                    case "*":
                        Console.WriteLine($"{x} * {y} = {Convert.ToDouble(x) * Convert.ToDouble(y)}");
                        break;
                    case "/":
                        Console.WriteLine($"{x} / {y} = {Convert.ToDouble(x) / Convert.ToDouble(y)}");
                        break;
                    case "^":
                        Console.WriteLine($"{x} ^ {y} = {x ^ y}");
                        break;
                    default:
                        Console.WriteLine("invalid operation");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("invalid number");
                throw;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("what is your first number?");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("what is your second number?");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("operation: ");
            string operation = Console.ReadLine();
            MathCalculator(num1, num2, operation);
        }
    }
}