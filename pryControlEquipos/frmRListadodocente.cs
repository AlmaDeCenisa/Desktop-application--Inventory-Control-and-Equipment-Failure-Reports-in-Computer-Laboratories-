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
    public partial class frmRListadodocente : Form
    {
        public frmRListadodocente()
        {
            InitializeComponent();
        }

        private void frmRListadodocente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSbdcontrolappslab.spListarDocente' Puede moverla o quitarla según sea necesario.
            this.spListarDocenteTableAdapter.Fill(this.DSbdcontrolappslab.spListarDocente);

            this.reportViewer1.RefreshReport();
        }
    }
}
