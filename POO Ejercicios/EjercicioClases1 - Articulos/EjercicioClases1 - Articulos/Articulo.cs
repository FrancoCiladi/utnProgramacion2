using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases1___Articulos
{
    class Articulo
    {
        private string p_descripcion;
        private string p_marca;
        private string p_codigobarra;
        private int p_precio;
        private int p_stock;

        public string Descripcion
        {
            get { return this.p_descripcion; }
            set { this.p_descripcion = value; }
        }
        public string Marca
        {
            get { return this.p_marca; }
            set { this.p_marca = value; }
        }
        public string CodigoBarra
        {
            get { return this.p_codigobarra; }
            set { this.p_codigobarra = value; }
        }
        public int Precio
        {
            get { return this.p_precio; }
            set { this.p_precio = value; }
        }
        public int Stock
        {
            get { return this.p_stock; }
            set { this.p_stock = value; }
        }
    }
}
