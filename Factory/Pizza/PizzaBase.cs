using System;
using System.Collections.Generic;

namespace Factory.Pizza
{
    public abstract class PizzaBase
    {
        protected string Name { get; set; }
        protected string Dough { get; set; }
        protected string Sauce { get; set; }
        protected List<string> Toppings { get; set; }

        public PizzaBase()
        {
            Toppings = new List<string>();
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing Dough...");
            Console.WriteLine("Adding Sauce...");
            Console.WriteLine("Adding Toppings...");
            foreach (string topping in Toppings)
            {
                Console.WriteLine(topping);
            }

            Bake();
            Cut();
            Box();
        }

        protected void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        protected virtual void Cut()
        {
            Console.WriteLine("Cutting Pizza into Diagonal slices..");
        }

        protected void Box()
        {
            Console.WriteLine("Putting in box");
        }

        public string GetName()
        {
            return Name;
        }
    }
}
