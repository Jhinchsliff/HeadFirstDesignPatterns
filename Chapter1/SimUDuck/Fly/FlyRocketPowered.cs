using System;

namespace Chapter1.SimUDuck.Fly
{
    public class FlyRocketPowered : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I am flying to the moon!");
        }
    }
}
