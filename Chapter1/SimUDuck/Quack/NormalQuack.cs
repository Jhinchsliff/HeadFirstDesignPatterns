using System;

namespace Chapter1.SimUDuck.Quack
{
    public class NormalQuack : IQuack
    {
        void IQuack.Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
