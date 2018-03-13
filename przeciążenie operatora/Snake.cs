using System;
using przeciążenie_operatora.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przeciążenie_operatora
{
    public class Snake : Animal, ICanRun, ICanFly, ICanClimb
    {
        public void Climb()
        {
            Console.WriteLine("Wspinam sie");
        }

        public override void Drink()
        {
            Console.WriteLine("Pije Tequile");
        }

        public override void Eat()
        {
            Console.WriteLine("Jem sobie ptaszka");
        }

        public void Fly()
        {
            Console.WriteLine("Nie latam bo nie mam skrzydel");
        }

        public void Run()
        {
            Console.WriteLine("Nie biegam tylko pelzam");
        }
    }
}
