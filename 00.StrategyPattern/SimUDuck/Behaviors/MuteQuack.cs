using System;
using SimUDuck.Behaviors.Interfaces;

namespace SimUDuck.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("<< Silence >>");
    }
}