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
    public partial class FrmProvincia : Form
    {
        public FrmProvincia()
        {
            InitializeComponent();
        }
        clsArchivo x = new clsArchivo();
        private void FrmProvincia_Load(object sender, EventArgs e)
        {
            x.NombreArchivo = ("Provincia.csv");
            if (File.Exists(x.NombreArchivo))
            {
                x.Recorrer(dgvProvincia);
            }
            else MessageBox.Show("Archivo no econtrado");

            x.Recorrer(dgvProvincia);
        }

        private void btnGrabarProv_Click(object sender, EventArgs e)
        {
            if (txtProvincias.Text == "")
            {
                MessageBox.Show("Nombre inválido", "ERROR");

            }
            else
            {
                string Dato = "";
                Dato = txtCodigo.Text + ";" + txtProvincias.Text;
                x.Grabar(Dato);
                x.Recorrer(dgvProvincia);
                txtProvincias.Text = "";
            }

        }

        private void ControlarTexto()
        {
            if (txtCodigo.Text != "" && txtProvincias.Text != "") btnGrabarProv.Enabled = true;
            else btnGrabarProv.Enabled = false;
        }

        private void txtProvincias_TextChanged(object sender, EventArgs e)
        {
           ControlarTexto();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ControlarTexto();
        }
    }

}
