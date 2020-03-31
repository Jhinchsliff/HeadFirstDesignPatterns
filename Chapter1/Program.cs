using Chapter1.SimUDuck;
using System;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckBase duck = new Mallard();
            duck.Quack();
            duck.Fly();

            Console.ReadLine();
        }
    }
}
