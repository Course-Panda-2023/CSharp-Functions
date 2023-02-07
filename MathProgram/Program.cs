
Console.WriteLine("Enter a valid number, an operator and another valid number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
String temp = Console.ReadLine()!;
char oper = Convert.ToChar(temp);
double num2 = Convert.ToDouble(Console.ReadLine());
double solution = 0;
switch(oper)
{
    case '+':
        solution = num1 + num2;
        break;
    case '-':
        solution = num1 - num2;
        break;
    case '*':
        solution = num1 * num2;
        break;
    case '/':
        solution = num1 / num2;
        break;
    case '^':
        solution = Math.Pow(num1, num2);
        break;
    default:
        Console.WriteLine("Invalid Operator");
}
Console.WriteLine("MathProgram " + num1 + " " + oper + " " + num2 + " -> " + solution);