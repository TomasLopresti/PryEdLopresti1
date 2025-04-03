using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdLopresti
{
    public partial class frmDias : Form
    {
        public frmDias()
        {
            InitializeComponent();
        }
        clsArchivo x = new clsArchivo();
        private void frmDias_Load(object sender, EventArgs e)
        {
            x.NombreArchivo = "Dias.csv";
            if (File.Exists(x.NombreArchivo))
            {
                x.Recorrer(dgvMostrarDias);
            }
            else MessageBox.Show("Archivo no econtrado");
            //x.Recorrer(dgvMostrarDias);
            TotalDin();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
           
            if (txtFecha.Text == "")
            {
                MessageBox.Show("Nombre inválido", "ERROR");

            }
            else
            {
                string Dato = "";
                Dato = txtFecha.Text + ";" + txtMonto.Text;
                x.Grabar(Dato);
                x.Recorrer(dgvMostrarDias);
                txtFecha.Text = "";
                txtMonto.Text = "";
            }
            TotalDin();
        }

        public void TotalDin()
        {
            double total = 0;

            
            foreach (DataGridViewRow fila in dgvMostrarDias.Rows)
            {
                if (fila.Cells["Monto"].Value != null) 
                {
                    double monto;
                    if (double.TryParse(fila.Cells["Monto"].Value.ToString(), out monto))
                    {
                        total += monto; 
                    }
                }
            }

            
            lblTotalDin.Text =  total.ToString("C");
        }
    }
}
