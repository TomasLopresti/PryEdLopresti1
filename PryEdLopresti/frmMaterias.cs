using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdLopresti
{
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
        }
        clsArchivo x = new clsArchivo();
        private void frmMaterias_Load(object sender, EventArgs e)
        {
            x.NombreArchivo = "Materias.csv";
            x.Recorrer(dgvMostrarMat);
            Promedio();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtMateria.Text == "")
            {
                MessageBox.Show("Nombre inválido", "ERROR");

            }
            else
            {
                string Dato = "";
                Dato = txtMateria.Text + ";" + txtNota.Text;
                x.Grabar(Dato);
                x.Recorrer(dgvMostrarMat);
                txtMateria.Text = "";
                txtNota.Text = "";
            }
            Promedio();
        }

        public void Promedio()
        {
            double suma = 0;
            int contador = 0;

            foreach (DataGridViewRow fila in dgvMostrarMat.Rows)
            {
                if (fila.Cells["Nota"].Value != null) 
                {
                    double nota;
                    if (double.TryParse(fila.Cells["Nota"].Value.ToString(), out nota))
                    {
                        suma += nota; 
                        contador++;   
                    }
                }
            }

            if (contador > 0)
            {
                double promedio = suma / contador; 
                lblPromedio.Text = promedio.ToString("F2"); 
            }
            else
            {
                lblPromedio.Text = "No hay notas disponibles.";
            }
        }
    }
}
