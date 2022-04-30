using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConEjer9
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            Console.WriteLine("Seleccione una opcion (A: agregar / L: listar): ");
            opcion = Console.ReadLine();

            while (opcion.ToUpper() == "A" || opcion.ToUpper() == "L")
            {
                if (opcion.ToUpper() == "A")
                {
                    Agregar();
                }
                else
                {
                    Listar();
                }
                Console.WriteLine("Seleccione una opcion (A: agregar / L: listar): ");
                opcion = Console.ReadLine();
            }
            Console.ReadKey();
        }

        static void Agregar()
        {
            FileStream archivo;
            StreamWriter contenidoG;
            string cadena;

            try
            {
                Console.WriteLine("ingrese una frase a almacenar: ");
                cadena = Console.ReadLine();

                archivo = new FileStream("UnCuento.txt", FileMode.Append);
                contenidoG = new StreamWriter(archivo);
                contenidoG.WriteLine(cadena);
                contenidoG.Close();
                archivo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("se ha presentado un error: " + e.Message);
            }
        }

        static void Listar()
        {
            FileStream archivo;
            StreamReader contenidoL;
            string cadena;

            archivo = new FileStream("UnCuento.txt", FileMode.Open);
            contenidoL = new StreamReader(archivo);
            while (contenidoL.EndOfStream == false)
            {
                cadena = contenidoL.ReadLine();
                Console.WriteLine(cadena);
            }
            contenidoL.Close();
            archivo.Close();
        }
    }
}
