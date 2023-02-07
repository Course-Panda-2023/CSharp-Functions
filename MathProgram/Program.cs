Console.WriteLine("Enter two numbers and an operator");
try
{
    double x = Convert.ToDouble(Console.ReadLine()!);
    double y = Convert.ToDouble(Console.ReadLine()!);
    string operand = Console.ReadLine()!;

    double res = Calculator(x, y, operand);
    Console.WriteLine($"The result is {res}");
}
catch (Exception)
{
    Console.WriteLine("Please enter a valid input!");
}

static double Plus(double x, double y)
{
    return x + y;
}

static double Minus(double x, double y)
{
    return x - y;
}

static double Mul(double x, double y)
{
    return x * y;
}

static double Div(double x, double y)
{
    return x / y;
}

static double Power(double x, double y)
{
    return Math.Pow(x, y);
}

static double Calculator(double x, double y, string operand)
{
    switch (operand)
    {
        case "+":
            return Plus(x, y);
        case "-":
            return Minus(x, y);
        case "*":
            return Mul(x, y);
        case "/":
            return Div(x, y);
        case "^":
            return Power(x, y);
    }
    throw new Exception("Operator not valid");
}
