using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjerOOP4
{
    class Tecla
    {
        private string _color;
        private string _colorLetra;
        private string _tipoLetra;

        public Tecla()
        {
            this.Color = "Negro";
            this.ColorLetra = "Blanco";
            this.TipoLetra = "Arial";
        }

        public Tecla(string NuevoColor, string NuevoColorLetra, string NuevoTipoLetra)
        {
            this.Color = NuevoColor;
            this.ColorLetra = NuevoColorLetra;
            this.TipoLetra = NuevoTipoLetra;
        }

        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        public string ColorLetra
        {
            get { return this._colorLetra; }
            set { this._colorLetra = value; }
        }

        public string TipoLetra
        {
            get { return this._tipoLetra; }
            set { this._tipoLetra = value; }
        }
    }
}
