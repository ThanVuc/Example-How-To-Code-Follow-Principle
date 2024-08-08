using DuckApp.BehaviorInterface.FlyBehavior;
using DuckApp.BehaviorInterface.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.DuckModel
{
    internal class DuckModel : Duck
    {
        public DuckModel()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Duck Model Display");
        }
    }
}
