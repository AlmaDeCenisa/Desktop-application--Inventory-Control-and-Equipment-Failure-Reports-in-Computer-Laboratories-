namespace pryControlEquipos
{
    partial class frmSolicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLab = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvequipo = new System.Windows.Forms.DataGridView();
            this.txtbusequi = new System.Windows.Forms.TextBox();
            this.dgvagregarequipo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregarequipo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDocente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMotsol = new System.Windows.Forms.ComboBox();
            this.btnañadir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbtiposol = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelmotivo = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtdescripmot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnañadirmot = new System.Windows.Forms.Button();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvagregarequipo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelmotivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FECHA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HORA:";
            // 
            // cmbLab
            // 
            this.cmbLab.FormattingEnabled = true;
            this.cmbLab.Location = new System.Drawing.Point(6, 37);
            this.cmbLab.Name = "cmbLab";
            this.cmbLab.Size = new System.Drawing.Size(121, 21);
            this.cmbLab.TabIndex = 2;
            this.cmbLab.SelectionChangeCommitted += new System.EventHandler(this.cmbLab_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione Laboratorio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Buscar Equipo";
            // 
            // dgvequipo
            // 
            this.dgvequipo.AllowUserToAddRows = false;
            this.dgvequipo.AllowUserToDeleteRows = false;
            this.dgvequipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvequipo.Location = new System.Drawing.Point(8, 120);
            this.dgvequipo.Name = "dgvequipo";
            this.dgvequipo.ReadOnly = true;
            this.dgvequipo.RowHeadersVisible = false;
            this.dgvequipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvequipo.Size = new System.Drawing.Size(250, 150);
            this.dgvequipo.TabIndex = 5;
            // 
            // txtbusequi
            // 
            this.txtbusequi.Location = new System.Drawing.Point(8, 94);
            this.txtbusequi.Name = "txtbusequi";
            this.txtbusequi.Size = new System.Drawing.Size(100, 20);
            this.txtbusequi.TabIndex = 6;
            this.txtbusequi.TextChanged += new System.EventHandler(this.txtbusequi_TextChanged);
            // 
            // dgvagregarequipo
            // 
            this.dgvagregarequipo.AllowUserToAddRows = false;
            this.dgvagregarequipo.AllowUserToDeleteRows = false;
            this.dgvagregarequipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvagregarequipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvagregarequipo.Location = new System.Drawing.Point(337, 120);
            this.dgvagregarequipo.Name = "dgvagregarequipo";
            this.dgvagregarequipo.ReadOnly = true;
            this.dgvagregarequipo.RowHeadersVisible = false;
            this.dgvagregarequipo.Size = new System.Drawing.Size(204, 150);
            this.dgvagregarequipo.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero Equipo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnagregarequipo
            // 
            this.btnagregarequipo.Location = new System.Drawing.Point(261, 184);
            this.btnagregarequipo.Name = "btnagregarequipo";
            this.btnagregarequipo.Size = new System.Drawing.Size(72, 37);
            this.btnagregarequipo.TabIndex = 8;
            this.btnagregarequipo.Text = "Agregar Equipos";
            this.btnagregarequipo.UseVisualStyleBackColor = true;
            this.btnagregarequipo.Click += new System.EventHandler(this.btnagregarequipo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Docente Solicitante";
            // 
            // cmbDocente
            // 
            this.cmbDocente.FormattingEnabled = true;
            this.cmbDocente.Location = new System.Drawing.Point(5, 38);
            this.cmbDocente.Name = "cmbDocente";
            this.cmbDocente.Size = new System.Drawing.Size(151, 21);
            this.cmbDocente.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Motivos de Solicitud";
            // 
            // cmbMotsol
            // 
            this.cmbMotsol.FormattingEnabled = true;
            this.cmbMotsol.Location = new System.Drawing.Point(161, 37);
            this.cmbMotsol.Name = "cmbMotsol";
            this.cmbMotsol.Size = new System.Drawing.Size(138, 21);
            this.cmbMotsol.TabIndex = 11;
            // 
            // btnañadir
            // 
            this.btnañadir.Location = new System.Drawing.Point(304, 35);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(75, 23);
            this.btnañadir.TabIndex = 13;
            this.btnañadir.Text = "AÑADIR";
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo Solicitud";
            // 
            // cmbtiposol
            // 
            this.cmbtiposol.FormattingEnabled = true;
            this.cmbtiposol.Location = new System.Drawing.Point(424, 37);
            this.cmbtiposol.Name = "cmbtiposol";
            this.cmbtiposol.Size = new System.Drawing.Size(121, 21);
            this.cmbtiposol.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvequipo);
            this.groupBox1.Controls.Add(this.cmbLab);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbusequi);
            this.groupBox1.Controls.Add(this.dgvagregarequipo);
            this.groupBox1.Controls.Add(this.btnagregarequipo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 301);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALLE SOLICITUD";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.SlateGray;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnguardar.Location = new System.Drawing.Point(348, 497);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(134, 58);
            this.btnguardar.TabIndex = 16;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelmotivo);
            this.groupBox2.Controls.Add(this.cmbDocente);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnañadir);
            this.groupBox2.Controls.Add(this.cmbMotsol);
            this.groupBox2.Controls.Add(this.cmbtiposol);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(44, 391);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(569, 87);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Solicitud";
            // 
            // panelmotivo
            // 
            this.panelmotivo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelmotivo.Controls.Add(this.btncancelar);
            this.panelmotivo.Controls.Add(this.txtdescripmot);
            this.panelmotivo.Controls.Add(this.label8);
            this.panelmotivo.Controls.Add(this.btnañadirmot);
            this.panelmotivo.Location = new System.Drawing.Point(161, 1);
            this.panelmotivo.Margin = new System.Windows.Forms.Padding(2);
            this.panelmotivo.Name = "panelmotivo";
            this.panelmotivo.Size = new System.Drawing.Size(237, 81);
            this.panelmotivo.TabIndex = 18;
            this.panelmotivo.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(18, 55);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 19;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtdescripmot
            // 
            this.txtdescripmot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripmot.Location = new System.Drawing.Point(89, 18);
            this.txtdescripmot.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescripmot.Name = "txtdescripmot";
            this.txtdescripmot.Size = new System.Drawing.Size(137, 22);
            this.txtdescripmot.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Descripcion";
            // 
            // btnañadirmot
            // 
            this.btnañadirmot.Location = new System.Drawing.Point(151, 55);
            this.btnañadirmot.Name = "btnañadirmot";
            this.btnañadirmot.Size = new System.Drawing.Size(75, 23);
            this.btnañadirmot.TabIndex = 16;
            this.btnañadirmot.Text = "AÑADIR";
            this.btnañadirmot.UseVisualStyleBackColor = true;
            this.btnañadirmot.Click += new System.EventHandler(this.btnañadirmot_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(78, 18);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(45, 13);
            this.lblfecha.TabIndex = 18;
            this.lblfecha.Text = "FECHA:";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(247, 18);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(41, 13);
            this.lblhora.TabIndex = 19;
            this.lblhora.Text = "HORA:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(98, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 58);
            this.button1.TabIndex = 20;
            this.button1.Text = "ESTADO DE SOLICITUDES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(637, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSolicitud";
            this.Load += new System.EventHandler(this.frmSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvagregarequipo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelmotivo.ResumeLayout(false);
            this.panelmotivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvequipo;
        private System.Windows.Forms.TextBox txtbusequi;
        private System.Windows.Forms.DataGridView dgvagregarequipo;
        private System.Windows.Forms.Button btnagregarequipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDocente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMotsol;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbtiposol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelmotivo;
        private System.Windows.Forms.Button btnañadirmot;
        private System.Windows.Forms.TextBox txtdescripmot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Button button1;
    }
}