using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases1___Articulos
{
    class Pintura : Articulo
    {
        private string p_es_lavable;
        private string p_capacidad_cobertura;
        private string p_es_secado_rapido;
        private string p_es_latex;

        public Pintura(string descripcion, string marca,string codigobarra,int precio,int stock,  string eslavable, string capacidadcobertura, string es_secado_rapido, string es_latex)
        {
            this.Descripcion = descripcion;
            this.CodigoBarra = codigobarra;
            this.Precio = precio;
            this.Stock = stock;
            this.Marca = marca;
            this.Es_Lavable = eslavable;
            this.CapacidadCobertura = capacidadcobertura;
            this.Es_Secado_Rapido = es_secado_rapido;
            this.Es_Latex = es_latex;
        }

        public string Es_Lavable
        {
            get { return this.p_es_lavable; }
            set { this.p_es_lavable = value; }
        }
        public string CapacidadCobertura
        {
            get { return this.p_capacidad_cobertura; }
            set { this.p_capacidad_cobertura = value; }
        }
        public string Es_Secado_Rapido
        {
            get { return this.p_es_secado_rapido; }
            set { this.p_es_secado_rapido = value; }
        }
        public string Es_Latex
        {
            get { return this.p_es_latex; }
            set { this.p_es_latex = value; }
        }
    }
}
