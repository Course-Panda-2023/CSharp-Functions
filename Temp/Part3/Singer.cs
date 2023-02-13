using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class Singer
    {
        private string name;

        public string Name { get { return name; } }

        public Singer (string name)
        {
            this.name = name;
        }

        public void Sing(Song song)
        {
            Console.WriteLine($"{name} started singing {song.songName}");
            Console.WriteLine(song.songLyrics);
        }
    }
}
