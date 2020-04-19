using Factory.Pizza;
using Factory.Store;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreBase nyStore = new NYPizzaStore();
            StoreBase chicagoStore = new ChicagoPizzaStore();

            PizzaBase pizza = nyStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Ethan ordered a {pizza.GetName()}");

            pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Joel ordered a {pizza.GetName()}");

            Console.ReadLine();
        }
    }
}
