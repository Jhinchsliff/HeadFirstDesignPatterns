using Decorator.Beverages;
using Decorator.Condiments;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase espresso = new Espresso();
            Console.WriteLine($"{espresso.GetDescription()} ${espresso.Cost()}");

            BeverageBase houseBlend = new HouseBlend();
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new WhipCream(houseBlend);
            Console.WriteLine($"{houseBlend.GetDescription()} ${houseBlend.Cost()}");

            BeverageBase darkRoast = new DarkRoast();
            darkRoast = new SoyMilk(darkRoast);
            darkRoast = new Mocha(darkRoast);
            darkRoast = new WhipCream(darkRoast);
            Console.WriteLine($"{darkRoast.GetDescription()} ${darkRoast.Cost()}");

            Console.ReadLine();
        }
    }
}
