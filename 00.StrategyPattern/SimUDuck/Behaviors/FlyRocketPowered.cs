using System;
using SimUDuck.Behaviors.Interfaces;

namespace SimUDuck.Behaviors
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}