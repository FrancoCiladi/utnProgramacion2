using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjer5
{
    class Program
    {
        static void Main(string[] args)
        {
            //desarrollar un procedimiento que reciba dos parametros numericos
            //e intercambie el valor de los mismos
            int p1, p2;
            Console.WriteLine("ingrese el 1er valor: ");
            p1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el 2do valor: ");
            p2 = int.Parse(Console.ReadLine());

            intercambiar(ref p1, ref p2);

            Console.WriteLine("Fuera del procedimiento");
            Console.WriteLine("El 1er valor: {0} El 2do. valor: {1}", p1, p2);
            Console.ReadKey();
        }

        static void intercambiar(ref int a, ref int b)
        {
            int aux;
            aux = a;
            a = b;
            b = aux;

            Console.WriteLine("Dentro del procedimiento");
            Console.WriteLine("El 1er valor: {0} El 2do. valor: {1}", a, b);
        }

    }
}
