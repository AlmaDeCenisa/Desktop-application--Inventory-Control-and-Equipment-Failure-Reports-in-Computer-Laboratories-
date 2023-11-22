namespace pryControlEquipos
{
    partial class frmComprobantedeSol
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSbdcontrolappslab = new pryControlEquipos.DSbdcontrolappslab();
            this.sp_ComprobantedeSolicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ComprobantedeSolicitudTableAdapter = new pryControlEquipos.DSbdcontrolappslabTableAdapters.sp_ComprobantedeSolicitudTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSbdcontrolappslab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ComprobantedeSolicitudBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_ComprobantedeSolicitudBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pryControlEquipos.Rcomprobantedesol.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(701, 397);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSbdcontrolappslab
            // 
            this.DSbdcontrolappslab.DataSetName = "DSbdcontrolappslab";
            this.DSbdcontrolappslab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_ComprobantedeSolicitudBindingSource
            // 
            this.sp_ComprobantedeSolicitudBindingSource.DataMember = "sp_ComprobantedeSolicitud";
            this.sp_ComprobantedeSolicitudBindingSource.DataSource = this.DSbdcontrolappslab;
            // 
            // sp_ComprobantedeSolicitudTableAdapter
            // 
            this.sp_ComprobantedeSolicitudTableAdapter.ClearBeforeFill = true;
            // 
            // frmComprobantedeSol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 397);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmComprobantedeSol";
            this.Text = "frmComprobantedeSol";
            this.Load += new System.EventHandler(this.frmComprobantedeSol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSbdcontrolappslab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ComprobantedeSolicitudBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_ComprobantedeSolicitudBindingSource;
        private DSbdcontrolappslab DSbdcontrolappslab;
        private DSbdcontrolappslabTableAdapters.sp_ComprobantedeSolicitudTableAdapter sp_ComprobantedeSolicitudTableAdapter;
    }
}