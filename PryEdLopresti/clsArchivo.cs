using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdLopresti
{
    internal class clsArchivo
    {
        public string NombreArchivo = "Archivo";

        public void Grabar()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo,true);
            AD.WriteLine("hola");
            AD.Close();
        }


        public void Grabar(string DatoRecibido) 
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.WriteLine(DatoRecibido);
            AD.Close();
        }

        public void Recorrer(ListBox lista)
        {
            StreamReader AD = new StreamReader(NombreArchivo);
            string Dato = "";
            Dato = AD.ReadLine();
            lista.Items.Clear();
            while (Dato != null)
            {
                lista.Items.Add(Dato);
                Dato = AD.ReadLine();
            }
            AD.Close();

        }

        public void Recorrer(ComboBox lista)
        {
            StreamReader AD = new StreamReader(NombreArchivo);
            string Dato = "";
            Dato = AD.ReadLine();
            lista.Items.Clear();
            while (Dato != null)
            {
                lista.Items.Add(Dato);
                Dato = AD.ReadLine();
            }
            AD.Close();

        }

        public void Recorrer(DataGridView lista)
        {
            StreamReader AD = new StreamReader(NombreArchivo);
            string Dato = "";
            Dato = AD.ReadLine();
            lista.Rows.Clear();
            while (Dato != null)
            {
                lista.Rows.Add(Dato.Split(';'));
                Dato = AD.ReadLine();
            }
            AD.Close();

        }

    }
}
