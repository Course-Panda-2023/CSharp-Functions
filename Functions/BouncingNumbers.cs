using System;

public class BouncingNumbers
{
	public static bool IsJumpingNumber(int num)
	{
		bool isAsc = true;
		bool isDesc = true;
		bool firstDigit = true;
		int currDigit = 0;
		while (num != 0)
		{  
			if (!firstDigit)
			{
				if (currDigit > num % 10)
					isAsc = false;
				else if (currDigit < num % 10)
					isDesc = false;
			}
			currDigit = num % 10;
			num /= 10;
			firstDigit = false;
		}
		return !isAsc && !isDesc;
	}
}
