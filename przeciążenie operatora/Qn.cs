using przeciążenie_operatora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przeciążenie_operatora
{
    public class Qn : Animal, ICanFly, ICanClimb, ICanRun
    {
        public void Climb()
        {
            Console.WriteLine("Tylko ciekawe gdzie");
        }

        public override void Drink()
        {
            Console.WriteLine("Pije sobie wode");
        }

        public override void Eat()
        {
            Console.WriteLine("Jem se trawe");
        }

        public void Fly()
        {
            Console.WriteLine("Brak skrzydel wiec lipa");
        }

        public void Run()
        {
            Console.WriteLine("Biegam se Ihaaaaa");
        }
    }
}
