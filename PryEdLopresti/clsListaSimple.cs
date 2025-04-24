using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdLopresti
{
    internal class clsListaSimple
    {
        private clsNodo pri;

        public clsNodo primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public void Agregar(clsNodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo; 
            }
            else
            {
                if (nuevo.codigo <= primero.codigo)
                {
                    nuevo.Siguiente = primero;
                    primero = nuevo;
                }
                else
                {
                    clsNodo aux = primero;
                    clsNodo ant = primero;
                    while (aux != null && nuevo.codigo > aux.codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                    }
                    ant.Siguiente = nuevo;
                    nuevo.Siguiente = aux;


                }
            }
        }

        public void Eliminar(Int32 codigo)
        {
            if (primero.codigo == codigo)
            {
                primero = primero.Siguiente;
            }
            else
            {
                clsNodo ant = primero;
                clsNodo aux = primero;
                while (aux.codigo != codigo)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                ant.Siguiente = aux.Siguiente;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox lista)
        {
            clsNodo aux = primero;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox combo)
        {
            clsNodo aux = primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer()
        {
            clsNodo aux = primero;
            StreamWriter AD = new StreamWriter("ListaSimple.csv", false, Encoding.UTF8);
            AD.WriteLine("lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
    }
}
