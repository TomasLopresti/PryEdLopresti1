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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple FilaPersona = new clsListaSimple();

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
             
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            FilaPersona.Agregar(Persona);

            FilaPersona.Recorrer();
            FilaPersona.Recorrer(dgvDatos);
            FilaPersona.Recorrer(lstDatos);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = ""; 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaPersona.primero != null)
            {
                
            }
        }
    }
}
