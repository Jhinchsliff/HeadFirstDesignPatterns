using Decorator.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    public class WhipCream : DecoratorBase
    {
        private readonly BeverageBase _beverage;

        public WhipCream(BeverageBase beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Whip Cream";
        }

        public override double Cost()
        {
            return _beverage.Cost() + .50;
        }
    }
}
