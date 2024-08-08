using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.BehaviorInterface.QuackBehavior
{
    internal class QuackQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack Quack");
        }
    }
}
