namespace Decorator.Beverages
{
    public class DarkRoast : BeverageBase
    {
        public DarkRoast()
        {
            Description = "Dark Roast";
        }

        public override double Cost()
        {
            return 1.79;
        }
    }
}
