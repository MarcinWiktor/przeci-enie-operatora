using System;
using przeciążenie_operatora.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przeciążenie_operatora
{
    public class Dog : Animal, ICanClimb, ICanFly, ICanRun
    {
        public void Climb()
        {
            Console.WriteLine("Wspinam sie po jedzenie");
        }

        public override void Drink()
        {
            Console.WriteLine("Pije wode z miski");
        }

        public override void Eat()
        {
            Console.WriteLine("Jem miecho z miski");
        }

        public void Fly()
        {
            Console.WriteLine("Nie latam!! Brak skrzydel");
        }

        public void Run()
        {
            Console.WriteLine("Gonie Kota bo jestem glodny");
        }
    }
}
