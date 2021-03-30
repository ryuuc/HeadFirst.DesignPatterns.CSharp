using System;
using SimUDuck.Behaviors.Interfaces;

namespace SimUDuck.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I can't fly.");
    }
}