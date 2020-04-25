namespace AbstractFactory.Ingredients.Contracts
{
    public interface IPizzaIngredientFactory
    {
        public IDough CreateDough();

        public ISauce CreateSauce();

        public ICheese CreateCheese();

        public IPepperoni CreatePepperoni();

        public IMeat CreateMeat();
    }
}
