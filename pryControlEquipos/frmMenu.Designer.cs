namespace pryControlEquipos
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuUsuario = new System.Windows.Forms.MenuStrip();
            this.rectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aurorizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jefeLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aceptarMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuUsuario
            // 
            this.menuUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectorToolStripMenuItem,
            this.jefeLabToolStripMenuItem,
            this.docenteToolStripMenuItem});
            this.menuUsuario.Location = new System.Drawing.Point(0, 0);
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(502, 24);
            this.menuUsuario.TabIndex = 0;
            this.menuUsuario.Text = "menuStrip1";
            // 
            // rectorToolStripMenuItem
            // 
            this.rectorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEquiposToolStripMenuItem,
            this.aurorizarToolStripMenuItem});
            this.rectorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectorToolStripMenuItem.Name = "rectorToolStripMenuItem";
            this.rectorToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.rectorToolStripMenuItem.Text = "Rector";
            this.rectorToolStripMenuItem.Visible = false;
            // 
            // registrarEquiposToolStripMenuItem
            // 
            this.registrarEquiposToolStripMenuItem.Name = "registrarEquiposToolStripMenuItem";
            this.registrarEquiposToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.registrarEquiposToolStripMenuItem.Text = "Registrar Equipos";
            this.registrarEquiposToolStripMenuItem.Click += new System.EventHandler(this.registrarEquiposToolStripMenuItem_Click);
            // 
            // aurorizarToolStripMenuItem
            // 
            this.aurorizarToolStripMenuItem.Name = "aurorizarToolStripMenuItem";
            this.aurorizarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aurorizarToolStripMenuItem.Text = "Aurorizar";
            this.aurorizarToolStripMenuItem.Click += new System.EventHandler(this.aurorizarToolStripMenuItem_Click);
            // 
            // jefeLabToolStripMenuItem
            // 
            this.jefeLabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEquipoToolStripMenuItem,
            this.aceptarMantenimientoToolStripMenuItem,
            this.registrarDocenteToolStripMenuItem,
            this.reporteDeDocentesToolStripMenuItem,
            this.reporteDeEquiposToolStripMenuItem});
            this.jefeLabToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jefeLabToolStripMenuItem.Name = "jefeLabToolStripMenuItem";
            this.jefeLabToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.jefeLabToolStripMenuItem.Text = "JefeLab";
            this.jefeLabToolStripMenuItem.Visible = false;
            // 
            // registrarEquipoToolStripMenuItem
            // 
            this.registrarEquipoToolStripMenuItem.Name = "registrarEquipoToolStripMenuItem";
            this.registrarEquipoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.registrarEquipoToolStripMenuItem.Text = "Registrar Equipo";
            this.registrarEquipoToolStripMenuItem.Click += new System.EventHandler(this.registrarEquipoToolStripMenuItem_Click);
            // 
            // aceptarMantenimientoToolStripMenuItem
            // 
            this.aceptarMantenimientoToolStripMenuItem.Name = "aceptarMantenimientoToolStripMenuItem";
            this.aceptarMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.aceptarMantenimientoToolStripMenuItem.Text = "Aceptar Mantenimiento";
            this.aceptarMantenimientoToolStripMenuItem.Click += new System.EventHandler(this.aceptarMantenimientoToolStripMenuItem_Click);
            // 
            // registrarDocenteToolStripMenuItem
            // 
            this.registrarDocenteToolStripMenuItem.Name = "registrarDocenteToolStripMenuItem";
            this.registrarDocenteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.registrarDocenteToolStripMenuItem.Text = "Registrar Docente";
            this.registrarDocenteToolStripMenuItem.Click += new System.EventHandler(this.registrarDocenteToolStripMenuItem_Click);
            // 
            // reporteDeDocentesToolStripMenuItem
            // 
            this.reporteDeDocentesToolStripMenuItem.Name = "reporteDeDocentesToolStripMenuItem";
            this.reporteDeDocentesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.reporteDeDocentesToolStripMenuItem.Text = "Reporte de Docentes";
            this.reporteDeDocentesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeDocentesToolStripMenuItem_Click);
            // 
            // reporteDeEquiposToolStripMenuItem
            // 
            this.reporteDeEquiposToolStripMenuItem.Name = "reporteDeEquiposToolStripMenuItem";
            this.reporteDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.reporteDeEquiposToolStripMenuItem.Text = "Reporte de Equipos";
            this.reporteDeEquiposToolStripMenuItem.Click += new System.EventHandler(this.reporteDeEquiposToolStripMenuItem_Click);
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.Checked = true;
            this.docenteToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.docenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudToolStripMenuItem});
            this.docenteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.docenteToolStripMenuItem.Text = "Docente";
            this.docenteToolStripMenuItem.Visible = false;
            // 
            // solicitudToolStripMenuItem
            // 
            this.solicitudToolStripMenuItem.Name = "solicitudToolStripMenuItem";
            this.solicitudToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.solicitudToolStripMenuItem.Text = "Solicitud";
            this.solicitudToolStripMenuItem.Click += new System.EventHandler(this.solicitudToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 378);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuUsuario);
            this.MainMenuStrip = this.menuUsuario;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.menuUsuario.ResumeLayout(false);
            this.menuUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuUsuario;
        public System.Windows.Forms.ToolStripMenuItem rectorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem jefeLabToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aurorizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aceptarMantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEquiposToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}