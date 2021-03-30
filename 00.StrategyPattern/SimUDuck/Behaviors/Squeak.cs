using System;
using SimUDuck.Behaviors.Interfaces;

namespace SimUDuck.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("Squeak");
    }
}