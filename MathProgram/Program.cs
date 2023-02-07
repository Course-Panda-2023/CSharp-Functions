static int Addition(int x, int y)
{
return(x + y);
}

static int Subtraction(int x, int y)
{
    return(x - y);
}

static double Division(double x, double y)
{
    return(x / y);
}

static int Multiplication(int x, int y)
{
    return(x * y);
}

static void Calc(int x, int y, string sign)
{
    switch (sign)
    {
        case "+":
            Console.WriteLine(Addition(x,y));
            break;
        case "-":
            Console.WriteLine(Subtraction(x,y));
            break;
        case "*":
            Console.WriteLine(Multiplication(x,y));
            break;
        case "/":
            Console.WriteLine(Division(x,y));
            break;
        case "^":
            Console.WriteLine(Math.Pow(x,y));
            break;
    }
}