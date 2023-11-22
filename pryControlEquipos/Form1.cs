using System;
using System.Security.Cryptography;

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DSbdcontrolappslab ds = new DSbdcontrolappslab();
        DSbdcontrolappslabTableAdapters.docenteTableAdapter Tdocente = new DSbdcontrolappslabTableAdapters.docenteTableAdapter();
        DSbdcontrolappslabTableAdapters.spListarDocenteTableAdapter TlistarDoc = new DSbdcontrolappslabTableAdapters.spListarDocenteTableAdapter();
        //DSbdejemplo1TableAdapters.docenteTableAdapter Tdocente = new DSbdejemplo1TableAdapters.docenteTableAdapter();
        //DSbdejemplo1TableAdapters.spListarDocenteTableAdapter TlistarDoc = new DSbdejemplo1TableAdapters.spListarDocenteTableAdapter();
        DSbdcontrolappslabTableAdapters.spListarRolTableAdapter Trol = new DSbdcontrolappslabTableAdapters.spListarRolTableAdapter();
        private void Form1_Load(object sender, EventArgs e)
        {
            TlistarDoc.Fill(ds.spListarDocente);
            dgvdocentes.DataSource = ds.spListarDocente;
            Trol.Fill(ds.spListarRol);
            cmbRol.DataSource = ds.spListarRol;
            cmbRol.DisplayMember = "roles";
            cmbRol.ValueMember = "idrol";
            btnguardar.Enabled = false;

        }

       private bool AlgoritmoContraseñaSegura(string password)
        {
            bool mayuscula = false, minuscula = false, numero = false, carespecial = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password, i))
                {
                    mayuscula = true;
                }
                else if (Char.IsLower(password, i))
                {
                    minuscula = true;
                }
                else if (Char.IsDigit(password, i))
                {
                    numero = true;
                }
                else
                {
                    carespecial = true;
                }
            }
            if (mayuscula && minuscula && numero && carespecial && password.Length >= 8)
            {
                return true;
            }
            return false;
        }

     

        private bool ContieneMayuscula(string contraseña)
        {
            return contraseña.Any(char.IsUpper);
        }

        private bool ContieneMinuscula(string contraseña)
        {
            return contraseña.Any(char.IsLower);
        }

        private bool ContieneNumero(string contraseña)
        {
            return contraseña.Any(char.IsDigit);
        }

        private bool ContieneCaracterEspecial(string contraseña)
        {
            return contraseña.Any(c => !char.IsLetterOrDigit(c));
        }
        private string ObtenerTextoFaltante(string contraseña)
        {
            string textoFaltante = "";

            if (!ContieneMayuscula(contraseña))
            {
                textoFaltante += "mayúscula, ";
            }

            if (!ContieneMinuscula(contraseña))
            {
                textoFaltante += "minúscula, ";
            }

            if (!ContieneNumero(contraseña))
            {
                textoFaltante += "número, ";
            }

            if (!ContieneCaracterEspecial(contraseña))
            {
                textoFaltante += "carácter especial, ";
            }

            if (contraseña.Length < 8)
            {
                textoFaltante += "más caracteres, ";
            }

            // Eliminar la coma y el espacio extra al final del texto
            if (!string.IsNullOrEmpty(textoFaltante))
            {
                textoFaltante = textoFaltante.TrimEnd(',', ' ');
            }

            return textoFaltante;
        }
        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
           
            bool contraseñaSegura = AlgoritmoContraseñaSegura(txtcontraseña.Text);

            if (!contraseñaSegura)
            {
                string textoFaltante = ObtenerTextoFaltante(txtcontraseña.Text);
                lblStado.Text = "Falta: " + textoFaltante;
            }
            else
            {
                lblStado.Text = "La contraseña es segura.";
                
            }
        }

        private void txtcoincide_TextChanged(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == txtcoincide.Text)
            {
                lblStadorepite.Text = "Las contraseñas coinciden coinciden";
                btnguardar.Enabled = true;
            }
            else {
                lblStadorepite.Text = "Las contraseñas no coinciden";
            }
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
        private void btnguardar_Click(object sender, EventArgs e)
        {

            try
            {
                Tdocente.Insert(txtnombre.Text, txttelefono.Text, txtuuario.Text, GetMD5Hash(txtcontraseña.Text), Convert.ToInt16(cmbRol.SelectedValue));
                TlistarDoc.Fill(ds.spListarDocente);

                // Mostrar mensaje de éxito
                MessageBox.Show("La inserción se realizó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show("Error al realizar la inserción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
