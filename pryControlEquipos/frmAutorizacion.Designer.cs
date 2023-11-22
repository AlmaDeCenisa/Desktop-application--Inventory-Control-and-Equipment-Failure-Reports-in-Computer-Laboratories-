namespace pryControlEquipos
{
    partial class frmAutorizacion
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
            this.dgvlistasol = new System.Windows.Forms.DataGridView();
            this.gbdescripsoli = new System.Windows.Forms.GroupBox();
            this.cmbEquidef = new System.Windows.Forms.ComboBox();
            this.lbltiposol = new System.Windows.Forms.Label();
            this.lblmotivo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.btnrechazar = new System.Windows.Forms.Button();
            this.rbtnsolicitado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnAutorizado = new System.Windows.Forms.RadioButton();
            this.rbtnFinalizado = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistasol)).BeginInit();
            this.gbdescripsoli.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA DE SOLICITUDES NO AUTORIZADAS";
            // 
            // dgvlistasol
            // 
            this.dgvlistasol.AllowUserToAddRows = false;
            this.dgvlistasol.AllowUserToDeleteRows = false;
            this.dgvlistasol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistasol.Location = new System.Drawing.Point(118, 101);
            this.dgvlistasol.Margin = new System.Windows.Forms.Padding(2);
            this.dgvlistasol.Name = "dgvlistasol";
            this.dgvlistasol.ReadOnly = true;
            this.dgvlistasol.RowHeadersVisible = false;
            this.dgvlistasol.RowTemplate.Height = 24;
            this.dgvlistasol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistasol.Size = new System.Drawing.Size(606, 332);
            this.dgvlistasol.TabIndex = 0;
            this.dgvlistasol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistasol_CellContentClick);
            // 
            // gbdescripsoli
            // 
            this.gbdescripsoli.Controls.Add(this.cmbEquidef);
            this.gbdescripsoli.Controls.Add(this.lbltiposol);
            this.gbdescripsoli.Controls.Add(this.lblmotivo);
            this.gbdescripsoli.Controls.Add(this.label4);
            this.gbdescripsoli.Controls.Add(this.label3);
            this.gbdescripsoli.Controls.Add(this.label2);
            this.gbdescripsoli.Controls.Add(this.btnAutorizar);
            this.gbdescripsoli.Controls.Add(this.btnrechazar);
            this.gbdescripsoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdescripsoli.Location = new System.Drawing.Point(63, 442);
            this.gbdescripsoli.Margin = new System.Windows.Forms.Padding(2);
            this.gbdescripsoli.Name = "gbdescripsoli";
            this.gbdescripsoli.Padding = new System.Windows.Forms.Padding(2);
            this.gbdescripsoli.Size = new System.Drawing.Size(726, 247);
            this.gbdescripsoli.TabIndex = 0;
            this.gbdescripsoli.TabStop = false;
            this.gbdescripsoli.Text = "Descripcion de la Solicitud";
            // 
            // cmbEquidef
            // 
            this.cmbEquidef.FormattingEnabled = true;
            this.cmbEquidef.Location = new System.Drawing.Point(577, 38);
            this.cmbEquidef.Name = "cmbEquidef";
            this.cmbEquidef.Size = new System.Drawing.Size(135, 28);
            this.cmbEquidef.TabIndex = 11;
            // 
            // lbltiposol
            // 
            this.lbltiposol.AutoSize = true;
            this.lbltiposol.Location = new System.Drawing.Point(16, 132);
            this.lbltiposol.Name = "lbltiposol";
            this.lbltiposol.Size = new System.Drawing.Size(51, 20);
            this.lbltiposol.TabIndex = 8;
            this.lbltiposol.Text = "label8";
            // 
            // lblmotivo
            // 
            this.lblmotivo.AutoSize = true;
            this.lblmotivo.Location = new System.Drawing.Point(16, 66);
            this.lblmotivo.Name = "lblmotivo";
            this.lblmotivo.Size = new System.Drawing.Size(51, 20);
            this.lblmotivo.TabIndex = 6;
            this.lblmotivo.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo Solicitud:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nº Equipos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motivos:";
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.BackColor = System.Drawing.Color.SlateGray;
            this.btnAutorizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutorizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAutorizar.Location = new System.Drawing.Point(405, 195);
            this.btnAutorizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(122, 42);
            this.btnAutorizar.TabIndex = 0;
            this.btnAutorizar.Text = "Autorizar";
            this.btnAutorizar.UseVisualStyleBackColor = false;
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // btnrechazar
            // 
            this.btnrechazar.BackColor = System.Drawing.Color.SlateGray;
            this.btnrechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrechazar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrechazar.Location = new System.Drawing.Point(214, 195);
            this.btnrechazar.Margin = new System.Windows.Forms.Padding(2);
            this.btnrechazar.Name = "btnrechazar";
            this.btnrechazar.Size = new System.Drawing.Size(127, 42);
            this.btnrechazar.TabIndex = 1;
            this.btnrechazar.Text = "Cancelar";
            this.btnrechazar.UseVisualStyleBackColor = false;
            this.btnrechazar.Click += new System.EventHandler(this.btnrechazar_Click);
            // 
            // rbtnsolicitado
            // 
            this.rbtnsolicitado.AutoSize = true;
            this.rbtnsolicitado.Location = new System.Drawing.Point(22, 13);
            this.rbtnsolicitado.Name = "rbtnsolicitado";
            this.rbtnsolicitado.Size = new System.Drawing.Size(71, 17);
            this.rbtnsolicitado.TabIndex = 2;
            this.rbtnsolicitado.TabStop = true;
            this.rbtnsolicitado.Text = "Solicitado";
            this.rbtnsolicitado.UseVisualStyleBackColor = true;
            this.rbtnsolicitado.CheckedChanged += new System.EventHandler(this.rbtnsolicitado_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFinalizado);
            this.groupBox1.Controls.Add(this.rbtnAutorizado);
            this.groupBox1.Controls.Add(this.rbtnsolicitado);
            this.groupBox1.Location = new System.Drawing.Point(118, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 36);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // rbtnAutorizado
            // 
            this.rbtnAutorizado.AutoSize = true;
            this.rbtnAutorizado.Location = new System.Drawing.Point(133, 13);
            this.rbtnAutorizado.Name = "rbtnAutorizado";
            this.rbtnAutorizado.Size = new System.Drawing.Size(75, 17);
            this.rbtnAutorizado.TabIndex = 3;
            this.rbtnAutorizado.TabStop = true;
            this.rbtnAutorizado.Text = "Autorizado";
            this.rbtnAutorizado.UseVisualStyleBackColor = true;
            this.rbtnAutorizado.CheckedChanged += new System.EventHandler(this.rbtnAutorizado_CheckedChanged);
            // 
            // rbtnFinalizado
            // 
            this.rbtnFinalizado.AutoSize = true;
            this.rbtnFinalizado.Location = new System.Drawing.Point(252, 13);
            this.rbtnFinalizado.Name = "rbtnFinalizado";
            this.rbtnFinalizado.Size = new System.Drawing.Size(72, 17);
            this.rbtnFinalizado.TabIndex = 4;
            this.rbtnFinalizado.TabStop = true;
            this.rbtnFinalizado.Text = "Finalizado";
            this.rbtnFinalizado.UseVisualStyleBackColor = true;
            this.rbtnFinalizado.CheckedChanged += new System.EventHandler(this.rbtnFinalizado_CheckedChanged);
            // 
            // frmAutorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(829, 693);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbdescripsoli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvlistasol);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAutorizacion";
            this.Text = "frmAutorizacion";
            this.Load += new System.EventHandler(this.frmAutorizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistasol)).EndInit();
            this.gbdescripsoli.ResumeLayout(false);
            this.gbdescripsoli.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvlistasol;
        private System.Windows.Forms.GroupBox gbdescripsoli;
        private System.Windows.Forms.ComboBox cmbEquidef;
        private System.Windows.Forms.Label lbltiposol;
        private System.Windows.Forms.Label lblmotivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.Button btnrechazar;
        private System.Windows.Forms.RadioButton rbtnsolicitado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFinalizado;
        private System.Windows.Forms.RadioButton rbtnAutorizado;
    }
}