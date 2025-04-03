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
    public partial class FrmPrimera : Form
    {
        public FrmPrimera()
        {
            InitializeComponent();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosProgramador v = new FrmDatosProgramador();
            v.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void programacionOOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCiudades v = new FrmCiudades();
            v.ShowDialog();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProvincia v = new FrmProvincia();
            v.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses v = new frmMeses();    
            v.ShowDialog();
        }

        private void diasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDias v = new frmDias();  
            v.ShowDialog();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias v = new frmMaterias();
            v.ShowDialog();
        }
    }
}
