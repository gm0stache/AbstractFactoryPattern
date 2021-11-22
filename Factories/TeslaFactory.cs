using AbstractFactoryPattern.Cars.Tesla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    class TeslaFactory : ICarFactory
    {
        public string CompanyName { get; } = "Tesla";

        public Car AssembleCar(Enum model)
        {
            return model switch
            {
                TeslaModel.S => new TeslaModelS(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
