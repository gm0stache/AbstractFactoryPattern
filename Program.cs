using AbstractFactoryPattern.Cars.Mercedes;
using AbstractFactoryPattern.Cars.Tesla;
using AbstractFactoryPattern.Factories;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MercedesFactory mercedesFactory = new MercedesFactory();
            Car mercedes = mercedesFactory.AssembleCar(MercedesModel.Standard);
            Console.WriteLine(mercedes.ToString());

            TeslaFactory teslaFactory = new TeslaFactory();
            Car modelSTesla = teslaFactory.AssembleCar(TeslaModel.S);
            Console.WriteLine(modelSTesla.ToString());
        }
    }
}
