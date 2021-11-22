using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Cars.Tesla
{
    public class TeslaModelS : TeslaBase
    {
        public TeslaModelS() : base("Model S", 45_000)
        {
        }
    }
}
