using AbstractFactory.Ingredients.Contracts;
using Factory.Pizza;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Pizza
{
    public class PepperoniPizza : PizzaBase
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Cheese = _ingredientFactory.CreateCheese();
            Sauce = _ingredientFactory.CreateSauce();
            Pepperoni = _ingredientFactory.CreatePepperoni();
        }
    }
}
