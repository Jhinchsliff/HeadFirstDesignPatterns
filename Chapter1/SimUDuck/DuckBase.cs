using System;

namespace Chapter1.SimUDuck
{
    public abstract class DuckBase
    {
        protected IFly _flyBehavior { get; set; }
        protected IQuack _quackBehavior { get; set; }

        public abstract void Display();

        public void SetFlyBehavior(IFly flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuack quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }

        public void Quack()
        {
            _quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
