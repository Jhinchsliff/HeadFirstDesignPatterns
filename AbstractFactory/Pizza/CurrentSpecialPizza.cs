using AbstractFactory.Ingredients.Contracts;
using Factory.Pizza;
using System;

namespace AbstractFactory.Pizza
{
    public class CurrentSpecialPizza : PizzaBase
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public CurrentSpecialPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Cheese = _ingredientFactory.CreateCheese();
            Dough = _ingredientFactory.CreateDough();
            Meat = _ingredientFactory.CreateMeat();
            Sauce = _ingredientFactory.CreateSauce();
        }
    }
}
