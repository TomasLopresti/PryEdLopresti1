using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PryEdLopresti
{
     class clsNodo
    {
        private Int32 cod;
        private string nom;
        private string tram;
        private clsNodo sig;
        private clsNodo ant;
       

        public Int32 codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Tramite
        {
            get { return tram; }
            set { tram = value; }
        }

        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodo izuierdo
        {
            get { return ant; }
            set { ant = value; }
        }
        public clsNodo derecho
        {
            get { return sig; }
            set { sig = value; }
        }
    }

}
}
