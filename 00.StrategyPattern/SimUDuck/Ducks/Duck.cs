using System;
using SimUDuck.Behaviors.Interfaces;

namespace SimUDuck.Ducks
{
    public abstract class Duck
    {
        internal IFlyBehavior FlyBehavior;
        internal IQuackBehavior QuackBehavior;

        public void SetFlyBehavior(IFlyBehavior flyBehavior) => FlyBehavior = flyBehavior;
        public void SetQuackBehavior(IQuackBehavior quackBehavior) => QuackBehavior = quackBehavior;

        public abstract void Display();

        public void PerformFly() => FlyBehavior?.Fly();

        public void PerformQuack() => QuackBehavior?.Quack();

        public void Swim() => Console.WriteLine("All ducks float, even decoys!");
    }
}