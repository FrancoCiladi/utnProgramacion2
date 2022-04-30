using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjer4
{
    class Program
    {
        static void Main(string[] args)
        {

            string apellido;
            string nombre;
            string apelnoms;

            Console.WriteLine("el apellido a ingresar es: ");
            apellido = Console.ReadLine();
            Console.WriteLine("el nombre a ingresar es: ");
            nombre = Console.ReadLine();

            Console.WriteLine("El apelnom es : " + apelnom(apellido, nombre));

            apno(apellido, nombre);

            apnosal(apellido, nombre, out apelnoms);
            Console.WriteLine("El apnosal es : " + apelnoms);


            //desarrollar un procedimiento que solicite 5 nros y 
            //los presente ordenados de menor a mayor

            //pedirYordenar();

            //desarrollar un procedimiento que solicite 5 nros y 
            //los presente ordenados de menor a mayor
            //recibiendo como parametro el orden deseado

            //string orden;
            //Console.WriteLine("Que orden desea? (a:ascendente / d:descendente)");
            //orden = Console.ReadLine();
            //pedirYordenar(orden);


            Console.ReadKey();
        }

        //static void pedirYordenar(string tipo_orden)
        //{
        //    int[] vec = new int[5];
        //    string cadena;
        //    int num, aux;

        //    //la siguiente estructura solicita los datos
        //    //y los almacena en el vector
        //    for (int f = 0; f < 5; f++)
        //    {
        //        Console.WriteLine("ingrese un valor:");
        //        cadena = Console.ReadLine();
        //        while (!int.TryParse(cadena, out num))
        //        {
        //            Console.WriteLine("ingrese un valor:");
        //            cadena = Console.ReadLine();
        //        }
        //        vec[f] = num;
        //    }


        //    //la siguiente estructura ordena el vector
        //    if (tipo_orden == "a")
        //    {
        //        for (int f = 0; f < 4; f++)
        //        {
        //            for (int c = f + 1; c < 5; c++)
        //            {
        //                if (vec[f] > vec[c])
        //                {
        //                    aux = vec[f];
        //                    vec[f] = vec[c];
        //                    vec[c] = aux;
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        for (int f = 0; f < 4; f++)
        //        {
        //            for (int c = f + 1; c < 5; c++)
        //            {
        //                if (vec[f] < vec[c])
        //                {
        //                    aux = vec[f];
        //                    vec[f] = vec[c];
        //                    vec[c] = aux;
        //                }
        //            }
        //        }
        //    }

        //    //la siguiente estructura presenta el listado ya ordenado
        //    for (int f = 0; f < 5; f++)
        //    {
        //        Console.WriteLine("pos: " + f.ToString() + " numero: " + vec[f].ToString());
        //    }

        //}
        //static void pedirYordenar()
        //{
        //    int [] vec = new int[5];
        //    string cadena;
        //    int num, aux;

        //    //la siguiente estructura solicita los datos
        //    //y los almacena en el vector
        //    for(int f = 0; f<5;f++)
        //    {
        //        Console.WriteLine("ingrese un valor:");
        //        cadena = Console.ReadLine();
        //        while (!int.TryParse(cadena, out num))
        //        {
        //            Console.WriteLine("ingrese un valor:");
        //            cadena = Console.ReadLine();
        //        }
        //        vec[f] = num;
        //    }
            
        //    //la siguiente estructura ordena el vector
        //    for(int f = 0; f<4;f++)
        //    {
        //        for (int c = f+1; c < 5; c++)
        //        {
        //            if (vec[f] > vec[c])
        //            {
        //                aux = vec[f];
        //                vec[f] = vec[c];
        //                vec[c] = aux;
        //            }
        //        }
        //    }

        //    //la siguiente estructura presenta el listado ya ordenado
        //    for (int f = 0; f < 5; f++)
        //    {
        //        Console.WriteLine("pos: " + f.ToString() + " numero: " + vec[f].ToString());
        //    }

        //}

        static string apelnom (string apellido, string nombre)
        {
            string concatenado;

            concatenado = apellido + ", " + nombre;

            return concatenado;
        }

        static void apno(string apellido, string nombre)
        { 

            Console.WriteLine("el apno es: " +  apellido + ", " + nombre);

        }

        static void apnosal(string apellido, string nombre, out string apellidonombre)
        {

            apellidonombre = apellido + ", " + nombre;

        }

    }
}
