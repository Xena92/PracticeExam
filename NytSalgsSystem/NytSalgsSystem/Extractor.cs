using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NytSalgsSystem
{
    class Extractor : Product, INoiceLevel, ISmiley
    {

        enum ExtractorType { Suspended, OnWall, BuildIn};
        private int _kitchenSize;
        private bool _haveFilter;
        private int _noiceLevel;


        public int Suction { get; set; }

        public int KitchenSize{
            get { return _kitchenSize; }
            set {
                
                if(value > 875)
                    _kitchenSize = 35;

                else if(value > 750 && value < 1100)
                    _kitchenSize = 30;

                else if(value > 625 && value < 900)
                    _kitchenSize = 25;
                
                else if(value > 500 && value < 750)
                    _kitchenSize = 20;

                else if (value > 375 && value < 750)
                    _kitchenSize = 15;

                else if (value < 500)
                    _kitchenSize = 10;
            }
        }

        public int NoiceLevel
        {
            get { return _noiceLevel; }
            set
            {
                if (value >= 0 && value <= 140)
                    _noiceLevel = value;
                else
                    throw new ArgumentOutOfRangeException("NoiceLevel must be between 0 and 140")
            }
        }

        public bool Filter
        {
            get { return _haveFilter; }
            set { _haveFilter = value; }
        }

        public smiley GetSmiley()
        {
            if (_haveFilter)
                return smiley.Neutral;
            else
                return smiley.Neutral;
        }
    }
}
