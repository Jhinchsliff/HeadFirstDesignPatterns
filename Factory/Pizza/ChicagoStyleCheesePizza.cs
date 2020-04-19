using System;

namespace Factory.Pizza
{
    public class ChicagoStyleCheesePizza : PizzaBase
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra thick Crust dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Shredded Mozzarella");
        }

        protected override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices...");
        }
    }
}
