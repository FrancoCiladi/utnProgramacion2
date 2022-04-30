using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjerOOP3
{
    class RedBull : Equipos
    {
        public RedBull(string nombre, string color, string corredor1, string corredor2, int cantcamppil, int cantcampcons)
        {
            this.p_nombre = nombre;
            this.p_color = color;
            this.p_corredor1 = corredor1;
            this.p_corredor2 = corredor2;
            this.p_cantcamppilot = cantcamppil;
            this.p_cantcampconstruc = cantcampcons;
        }
        public override string p_nombre
        {
            get
            {
                return this.p_nombre;
            }
            set { this.p_nombre = value; }
        }
        public override string p_color
        {
            get
            {
                return this.p_color;
            }
            set { this.p_color = value; }
        }
        public override string p_corredor1
        {
            get
            {
                return this.p_corredor1;
            }
            set { this.p_corredor1 = value; }
        }
        public override string p_corredor2
        {
            get
            {
                return this.p_corredor2;
            }
            set { this.p_corredor2 = value; }
        }
        public override int p_cantcamppilot
        {
            get { return this.p_cantcamppilot; }
            set { this.p_cantcamppilot = value; }
        }
        public override int p_cantcampconstruc
        {
            get { return this.p_cantcampconstruc; }
            set { this.p_cantcampconstruc = value; }
        }
        public  int camptot
        {
            get
            {
                return this.p_cantcamppilot + this.p_cantcampconstruc;
            }
        }
        public override void Listar()
        {
            Console.Clear();
            Console.WriteLine("Nombre de equipo: " + this.p_nombre);
            Console.WriteLine("Color de equipo: " + this.p_color);
            Console.WriteLine("1° Corredor: " + this.p_corredor1);
            Console.WriteLine("2° Corredor: " + this.p_corredor2);
            Console.WriteLine("Cantidad de mundiales de pilotos: " + this.p_cantcamppilot.ToString());
            Console.WriteLine("Cantidad de mundiales de constructores: " + this.p_cantcampconstruc.ToString());
            Console.WriteLine("Campeonatos totales: " + this.camptot.ToString());
            Console.ReadKey();

        }
    }
}
