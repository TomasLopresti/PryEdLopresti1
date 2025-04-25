using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdLopresti
{
    internal class clsArbolBinario
    {

        private clsNodo primerNodo;

        public clsNodo Raiz
        {
            get { return primerNodo; }
            set { primerNodo = value; }
        }
        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo aux = Raiz;
            while (aux != null)
            {
                if (cod == aux.codigo) break;
                if (cod<aux.codigo)aux=aux.izuierdo;
                else aux = aux.derecho;
            }
            return aux;
        }
        public void Agregar(clsNodo nvo) 
        {
            nvo.izuierdo = null;
            nvo.derecho = null;
            if (Raiz == null)
            {
                Raiz = nvo;
            }
            else
            {
                clsNodo nodoPadre = Raiz;
                clsNodo aux = Raiz;
                while (aux != null)
                {
                    nodoPadre = aux;
                    if (nvo.codigo < aux.codigo)
                    {
                        aux = aux.izuierdo;
                    }
                    else
                    {
                        aux = aux.derecho;
                    }
                }
                if (nvo.codigo < nodoPadre.codigo)
                {
                    nodoPadre.izuierdo = nvo;
                }
                else
                {
                    nodoPadre.derecho = nvo;
                }
            }   
        }
        private clsNodo[] vector = new clsNodo[100];
        private Int32 i = 0;
        public void Equlibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EqulibrarArbol(0, i -1);
        }
        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibarArbol(0, i - 1);
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if(NodoPadre.izuierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.izuierdo);
            }
            vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.derecho);
            }
        }
        private void GrabarVectorInOrden(clsNodo nodoPadre,Int32 codigo)
        {
            if (nodoPadre.izuierdo != null)
            {
                GrabarVectorInOrden(nodoPadre.izuierdo, codigo);
            }
            if (nodoPadre.codigo != codigo)
            {
                vector[i] = nodoPadre;
                i = i + 1;
            }
            if (nodoPadre.derecho!= null)
            {
                GrabarVectorInOrden(nodoPadre.derecho, codigo);
            }
        }


        public void Recorrer(ComboBox lista)
        {
            lista.Items.Clear();
            InOrdenAsc(lista, Raiz);
        }

        private void InOrdenAsc(ComboBox lst, clsNodo R) 
        {
            if (R.izuierdo != null) InOrdenAsc(lst, R.izuierdo);
            lst.Items.Add(R.codigo);
            if (R.izuierdo != null) InOrdenAsc(lst, R.derecho);
        }


        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        private void InOrdenA
    }
}
