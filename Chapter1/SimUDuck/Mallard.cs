using Chapter1.SimUDuck.Fly;
using Chapter1.SimUDuck.Quack;
using System;

namespace Chapter1.SimUDuck
{
    public class Mallard : DuckBase
    {
        public Mallard() : base()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a Mallard Duck");
        }
    }
}
