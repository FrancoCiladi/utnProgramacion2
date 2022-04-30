using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDomicilio;

namespace ConEjer3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Inic;
            Inic = 27;
            Console.Write("Piux's: {0}", Piux(27, 10, 5));
            Console.ReadKey();

        }
        static int Piux(int M, int B, int G)
        {
            if (M < 3)
            {
                return M * B;
            }
            else
            {
                return Piux(M / 3, G, B - 1) + G;
            }
        }

    }

}
