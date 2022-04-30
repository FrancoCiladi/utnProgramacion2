using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjerOOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferrari fer = new Ferrari("Ferrari", "Rojo", "Charles Leclerc", "Carlos Sains Jr", 16, 2);
            fer.Listar();

            //Mercedes mer = new Mercedes();
            //mer.Listar();

            //RedBull rb = new RedBull();
            //rb.Listar();

        }
    }
}
