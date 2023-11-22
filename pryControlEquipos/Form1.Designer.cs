namespace pryControlEquipos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dgvdocentes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcoincide = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStado = new System.Windows.Forms.Label();
            this.lblStadorepite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(24, 80);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(139, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Completo";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(22, 134);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(141, 20);
            this.txttelefono.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.SlateGray;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnguardar.Location = new System.Drawing.Point(244, 255);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(140, 38);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "REGISTRAR";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dgvdocentes
            // 
            this.dgvdocentes.AllowUserToAddRows = false;
            this.dgvdocentes.AllowUserToDeleteRows = false;
            this.dgvdocentes.AllowUserToOrderColumns = true;
            this.dgvdocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdocentes.Location = new System.Drawing.Point(22, 311);
            this.dgvdocentes.Name = "dgvdocentes";
            this.dgvdocentes.ReadOnly = true;
            this.dgvdocentes.RowHeadersVisible = false;
            this.dgvdocentes.Size = new System.Drawing.Size(573, 289);
            this.dgvdocentes.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "REGISTRO DE DOCENTE";
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(22, 192);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(141, 21);
            this.cmbRol.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Rol";
            // 
            // txtcoincide
            // 
            this.txtcoincide.Location = new System.Drawing.Point(319, 193);
            this.txtcoincide.Name = "txtcoincide";
            this.txtcoincide.PasswordChar = '*';
            this.txtcoincide.Size = new System.Drawing.Size(141, 20);
            this.txtcoincide.TabIndex = 26;
            this.txtcoincide.TextChanged += new System.EventHandler(this.txtcoincide_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Repite Contraseña";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(319, 134);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(141, 20);
            this.txtcontraseña.TabIndex = 24;
            this.txtcontraseña.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Contraseña";
            // 
            // txtuuario
            // 
            this.txtuuario.Location = new System.Drawing.Point(319, 80);
            this.txtuuario.Name = "txtuuario";
            this.txtuuario.Size = new System.Drawing.Size(141, 20);
            this.txtuuario.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Usuario";
            // 
            // lblStado
            // 
            this.lblStado.AutoSize = true;
            this.lblStado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStado.Location = new System.Drawing.Point(299, 161);
            this.lblStado.Name = "lblStado";
            this.lblStado.Size = new System.Drawing.Size(15, 13);
            this.lblStado.TabIndex = 29;
            this.lblStado.Text = "..";
            // 
            // lblStadorepite
            // 
            this.lblStadorepite.AutoSize = true;
            this.lblStadorepite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadorepite.Location = new System.Drawing.Point(319, 216);
            this.lblStadorepite.Name = "lblStadorepite";
            this.lblStadorepite.Size = new System.Drawing.Size(15, 13);
            this.lblStadorepite.TabIndex = 30;
            this.lblStadorepite.Text = "..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(632, 612);
            this.Controls.Add(this.lblStadorepite);
            this.Controls.Add(this.lblStado);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcoincide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtuuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvdocentes);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dgvdocentes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcoincide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStado;
        private System.Windows.Forms.Label lblStadorepite;
    }
}

