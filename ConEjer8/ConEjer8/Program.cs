using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjer8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultado;
            

            if (args.Length == 3)
            {
                while(!(int.TryParse(args[0], out a)))
                {
                    Console.WriteLine("No ingreso un numero como primer argumento. Vuelva a intentarlo.");
                    args[0] = Console.ReadLine();
                }

                while (!(int.TryParse(args[1], out b)))
                {
                    Console.WriteLine("No ingreso un numero como segundo argumento. Vuelva a intentarlo.");
                    args[1] = Console.ReadLine();
                }
                
                while(!(args[2]=="+" || args[2]=="-" || args[2]=="*" || args[2]=="/"))
                {
                    Console.WriteLine("Lo que usted ingreso no es un operador. Vuelva a intentarlo.");
                    args[2] = Console.ReadLine();
                }
                
                switch (args[2])
                {
                    case "+":
                        {
                            resultado = sumar(a, b);
                            Console.WriteLine("La suma es: " + resultado.ToString());
                            break;
                        }
                    case "-":
                        {
                            resultado = restar(a, b);
                            Console.WriteLine("La diferencia es: " + resultado.ToString());
                            break;
                        }
                    case "*":
                        {
                            resultado = multiplicar(a, b);
                            Console.WriteLine("El producto es: " + resultado.ToString());
                            break;
                        }
                    case "/":
                        {
                            try
                            {
                                resultado = dividir(a, b);
                                Console.WriteLine("El cociente es: " + resultado.ToString());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Se ha presentado un error: " + e.Message);
                            }
                            finally
                            {
                                Console.WriteLine("Opèracion finalizada");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("El operador no es valido.");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Faltan parametros.");
            }

        }

        static int sumar(int p1, int p2)
        {
            return p1 + p2;
        }
        static int restar(int p1, int p2)
        {
            return p1 - p2;
        }

        static int multiplicar(int p1, int p2)
        {
            return p1 * p2;
        }

        static int dividir(int p1, int p2)
        {
            if (p2 != 0)
            {
                return p1 / p2;
            }
            else
            {
                Exception e = new Exception("Imposible dividir por cero.");
                throw e;
            }
        }
    }
}
