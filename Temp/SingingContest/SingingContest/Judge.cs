﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingingContest
{
    public class Judge
    {
        private string name;

        public Judge(string name)
        {
            this.name = name;
        }

        public void Judging(params Singer[] singers)
        {
            Console.WriteLine($"{name} will now be judging.");
            Console.WriteLine();
            var rand = new Random();
            int index = rand.Next(0, singers.Length);

            string winner = singers[index].Name;
            Console.WriteLine("The winner of the singing contest is...");
            Console.WriteLine(winner);
        }
    }
}
