namespace DecoratorPattern.Components
{
    public abstract class Beverage
    {
        public string Description = "Unknown Beverage";
        public Size Size { get; set; }

        public virtual string GetDescription() => Description;

        public abstract double Cost();

        public void SetSize(Size size)
        {
            Size = size;
        }

        public Size GetSize() => Size;
    }

    public enum Size
    {
        Tall,
        Grande,
        Venti
    }
}
