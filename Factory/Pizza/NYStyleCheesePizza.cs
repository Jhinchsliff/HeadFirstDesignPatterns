namespace Factory.Pizza
{
    public class NYStyleCheesePizza : PizzaBase
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin crust";
            Sauce = "Marinara";

            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
