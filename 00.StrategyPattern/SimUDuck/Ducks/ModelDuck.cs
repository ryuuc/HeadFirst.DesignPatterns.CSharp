using System;
using SimUDuck.Behaviors;

namespace SimUDuck.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            QuackBehavior = new NormalQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display() => Console.WriteLine("I'm a model duck.");
    }
}