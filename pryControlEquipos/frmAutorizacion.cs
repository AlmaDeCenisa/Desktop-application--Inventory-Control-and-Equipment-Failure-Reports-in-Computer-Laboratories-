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
    public partial class frmAutorizacion : Form
    {
        public frmAutorizacion()
        {
            InitializeComponent();
        }
        DSbdcontrolappslab ds = new DSbdcontrolappslab();
        DSbdcontrolappslabTableAdapters.spBuscarsolicitudXestadoSolicitaTableAdapter TbusEstadoSoli = new DSbdcontrolappslabTableAdapters.spBuscarsolicitudXestadoSolicitaTableAdapter();
        DSbdcontrolappslabTableAdapters.splistequiposTableAdapter Tlistaequidefec = new DSbdcontrolappslabTableAdapters.splistequiposTableAdapter();
        DSbdcontrolappslabTableAdapters.QueriesTableAdapter Tprocedimientos = new DSbdcontrolappslabTableAdapters.QueriesTableAdapter();
        private void frmAutorizacion_Load(object sender, EventArgs e)
        {
                ds.EnforceConstraints = false;
            gbdescripsoli.Visible = false;
        
       
            TbusEstadoSoli.Fill(ds.spBuscarsolicitudXestadoSolicita, "%");
            dgvlistasol.DataSource = ds.spBuscarsolicitudXestadoSolicita;
        }

        private void dgvlistasol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gbdescripsoli.Visible = true;
            Tlistaequidefec.Fill(ds.splistequipos, Convert.ToInt32 (dgvlistasol.CurrentRow.Cells[0].Value));

            cmbEquidef.DataSource = ds.splistequipos;
            cmbEquidef.DisplayMember = "nroequipo";
            cmbEquidef.ValueMember = "nroequipo";
            lblmotivo.Text = dgvlistasol.CurrentRow.Cells[1].Value.ToString();
            lbltiposol.Text = dgvlistasol.CurrentRow.Cells[2].Value.ToString();
            

        }

        private void btnrechazar_Click(object sender, EventArgs e)
        {
            gbdescripsoli.Visible = false;
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            Tprocedimientos.spActualizarSoli("Autorizado", Convert.ToInt32(dgvlistasol.CurrentRow.Cells[0].Value));
            MessageBox.Show("Autorizacion completada");
            TbusEstadoSoli.Fill(ds.spBuscarsolicitudXestadoSolicita, "Solicita");
            gbdescripsoli.Visible = false;
        }

        private void rbtnFinalizado_CheckedChanged(object sender, EventArgs e)
        {
            string estado = "";
            if (rbtnFinalizado.Checked)
            {
                estado = "finalizado";
            }
            TbusEstadoSoli.Fill(ds.spBuscarsolicitudXestadoSolicita, estado);
            dgvlistasol.DataSource = ds.spBuscarsolicitudXestadoSolicita;

        }

        private void rbtnsolicitado_CheckedChanged(object sender, EventArgs e)
        {
            string estado = "";
            if (rbtnsolicitado.Checked)
            {
                estado = "solicita";
            }
            TbusEstadoSoli.Fill(ds.spBuscarsolicitudXestadoSolicita, estado);
            dgvlistasol.DataSource = ds.spBuscarsolicitudXestadoSolicita;
        }

        private void rbtnAutorizado_CheckedChanged(object sender, EventArgs e)
        {
            string estado = "";
            if (rbtnAutorizado.Checked)
            {
                estado = "Autorizado";
            }
            TbusEstadoSoli.Fill(ds.spBuscarsolicitudXestadoSolicita, estado);
            dgvlistasol.DataSource = ds.spBuscarsolicitudXestadoSolicita;
        }
    }
}
