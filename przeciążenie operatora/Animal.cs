using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przeciążenie_operatora
{
    public abstract class Animal
    {
        
        public virtual void Sleep()
        {
            Console.WriteLine("chrapie");
        }
        public virtual void Sound()
        {
            Console.WriteLine("bleczy");
        }
        public abstract void Eat();
        public abstract void Drink();
        
    }

}
