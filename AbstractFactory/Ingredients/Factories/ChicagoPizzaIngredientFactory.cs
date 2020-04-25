using AbstractFactory.Ingredients.Contracts;

namespace AbstractFactory.Ingredients
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IDough CreateDough()
        {
            return new DeepDishDough();
        }

        public IMeat CreateMeat()
        {
            return new ItalianSausage();
        }

        public IPepperoni CreatePepperoni()
        {
            return new Pepperoni();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }
    }
}
