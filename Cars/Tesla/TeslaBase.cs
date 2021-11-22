namespace AbstractFactoryPattern.Cars.Tesla
{
    public class TeslaBase : Car
    {
        public override string BrandName { get; } = "Tesla";
        public override string ModelName { get; }
        public override decimal Price { get; }

        public TeslaBase(string modelName, decimal price)
        {
            ModelName = modelName;
            Price = price;
        }
    }
}