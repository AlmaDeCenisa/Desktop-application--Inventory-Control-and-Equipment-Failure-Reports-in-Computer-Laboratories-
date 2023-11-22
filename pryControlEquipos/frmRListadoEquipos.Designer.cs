namespace pryControlEquipos
{
    partial class frmRListadoEquipos
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
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSbdcontrolappslab = new pryControlEquipos.DSbdcontrolappslab();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.equipoTableAdapter = new pryControlEquipos.DSbdcontrolappslabTableAdapters.equipoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSbdcontrolappslab)).BeginInit();
            this.SuspendLayout();
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "equipo";
            this.equipoBindingSource.DataSource = this.DSbdcontrolappslab;
            // 
            // DSbdcontrolappslab
            // 
            this.DSbdcontrolappslab.DataSetName = "DSbdcontrolappslab";
            this.DSbdcontrolappslab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.equipoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pryControlEquipos.RListadoEquipos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(552, 441);
            this.reportViewer1.TabIndex = 0;
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRListadoEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 441);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRListadoEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRListadoEquipos";
            this.Load += new System.EventHandler(this.frmRListadoEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSbdcontrolappslab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private DSbdcontrolappslab DSbdcontrolappslab;
        private DSbdcontrolappslabTableAdapters.equipoTableAdapter equipoTableAdapter;
    }
}