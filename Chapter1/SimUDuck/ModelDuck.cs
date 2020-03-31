using Chapter1.SimUDuck.Fly;
using Chapter1.SimUDuck.Quack;
using System;

namespace Chapter1.SimUDuck
{
    public class ModelDuck : DuckBase
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a model duck");
        }
    }
}
