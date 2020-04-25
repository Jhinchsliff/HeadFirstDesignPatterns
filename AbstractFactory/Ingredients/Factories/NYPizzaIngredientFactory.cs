using AbstractFactory.Ingredients.Contracts;

namespace AbstractFactory.Ingredients
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public IMeat CreateMeat()
        {
            return new Pepperoni();
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
