using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdLopresti
{
    internal class clsCola
    {
        private clsNodo pri;
        private clsNodo ult;


        public clsNodo primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (primero == null)
            {
                primero = Nuevo;
                ultimo = Nuevo;
            }
            else
            {
                ultimo.Siguiente = Nuevo;
                ultimo = Nuevo;
            }
        }

        public void Eliminar()
        {
            if ( primero == ultimo)
            {
                pri = null;
                ult = null;
            }
            else
            {
                pri = primero.Siguiente;
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

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.codigo);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer()
        {
            clsNodo aux = primero;
            StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8);
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
