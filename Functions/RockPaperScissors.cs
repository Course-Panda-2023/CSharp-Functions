public class RockPaperScissors
{
    public enum RPS
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    }
    public static RPS ReadInput()
    {
        Console.WriteLine("Write r, p or s");
        string input = Console.ReadLine();
        if (input == "r")
        {
            return RPS.Rock;
        }
        else if (input == "p")
        {
            return RPS.Paper;
        }
        else if (input == "s")
        {
            return RPS.Scissors;
        }
        else
        {
            Console.WriteLine("wrong input");
            return ReadInput();
        }
    }
    public static void RPSOutput(int player1Num, int player2Num)
    {
        if (player1Num == player2Num)
        {
            Console.WriteLine("it's a tie!");
        }
        if ((3 + player1Num - player2Num) % 3 == 1)
        {
            Console.WriteLine("player 1 wins");
        }
        if ((3 + player1Num - player2Num) % 3 == 2)
        {
            Console.WriteLine("player 2 wins");
        }
    }
    public static int RPSToNumber(RPS sign)
    {
        if (sign == RPS.Rock) { return 0; }
        if (sign == RPS.Paper) { return 1; }
        return 2;
    }

}