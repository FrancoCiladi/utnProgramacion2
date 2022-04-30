using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjerOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            float VT;
            Camion fiat = new Camion("axt-980", "gomez", 100);
            Caja cajita = new Caja();

            cajita = new Caja("101", "Manzanas", 10, 5, 7, 90, "carton");
            if (fiat.AgregarCaja(cajita) == true)
            {
                Console.WriteLine("la caja fue agregada");
            }
            else
            {
                Console.WriteLine("la caja no fue agregada");
            }


            cajita = new Caja("107", "peras", 8, 3, 15, 5, "madera");
            if (fiat.AgregarCaja(cajita) == true)
            {
                Console.WriteLine("la caja fue agregada");
            }
            else
            {
                Console.WriteLine("la caja no fue agregada");
            }

            cajita = new Caja("108", "frutillas", 4, 5, 30, 3, "madera");
            if (fiat.AgregarCaja(cajita) == true)
            {
                Console.WriteLine("la caja fue agregada");
            }
            else
            {
                Console.WriteLine("la caja no fue agregada");
            }

            //VT = 0;
            for (int i = 0; i< fiat.CantCajasCargadas;i++)
            {
                fiat.RecuperarDatosCaja(i, out cajita);
                Console.WriteLine("Codigo: {0} Material: {1} Contenido: {2}",cajita.CodigoInterno ,cajita.Material, cajita.Contenido);
                //VT = VT + cajita.VolumenCM3;
            }
            Console.WriteLine("Volumen Total: "+ fiat.VolumenTotal.ToString());

            Console.ReadKey();
        }
    }
}
