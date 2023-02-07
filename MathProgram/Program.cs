namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("ENTER YOUR NUMBER HUMAN");
            try
            {
                num1 = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("INVALID NUMBER ENTERED :(");
                return;
            }
            Console.WriteLine("ENTER YOUR OTHER NUMBER HUMAN");
            try
            {
                num2 = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("INVALID NUMBER ENTERED :(");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("ENTER THE OPERATION YOU WOULD LIKE ME TO PERFORM");
            String operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"MathProgram {num1} {operation} {num2} -> {num1 + num2}");
                    Console.ReadLine();
                    break;
                case "-":
                    Console.WriteLine($"MathProgram {num1} {operation} {num2} -> {num1 - num2}");
                    Console.ReadLine();
                    break;
                case "*":
                    Console.WriteLine($"MathProgram {num1} {operation} {num2} -> {num1 * num2}");
                    Console.ReadLine();
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"MathProgram {num1} {operation} {num2} -> undefined");
                        Console.ReadLine();
                        return;
                    }
                    Console.WriteLine($"MathProgram {num1} {operation} {num2} -> {num1 / num2}");
                    Console.ReadLine();
                    break;
                case "^":
                    if (num1 == 0 && num2 == 0)
                    {
                        Console.WriteLine($"MathProgram {num1} {operation} {num2} -> undefined");
                        Console.ReadLine();
                        return;
                    }
                    Console.WriteLine($"MathProgram {num1} {operation} {num2} -> {num1 ^ num2}");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("INVALID OPERATION ENTERED");
                    Console.ReadLine();
                    return;
                    break;
            }
        }
    }
}