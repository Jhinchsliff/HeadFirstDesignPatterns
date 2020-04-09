namespace Decorator.Beverages
{
    public abstract class BeverageBase
    {
        public string Description { get; set; } = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}
