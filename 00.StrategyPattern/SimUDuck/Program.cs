using System;

using SimUDuck.Behaviors;
using SimUDuck.Ducks;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();

            Duck model = new ModelDuck();
            model.Display();
            model.PerformFly();
            model.PerformQuack();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();

            Console.ReadKey();
        }
    }
}
