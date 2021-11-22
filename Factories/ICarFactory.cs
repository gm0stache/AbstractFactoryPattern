using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    interface ICarFactory
    {
        public Car AssembleCar(Enum model);
    }
}
