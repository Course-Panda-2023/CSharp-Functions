using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public class Song
    {
        private string name;
        private string lyrics;

        public string songName { get { return name; } }
        public string songLyrics { get { return lyrics; } }

        public Song (string name, string lyrics)
        {
            this.name = name;
            this.lyrics = lyrics;
        }
    }
}
