using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NytSalgsSystem
{
    class VentDryer: Dryer
    {

        public bool haveHose { get; set; }

        public EnergyClassEnum FindEnergyClass(double energyUse, double capacity)
        {
            double index = EnergyDividedCapacity(energyUse, capacity);

            if (index < 0.51)
                return EnergyClassEnum.A;
            else if (index > 0.51 && index <= 0.59)
                return EnergyClassEnum.B;
            else if (index > 0.59 && index <= 0.67)
                return EnergyClassEnum.C;
            else if (index > 0.67 && index <= 0.75)
                return EnergyClassEnum.D;
            else if (index > 0.75 && index <= 0.83)
                return EnergyClassEnum.E;
            else if (index > 0.83 && index <= 91)
                return EnergyClassEnum.F;
            else
                return EnergyClassEnum.G;
        }
    }
}
