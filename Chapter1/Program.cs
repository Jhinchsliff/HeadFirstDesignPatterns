using Chapter1.SimUDuck;
using Chapter1.SimUDuck.Fly;
using System;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckBase mallard = new MallardDuck();
            mallard.Quack();
            mallard.Fly();

            DuckBase model = new ModelDuck();
            model.Fly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.Fly();

            Console.ReadLine();
        }
    }
}
