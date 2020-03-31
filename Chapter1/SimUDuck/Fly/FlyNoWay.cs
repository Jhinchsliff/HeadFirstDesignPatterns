using System;

namespace Chapter1.SimUDuck.Fly
{
    public class FlyNoWay : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }
}
