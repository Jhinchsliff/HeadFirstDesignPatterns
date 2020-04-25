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
            pizza.DescribeIngredients();

            pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
            pizza.DescribeIngredients();

            Console.WriteLine("Time for a second round of Pizza!");

            pizza = nyStore.OrderPizza(PizzaType.Special);
            pizza.DescribeIngredients();

            pizza = chicagoStore.OrderPizza(PizzaType.Special);
            pizza.DescribeIngredients();

            Console.ReadLine();
        }
    }
}
