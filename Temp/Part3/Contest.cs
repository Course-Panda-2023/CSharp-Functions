using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class Contest
    {
        private List<Singer> contestants;
        private List<Singer> winners;
        private Judge judge;
        private int roundNum;
        private List<Song> songs;
        private int amountOfPeopleInTheAudience;


        public Contest(Judge judge, List<Song> songList, int amountOfPeopleInTheAudience, params Singer[] singers)
        {
            this.judge = judge;
            contestants = new List<Singer>();
            foreach (Singer singer in singers)
            {
                contestants.Add(singer);
            }
            roundNum = 1;
            winners = new List<Singer>();
            songs = new List<Song>();
            foreach (Song s in songList)
            {
                songs.Add(s);
            }
            this.amountOfPeopleInTheAudience = amountOfPeopleInTheAudience;
        }

        public Singer Competition()
        {
            var rand = new Random();
            // singers are singing.
            foreach (Singer singer in contestants)
            {
                singer.Sing(songs[rand.Next(0, songs.Count)]);
                Console.WriteLine();
            }

            // audience voting
            Console.WriteLine("The audience is voting.");

            List<int> votes = new List<int>(new int[contestants.Count]);

            for (int i = 0; i < amountOfPeopleInTheAudience; i++)
            {
                int index = rand.Next(0, contestants.Count);
                votes[index]++;
            }
            int place = GetIndexOfFinalWinner(votes);
            Console.WriteLine(contestants[place].Name);
            return contestants[place];
        }

        public int GetIndexOfFinalWinner(List<int> votes)
        {
            var rand = new Random();
            int maxVotes = votes.Max();
            List<int> equalVotes = new List<int>();
            equalVotes = CheckMax(maxVotes, votes);

            while (equalVotes.Count != 1)
            {
                for (int i = 0; i < amountOfPeopleInTheAudience; i++)
                {
                    int index = rand.Next(0, equalVotes.Count);
                    votes[equalVotes[index]]++;
                }
                maxVotes = votes.Max();
                equalVotes = CheckMax(maxVotes, votes);
            }
            return equalVotes[0];
        }

        public List<int> CheckMax(int max, List<int> votes)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < contestants.Count; i++)
            {
                if (votes[i] == max)
                    res.Add(i);
            }
            return res;
        }
    }
}
