using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjer1
{
    class Program
    {

        unsafe static void Main(string[] args)
        {
            float[] Comps = new float[5];
            float Total;
            Comps[0] = 125;
            Comps[1] = 140;
            Comps[2] = 35;
            Comps[3] = 780;
            Comps[4] = 230;
            fixed (float* CA = &Comps[4], CB = Comps)
            {
                Console.WriteLine(*(CA - 2));
                *(CA - 3) = *(CA - 3) - *CB;
                if (Comps[2] < *(CA - 3))
                {
                    Comps[3] = 24;
                }
                else
                {
                    Comps[3] = 70;
                }
            }
            fixed (float* CA = &Comps[0])
            {
                Total = 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(*(CA + i));
                    Total = Total + *(CA + i);
                }
                Console.WriteLine(Total);
            }
            Console.ReadKey();
        }

    }       
}
