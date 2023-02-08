Console.WriteLine("enter a number, operator and number");
string firstNumber = Console.ReadLine()!;
string mathOperator = Console.ReadLine()!;
string secondNumber = Console.ReadLine()!;
try
{
    double x = Convert.ToDouble(firstNumber);
    double y = Convert.ToDouble(secondNumber);
    if (mathOperator == "+")
    {
        double output = x + y;
        Console.WriteLine($"{x}{mathOperator}{y}={output}");
    }
    else if (mathOperator == "-")
    {
        double output = x - y;
        Console.WriteLine($"{x}{mathOperator}{y}={output}");
    }
    else if (mathOperator == "*")
    {
        double output = x * y;
        Console.WriteLine($"{x}{mathOperator}{y}={output}");
    }
    else if (mathOperator == "/")
    {
        if (y == 0)
        {
            Console.WriteLine("invalid! divisior can't be 0! cannot compute");
        }
        else
        {
            double output = x / y;
            Console.WriteLine($"{x}{mathOperator}{y}={output}");
        }
    }
    else if (mathOperator == "^")
    {
        double output = Math.Pow(x, y);
        Console.WriteLine($"{x}{mathOperator}{y}={output}");
    }
    else
    {
        Console.WriteLine("invalid operator entered");
    }
}
catch
{
    Console.WriteLine("invalid number entered");
}
