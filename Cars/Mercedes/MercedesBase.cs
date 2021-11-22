using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Cars.Mercedes
{
    public abstract class MercedesBase : Car
    {
        public override string BrandName { get; } = "Mercedes";
        public override string ModelName { get; }
        public override decimal Price { get; }

        public MercedesBase(MercedesModel mercedesModel, decimal price)
        {
            ModelName = mercedesModel.ToString();
            Price = price;
        }
    }
}
