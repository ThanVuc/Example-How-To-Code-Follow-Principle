using DuckApp.BehaviorInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp.DuckModel
{
    public abstract class Duck
    {

        public IQuackBehavior? quackBehavior;
        public IFlyBehavior? flyBehavior;

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All Ducks can be swim!");
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }

        public virtual void Display()
        {
            PerformQuack();
            PerformFly();
        }
    }
}
