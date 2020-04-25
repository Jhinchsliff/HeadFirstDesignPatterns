using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Contracts;
using AbstractFactory.Pizza;
using Factory.Pizza;
using System;

namespace Factory.Store
{
    public class NYPizzaStore : StoreBase
    {
        protected override PizzaBase CreatePizza(PizzaType type)
        {
            PizzaBase pizza = null;
            IPizzaIngredientFactory factory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case PizzaType.Cheese:
                    {
                        pizza = new CheesePizza(factory);
                        pizza.SetName("New York Style Cheese Pizza");
                        break;
                    }
                case PizzaType.Pepperoni:
                    {
                        pizza = new PepperoniPizza(factory);
                        pizza.SetName("New York Style Pepperoni Pizza");
                        break;
                    }
                case PizzaType.Special:
                    {
                        pizza = new CurrentSpecialPizza(factory);
                        pizza.SetName("New York Pizza Special!");
                        break;
                    }
                default:
                    throw new ArgumentException("Invalid Pizza type given");
            }

            return pizza;
        }
    }
}
