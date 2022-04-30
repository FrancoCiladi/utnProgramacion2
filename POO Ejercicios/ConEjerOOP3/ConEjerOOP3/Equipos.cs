using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEjerOOP3
{
    abstract class Equipos
    {


        public abstract string p_nombre
        {
            get;
            set;
        }
        
        public abstract string p_color
        {
            get;
            set;
            
        }
        public abstract string p_corredor1
        {
            get;
            set;
        }
        public abstract string p_corredor2
        {
            get;
            set;
        }
        public abstract int p_cantcamppilot
        {
            get;
            set;
        }
        public abstract int p_cantcampconstruc
        {
            get;
            set;
        }
        
        public abstract void Listar();
       
    }
}
