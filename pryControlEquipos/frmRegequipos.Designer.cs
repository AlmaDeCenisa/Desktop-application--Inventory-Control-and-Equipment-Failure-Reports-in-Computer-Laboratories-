namespace pryControlEquipos
{
    partial class frmRegequipos
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
            this.dgvNroequpo = new System.Windows.Forms.DataGridView();
            this.cmblabs = new System.Windows.Forms.ComboBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbllaboratorio = new System.Windows.Forms.Label();
            this.numequi = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnagregarequipoi = new System.Windows.Forms.Button();
            this.grpReglab = new System.Windows.Forms.GroupBox();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnguardarlab = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNroequpo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numequi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpReglab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laboratorio";
            // 
            // dgvNroequpo
            // 
            this.dgvNroequpo.AllowUserToAddRows = false;
            this.dgvNroequpo.AllowUserToDeleteRows = false;
            this.dgvNroequpo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNroequpo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvNroequpo.Location = new System.Drawing.Point(32, 96);
            this.dgvNroequpo.Name = "dgvNroequpo";
            this.dgvNroequpo.ReadOnly = true;
            this.dgvNroequpo.RowHeadersVisible = false;
            this.dgvNroequpo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNroequpo.Size = new System.Drawing.Size(303, 150);
            this.dgvNroequpo.TabIndex = 1;
            // 
            // cmblabs
            // 
            this.cmblabs.FormattingEnabled = true;
            this.cmblabs.Location = new System.Drawing.Point(15, 52);
            this.cmblabs.Name = "cmblabs";
            this.cmblabs.Size = new System.Drawing.Size(121, 21);
            this.cmblabs.TabIndex = 2;
            this.cmblabs.SelectedIndexChanged += new System.EventHandler(this.cmblabs_SelectedIndexChanged);
            this.cmblabs.SelectionChangeCommitted += new System.EventHandler(this.cmblabs_SelectionChangeCommitted);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(163, 50);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 3;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datos Equipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo";
            // 
            // lbllaboratorio
            // 
            this.lbllaboratorio.AutoSize = true;
            this.lbllaboratorio.Location = new System.Drawing.Point(89, 60);
            this.lbllaboratorio.Name = "lbllaboratorio";
            this.lbllaboratorio.Size = new System.Drawing.Size(40, 13);
            this.lbllaboratorio.TabIndex = 6;
            this.lbllaboratorio.Text = "Codigo";
            // 
            // numequi
            // 
            this.numequi.Location = new System.Drawing.Point(177, 60);
            this.numequi.Name = "numequi";
            this.numequi.Size = new System.Drawing.Size(120, 20);
            this.numequi.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnagregarequipoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numequi);
            this.groupBox1.Controls.Add(this.dgvNroequpo);
            this.groupBox1.Controls.Add(this.lbllaboratorio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 265);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Equipo";
            // 
            // btnagregarequipoi
            // 
            this.btnagregarequipoi.Location = new System.Drawing.Point(316, 55);
            this.btnagregarequipoi.Name = "btnagregarequipoi";
            this.btnagregarequipoi.Size = new System.Drawing.Size(75, 23);
            this.btnagregarequipoi.TabIndex = 9;
            this.btnagregarequipoi.Text = "Agregar";
            this.btnagregarequipoi.UseVisualStyleBackColor = true;
            this.btnagregarequipoi.Click += new System.EventHandler(this.btnagregarequipoi_Click);
            // 
            // grpReglab
            // 
            this.grpReglab.Controls.Add(this.btnCancelar);
            this.grpReglab.Controls.Add(this.btnguardarlab);
            this.grpReglab.Controls.Add(this.txtLaboratorio);
            this.grpReglab.Location = new System.Drawing.Point(261, 12);
            this.grpReglab.Name = "grpReglab";
            this.grpReglab.Size = new System.Drawing.Size(239, 100);
            this.grpReglab.TabIndex = 9;
            this.grpReglab.TabStop = false;
            this.grpReglab.Text = "Registro Laboratorio";
            this.grpReglab.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(73, 38);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(100, 20);
            this.txtLaboratorio.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(17, 70);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnguardarlab
            // 
            this.btnguardarlab.Location = new System.Drawing.Point(138, 70);
            this.btnguardarlab.Name = "btnguardarlab";
            this.btnguardarlab.Size = new System.Drawing.Size(75, 23);
            this.btnguardarlab.TabIndex = 11;
            this.btnguardarlab.Text = "Guardar";
            this.btnguardarlab.UseVisualStyleBackColor = true;
            this.btnguardarlab.Click += new System.EventHandler(this.button3_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NroEquipo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Estado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Accion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(361, 154);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // frmRegequipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpReglab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.cmblabs);
            this.Controls.Add(this.label1);
            this.Name = "frmRegequipos";
            this.Text = "frmRegequipos";
            this.Load += new System.EventHandler(this.frmRegequipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNroequpo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numequi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpReglab.ResumeLayout(false);
            this.grpReglab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNroequpo;
        private System.Windows.Forms.ComboBox cmblabs;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbllaboratorio;
        private System.Windows.Forms.NumericUpDown numequi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnagregarequipoi;
        private System.Windows.Forms.GroupBox grpReglab;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnguardarlab;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btneliminar;
    }
}