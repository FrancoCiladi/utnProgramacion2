using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases2___Teclado
{
    class Carcaza
    {
        private string p_material_carcaza;
        private string p_color_carcaza;

        public Carcaza(string materialcarcaza, string colorcarcaza)
        {
            this.MaterialCarcaza = materialcarcaza;
            this.ColorCarcaza = colorcarcaza;
        }
        public string MaterialCarcaza
        {
            get { return this.p_material_carcaza; }
            set { this.p_material_carcaza = value; }
        }
        public string ColorCarcaza
        {
            get { return this.p_color_carcaza; }
            set { this.p_color_carcaza = value; }
        }
    }
}
