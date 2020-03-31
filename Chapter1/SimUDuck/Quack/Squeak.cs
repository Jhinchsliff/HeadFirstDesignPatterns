using System;

namespace Chapter1.SimUDuck.Quack
{
    public class Squeak : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
