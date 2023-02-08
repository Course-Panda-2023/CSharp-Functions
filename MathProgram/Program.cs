/*
 * TODO: Write code here
 */


double num1, num2;
double try1, try2;
string opertion;
string input;
string[] validInput = { "+", "-", "/", "*", "^" };

Console.WriteLine("Enter number:");
input = Console.ReadLine();

while (!double.TryParse(input,out try1))
{
    Console.WriteLine("Invalid input \nPlease Enter number");
    input = Console.ReadLine();
}
num1 = double.Parse(input);

Console.WriteLine("Enter operator:+ - / * ^");
input = Console.ReadLine();
while (!validInput.Contains(input))
{
    Console.WriteLine("Invalid input \nPlease Enter operator + - / * ^");
    input = Console.ReadLine();
}
opertion = input;

Console.WriteLine("Enter another number:");
input = Console.ReadLine();
while (!double.TryParse(input, out try2))
{
    Console.WriteLine("Invalid input \nPlease Enter number");
    input = Console.ReadLine();
}
num2 = double.Parse(input);

Console.Write("---------------\nanswer:  ");
switch (opertion)
{
    case "+":
        Console.WriteLine(num1 + num2);
        break;

    case "-":
        Console.WriteLine(num1 - num2);
        break;

    case "*":
        Console.WriteLine(num1 * num2);
        break;

    case "^":
        Console.WriteLine( Math.Pow(num1 , num2));
        break;

    case "/":
        if (num2 == 0)
            Console.WriteLine("can not divide by 0");
        else
            Console.WriteLine(num1 / num2);
        break;

    default:
        Console.WriteLine("invalid opertion or numbers");
        break;
}



Console.ReadLine();

