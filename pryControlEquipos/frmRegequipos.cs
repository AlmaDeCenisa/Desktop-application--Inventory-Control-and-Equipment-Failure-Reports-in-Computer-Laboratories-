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
    public partial class frmRegequipos : Form
    {

        DSbdcontrolappslab ds = new DSbdcontrolappslab();
        DSbdcontrolappslabTableAdapters.laboratorioTableAdapter Tlab = new DSbdcontrolappslabTableAdapters.laboratorioTableAdapter();
        DSbdcontrolappslabTableAdapters.QueriesTableAdapter Tprocedimientso = new DSbdcontrolappslabTableAdapters.QueriesTableAdapter();

        public frmRegequipos()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void frmRegequipos_Load(object sender, EventArgs e)
        {
            Tlab.Fill(ds.laboratorio);
            grpReglab.Visible = false;
            cmblabs.DataSource = ds.laboratorio;
            cmblabs.DisplayMember = "nrolab";
            cmblabs.ValueMember = "nrolab";


        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            grpReglab.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grpReglab.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tprocedimientso.spinsertarlab(txtLaboratorio.Text);
            MessageBox.Show("Laboratorio insertado correctamente");
            Tlab.Fill(ds.laboratorio);
        }

        private void cmblabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmblabs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbllaboratorio.Text = cmblabs.SelectedValue.ToString();
        }

        private void btnagregarequipoi_Click(object sender, EventArgs e)
        {
            
            dgvNroequpo.Rows.Add(lbllaboratorio.Text + "-" + numequi.Value.ToString(), "Activo");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int fila = 0; fila < dgvNroequpo.Rows.Count; fila++)
            {
                Tprocedimientso.SPINSERTAREQUIPO(dgvNroequpo.Rows[fila].Cells[0].Value.ToString(), dgvNroequpo.Rows[fila].Cells[1].Value.ToString(),lbllaboratorio.Text);
                MessageBox.Show("Resgistro Correcto");
            }
         
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            dgvNroequpo.Rows.Remove(dgvNroequpo.SelectedRows[0]);
        }
    }
}
