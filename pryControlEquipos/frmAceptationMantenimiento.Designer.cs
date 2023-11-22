namespace pryControlEquipos
{
    partial class frmAceptationMantenimiento
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
            this.gbdescripsoli = new System.Windows.Forms.GroupBox();
            this.cmbEquidef = new System.Windows.Forms.ComboBox();
            this.lbltiposol = new System.Windows.Forms.Label();
            this.lblmotivo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.btnrechazar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvlistasol = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.gbFinalizado = new System.Windows.Forms.GroupBox();
            this.cmbequifina = new System.Windows.Forms.ComboBox();
            this.lbltiposolfina = new System.Windows.Forms.Label();
            this.lblmotfina = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbDescrip = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btncerrarsoli = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.rtbfina = new System.Windows.Forms.RichTextBox();
            this.gbdescripsoli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistasol)).BeginInit();
            this.gbFinalizado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbdescripsoli
            // 
            this.gbdescripsoli.Controls.Add(this.label11);
            this.gbdescripsoli.Controls.Add(this.rtbDescrip);
            this.gbdescripsoli.Controls.Add(this.cmbEquidef);
            this.gbdescripsoli.Controls.Add(this.lbltiposol);
            this.gbdescripsoli.Controls.Add(this.lblmotivo);
            this.gbdescripsoli.Controls.Add(this.label4);
            this.gbdescripsoli.Controls.Add(this.label3);
            this.gbdescripsoli.Controls.Add(this.label2);
            this.gbdescripsoli.Controls.Add(this.btnAutorizar);
            this.gbdescripsoli.Controls.Add(this.btnrechazar);
            this.gbdescripsoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdescripsoli.Location = new System.Drawing.Point(136, 411);
            this.gbdescripsoli.Margin = new System.Windows.Forms.Padding(2);
            this.gbdescripsoli.Name = "gbdescripsoli";
            this.gbdescripsoli.Padding = new System.Windows.Forms.Padding(2);
            this.gbdescripsoli.Size = new System.Drawing.Size(726, 256);
            this.gbdescripsoli.TabIndex = 2;
            this.gbdescripsoli.TabStop = false;
            this.gbdescripsoli.Text = "Descripcion de la Solicitud";
            // 
            // cmbEquidef
            // 
            this.cmbEquidef.FormattingEnabled = true;
            this.cmbEquidef.Location = new System.Drawing.Point(554, 24);
            this.cmbEquidef.Name = "cmbEquidef";
            this.cmbEquidef.Size = new System.Drawing.Size(135, 28);
            this.cmbEquidef.TabIndex = 11;
            // 
            // lbltiposol
            // 
            this.lbltiposol.AutoSize = true;
            this.lbltiposol.Location = new System.Drawing.Point(18, 117);
            this.lbltiposol.Name = "lbltiposol";
            this.lbltiposol.Size = new System.Drawing.Size(51, 20);
            this.lbltiposol.TabIndex = 8;
            this.lbltiposol.Text = "label8";
            // 
            // lblmotivo
            // 
            this.lblmotivo.AutoSize = true;
            this.lblmotivo.Location = new System.Drawing.Point(18, 51);
            this.lblmotivo.Name = "lblmotivo";
            this.lblmotivo.Size = new System.Drawing.Size(51, 20);
            this.lblmotivo.TabIndex = 6;
            this.lblmotivo.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo Solicitud:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nº Equipos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
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
            this.btnAutorizar.Location = new System.Drawing.Point(391, 210);
            this.btnAutorizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(140, 42);
            this.btnAutorizar.TabIndex = 0;
            this.btnAutorizar.Text = "Finalizar Tarea";
            this.btnAutorizar.UseVisualStyleBackColor = false;
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // btnrechazar
            // 
            this.btnrechazar.BackColor = System.Drawing.Color.SlateGray;
            this.btnrechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrechazar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrechazar.Location = new System.Drawing.Point(184, 210);
            this.btnrechazar.Margin = new System.Windows.Forms.Padding(2);
            this.btnrechazar.Name = "btnrechazar";
            this.btnrechazar.Size = new System.Drawing.Size(127, 42);
            this.btnrechazar.TabIndex = 1;
            this.btnrechazar.Text = "Cancelar";
            this.btnrechazar.UseVisualStyleBackColor = false;
            this.btnrechazar.Click += new System.EventHandler(this.btnrechazar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, -32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "LISTA DE SOLICITUDES";
            // 
            // dgvlistasol
            // 
            this.dgvlistasol.AllowUserToAddRows = false;
            this.dgvlistasol.AllowUserToDeleteRows = false;
            this.dgvlistasol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistasol.Location = new System.Drawing.Point(136, 75);
            this.dgvlistasol.Margin = new System.Windows.Forms.Padding(2);
            this.dgvlistasol.Name = "dgvlistasol";
            this.dgvlistasol.ReadOnly = true;
            this.dgvlistasol.RowHeadersVisible = false;
            this.dgvlistasol.RowTemplate.Height = 24;
            this.dgvlistasol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistasol.Size = new System.Drawing.Size(726, 332);
            this.dgvlistasol.TabIndex = 3;
            this.dgvlistasol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistasol_CellContentClick);
            this.dgvlistasol.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvlistasol_DataBindingComplete);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "LISTA DE SOLICITUDES VIGENTES";
            // 
            // gbFinalizado
            // 
            this.gbFinalizado.Controls.Add(this.label12);
            this.gbFinalizado.Controls.Add(this.rtbfina);
            this.gbFinalizado.Controls.Add(this.btncerrarsoli);
            this.gbFinalizado.Controls.Add(this.cmbequifina);
            this.gbFinalizado.Controls.Add(this.lbltiposolfina);
            this.gbFinalizado.Controls.Add(this.lblmotfina);
            this.gbFinalizado.Controls.Add(this.label8);
            this.gbFinalizado.Controls.Add(this.label9);
            this.gbFinalizado.Controls.Add(this.label10);
            this.gbFinalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFinalizado.Location = new System.Drawing.Point(133, 411);
            this.gbFinalizado.Margin = new System.Windows.Forms.Padding(2);
            this.gbFinalizado.Name = "gbFinalizado";
            this.gbFinalizado.Padding = new System.Windows.Forms.Padding(2);
            this.gbFinalizado.Size = new System.Drawing.Size(726, 256);
            this.gbFinalizado.TabIndex = 6;
            this.gbFinalizado.TabStop = false;
            this.gbFinalizado.Text = "Descripcion de la Solicitud";
            // 
            // cmbequifina
            // 
            this.cmbequifina.FormattingEnabled = true;
            this.cmbequifina.Location = new System.Drawing.Point(577, 38);
            this.cmbequifina.Name = "cmbequifina";
            this.cmbequifina.Size = new System.Drawing.Size(135, 28);
            this.cmbequifina.TabIndex = 11;
            // 
            // lbltiposolfina
            // 
            this.lbltiposolfina.AutoSize = true;
            this.lbltiposolfina.Location = new System.Drawing.Point(16, 132);
            this.lbltiposolfina.Name = "lbltiposolfina";
            this.lbltiposolfina.Size = new System.Drawing.Size(51, 20);
            this.lbltiposolfina.TabIndex = 8;
            this.lbltiposolfina.Text = "label8";
            // 
            // lblmotfina
            // 
            this.lblmotfina.AutoSize = true;
            this.lblmotfina.Location = new System.Drawing.Point(16, 66);
            this.lblmotfina.Name = "lblmotfina";
            this.lblmotfina.Size = new System.Drawing.Size(51, 20);
            this.lblmotfina.TabIndex = 6;
            this.lblmotfina.Text = "label6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tipo Solicitud:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nº Equipos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Motivos:";
            // 
            // rtbDescrip
            // 
            this.rtbDescrip.Location = new System.Drawing.Point(443, 87);
            this.rtbDescrip.Name = "rtbDescrip";
            this.rtbDescrip.Size = new System.Drawing.Size(278, 107);
            this.rtbDescrip.TabIndex = 7;
            this.rtbDescrip.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(439, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Descripcion:";
            // 
            // btncerrarsoli
            // 
            this.btncerrarsoli.BackColor = System.Drawing.Color.SlateGray;
            this.btncerrarsoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrarsoli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncerrarsoli.Location = new System.Drawing.Point(266, 197);
            this.btncerrarsoli.Margin = new System.Windows.Forms.Padding(2);
            this.btncerrarsoli.Name = "btncerrarsoli";
            this.btncerrarsoli.Size = new System.Drawing.Size(127, 42);
            this.btncerrarsoli.TabIndex = 12;
            this.btncerrarsoli.Text = "Cerrar";
            this.btncerrarsoli.UseVisualStyleBackColor = false;
            this.btncerrarsoli.Click += new System.EventHandler(this.btncerrarsoli_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(430, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Descripcion:";
            // 
            // rtbfina
            // 
            this.rtbfina.Location = new System.Drawing.Point(434, 99);
            this.rtbfina.Name = "rtbfina";
            this.rtbfina.Size = new System.Drawing.Size(278, 107);
            this.rtbfina.TabIndex = 13;
            this.rtbfina.Text = "";
            // 
            // frmAceptationMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 713);
            this.Controls.Add(this.gbFinalizado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbdescripsoli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvlistasol);
            this.Name = "frmAceptationMantenimiento";
            this.Text = "frmAceptationMantenimiento";
            this.Load += new System.EventHandler(this.frmAceptationMantenimiento_Load);
            this.gbdescripsoli.ResumeLayout(false);
            this.gbdescripsoli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistasol)).EndInit();
            this.gbFinalizado.ResumeLayout(false);
            this.gbFinalizado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdescripsoli;
        private System.Windows.Forms.ComboBox cmbEquidef;
        private System.Windows.Forms.Label lbltiposol;
        private System.Windows.Forms.Label lblmotivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.Button btnrechazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvlistasol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtbDescrip;
        private System.Windows.Forms.GroupBox gbFinalizado;
        private System.Windows.Forms.ComboBox cmbequifina;
        private System.Windows.Forms.Label lbltiposolfina;
        private System.Windows.Forms.Label lblmotfina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtbfina;
        private System.Windows.Forms.Button btncerrarsoli;
    }
}