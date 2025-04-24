using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEdLopresti
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        
        clsCola FilaPersonas = new clsCola();
        private void frmCola_Load(object sender, EventArgs e)
        {
            FilaPersonas.Agretgar();
            FilaPersonas.Recorrer();
            FilaPersonas.Recorrer(dgvDatos);
            FilaPersonas.Recorrer(lstDatos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;   
            Persona.Tramite = txtTramite.Text;

            FilaPersonas.Agregar(Persona);

            FilaPersonas.Recorrer();
            FilaPersonas.Recorrer(dgvDatos);
            FilaPersonas.Recorrer(lstDatos);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaPersonas.primero != null)
            {
                lblCodi.Text = FilaPersonas.primero.codigo.ToString();
                lblNom.Text = FilaPersonas.primero.Nombre;
                lblTrami.Text = FilaPersonas.primero.Tramite;

                FilaPersonas.Eliminar();

                FilaPersonas.Recorrer();
                FilaPersonas.Recorrer(dgvDatos);
                FilaPersonas.Recorrer(lstDatos);
            }
            else
            {
                lblCodi.Text = "";
                lblNom.Text = "";
                lblTrami.Text = "";

            }
        }
    }
}
