using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjer2
{
    class Program
    {
        static void Main(string[] args)
        {
            //legajo (numerico positivo), apellido (entre 4 y 15), nombre (entre 4 y 15), fechanac (datetime)
            int legajo;
            string apellido, nombre, cadena;
            DateTime fechanac;

            Console.WriteLine("Ingrese el Legajo: ");
            cadena = Console.ReadLine();
            while (!(int.TryParse(cadena, out legajo) && legajo > 0))
            {
                Console.WriteLine("Ingrese el Legajo: ");
                cadena = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el Apellido (4-15): ");
            apellido = Console.ReadLine();
            while (!(apellido.Length >= 4 && apellido.Length <= 15))
            {
                Console.WriteLine("Ingrese el Apellido (4-15): ");
                apellido = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el Nombre (4-15): ");
            nombre = Console.ReadLine();
            while (!(nombre.Length >= 4 && nombre.Length <= 15))
            {
                Console.WriteLine("Ingrese el Nombre (4-15): ");
                nombre = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el Fecha de Nac.: ");
            cadena = Console.ReadLine();
            while (!(DateTime.TryParse(cadena, out fechanac)))
            {
                Console.WriteLine("Ingrese el Fecha de Nac.: ");
                cadena = Console.ReadLine();
            }

            //Console.WriteLine("Los datos ingresados fueron:");
            //Console.WriteLine("Legajo: " + legajo.ToString());
            //Console.WriteLine("Apellido: " + apellido);
            //Console.WriteLine("Nombre: " + nombre);
            //Console.WriteLine("Fecha Nac.: " + fechanac.ToShortDateString());

            Console.Clear();
            Console.WriteLine("Legajo".PadRight(10, ' ') + "Apellido".PadRight(10, ' ') + "Nombre".PadRight(5, ' ') + "Fecha Nac".PadLeft(12, ' '));
            Console.WriteLine(legajo.ToString().PadRight(10, ' ') + apellido.PadRight(10, ' ') + nombre.PadRight(5, ' ') + fechanac.ToShortDateString().PadLeft(12, ' '));
            Console.ReadKey();
        }
    }
}
