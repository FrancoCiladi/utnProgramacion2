using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjerOOP4
{
    class Carcaza
    {
        private string _material;
        private string _color;

        public Carcaza()
        {
            this.Color = "Negro";
            this.Material = "Plastico";
        }

        public Carcaza(string NuevoColor, string NuevoMaterial)
        {
            this.Color = NuevoColor;
            this.Material = NuevoMaterial;
        }

        public string Color
        {
            get { return this._color; }
            set { this._color = value;}
        }

        public string Material
        {
            get { return this._material; }
            set { this._material = value; }
        }
    }
}
