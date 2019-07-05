namespace DecoratorPattern.Components
{
    public abstract class Beverage
    {
        public string Description = "Unknown Beverage";

        public virtual string GetDescription() => Description;
        public abstract double Cost();
    }
}
