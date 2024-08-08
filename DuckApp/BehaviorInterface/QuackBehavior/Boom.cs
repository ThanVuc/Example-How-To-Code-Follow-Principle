using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.BehaviorInterface.QuackBehavior
{
    internal class Boom : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Boom Boom");
        }
    }
}
