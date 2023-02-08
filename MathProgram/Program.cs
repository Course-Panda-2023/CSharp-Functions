Console.WriteLine("Enter two numbers and an operator");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
string oper = Console.ReadLine();

double result = Calculator(x, y, oper);
Console.WriteLine($"The result is: {result}");

static double sum(double x, double y)
{
    return x + y;
}
static double minus(double x, double y)
{
    return x - y;
}
static double mult(double x, double y)
{
    return x * y;
}
static double div(double x, double y)
{
    return x / y;
}
static double pow(double x, double y)
{
    return Math.Pow(x, y);
}
static double Calculator(double x, double y, string oper)
{
    switch (oper)
    {
        case "+":
            return sum(x, y);
        case "-":
            return minus(x, y);
        case "*":
            return mult(x, y);
        case "/":
            return div(x, y);
        case "^":
            return pow(x, y);
    }
    throw new Exception("Operator is missing!");
}
