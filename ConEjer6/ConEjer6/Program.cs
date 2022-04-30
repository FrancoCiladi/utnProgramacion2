using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjer6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int facto;
            // !0 = 1
            // !1 = 1
            // !2 = 1*2
            // !3 = 1*2*3 = 3*2*1 = 3* factorial(2) = 3*2* factrial(1)
            // !4 = 1*2*3*4
            // !5 = 1*2*3*4*5


            //Console.WriteLine("ingrese el nro al cual calcular el factorial: ");
            //num = int.Parse(Console.ReadLine());

            //Console.WriteLine(factorial(num));


            //facto = factorialREC(num);
            //Console.WriteLine("El factorial es: " + facto.ToString());


            Console.WriteLine("El valor retornado es: " + mifunc(5, 3).ToString());

            Console.WriteLine("El valor retornado (messi) es: " + messi(8, 4, 2).ToString());

            Console.WriteLine("El valor retornado es (partes) : " + partes(5, 3).ToString());

            Console.ReadKey();
        }

        static int factorial(int nro)
        {
            int fac;

            fac = 1;
            for (int f = 1; f <= nro; f++)
            {
                fac = fac * f;
            }

            return fac;
        }

        //factorial(5)
        //5* factorial(4)
            //4*factorial(3)
                //3*factorial(2)
                    //2*factorial(1)
                        //1

        static int factorialREC(int nro)
        {
            if (nro > 1)
            {
                return nro * factorialREC(nro - 1);
            }
            else
            {
                return 1;
            }
        }

        static int mifunc(int A, int B)
        {
            if (A > 0)
            {
                return (mifunc(A - 1, B) * A) - B;
            }
            else
            {
                return 1;
            }
        }

        //mifunc(5,3)
        //(mifunc(4,3)*5)-3
        //(mifunc(3,3)*4)-3)
        //(mifunc(2,3)*3)-3
        //(mifunc(1,3)*2)-3
        //(mifunc(0,3)*1)-3
        //1

        static int messi(int suarez, int vidal, int pique)
        {
            if (suarez - vidal > 2)
            {
                return messi(vidal - 1, pique - 2, suarez) + suarez + pique;
            }
            else
            {
                return pique;
            }
        }

        //messi(8,4,2)
        //messi(3,0,8)+8+2
            //messi(-1,6,3)+3+8
                //3
        

        static int partes(int free, int cash)
        {
            if (free * 2 < cash)
            {
                return cash * 3;
            }
            else
            {
                return partes(cash - 2, free - 1) + cash;
            }    
        }
        //EL (CASH "+" 2), HACE QUE SEA LOOP INFINITO, PARA QUE NO LO SEA CAMBIAR A MENOS
        //partes(5,3)
        //partes(5,4)+3
            //partes(6,4)+4
                //partes(6,5)+4

        // (CASH "-" 2) == 15
        //partes(5,3)
        //partes(1,4)+3
            //12
    }
}
