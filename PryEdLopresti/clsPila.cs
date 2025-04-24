using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdLopresti
{
    internal class clsPila
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
            if (primero == ultimo)
            {
                pri = null;
                ult = null;
            }
            else
            {
                pri = primero.Siguiente;
            }
        }
        public void Agregar()
        {
            StreamReader AD = new StreamReader("Cola.csv");
            String dato = "";
            dato = AD.ReadLine(); //Titulo
            dato = AD.ReadLine(); //Reglon vacio
            dato = AD.ReadLine(); //Titulos de columna
            dato = AD.ReadLine(); //Primera fila con datos
            while (dato != null)
            {
                clsNodo Persona = new clsNodo();
                String[] datos = dato.Split(';');
                Persona.codigo = Convert.ToInt32(datos[0]);
                Persona.Nombre = datos[1];
                Persona.Tramite = datos[2];
                Agregar(Persona);
                dato = AD.ReadLine();
            }
            AD.Close();
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
        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.codigo + " " + aux.Nombre + " " +
                aux.Tramite);
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
        public void Recorrer()
        {
            clsNodo aux = primero;
            StreamWriter AD = new StreamWriter("Pila.csv", false,
            Encoding.UTF8);
            AD.WriteLine("Lista de personas\n");
            AD.WriteLine("Código;Nombre;Trámite");
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
        public void Recorrer(String NmmbreArchivo)
        {
            clsNodo aux = primero;
            StreamWriter AD = new StreamWriter(NmmbreArchivo, false,
            Encoding.UTF8);
            AD.WriteLine("Lista de personas\n");
            AD.WriteLine("Código;Nombre;Trámite");
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
