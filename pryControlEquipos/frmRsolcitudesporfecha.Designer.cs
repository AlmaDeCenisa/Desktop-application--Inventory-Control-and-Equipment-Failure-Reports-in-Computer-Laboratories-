namespace pryControlEquipos
{
    partial class frmRsolcitudesporfecha
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtpFechasol = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.sp_listado_fechaSolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSbdcontrolappslab = new pryControlEquipos.DSbdcontrolappslab();
            this.sp_listado_fechaSolTableAdapter = new pryControlEquipos.DSbdcontrolappslabTableAdapters.sp_listado_fechaSolTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_listado_fechaSolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSbdcontrolappslab)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechasol
            // 
            this.dtpFechasol.Location = new System.Drawing.Point(203, 36);
            this.dtpFechasol.Name = "dtpFechasol";
            this.dtpFechasol.Size = new System.Drawing.Size(200, 20);
            this.dtpFechasol.TabIndex = 0;
            this.dtpFechasol.Value = new System.DateTime(2023, 5, 26, 0, 0, 0, 0);
            this.dtpFechasol.ValueChanged += new System.EventHandler(this.dtpFechasol_ValueChanged);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sp_listado_fechaSolBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pryControlEquipos.RListadoSoliXfechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 67);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(813, 438);
            this.reportViewer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de solicitud";
            // 
            // sp_listado_fechaSolBindingSource
            // 
            this.sp_listado_fechaSolBindingSource.DataMember = "sp_listado_fechaSol";
            this.sp_listado_fechaSolBindingSource.DataSource = this.DSbdcontrolappslab;
            // 
            // DSbdcontrolappslab
            // 
            this.DSbdcontrolappslab.DataSetName = "DSbdcontrolappslab";
            this.DSbdcontrolappslab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_listado_fechaSolTableAdapter
            // 
            this.sp_listado_fechaSolTableAdapter.ClearBeforeFill = true;
            // 
            // frmRsolcitudesporfecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dtpFechasol);
            this.Name = "frmRsolcitudesporfecha";
            this.Text = "frmRsolcitudesporfecha";
            this.Load += new System.EventHandler(this.frmRsolcitudesporfecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_listado_fechaSolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSbdcontrolappslab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechasol;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_listado_fechaSolBindingSource;
        private DSbdcontrolappslab DSbdcontrolappslab;
        private System.Windows.Forms.Label label1;
        private DSbdcontrolappslabTableAdapters.sp_listado_fechaSolTableAdapter sp_listado_fechaSolTableAdapter;
    }
}