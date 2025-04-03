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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        clsArchivo x = new clsArchivo();
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtMeses.Text == "")
            {
                MessageBox.Show("Nombre inválido", "ERROR");


            }
            else
            {
                x.Grabar(txtMeses.Text + ";" + txtTareas.Text);
                x.Recorrer(dgvMostrarMes);
                txtMeses.Text = "";
                txtTareas.Text = "";
            }
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {
            x.NombreArchivo = "Meses.csv";
            x.Recorrer(dgvMostrarMes);
        }
    }
}
