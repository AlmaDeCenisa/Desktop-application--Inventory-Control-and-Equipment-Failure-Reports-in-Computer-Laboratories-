namespace pryControlEquipos
{
    partial class frmRListadodocente
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
            this.spListarDocenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSbdcontrolappslab = new pryControlEquipos.DSbdcontrolappslab();
            this.spListarDocenteTableAdapter = new pryControlEquipos.DSbdcontrolappslabTableAdapters.spListarDocenteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spListarDocenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSbdcontrolappslab)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spListarDocenteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pryControlEquipos.RListadoDocente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(681, 432);
            this.reportViewer1.TabIndex = 0;
            // 
            // spListarDocenteBindingSource
            // 
            this.spListarDocenteBindingSource.DataMember = "spListarDocente";
            this.spListarDocenteBindingSource.DataSource = this.DSbdcontrolappslab;
            // 
            // DSbdcontrolappslab
            // 
            this.DSbdcontrolappslab.DataSetName = "DSbdcontrolappslab";
            this.DSbdcontrolappslab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListarDocenteTableAdapter
            // 
            this.spListarDocenteTableAdapter.ClearBeforeFill = true;
            // 
            // frmRListadodocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 433);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRListadodocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRListadodocente";
            this.Load += new System.EventHandler(this.frmRListadodocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spListarDocenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSbdcontrolappslab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spListarDocenteBindingSource;
        private DSbdcontrolappslab DSbdcontrolappslab;
        private DSbdcontrolappslabTableAdapters.spListarDocenteTableAdapter spListarDocenteTableAdapter;
    }
}