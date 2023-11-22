using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace pryControlEquipos
{
    public partial class frmlogin : Form
    {
        DSbdcontrolappslab ds = new DSbdcontrolappslab();
        DSbdcontrolappslabTableAdapters.spverifcontraseniaTableAdapter Tusuario = new DSbdcontrolappslabTableAdapters.spverifcontraseniaTableAdapter();

        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
        private string GetMD5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
        private void btningresar_Click(object sender, EventArgs e)
        {
                Tusuario.Fill(ds.spverifcontrasenia, txtUsuario.Text, GetMD5Hash (txtContraseña.Text));
            //MessageBox.Show(ds.spverifcontrasenia.Rows[0].ItemArray[0].ToString());
            if (ds.spverifcontrasenia.Rows.Count > 0)
            {
                frmMenu frm = new frmMenu();
                frm.Show();
                if (ds.spverifcontrasenia.Rows[0].ItemArray[0].ToString() == "Rector")
                {
                    frm.rectorToolStripMenuItem.Visible = true;

                }

                if (ds.spverifcontrasenia.Rows[0].ItemArray[0].ToString() == "Jefelab")
                {
                    frm.jefeLabToolStripMenuItem.Visible = true;

                }
                
                 if (ds.spverifcontrasenia.Rows[0].ItemArray[0].ToString() == "Docente")
                {
                    frm.docenteToolStripMenuItem.Visible = true;

                }

            }
            else
            {
             MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtalo nuevamente.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

