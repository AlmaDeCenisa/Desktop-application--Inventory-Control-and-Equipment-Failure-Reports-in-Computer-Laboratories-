namespace pryControlEquipos
{
    partial class frmmodificarsolicitud
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
            this.GboxDescripSoli = new System.Windows.Forms.GroupBox();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.cmbmoti = new System.Windows.Forms.ComboBox();
            this.cmbtiposol = new System.Windows.Forms.ComboBox();
            this.lbldocente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbllaboratorio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvsolicitud = new System.Windows.Forms.DataGridView();
            this.txtdocente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvequipos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnquitar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbequipo = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GboxDescripSoli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipos)).BeginInit();
            this.SuspendLayout();
            // 
            // GboxDescripSoli
            // 
            this.GboxDescripSoli.Controls.Add(this.lblhora);
            this.GboxDescripSoli.Controls.Add(this.lblfecha);
            this.GboxDescripSoli.Controls.Add(this.cmbmoti);
            this.GboxDescripSoli.Controls.Add(this.cmbtiposol);
            this.GboxDescripSoli.Controls.Add(this.lbldocente);
            this.GboxDescripSoli.Controls.Add(this.label9);
            this.GboxDescripSoli.Controls.Add(this.label8);
            this.GboxDescripSoli.Controls.Add(this.lbllaboratorio);
            this.GboxDescripSoli.Controls.Add(this.label5);
            this.GboxDescripSoli.Controls.Add(this.label4);
            this.GboxDescripSoli.Controls.Add(this.label3);
            this.GboxDescripSoli.Controls.Add(this.label2);
            this.GboxDescripSoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxDescripSoli.Location = new System.Drawing.Point(33, 323);
            this.GboxDescripSoli.Margin = new System.Windows.Forms.Padding(2);
            this.GboxDescripSoli.Name = "GboxDescripSoli";
            this.GboxDescripSoli.Padding = new System.Windows.Forms.Padding(2);
            this.GboxDescripSoli.Size = new System.Drawing.Size(584, 291);
            this.GboxDescripSoli.TabIndex = 2;
            this.GboxDescripSoli.TabStop = false;
            this.GboxDescripSoli.Text = "Datos Solicitud";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(435, 142);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(44, 20);
            this.lblhora.TabIndex = 16;
            this.lblhora.Text = "Hora";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(435, 83);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(54, 20);
            this.lblfecha.TabIndex = 15;
            this.lblfecha.Text = "Fecha";
            // 
            // cmbmoti
            // 
            this.cmbmoti.FormattingEnabled = true;
            this.cmbmoti.Location = new System.Drawing.Point(140, 131);
            this.cmbmoti.Name = "cmbmoti";
            this.cmbmoti.Size = new System.Drawing.Size(135, 28);
            this.cmbmoti.TabIndex = 14;
            // 
            // cmbtiposol
            // 
            this.cmbtiposol.FormattingEnabled = true;
            this.cmbtiposol.Location = new System.Drawing.Point(140, 80);
            this.cmbtiposol.Name = "cmbtiposol";
            this.cmbtiposol.Size = new System.Drawing.Size(135, 28);
            this.cmbtiposol.TabIndex = 13;
            // 
            // lbldocente
            // 
            this.lbldocente.AutoSize = true;
            this.lbldocente.Location = new System.Drawing.Point(435, 41);
            this.lbldocente.Name = "lbldocente";
            this.lbldocente.Size = new System.Drawing.Size(60, 20);
            this.lbldocente.TabIndex = 12;
            this.lbldocente.Text = "label11";
            this.lbldocente.TextChanged += new System.EventHandler(this.lbldocente_TextChanged);
            this.lbldocente.Click += new System.EventHandler(this.lbldocente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Docente:";
            // 
            // lbllaboratorio
            // 
            this.lbllaboratorio.AutoSize = true;
            this.lbllaboratorio.Location = new System.Drawing.Point(140, 41);
            this.lbllaboratorio.Name = "lbllaboratorio";
            this.lbllaboratorio.Size = new System.Drawing.Size(51, 20);
            this.lbllaboratorio.TabIndex = 6;
            this.lbllaboratorio.Text = "label6";
            this.lbllaboratorio.TextChanged += new System.EventHandler(this.lbllaboratorio_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo Solicitud:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Motivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Laboratorio";
            // 
            // dgvsolicitud
            // 
            this.dgvsolicitud.AllowUserToAddRows = false;
            this.dgvsolicitud.AllowUserToDeleteRows = false;
            this.dgvsolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsolicitud.Location = new System.Drawing.Point(33, 85);
            this.dgvsolicitud.Margin = new System.Windows.Forms.Padding(2);
            this.dgvsolicitud.Name = "dgvsolicitud";
            this.dgvsolicitud.ReadOnly = true;
            this.dgvsolicitud.RowHeadersVisible = false;
            this.dgvsolicitud.RowTemplate.Height = 24;
            this.dgvsolicitud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsolicitud.Size = new System.Drawing.Size(732, 212);
            this.dgvsolicitud.TabIndex = 3;
            this.dgvsolicitud.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsolicitud_CellContentClick);
            // 
            // txtdocente
            // 
            this.txtdocente.Location = new System.Drawing.Point(33, 46);
            this.txtdocente.Name = "txtdocente";
            this.txtdocente.Size = new System.Drawing.Size(246, 20);
            this.txtdocente.TabIndex = 4;
            this.txtdocente.TextChanged += new System.EventHandler(this.txtdocente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre Docente";
            // 
            // dgvequipos
            // 
            this.dgvequipos.AllowUserToAddRows = false;
            this.dgvequipos.AllowUserToDeleteRows = false;
            this.dgvequipos.AllowUserToOrderColumns = true;
            this.dgvequipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvequipos.Location = new System.Drawing.Point(815, 85);
            this.dgvequipos.Name = "dgvequipos";
            this.dgvequipos.ReadOnly = true;
            this.dgvequipos.RowHeadersVisible = false;
            this.dgvequipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvequipos.Size = new System.Drawing.Size(288, 212);
            this.dgvequipos.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(812, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Equipos Seleccionados";
            // 
            // btnquitar
            // 
            this.btnquitar.Location = new System.Drawing.Point(1108, 171);
            this.btnquitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(85, 26);
            this.btnquitar.TabIndex = 10;
            this.btnquitar.Text = "Quitar";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(715, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Equipo Nuevo";
            // 
            // cmbequipo
            // 
            this.cmbequipo.FormattingEnabled = true;
            this.cmbequipo.Location = new System.Drawing.Point(718, 397);
            this.cmbequipo.Name = "cmbequipo";
            this.cmbequipo.Size = new System.Drawing.Size(121, 21);
            this.cmbequipo.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(870, 393);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 26);
            this.button3.TabIndex = 13;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(776, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 96);
            this.button1.TabIndex = 14;
            this.button1.Text = "Actualizar Solicitud";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmmodificarsolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbequipo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvequipos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdocente);
            this.Controls.Add(this.GboxDescripSoli);
            this.Controls.Add(this.dgvsolicitud);
            this.Name = "frmmodificarsolicitud";
            this.Text = "frmmodificarsolicitud";
            this.Load += new System.EventHandler(this.frmmodificarsolicitud_Load);
            this.GboxDescripSoli.ResumeLayout(false);
            this.GboxDescripSoli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GboxDescripSoli;
        private System.Windows.Forms.ComboBox cmbmoti;
        private System.Windows.Forms.ComboBox cmbtiposol;
        private System.Windows.Forms.Label lbldocente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbllaboratorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvsolicitud;
        private System.Windows.Forms.TextBox txtdocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvequipos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbequipo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
    }
}