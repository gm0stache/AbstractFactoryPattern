using AbstractFactoryPattern.Cars.Mercedes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    class MercedesFactory : ICarFactory
    {
        public string CompanyName { get; private set; } = "Mercedes";

        public Car AssembleCar(Enum model)
        {
            return model switch
            {
                MercedesModel.Standard => new StandardMercedes(MercedesModel.Standard),
                _ => throw new NotImplementedException()
            };
        }
    }
}
