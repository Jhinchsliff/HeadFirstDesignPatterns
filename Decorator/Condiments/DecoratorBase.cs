using Decorator.Beverages;

namespace Decorator.Condiments
{
    public abstract class DecoratorBase : BeverageBase
    {
        public override abstract string GetDescription();
    }
}
