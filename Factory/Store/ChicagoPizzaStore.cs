using Factory.Pizza;
using System;

namespace Factory.Store
{
    public class ChicagoPizzaStore : StoreBase
    {
        protected override PizzaBase CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new ChicagoStyleCheesePizza();
                default:
                    throw new ArgumentException("Invalid Pizza type given");
            }
        }
    }
}
