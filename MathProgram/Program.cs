public static void EX2(double firstNumber, double secondNumber, string operand)
{
    switch (operand)
    {
        case "+":
            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
            break;
        case "-":
            Console.WriteLine(firstNumber + " - " + secondNumber + " = " + (firstNumber - secondNumber));
            break;
        case "*":
            Console.WriteLine(firstNumber + " * " + secondNumber + " = " + (firstNumber * secondNumber));
            break;
        case "/":
            Console.WriteLine(firstNumber + " / " + secondNumber + " = " + (firstNumber / secondNumber));
            break;
        case "^":
            int power = (int)Math.Pow(firstNumber, secondNumber);
            Console.WriteLine(firstNumber + " ^ " + secondNumber + " = " + power);
            break;
        default:
            break;
    }
}