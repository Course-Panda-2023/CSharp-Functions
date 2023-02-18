using System;
using System.Reflection.Metadata.Ecma335;
/*
             * Very stupid and inefficient solution
             * Very very sorry for that!!!
*/
public class BouncingNumbers
{
	public static int GiveNum()
	{
		int number = 0, numCounter = 0;
		double density = 0;
		while(true) 
		{
            const Int32 minNum = 21780;
            const int minDensity = 99;
            if (number > minNum && density >= minDensity)
			{
				return number;
			}
			if (NumIsBouncing(number))
			{
				numCounter++;
            }
			number++;
			density= numCounter/number + 1;
		}
	}
	public static bool NumIsBouncing(in int num)
	{
		if(num < 10) { return true; }
		int tempNum = num;
		List<int> tempList = new List<int>();        
		bool status = false;		
		bool incr = false;
        while (true)
		{
			if(tempNum < 10)
			{
                tempList.Add(tempNum);
				break;
            }
			tempList.Add(tempNum % 10);
			tempNum= tempNum / 10;
		}
		
		int incrCounter = 0, descrCounter = 0;
        for (int i = 0; i<tempList.Count - 1; i++)
		{
			if (tempList[i+1] >= tempList[i])
			{
                
                incrCounter++;
			}
        }
        for (int i = 0; i < tempList.Count - 1; i++)
        {
			

            if (tempList[i+1] <= tempList[i])
            {
                descrCounter++;
            }
        }
        if (incrCounter == tempList.Count - 1 || descrCounter == tempList.Count - 1) { status = true; }
        return status;
    }
	
}
