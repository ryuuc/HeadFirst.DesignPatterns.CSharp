﻿using System;
using SimUDuck.Behaviors;

namespace SimUDuck.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new NormalQuack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display() => Console.WriteLine("I'm a real Mallard duck.");
    }
}