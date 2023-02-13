using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class Singer
    {
        private string name;
        private string songName;
        private string song;

        public string Name { get { return name; } }

        public Singer (string name, string songName, string song)
        {
            this.name = name;
            this.songName = songName;
            this.song = song;
        }

        public void Sing()
        {
            Console.WriteLine($"{name} started singing {songName}");
            Console.WriteLine(song);
        }
    }
}
