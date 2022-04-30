using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsEjer7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string palabra;
            Console.WriteLine("ingrese una palabra: ");
            palabra = Console.ReadLine();

            if (palabra == "hola")
            {
                Console.WriteLine("La persona acaba de llegar y entiendo que es amable.");
            }
            else
            {
                if (palabra == "adios")
                {
                    Console.WriteLine("La persona saluda porque se acaba de ir.");
                }
                else
                {
                    Console.WriteLine("La persona no se esta comunicando.");
                }
            }
            Console.ReadKey();
            */

            
            if (args.Length > 0)
            {
                if (args[0] == "hola")
                {
                    Console.WriteLine("La persona acaba de llegar y entiendo que es amable.");
                }
                else
                {
                    if (args[0] == "adios")
                    {
                        Console.WriteLine("La persona saluda porque se acaba de ir.");
                    }
                    else
                    {
                        Console.WriteLine("La persona no se esta comunicando.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Sin Parametros");
            }
            
        }
    }
}
