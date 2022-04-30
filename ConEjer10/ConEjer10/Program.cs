using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConEjer10
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream archivo;
            StreamWriter contenidoG;
            StreamReader contenidoL;
            string cadena, fruta, marca;
            int cant;
            string [] datos;
            int total;


            Console.Write("Fruta: ");
            fruta = Console.ReadLine();
            Console.Write("Marca: ");
            marca = Console.ReadLine();
            Console.Write("Cantidad: ");
            cadena = Console.ReadLine();
            if (!int.TryParse(cadena, out cant))
            {
                Console.WriteLine("La cantidad debia ser numerica por lo cual se le asignara cero.");
                cant = 0;
            }

            Console.Clear();

            archivo = new FileStream("mercado.csv", FileMode.Append);
            contenidoG = new StreamWriter(archivo);
            contenidoG.WriteLine(fruta + ";" + marca + ";" + cant.ToString());
            contenidoG.Close();
            archivo.Close();

            total = 0;
            archivo = new FileStream("mercado.csv", FileMode.Open);
            contenidoL = new StreamReader(archivo);
            Console.WriteLine("Fruta".PadRight(15, ' ') + "Marca".PadRight(10, ' ') + "Cant".PadLeft(5, ' '));
            while (contenidoL.EndOfStream == false)
            {
                cadena = contenidoL.ReadLine();
                datos = cadena.Split(';');

                Console.WriteLine(datos[0].PadRight(15,' ') + datos[1].PadRight(10, ' ') + datos[2].PadLeft(5, ' '));
                total = total + int.Parse(datos[2]);
            }

            Console.WriteLine();
            Console.WriteLine("La cantidad total es: {0}", total.ToString());

            contenidoL.Close();
            archivo.Close();

            Console.ReadKey();
        }
    }
}
