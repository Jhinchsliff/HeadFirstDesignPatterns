using Factory.Pizza;
using System;

namespace Factory.Store
{
    public class NYPizzaStore : StoreBase
    {
        protected override PizzaBase CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new NYStyleCheesePizza();
                default:
                    throw new ArgumentException("Invalid Pizza type given");
            }
        }
    }
}
