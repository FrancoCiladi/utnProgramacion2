using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases2___Teclado
{
    class Program
    {
        static void Main(string[] args)
        {

            Carcaza car = new Carcaza("Plastico", "Blanca");
            Teclado tec = new Teclado(car, "Genius", "T156", "Prueba", "Si", "No");
            tec.TeclasObj.Add(new Tecla("Negra", "Arial", "Blanca"));
            Console.WriteLine("Cant de Teclas: " + tec.CantTeclas);
            Console.WriteLine("Color de Carcaza: " + tec.CarcazaObj.ColorCarcaza);
            Console.WriteLine("Color de Letra: " + tec.TeclasObj[0].ColorTecla);
            Console.ReadKey();
            
        }
    }
}
