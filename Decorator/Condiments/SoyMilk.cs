using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class SoyMilk : DecoratorBase
    {
        private readonly BeverageBase _beverage;

        public SoyMilk(BeverageBase beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Soy Milk";
        }

        public override double Cost()
        {
            return _beverage.Cost() + .90;
        }
    }
}
