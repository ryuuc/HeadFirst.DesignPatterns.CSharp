using System;
using SimUDuck.Behaviors.Interfaces;

namespace SimUDuck.Behaviors
{
    public class NormalQuack : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("Quack");
    }
}