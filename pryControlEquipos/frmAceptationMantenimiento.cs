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
    public partial class frmAceptationMantenimiento : Form
    {
        public frmAceptationMantenimiento()
        {
            InitializeComponent();
        }
        DSbdcontrolappslab ds = new DSbdcontrolappslab();
        DSbdcontrolappslabTableAdapters.spBuscarsolicitudXestadoSolicitaTableAdapter TbusEstadoSoli = new DSbdcontrolappslabTableAdapters.spBuscarsolicitudXestadoSolicitaTableAdapter();
        DSbdcontrolappslabTableAdapters.splistequiposTableAdapter Tlistaequidefec = new DSbdcontrolappslabTableAdapters.splistequiposTableAdapter();
        DSbdcontrolappslabTableAdapters.QueriesTableAdapter Tprocedimientos = new DSbdcontrolappslabTableAdapters.QueriesTableAdapter();
        DSbdcontrolappslabTableAdapters.spBuscarsolicitudXestadoAutorizadoFinalizadoTableAdapter TautorizadoFinalizado = new DSbdcontrolappslabTableAdapters.spBuscarsolicitudXestadoAutorizadoFinalizadoTableAdapter();
        private void frmAceptationMantenimiento_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            gbdescripsoli.Visible = false;
            gbFinalizado.Visible = false;
            TautorizadoFinalizado.Fill(ds.spBuscarsolicitudXestadoAutorizadoFinalizado, "Autorizado","Finalizado");
            dgvlistasol.DataSource = ds.spBuscarsolicitudXestadoAutorizadoFinalizado;

        }
        int idnrosol;
        private void dgvlistasol_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           /* if (dgvlistasol.Columns["Acciones"] == null)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Acciones";
                buttonColumn.Name = "Acciones";
                buttonColumn.UseColumnTextForButtonValue = true;
                buttonColumn.Text = "Registrar Tarea"; // Establecer el texto del botón
                dgvlistasol.Columns.Add(buttonColumn);
            }*/
        }

        private void btnrechazar_Click(object sender, EventArgs e)
        {
            gbdescripsoli.Visible = false;
        }

        private void dgvlistasol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvlistasol.CurrentRow.Cells[5].Value.ToString() == "Autorizado")
            {

                gbdescripsoli.Visible = true;
                gbFinalizado.Visible = false;
                Tlistaequidefec.Fill(ds.splistequipos, Convert.ToInt32(dgvlistasol.CurrentRow.Cells[0].Value));
                cmbEquidef.DataSource = ds.splistequipos;
                cmbEquidef.DisplayMember = "nroequipo";
                cmbEquidef.ValueMember = "nroequipo";
                lblmotivo.Text = dgvlistasol.CurrentRow.Cells[1].Value.ToString();
                lbltiposol.Text = dgvlistasol.CurrentRow.Cells[2].Value.ToString();
                idnrosol = Convert.ToInt32(dgvlistasol.CurrentRow.Cells[0].Value);
            }
            if (dgvlistasol.CurrentRow.Cells[5].Value.ToString() == "Finalizado") { 
                gbFinalizado.Visible = true;
                gbdescripsoli.Visible = false;
                Tlistaequidefec.Fill(ds.splistequipos, Convert.ToInt32(dgvlistasol.CurrentRow.Cells[0].Value));
                cmbequifina.DataSource = ds.splistequipos;
                cmbequifina.DisplayMember = "nroequipo";
                cmbequifina.ValueMember = "nroequipo";
                lblmotfina.Text = dgvlistasol.CurrentRow.Cells[1].Value.ToString();
                lbltiposolfina.Text = dgvlistasol.CurrentRow.Cells[2].Value.ToString();
                rtbfina.Text= dgvlistasol.CurrentRow.Cells[6].Value.ToString();
                rtbfina.ReadOnly = true;
            }

        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            TimeSpan hora = DateTime.Now.TimeOfDay;
           
            Tprocedimientos.spActualizarAutorizado("Finalizado", Convert.ToInt32(dgvlistasol.CurrentRow.Cells[0].Value),DateTime.Now,hora,rtbDescrip.Text);
            MessageBox.Show("Tarea Finalizada");
            TautorizadoFinalizado.Fill(ds.spBuscarsolicitudXestadoAutorizadoFinalizado, "Autorizado", "Finalizado");
            gbdescripsoli.Visible = false;
            frmComprobantedeMantenimiento frm = new frmComprobantedeMantenimiento();
            frm.Tag = idnrosol;
            frm.ShowDialog();
        }

        private void btncerrarsoli_Click(object sender, EventArgs e)
        {
            gbFinalizado.Visible = false;
        }
    }
}
