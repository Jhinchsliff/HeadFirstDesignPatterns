using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Mocha : DecoratorBase
    {
        private readonly BeverageBase _beverage;

        public Mocha(BeverageBase beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Mocha";
        }

        public override double Cost()
        {
            return _beverage.Cost() + .20;
        }
    }
}
