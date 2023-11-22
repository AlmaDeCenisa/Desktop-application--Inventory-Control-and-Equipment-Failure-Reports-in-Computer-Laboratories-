using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryControlEquipos
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void registrarEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegequipos frm = new frmRegequipos();
            frm.Show();
        }

        private void aurorizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutorizacion frm = new frmAutorizacion();
            frm.Show();
        }

        private void registrarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegequipos frm = new frmRegequipos();
            frm.Show();
        }

        private void aceptarMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAceptationMantenimiento frm = new frmAceptationMantenimiento();
            frm.Show();
        }

        private void registrarDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void reporteDeDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRListadodocente frm = new frmRListadodocente();
            frm.ShowDialog();
        }

        private void reporteDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRListadoEquipos frm = new frmRListadoEquipos();
            frm.ShowDialog();
        }

        private void solicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSolicitud frm = new frmSolicitud();
            frm.ShowDialog();
        }
    }
}
