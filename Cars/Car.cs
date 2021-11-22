using System.Text.Json;

namespace AbstractFactoryPattern
{
    public abstract class Car
    {
        public abstract string BrandName { get; }
        public abstract string ModelName { get; }
        public abstract decimal Price { get; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}