using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NytSalgsSystem
{
    public class Dryer: Product, IEnergyUse
    {
        private double _energyUse;
        private int _noiceLevel;

        public Dimension dimension;

        public Dryer(double length, double height, double width)
        {
            dimension = new Dimension(length, height, width);
        }


        public double EnergyUse
        {
            get { return _energyUse; }
            set { _energyUse = value; }
        }

        public double Capacity { get; set; }

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

        public double DryerTime { get; set; }

        public double EnergyDividedCapacity(double energyUse, double capacity){
            return energyUse / capacity;
        }
    }
}
