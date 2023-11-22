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
    public partial class frmComprobantedeSol : Form
    {
        public frmComprobantedeSol()
        {
            InitializeComponent();
        }

        private void frmComprobantedeSol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSbdcontrolappslab.sp_ComprobantedeSolicitud' Puede moverla o quitarla según sea necesario.
            int idnrosol = (int)Tag;
            this.sp_ComprobantedeSolicitudTableAdapter.Fill(this.DSbdcontrolappslab.sp_ComprobantedeSolicitud,idnrosol);

            this.reportViewer1.RefreshReport();
        }
    }
}
