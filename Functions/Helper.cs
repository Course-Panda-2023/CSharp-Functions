﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        /*
         * TODO: Add any needed helper functions
         */
        RockPaperScissors.RPS getMove() 
        {
            Console.WriteLine("Write a move: Rock or Paper or Scissors");
            string move = Console.ReadLine();
            RockPaperScissors.RPS moveRe = null;
            switch (move)
            {
                case "Rock":
                    moveRe =  RockPaperScissors.RPS.Rock; 
                    break;
                case "Paper":
                    moveRe = RockPaperScissors.RPS.Paper;
                    break;
                case "Scissors":
                    moveRe = RockPaperScissors.RPS.Scissors;
                    break;
                default:
                    moveRe = getMove(); //In case of invalid selection
            }
            return moveRe;
        }

        public static void reversArray(params double[] nums) 
        {

            for (int i = 0; i < nums.Length / 2; i++)
            {
                double tmp = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = tmp;
            } 
        }

    }
}
