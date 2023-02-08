public class RockPaperScissors
{
	public enum RPS
	{
		ROCK,
		SCISSORS,
		PAPER
	};
	
	private static Dictionary<RPS, int> opToLevel = new Dictionary<RPS, int>()
	{
		{RPS.ROCK, 0},
		{RPS.SCISSORS, 1},
		{RPS.PAPER, 2}
	};
	
	public static Dictionary<string, RPS> StringToRPS = new Dictionary<string, RPS>()
	{
		{"ROCK", RPS.ROCK},
		{"SCISSORS", RPS.SCISSORS},
		{"PAPER", RPS.PAPER}
	};

	public static int CalculateScore(RPS firstUserOp, RPS secondUserOp)
	{
		// returns 1 if the first user won in this round, -1 if the second user won, else 0

		if ((opToLevel[firstUserOp] + 1) % 3 == opToLevel[secondUserOp])
		{
			// second user won
			return -1;
		}

		if ((opToLevel[secondUserOp] + 1) % 3 == opToLevel[firstUserOp])
		{
			// first user won
			return 1;
		}

		return 0;
	}

	public static RPS ScanUserChoose(string UserName)
	{
		Console.WriteLine($"Enter {UserName} choose from ['ROCK', 'SCISSORS', 'PAPER']");

		string input = Console.ReadLine();
		while (!StringToRPS.ContainsKey(input))
		{
			Console.WriteLine("Invalid input, try again");
			input = Console.ReadLine();
		}

		return StringToRPS[input];
	}
}
