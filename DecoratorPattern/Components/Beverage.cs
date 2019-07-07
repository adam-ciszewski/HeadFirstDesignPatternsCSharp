using DecoratorPattern.Decorators;

namespace DecoratorPattern.Components
{
    public abstract class Beverage
    {
        public string Description = "Unknown Beverage";
        public ISizeDecorator Size { get; set; }

        public virtual string GetDescription() => Description;

        public abstract double Cost();

        public void SetSize(ISizeDecorator size)
        {
            Size = size;
        }

        public ISizeDecorator GetSize() => Size;
    }
}
