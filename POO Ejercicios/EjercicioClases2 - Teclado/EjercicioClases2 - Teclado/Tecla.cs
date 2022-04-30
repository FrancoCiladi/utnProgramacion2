using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases2___Teclado
{
    class Tecla
    {
        private string p_color_tecla;
        private string p_tipo_letra_rotulada;
        private string p_color_letra_rotulada;

        public Tecla(string colortecla, string tipoletrarotulada, string colorletrarotulada)
        {
            this.ColorTecla = colortecla;
            this.TipoLetraRotulada = tipoletrarotulada;
            this.ColorLetraRotulada = colorletrarotulada;
        }
        public string ColorTecla
        {
            get { return this.p_color_tecla; }
            set { this.p_color_tecla = value; }
        }
        public string TipoLetraRotulada
        {
            get { return this.p_tipo_letra_rotulada; }
            set { this.p_tipo_letra_rotulada = value; }
        }
        public string ColorLetraRotulada
        {
            get { return this.p_color_letra_rotulada; }
            set { this.p_color_letra_rotulada = value; }
        }
    }
}
