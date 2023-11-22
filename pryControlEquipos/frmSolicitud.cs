using MySql.Data.MySqlClient;
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
    public partial class frmSolicitud : Form
    {
        
        DSbdcontrolappslab ds = new DSbdcontrolappslab();
        DSbdcontrolappslabTableAdapters.laboratorioTableAdapter Tlab = new DSbdcontrolappslabTableAdapters.laboratorioTableAdapter();
        DSbdcontrolappslabTableAdapters.spListarDocenteTableAdapter Tdocente = new DSbdcontrolappslabTableAdapters.spListarDocenteTableAdapter();
        DSbdcontrolappslabTableAdapters.tiposolTableAdapter TtipoSolicitud = new DSbdcontrolappslabTableAdapters.tiposolTableAdapter();
        DSbdcontrolappslabTableAdapters.motivoTableAdapter Tmotivo = new DSbdcontrolappslabTableAdapters.motivoTableAdapter();
        DSbdcontrolappslabTableAdapters.spBuscarEquipoXEstadoTableAdapter Tbusequi = new DSbdcontrolappslabTableAdapters.spBuscarEquipoXEstadoTableAdapter();
        DSbdcontrolappslabTableAdapters.QueriesTableAdapter Tprocedimientos = new DSbdcontrolappslabTableAdapters.QueriesTableAdapter();
        DSbdcontrolappslabTableAdapters.solicitudTableAdapter tsolicitud = new DSbdcontrolappslabTableAdapters.solicitudTableAdapter();
        public frmSolicitud()
        {
            InitializeComponent();

        }
        //int numsol = 0;
        private void frmSolicitud_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.Date.ToShortDateString();
            lblhora.Text = DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss");
            Tlab.Fill(ds.laboratorio);
            Tdocente.Fill(ds.spListarDocente);
            TtipoSolicitud.Fill(ds.tiposol);
            Tmotivo.Fill(ds.motivo);
            Tbusequi.Fill(ds.spBuscarEquipoXEstado,"Activo","%","%");
            tsolicitud.Fill(ds.solicitud);
            dgvequipo.DataSource = ds.spBuscarEquipoXEstado;
            cmbLab.DataSource = ds.laboratorio;
            cmbLab.DisplayMember = "nrolab";
            cmbLab.ValueMember = "nrolab";

            cmbDocente.DataSource = ds.spListarDocente;
            cmbDocente.DisplayMember = "nombrecompleto";
            cmbDocente.ValueMember = "codRP";

            cmbMotsol.DataSource = ds.motivo;
            cmbMotsol.DisplayMember = "descripmot";
            cmbMotsol.ValueMember = "codmot";

            cmbtiposol.DataSource = ds.tiposol;
            cmbtiposol.DisplayMember = "descriptiposol";
            cmbtiposol.ValueMember = "codtiposol";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbLab_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Tbusequi.Fill(ds.spBuscarEquipoXEstado, "Activo", "%",cmbLab.SelectedValue.ToString());
        }

        private void txtbusequi_TextChanged(object sender, EventArgs e)
        {
            Tbusequi.Fill(ds.spBuscarEquipoXEstado, "Activo",txtbusequi.Text+"%", "%");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelmotivo.Visible = true;
         }

        private void btnañadirmot_Click(object sender, EventArgs e)
        {
            if (txtdescripmot.Text == "") { 
                MessageBox.Show("Inerte motivo");
            }
            else { 
            Tprocedimientos.spInsertarMotivo(txtdescripmot.Text);
            }
            Tmotivo.Fill(ds.motivo);
            panelmotivo.Visible = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            panelmotivo.Visible = false;
        }

        private void btnagregarequipo_Click(object sender, EventArgs e)
        {
                dgvagregarequipo.Rows.Add(dgvequipo.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            // string hora = DateTime.Now.ToString("h:mm:ss");
            TimeSpan hora = DateTime.Now.TimeOfDay;
            Tprocedimientos.spInsertarSolicitud(hora, null, DBNull.Value, Convert.ToInt16(cmbMotsol.SelectedValue), Convert.ToInt16(cmbtiposol.SelectedValue));
            tsolicitud.Fill(ds.solicitud);
            int idnrosol = Convert.ToInt32(ds.solicitud.Rows[ds.solicitud.Rows.Count - 1].ItemArray[0]);
            Tprocedimientos.spInsertarGenera(Convert.ToInt16(cmbDocente.SelectedValue), idnrosol);

            for (int fila = 0; fila < dgvagregarequipo.Rows.Count; fila++)
            {
                Tprocedimientos.spInsertarincluye(idnrosol, dgvagregarequipo.Rows[fila].Cells[0].Value.ToString());

            }
            frmComprobantedeSol frm = new frmComprobantedeSol();
            frm.Tag = idnrosol;
            frm.ShowDialog();
            //MessageBox.Show("Registro ingresado correctamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRsolcitudesporfecha frm = new frmRsolcitudesporfecha();
            frm.ShowDialog();
        }
    }
    }
   
