namespace Starbuzz
{
    public class DarkRoast : Beverage
    {
        public override double Cost() => .99;
        public override string Description { get; } = "Dark Roast Coffee";
    }
}