namespace Decorator.Beverages
{
    public class Espresso : BeverageBase
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
