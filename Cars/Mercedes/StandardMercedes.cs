namespace AbstractFactoryPattern.Cars.Mercedes
{
    public class StandardMercedes : MercedesBase
    {
        public StandardMercedes(MercedesModel mercedesModel) : base(mercedesModel, 50000)
        {
        }
    }
}