public class RockPaperScissors
{
	public enum Action
	{
		Rock,
		Paper,
		Scissors,
		Unknown
	}

	public static Action handleActions(string choice)
	{
		switch (choice)
		{
			case "rock":
				return Action.Rock;
			case "paper":
				return Action.Paper;
			case "scissors":
				return Action.Scissors;
			default:
				break;
		}
		return Action.Unknown;
	}
	public static void handleResults(Action player1, Action player2)
	{
		if (player1 == player2)
		{
			if (player1 == Action.Unknown && player2 == Action.Unknown) {
				Console.WriteLine("two actions invalid");
				return;
			}
			Console.WriteLine("tie");
		}
		else if (player1 == Action.Rock)
		{
			switch (player2)
			{
				case Action.Paper:
					Console.WriteLine("player 2 win");
					break;
				case Action.Scissors:
					Console.WriteLine("player 1 win");
					break;
				default:
					break;
			}
		}
		else if (player1 == Action.Paper)
		{
			switch (player2)
			{
				case Action.Scissors:
					Console.WriteLine("player 2 win");
					break;
				case Action.Rock:
					Console.WriteLine("player 1 win");
					break;
				default:
					break;
			}
		}
		else if (player1 == Action.Scissors)
		{
			switch(player2)
			{
				case Action.Rock:
					Console.WriteLine("player 2 win");
					break;
				case Action.Paper:
					Console.WriteLine("player 1 win");
					break;
				default:
					break;
			}
		}
		if (player1 == Action.Unknown || player2 == Action.Unknown)
		{
			Console.WriteLine("atleast one invalid action");
		}
	}
}
