using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjerOOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de un objeto rectangulo
            Rectangulo r;

            //instanciando un objeto rectangulo
            r = new Rectangulo(10, 25, "rojo");

            //haciendo uso de un objeto rectangulo
            Console.WriteLine("el lado A es: " + r.LadoA.ToString());
            Console.WriteLine("el lado B es: " + r.LadoB.ToString());
            Console.WriteLine("el color es: " + r.Color);
            try { r.Color = "negro"; }
            catch (Exception p)
            { Console.WriteLine("Error: " + p.Message); }
            
            Console.WriteLine("el color es: " + r.Color);
          
            Console.WriteLine("su superficie es: " + r.Sup.ToString());

            r.LadoA = 5;
            Console.WriteLine("su superficie es: " + r.Sup.ToString());

            Console.ReadKey();

        }

    }
}
