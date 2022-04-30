using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos_17_8
{
    class Program
    {
        static void Main(string[] args)
        {

            bool mostrarMenu = true;
            while (mostrarMenu)
            {
                mostrarMenu = Menu();
            }
            Environment.Exit(0);


        }

        static void leer()
        {

            FileStream archivo;
            StreamReader contenidoL;
            string frase;

            archivo = new FileStream("UnCuento.txt", FileMode.Open);
            contenidoL = new StreamReader(archivo);
            while (contenidoL.EndOfStream == false)
            {
                frase = contenidoL.ReadLine();
                Console.WriteLine(frase);
            }

            contenidoL.Close();
            archivo.Close();
            
        }

        static void guardar()
        {
            FileStream archivo;
            StreamWriter contenidoG;
            string frase;

            
                Console.WriteLine("Escriba una frase a almacenar: ");
                frase = Console.ReadLine();

                archivo = new FileStream("UnCuento.txt", FileMode.Append);
                contenidoG = new StreamWriter(archivo);
                contenidoG.WriteLine(frase);
                contenidoG.Close();
                archivo.Close();
            
            
        }

        static bool Menu()
        {
            string opcion;
            Console.Clear();
            Console.WriteLine("\t 1.Leer");
            Console.WriteLine("\t 2.Gaurdar");
            Console.WriteLine("\t 0.Salir");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    {
                        Console.Clear();
                        leer();
                        Esperar();
                        return true;
                    }
                case "2":
                    {
                        Console.Clear();
                        guardar();
                        Esperar();
                        return true;   
                    }
                case "0":
                    {
                        return false;
                    }
                default:
                    return true;
                
            }
        }

        static void Esperar()
        {
            Console.WriteLine();
            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey();
        }
           

    }
}
