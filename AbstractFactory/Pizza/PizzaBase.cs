using AbstractFactory.Ingredients.Contracts;
using System;

namespace Factory.Pizza
{
    public abstract class PizzaBase
    {
        protected string Name { get; set; }
        protected IDough Dough { get; set; }
        protected ISauce Sauce { get; set; }
        protected ICheese Cheese { get; set; }
        protected IMeat Meat { get; set; }
        protected IPepperoni Pepperoni { get; set; }

        public abstract void Prepare();

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

        public void SetName(string newName)
        {
            Name = newName;
        }

        public void DescribeIngredients()
        {
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"This pizza is a {Name}");

            if(Dough != null)
                Console.WriteLine($"Dough is {Dough.GetType().Name} ");

            if (Sauce != null)
                Console.WriteLine($"Sauce is {Sauce.GetType().Name} ");

            if (Cheese != null)
                Console.WriteLine($"Cheese is {Cheese.GetType().Name} ");

            if (Meat != null)
                Console.WriteLine($"Meat is {Meat.GetType().Name} ");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
        }
    }
}
