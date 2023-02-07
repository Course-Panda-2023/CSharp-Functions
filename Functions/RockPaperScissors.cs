using System.ComponentModel;

public class RockPaperScissors
{
	public enum RPS
	{
		Rock,
		Paper,
		Scissors
	}
	public static int winner(RPS move1, RPS move2)
	{
		/*
		 * Function receives two moves and returns the number of the winner, 1 for player 1, 2 for player 2
		 * and 0 for draw.
		 */
		if ((move1 == RPS.Rock) && (move2 == RPS.Scissors))
		{
			return 1;
		}
		else if (move1 > move2)
		{
			return 1;
		}
		else if (move2 > move1)
		{
			return 2;
		}
		else
		{
			return 0;
		}
	}
}
