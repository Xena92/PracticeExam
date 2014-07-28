using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NytSalgsSystem
{
    public class ElectricOven: DimensionAndEnergy, IEnergyUse, ISmiley

    {
        private int _energyClass;
        private double _volumeInLiter;
        private double _energyUse;

        public Dimension dimension;

        public ElectricOven(double length, double width, double height, double energy, bool cleanFunction, bool grill)
        {
            dimension = new Dimension(length, height, width);
            _volumeInLiter = SetVolume(length, width, height);
            SetEnergyClass(_volumeInLiter, energy);
            GetSmiley();
        }

        public double VolumeInLiter { get{ return _volumeInLiter;} }

        public int EnergyClass
        {
            get { return _energyClass; }
        }

        public double EnergyUse
        {
            get { return _energyUse; }
            set { _energyUse = value; }
        }

        public bool CleanFunction { get; set; }

        public bool Grill { get; set; }

        private double SetVolume(double length, double width, double height )
        {
            return length * width * height;
        }

        private EnergyClassEnum SetEnergyClass(double volume, double energy){
            
            if (volume < 35)
            {
                if (energy < 0.6)
                    return EnergyClassEnum.A;
                else if (energy >= 0.6 && energy < 0.8)
                    return EnergyClassEnum.B;
                else if (energy >= 0.8 && energy < 1)
                    return EnergyClassEnum.C;
                else if (energy >= 1 && energy < 1.2)
                    return EnergyClassEnum.D;
                else if (energy >= 1.2 && energy < 1.4)
                    return EnergyClassEnum.E;
                else if (energy >= 1.4 && energy < 1.6)
                    return EnergyClassEnum.F;
                else
                    return EnergyClassEnum.G; 
            }

            else if(volume >= 35 && volume < 65){
                if (energy < 0.8)
                    return EnergyClassEnum.A;
                else if (energy >= 0.8 && energy < 1)
                    return EnergyClassEnum.B;
                else if (energy >= 1 && energy < 1.2)
                    return EnergyClassEnum.C;
                else if (energy >= 1.2 && energy < 1.4)
                    return EnergyClassEnum.D;
                else if (energy >= 1.4 && energy < 1.6)
                    return EnergyClassEnum.E;
                else if (energy >= 1.6 && energy < 1.8)
                    return EnergyClassEnum.F;
                else
                    return EnergyClassEnum.G; 
            }

            else
            {
                if (energy < 1)
                    return EnergyClassEnum.A;
                else if (energy >= 1 && energy < 1.2)
                    return EnergyClassEnum.B;
                else if (energy >= 1.2 && energy < 1.4)
                    return EnergyClassEnum.C;
                else if (energy >= 1.4 && energy < 1.6)
                    return EnergyClassEnum.D;
                else if (energy >= 1.6 && energy < 1.8)
                    return EnergyClassEnum.E;
                else if (energy >= 1.8 && energy < 2)
                    return EnergyClassEnum.F;
                else
                    return EnergyClassEnum.G;
            }
        }

        public smiley GetSmiley()
        {
            if (CleanFunction && Grill)
                return smiley.Happy;
            else if (CleanFunction)
                return smiley.Happy;
            else if (Grill)
                return smiley.Neutral;
            else
                return smiley.Unhappy;

        }

    }
}
