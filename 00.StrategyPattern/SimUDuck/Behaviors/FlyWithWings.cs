using System;
using SimUDuck.Behaviors.Interfaces;

namespace SimUDuck.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I'm flying!!");
    }
}