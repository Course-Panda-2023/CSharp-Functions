public class RockPaperScissors
{
	public enum Action
	{
		Rock,
		Paper,
		Scissors
	}

	public static Boolean validateAction(string input)
	{
		return (input == "rock" || input == "Rock"
			|| input == "paper" || input == "Paper"
			|| input == "scissors" || input == "Scissors");
	}

	public static Action strToActionConverter(string str)
	{
		switch (str)
		{
			case "rock":
				return Action.Rock;
				break;
			case "Rock":
				return Action.Rock;
				break;
			case "Paper":
				return Action.Paper;
			case "paper":
				return Action.Paper;
				break;
			case "Scissors":
				return Action.Scissors;
				break;
			case "scissors":
				return Action.Scissors;
				break;
		}
		return new Action();
	}

	public static Action getValidAction()
	{
		Console.WriteLine("please enter your action: ");
		string playerInput = Console.ReadLine();

		while (!validateAction(playerInput))
		{
			Console.WriteLine("input is not valid! try again.");
			Console.WriteLine("please enter new action: ");
			playerInput= Console.ReadLine();
		}

		return strToActionConverter(playerInput);
	}

	public static int runARound()
	{
		Action firstPlayerAction = getValidAction();
		Action secondPlayerAction = getValidAction();

		if ((firstPlayerAction == Action.Rock && secondPlayerAction == Action.Scissors) ||
			(firstPlayerAction == Action.Paper && secondPlayerAction == Action.Rock) ||
			(firstPlayerAction == Action.Scissors && secondPlayerAction == Action.Paper))
		{
			Console.WriteLine("First player wins!");
			return 1;
		}
		else
		{
			if ((secondPlayerAction == Action.Rock && firstPlayerAction == Action.Scissors) ||
				(secondPlayerAction == Action.Paper && firstPlayerAction == Action.Rock) ||
				(secondPlayerAction == Action.Scissors && firstPlayerAction == Action.Paper))
			{
				Console.WriteLine("Second player wins!");
				return 2;
			}
			else
			{
				Console.WriteLine("It's a tie!");
				return 0;
			}
		}
	}

	public static void runGame()
	{
		Console.WriteLine("Welcome to Rock Paper Scissors!!!");
		int firstPlayerPoints = 0;
		int secondPlayerPoints = 0;
		int roundResult;
		bool gameRunFlag = true;

		while (gameRunFlag)
		{
			roundResult = runARound();
			if (roundResult == 1)
			{
				firstPlayerPoints++;
			}
			else if (roundResult == 2)
			{
				secondPlayerPoints++;
			}
			Console.WriteLine("do you want to play another round? y - yes. to finish press any other key.");
			gameRunFlag = Console.ReadLine() == "y" ? true : false;
			Console.WriteLine();
		}
		Console.WriteLine( $"first player has: {firstPlayerPoints} points. second player has: {secondPlayerPoints} points.");
	}
}
