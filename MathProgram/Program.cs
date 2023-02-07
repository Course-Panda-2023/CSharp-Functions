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
    Environment.Exit();
}
Console.WriteLine("ENTER YOUR OTHER NUMBER HUMAN");
try
{
    num2 = Int32.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("INVALID NUMBER ENTERED :(");
    Environment.Exit();
}
Console.WriteLine("ENTER THE OPERATION YOU WOULD LIKE ME TO PERFORM");
String operation = Console.ReadLine();
switch (operation)
{
    case "+":
        Console.WriteLine($"MathProgram {num1} {operation} {num2} -> {num1+num2}");
            break;
    case "-":
        Console.WriteLine($"MathProgram {num1} {operation} {num2} -> {num1 - num2}");
        break;
    case "*":
        Console.WriteLine($"MathProgram {num1} {operation} {num2} -> {num1 * num2}");
        break;
    case "/":
        if (num2 == 0)
        {
            Console.WriteLine($"MathProgram {num1} {operation} {num2} -> undefined")
        }
        Console.WriteLine($"MathProgram {num1} {operation} {num2} -> {num1 / num2}");
        break;
    case "^":
        if (num1 == 0 &&  num2 == 0)
        {
            Console.WriteLine($"MathProgram {num1} {operation} {num2} -> undefined")
        }
        Console.WriteLine($"MathProgram {num1} {operation} {num2} -> {num1 ^ num2}");
        break;
    default:
        Console.WriteLine("INVALID OPERATION ENTERED");
        Environment.Exit();
        break;
}