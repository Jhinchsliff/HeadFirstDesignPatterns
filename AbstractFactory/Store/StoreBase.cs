using Factory.Pizza;

namespace Factory.Store
{
    public abstract class StoreBase
    {
        public PizzaBase OrderPizza(PizzaType type)
        {
            PizzaBase pizza = CreatePizza(type);
            pizza.Prepare();

            return pizza;
        }

        protected abstract PizzaBase CreatePizza(PizzaType type);
    }
}
