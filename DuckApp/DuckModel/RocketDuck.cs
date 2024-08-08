using DuckApp.BehaviorInterface.FlyBehavior;
using DuckApp.BehaviorInterface.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.DuckModel
{
    internal class RocketDuck : Duck
    {
        public RocketDuck()
        {
            flyBehavior = new RocketFly();
            quackBehavior = new Boom();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Rocket Duck");
        }
    }
}
