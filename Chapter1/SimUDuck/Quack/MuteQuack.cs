using System;

namespace Chapter1.SimUDuck.Quack
{
    public class MuteQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}
