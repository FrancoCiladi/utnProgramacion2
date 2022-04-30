using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases1___Articulos
{
    class Herramienta : Articulo
    {
        private string p_voltaje;
        private string p_modelo;
        private string p_incluye_bateria;

        public Herramienta(string descripcion, string codigobarra, int precio,  int stock, string marca, string voltaje, string modelo, string incluyebateria)
        {
            this.Descripcion = descripcion;
            this.CodigoBarra = codigobarra;
            this.Precio = precio;
            this.Stock = stock;
            this.Marca = marca;
            this.Voltaje = voltaje;
            this.Modelo = modelo;
            this.IncluyeBateria = incluyebateria;
        }
        public string Voltaje
        {
            get { return this.p_voltaje; }
            set { this.p_voltaje = value; }
        }
        public string Modelo
        {
            get { return this.p_modelo; }
            set { this.p_modelo = value; }
        }
        public string IncluyeBateria
        {
            get { return this.p_incluye_bateria; }
            set { this.p_incluye_bateria = value; }
        }
        public void Encender()
        {

        }
        public void Apagar()
        {

        }
    }
}
