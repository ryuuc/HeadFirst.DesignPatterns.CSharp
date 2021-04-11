using System;

namespace Starbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.Description} $ {beverage.Cost()}");


            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Soy(beverage2);
            Console.WriteLine($"{beverage2.Description} $ {beverage2.Cost()}");

            Beverage beverage3 = new DarkRoast();
            beverage3 = new Mocha(beverage3);
            beverage3 = new Soy(beverage3);
            Console.WriteLine($"{beverage3.Description} $ {beverage3.Cost()}");

            Console.ReadKey();
        }
    }
}
