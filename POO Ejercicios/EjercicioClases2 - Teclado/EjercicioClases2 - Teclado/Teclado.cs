using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases2___Teclado
{
    class Teclado
    {
        private string p_marca;
        private string p_modelo;
        private Carcaza obj_carcaza;
        private string p_distribucion;
        private List<Tecla> obj_tecla;
        private string p_contiene_funciones_especiales;
        private string p_es_inalambrico;

        public Teclado(Carcaza nuevacarcaza,string marca, string modelo, string distribucion, string contfuncespecial, string esinalambrico)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.CarcazaObj = nuevacarcaza;
            this.Distribucion = distribucion;
            this.TeclasObj = new List<Tecla>();
            this.ContieneFuncionesEspeciales = contfuncespecial;
            this.EsInalambrico = esinalambrico;
        }
        public string Marca
        {
            get { return this.p_marca; }
            set { this.p_marca = value; }
        }
        public string Modelo
        {
            get { return this.p_modelo; }
            set { this.p_modelo = value; }
        }
        
        public string Distribucion
        {
            get { return this.p_distribucion; }
            set { this.p_distribucion = value; }
        }
        public int CantTeclas
        {
            get { return this.TeclasObj.Count; }
            
        }
        public string ContieneFuncionesEspeciales
        {
            get { return this.p_contiene_funciones_especiales; }
            set { this.p_contiene_funciones_especiales = value; }
        }
        public string EsInalambrico
        {
            get { return this.p_es_inalambrico; }
            set { this.p_es_inalambrico = value; }
        }
        public Carcaza CarcazaObj
        {
            get { return this.obj_carcaza; }
            set { this.obj_carcaza = value; }
        }
        public List<Tecla> TeclasObj
        {
            get { return this.obj_tecla; }
            set { this.obj_tecla = value; }
        }
    }
}
