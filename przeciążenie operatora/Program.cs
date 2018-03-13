using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przeciążenie_operatora
{
    public class Program 
    {
        static void Main(string[] args)
        {
            
            //Number x = 8;
            //Number y = 4;
            //Number z = x - y;
            //Number a = x * y;
            //Car syrena = new Car();
            //syrena.Wrum();
            //syrena.Beep();
            Console.WriteLine("--------------------------------------------");
            Snake Cobra = new Snake();
            Console.WriteLine("Cobra");
            Console.WriteLine("--------------------------------------------");
            Cobra.Climb();
            Cobra.Drink();
            Cobra.Eat();
            Cobra.Fly();
            Cobra.Run();
            Cobra.Sleep();
            Cobra.Sound();
            Console.WriteLine("--------------------------------------------");
            Chicken Latek = new Chicken();
            Console.WriteLine("Latek");
            Console.WriteLine("--------------------------------------------");
            Latek.Climb();
            Latek.Drink();
            Latek.Eat();
            Latek.Fly();
            Latek.Run();
            Latek.Sleep();
            Latek.Sound();
            Console.WriteLine("--------------------------------------------");
            Dog Terier= new Dog();
            Console.WriteLine("Terier");
            Console.WriteLine("--------------------------------------------");
            Terier.Climb();
            Terier.Drink();
            Terier.Eat();
            Terier.Fly();
            Terier.Run();
            Terier.Sleep();
            Terier.Sound();
            Console.WriteLine("--------------------------------------------");
            Qn grzywacz = new Qn();
            Console.WriteLine("grzywacz");
            Console.WriteLine("--------------------------------------------");
            grzywacz.Climb();
            grzywacz.Drink();
            grzywacz.Eat();
            grzywacz.Fly();
            grzywacz.Run();
            grzywacz.Sleep();
            grzywacz.Sound();
            Console.WriteLine("--------------------------------------------");
            
            Console.ReadLine();
            //Console.WriteLine(z);
            //Console.WriteLine(a);


        }
    }

}
