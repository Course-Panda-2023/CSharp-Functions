
static object Dev(double a, double b)
{
    if (b == 0)
        return "Can't devide by zero";
    else
        return a / b;
}

static double Mul(double a, double b)
{
    return a * b;
}

static double Add(double a, double b)
{
    return a + b;
}

static double Sub(double a, double b)
{
    return a - b;
}

static double Pow(double a, double b)
{
    return Math.Pow(a, b);
}

static void MathProgram(double num1, char c, double num2)
{
    switch (c)
    {
        case '/':
            Console.WriteLine(Dev(num1, num2));
            break;
        case '*':
            Console.WriteLine(Mul(num1, num2));
            break;
        case '+':
            Console.WriteLine(Add(num1, num2));
            break;
        case '-':
            Console.WriteLine(Sub(num1, num2));
            break;
        case '^':
            Console.WriteLine(Pow(num1, num2));
            break;
        default:
            Console.WriteLine("The input is wrong");
            break;
    }
}

Console.WriteLine("Please enter a number:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter a mathmatical character:");
char c = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Please enter another number:");
double num2 = Convert.ToDouble(Console.ReadLine());

MathProgram(num1, c, num2);






