using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjerOOP1
{
    class Rectangulo
    {
        private int ladoA_;
        private int ladoB_;
        private string color_;

        public Rectangulo()
        {
            this.LadoA = 0;
            this.LadoB = 0;
            this.Color = "blanco";
        }
        public Rectangulo(int LA, int LB)
        {
            this.LadoA = LA;
            this.LadoB = LB;
            this.Color = "blanco";

        }

        public Rectangulo(int LA, int LB, string Col)
        {
            this.LadoA = LA;
            this.LadoB = LB;
            this.Color = Col;

        }
        public int Sup
        {
            get { return this.LadoA*this.LadoB ; }
        }
        public int LadoA
        {
            get { return this.ladoA_; }
            set
            {
                if (value >= 0)
                {
                    this.ladoA_ = value;
                }
            }
        }
        public int LadoB
        {
            get { return this.ladoB_; }
            set
            {
                if (value >= 0)
                {
                    this.ladoB_ = value;
                }
            }
        }

        public string Color
        {
            get { return this.color_; }
            set { 
                if (value.ToLower() == "blanco" || value.ToLower() == "rojo" || value.ToLower() == "azul")
                {
                    this.color_ = value;
                }
                else
                {
                    Exception e = new Exception("Color no valido");
                    throw e;
                }
                }
        }
    }
}
