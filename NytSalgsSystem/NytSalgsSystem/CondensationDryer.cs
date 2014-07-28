using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NytSalgsSystem
{
    public class CondensationDryer: Dryer
    {

        public bool HeatPump { get; set; }

        public EnergyClassEnum FindEnergyClass(double energyUse, double capacity)
        {
            double index = EnergyDividedCapacity(energyUse, capacity);

            if (index < 0.55)
                return EnergyClassEnum.A;
            else if (index > 0.55 && index <= 0.64)
                return EnergyClassEnum.B;
            else if (index > 0.64 && index <= 0.73)
                return EnergyClassEnum.C;
            else if (index > 0.73 && index <= 0.82)
                return EnergyClassEnum.D;
            else if (index > 0.82 && index <= 0.91)
                return EnergyClassEnum.E;
            else if (index > 0.91 && index <= 1)
                return EnergyClassEnum.F;
            else
                return EnergyClassEnum.G;
        }
    }
}
