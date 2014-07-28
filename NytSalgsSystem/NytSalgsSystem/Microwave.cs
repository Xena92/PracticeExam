using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NytSalgsSystem
{
    public class Microwave: Product, ISmiley
    {
        public bool haveHotAir { get; set; }
        private bool _haveGrill;

        public bool Grill
        {
            get { return _haveGrill; }
            set { _haveGrill = value; }
        }


        public smiley GetSmiley()
        {
            if (_haveGrill)
                return smiley.Neutral;
            else
                return smiley.Unhappy;
        }
    }
}
