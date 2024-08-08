using DuckApp.BehaviorInterface.FlyBehavior;
using DuckApp.BehaviorInterface.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.DuckModel
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new QuackQuack();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Mallard Duck");
        }
    }
}
