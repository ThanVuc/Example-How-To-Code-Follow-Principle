using DuckApp.BehaviorInterface.FlyBehavior;
using DuckApp.BehaviorInterface.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.DuckModel
{
    internal class RedHatDuck : Duck
    {
        public RedHatDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new QuackQuack();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("RedHat Duck Display!");
        }
    }
}
