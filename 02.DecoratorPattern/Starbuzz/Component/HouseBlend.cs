namespace Starbuzz
{
    public class HouseBlend : Beverage
    {
        public override string Description { get; } = "House Blend Coffee";

        public override double Cost() => .89;
    }
}