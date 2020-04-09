namespace Decorator.Beverages
{
    public class HouseBlend : BeverageBase
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
