using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjerOOP4
{
    class Teclado
    {
        private string _marca;
        private string _modelo;
        private string _distribucion;
        private bool _contiene_funciones;
        private bool _esInalambrico;
        private Carcaza _carcazaObj;
        private List<Tecla> _teclasObj;    

        public Teclado()
        {
            this.Carcaza_Obj = new Carcaza("Roja", "Plastico");
            this.Teclas_Obj = new List<Tecla>();
            this.Distribucion = "Ingles";
            this.Marca = "Genius";
            this.Modelo = "Zx-342";
            this.EsInalambrico = false;
            this.ContieneFunciones = false;
        }

        public Teclado(Carcaza NuevaCarcaza, string NuevaDistribucion, string NuevaMarca, string NuevoModelo, bool NuevoEsInalambrico, bool NuevoContieneFunciones)
        {
            this.Carcaza_Obj = NuevaCarcaza;
            this.Teclas_Obj = new List<Tecla>();
            this.Distribucion = NuevaDistribucion;
            this.Marca = NuevaMarca;
            this.Modelo = NuevoModelo;
            this.EsInalambrico = NuevoEsInalambrico;
            this.ContieneFunciones = NuevoContieneFunciones;
        }

        public int CantTeclas
        {
            //al tener el metodo de propiedad publico que permite manipular la lista directamente
            //no tiene mucho sentido que el teclado cuente con esta propiedad CantTeclas
            //Solo la mantenemos como ejemplo y para respetar la consigna
            get { return this.Teclas_Obj.Count; }
        }

        public string Marca
        {
            get { return this._marca; }
            set { this._marca = value; }
        }

        public string Modelo
        {
            get { return this._modelo; }
            set { this._modelo = value; }
        }

        public string Distribucion
        {
            get { return this._distribucion; }
            set { this._distribucion = value; }
        }

        public bool ContieneFunciones
        {
            get { return this._contiene_funciones; }
            set { this._contiene_funciones = value; }
        }

        public bool EsInalambrico
        {
            get { return this._esInalambrico; }
            set { this._esInalambrico = value; }
        }

        public Carcaza Carcaza_Obj
        {
            get { return this._carcazaObj; }
            set { this._carcazaObj = value; }
        }

        public List<Tecla> Teclas_Obj
        {
            get { return this._teclasObj; }
            set { this._teclasObj = value; }
        }

        public void Suspender()
        { 
        
        }

        public void Navegar()
        { 
        
        }
    }
}
