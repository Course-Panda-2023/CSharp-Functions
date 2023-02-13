using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Part4
{
    public abstract class Contestant
    {
        private string name;
        public string Name => name;

        public Contestant(string name)
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
