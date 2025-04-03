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
    public partial class FrmCiudades : Form
    {
        public FrmCiudades()
        {
            InitializeComponent();
        }

        clsArchivo x = new clsArchivo();
        private void FrmCiudades_Load(object sender, EventArgs e)
        {
            x.NombreArchivo = "Ciudades.csv";
            x.Recorrer(dgvCiudades);
            
        }

        private void btnGrabarCiud_Click(object sender, EventArgs e)
        {
            if (txtCiudades.Text == "")
            {
                MessageBox.Show("Nombre inválido", "ERROR");


            }
            else
            {
                x.Grabar(txtCiudades.Text + ";" + txtCodigoPostal.Text);
                x.Recorrer(dgvCiudades);
                txtCiudades.Text = "";
                txtCodigoPostal.Text = "";
            }
        }

    }
}
