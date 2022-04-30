using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjerOOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Carcaza car = new Carcaza("Negro","Madera");

            Teclado TGenius = new Teclado(car, "Latinoamericana", "Genius", "X-890", true, true);
            TGenius.Teclas_Obj.Add(new Tecla("Blanco", "Negro", "Verdana"));
            TGenius.Teclas_Obj.Add(new Tecla("Blanco", "Rojo", "Verdana"));
            TGenius.Teclas_Obj.Add(new Tecla("Azul", "Amarillo", "Verdana"));

            Console.WriteLine("El Material de la carcaza es: " + TGenius.Carcaza_Obj.Material);
            Console.WriteLine("La cantidad de teclas es: " + TGenius.CantTeclas.ToString());
            Console.WriteLine("La 1er. tecla es de color: " + TGenius.Teclas_Obj[0].ColorLetra);

            Console.ReadKey();
        }
    }
}
