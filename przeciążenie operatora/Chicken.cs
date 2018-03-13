using System;
using przeciążenie_operatora.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przeciążenie_operatora
{
    class Chicken : Animal, ICanFly, ICanClimb, ICanRun
    {
        public void Climb()
        {
            Console.WriteLine("Wspinam sie po jajka");
        }

        public override void Drink()
        {
            Console.WriteLine("pije wode");
        }

        public override void Eat()
        {
            Console.WriteLine("Jem ziarno by żyć");
        }

        public void Fly()
        {
            Console.WriteLine("Odbywam lot na niskim pułapie");
        }

        public void Run()
        {
            Console.WriteLine("Uciekam przed kotem");
        }
    }
}
