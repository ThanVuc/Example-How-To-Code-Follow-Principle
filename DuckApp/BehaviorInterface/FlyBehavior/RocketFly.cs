using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.BehaviorInterface.FlyBehavior
{
    internal class RocketFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Rocket Fast Fly");
        }
    }
}
