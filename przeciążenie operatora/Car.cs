using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przeciążenie_operatora
{
    public class Car :Vehicle
    {
        public override void Wrum()
        {
            Console.WriteLine("brum brummmmm");
        }
        public override void Beep()
        {
            Console.WriteLine("Biiiip biiiiip");
        }
    }
}
