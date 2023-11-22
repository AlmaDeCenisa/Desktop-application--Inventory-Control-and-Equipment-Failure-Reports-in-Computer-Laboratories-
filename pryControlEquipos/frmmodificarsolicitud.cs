using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace pryControlEquipos
{
    public partial class frmmodificarsolicitud : Form
    {
        public frmmodificarsolicitud()
        {
            InitializeComponent();
        }
        DSbdcontrolappslab ds = new DSbdcontrolappslab();
        DSbdcontrolappslabTableAdapters.spBuscarNombreSolicitudTableAdapter TbusNombre = new DSbdcontrolappslabTableAdapters.spBuscarNombreSolicitudTableAdapter();
        DSbdcontrolappslabTableAdapters.motivoTableAdapter Tmotivo = new DSbdcontrolappslabTableAdapters.motivoTableAdapter();
        DSbdcontrolappslabTableAdapters.tiposolTableAdapter Ttiposol = new DSbdcontrolappslabTableAdapters.tiposolTableAdapter();
        DSbdcontrolappslabTableAdapters.spBuscarEquipoXEstadoTableAdapter Tbusequipo = new DSbdcontrolappslabTableAdapters.spBuscarEquipoXEstadoTableAdapter();
        DSbdcontrolappslabTableAdapters.splistequipopordocenteTableAdapter TequipoDoc = new DSbdcontrolappslabTableAdapters.splistequipopordocenteTableAdapter();
        DSbdcontrolappslabTableAdapters.splistarequiposparaacutlizaTableAdapter Tlistaequipos = new DSbdcontrolappslabTableAdapters.splistarequiposparaacutlizaTableAdapter();
        private void frmmodificarsolicitud_Load(object sender, EventArgs e)
        {
            ds.EnforceConstraints = false;
            TbusNombre.Fill(ds.spBuscarNombreSolicitud,"%", "Solicita");
            dgvsolicitud.DataSource = ds.spBuscarNombreSolicitud;
            Tmotivo.Fill(ds.motivo);
            Ttiposol.Fill(ds.tiposol);
            cmbmoti.DataSource = ds.motivo;
            cmbmoti.DisplayMember = "descripmot";
            cmbmoti.ValueMember = "codmot";

            cmbtiposol.DataSource = ds.tiposol;
            cmbtiposol.DisplayMember = "descriptiposol";
            cmbtiposol.ValueMember = "codtiposol";

            TequipoDoc.Fill(ds.splistequipopordocente,"","",null);
            

            Tlistaequipos.Fill(ds.splistarequiposparaacutliza, lbllaboratorio.Text, "Activo");
                    
        }

        private void txtdocente_TextChanged(object sender, EventArgs e)
        {
            TbusNombre.Fill(ds.spBuscarNombreSolicitud, txtdocente.Text + "%", "Solicita");
            
        }

        private void dgvsolicitud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbllaboratorio.Text = dgvsolicitud.CurrentRow.Cells[7].Value.ToString();
            cmbtiposol.Text= dgvsolicitud.CurrentRow.Cells[2].Value.ToString();
            cmbmoti.Text= dgvsolicitud.CurrentRow.Cells[3].Value.ToString();
            lbldocente.Text= dgvsolicitud.CurrentRow.Cells[1].Value.ToString();
            lblfecha.Text= dgvsolicitud.CurrentRow.Cells[4].Value.ToString();
            lblhora.Text= dgvsolicitud.CurrentRow.Cells[5].Value.ToString();
            dgvequipos.DataSource = (ds.splistequipopordocente);
        }

        private void lbldocente_Click(object sender, EventArgs e)
        {

        }

        private void lbldocente_TextChanged(object sender, EventArgs e)
        {
            TequipoDoc.Fill(ds.splistequipopordocente,lbldocente.Text,lbllaboratorio.Text, Convert.ToInt32 (dgvsolicitud.CurrentRow.Cells[0].Value));
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            dgvequipos.Rows.Remove(dgvequipos.SelectedRows[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ((DataTable)dgvequipos.DataSource);
            DataRow newRow = dataTable.NewRow();
            newRow["nroequipo"] = cmbequipo.Text;
            dataTable.Rows.Add(newRow);
            dgvequipos.DataSource = dataTable;
        }

        private void lbllaboratorio_TextChanged(object sender, EventArgs e)
        {
            Tlistaequipos.Fill(ds.splistarequiposparaacutliza, lbllaboratorio.Text, "Activo");
            cmbequipo.DataSource = ds.splistarequiposparaacutliza;
            cmbequipo.DisplayMember = "nroequipo";
            cmbequipo.ValueMember = "nroequipo";

        }
    }
}
