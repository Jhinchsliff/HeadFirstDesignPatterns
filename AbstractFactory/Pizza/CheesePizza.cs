using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Contracts;
using Factory.Pizza;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Pizza
{
    public class CheesePizza : PizzaBase
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {this.Name}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
        }
    }
}
