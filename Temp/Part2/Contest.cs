using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class Contest
    {
        private List<Singer> contestants;
        private Judge judge;
        private List<Singer> winners;
        private int roundNum;

        public Contest(Judge judge, params Singer[] singers) 
        {
            this.judge = judge;
            contestants = new List<Singer>();
            foreach (Singer singer in singers)
            {
                contestants.Add(singer);
            }
            roundNum = 1;
            winners = new List<Singer>();
        }

        public void Dual(Singer singer1, Singer singer2)
        {
            singer1.Sing();
            Console.WriteLine();
            singer2.Sing();
            Console.WriteLine();
            Singer winner = judge.Judging(singer1, singer2);
            winners.Add(winner);
            contestants.Remove(singer1);
            contestants.Remove(singer2);
        }

        public List<Singer> Rounds()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"Starting round {roundNum}.");
            roundNum++;
            while (contestants.Count > 1)
            {
                var rand = new Random();
                int index2 = -1;
                int index1 = rand.Next(0, contestants.Count);
                int temp = rand.Next(0, contestants.Count);
                
                if (temp != index1)
                    index2 = temp;

                if(index2 != -1)
                    Dual(contestants[index1], contestants[index2]);
            }
            foreach (Singer singer in winners)
                contestants.Add(singer);
            
            winners.Clear();
            return contestants;
        }

        public Singer AllRounds()
        {
            Console.WriteLine("Starting Competition");
            List<Singer> singers = Rounds();
            while(singers.Count > 1)
            {
                singers = Rounds();
            }
            return singers[0];
        }
    }
}
