using System;
using System.Globalization;

public class BouncingNumbers
{
    /*
	 * TODO: Write helper function for 'BouncingNumbers'
	 */
	public static bool IfBouncNum(int num)
	{
		int newNum = num;
		int digit;
		int mostUpdateDigit = 0;
		while (newNum > 0)
		{
			digit = newNum % 10;
			if (digit >= mostUpdateDigit)
			{
				mostUpdateDigit = digit;
			}
			else
				break;
			newNum = newNum / 10;
		}
		if (newNum == 0)
		{
			return false;
		}

		newNum = num;
		mostUpdateDigit = 10;
        while (newNum > 0)
        {
            digit = newNum % 10;
            if (digit <= mostUpdateDigit)
            {
                mostUpdateDigit = digit;
            }
            else
                break;
            newNum = newNum / 10;
        }
        if (newNum == 0)
        {
            return false;
        }
		else 
		{
			return true;
		}
    }
}
