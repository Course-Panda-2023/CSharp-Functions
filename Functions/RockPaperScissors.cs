using System.Security.Cryptography.X509Certificates;

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
		input = input.ToLower();
		return (input == "rock" || input == "paper" || input == "scissors");
	}

	public static Action strToActionConverter(string str)
	{
		switch (str.ToLower())
		{
			case "rock":
				return Action.Rock;
			case "paper":
				return Action.Paper;
			case "scissors":
				return Action.Scissors;
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

	public static int RunARound()
	{
		Action firstPlayerAction = getValidAction();
		Action secondPlayerAction = getValidAction();

		if (IsWinner(firstPlayerAction, secondPlayerAction))
		{
			Console.WriteLine("First player wins!");
			return 1;
		}
		else
		{
			if (IsWinner(secondPlayerAction,firstPlayerAction))
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

	public static bool IsWinner(Action checkIfWinner, Action secondPlayerAction)
	{
		return (checkIfWinner == Action.Rock && secondPlayerAction == Action.Scissors) ||
			(checkIfWinner == Action.Paper && secondPlayerAction == Action.Rock) ||
			(checkIfWinner == Action.Scissors && secondPlayerAction == Action.Paper);
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
			roundResult = RunARound();
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
