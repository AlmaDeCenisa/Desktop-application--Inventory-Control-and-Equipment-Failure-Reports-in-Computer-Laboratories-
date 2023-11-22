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
    public partial class frmRsolcitudesporfecha : Form
    {
        public frmRsolcitudesporfecha()
        {
            InitializeComponent();
        }

        private void frmRsolcitudesporfecha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSbdcontrolappslab.sp_listado_fechaSol' Puede moverla o quitarla según sea necesario.
          
        }

        private void dtpFechasol_ValueChanged(object sender, EventArgs e)
        {
            this.sp_listado_fechaSolTableAdapter.Fill(this.DSbdcontrolappslab.sp_listado_fechaSol,dtpFechasol.Value.Date);
             this.reportViewer1.RefreshReport();
       
        }
    }
}
