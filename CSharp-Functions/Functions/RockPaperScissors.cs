public class RockPaperScissors
{
	public enum RPS
	{
		R,
		P,
		S
	}

	public static string RPSFunc()
	{
        string result; 
		Console.WriteLine("This is a game of rock paper scissors.");
        Console.WriteLine("Player1, Please type R, P or S:");
        string player1 = Console.ReadLine();
        Console.WriteLine("Player2, Please type R, P or S:");
        string player2 = Console.ReadLine();

        if (!CheckCorrectInput(player1, player2))
        {
            result = "Your input is incorrect.";
        }
        else if (player1 == player2)
        {
            result = "It's a tie!";
        }
        else if (SecondPlayerWon(player1, player2))
        {
            result = "Second player wins!";
        }
        else
            result = "First player wins!";
        return result;
	}

    public static bool CheckCorrectInput(string player1, string player2)
    {
        return ((player1 == RPS.R.ToString() || player1 == RPS.P.ToString() || player1 == RPS.S.ToString()) && (player2 == RPS.R.ToString() ||
            player2 == RPS.P.ToString() || player2 == RPS.S.ToString()));
    }

    public static bool SecondPlayerWon(string player1, string player2)
    {
        return (player1 == RPS.S.ToString() && (player2 == RPS.R.ToString())) || (player1 == RPS.R.ToString() && (player2 == RPS.P.ToString())) ||
            (player1 == RPS.P.ToString() && (player2 == RPS.S.ToString()));
    }
}
