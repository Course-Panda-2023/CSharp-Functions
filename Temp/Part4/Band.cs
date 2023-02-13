using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public class Band : Contestant
    {
        private List<Singer> singersInBand;

        public Band(string name, params Singer[] singers) : base(name) 
        {
            singersInBand = new List<Singer>();
            foreach(Singer singer in singers)
            {
                singersInBand.Add(singer);
            }
        }
    }
}
