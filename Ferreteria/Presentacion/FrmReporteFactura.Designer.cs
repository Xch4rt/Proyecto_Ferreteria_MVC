
namespace Presentacion
{
    partial class FrmReporteFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataReportexsd = new Presentacion.dataReportexsd();
            this.Reporte_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_FacturaTableAdapter = new Presentacion.dataReportexsdTableAdapters.Reporte_FacturaTableAdapter();
            this.Reporte_Detalle_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_Detalle_FacturaTableAdapter = new Presentacion.dataReportexsdTableAdapters.Reporte_Detalle_FacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataReportexsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Detalle_FacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataReporte";
            reportDataSource1.Value = this.Reporte_FacturaBindingSource;
            reportDataSource2.Name = "DataSetDetalleFactura";
            reportDataSource2.Value = this.Reporte_Detalle_FacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReporteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1251, 496);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataReportexsd
            // 
            this.dataReportexsd.DataSetName = "dataReportexsd";
            this.dataReportexsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_FacturaBindingSource
            // 
            this.Reporte_FacturaBindingSource.DataMember = "Reporte_Factura";
            this.Reporte_FacturaBindingSource.DataSource = this.dataReportexsd;
            // 
            // Reporte_FacturaTableAdapter
            // 
            this.Reporte_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Detalle_FacturaBindingSource
            // 
            this.Reporte_Detalle_FacturaBindingSource.DataMember = "Reporte_Detalle_Factura";
            this.Reporte_Detalle_FacturaBindingSource.DataSource = this.dataReportexsd;
            // 
            // Reporte_Detalle_FacturaTableAdapter
            // 
            this.Reporte_Detalle_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 496);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteFactura";
            this.Text = "FrmReporteFactura";
            this.Load += new System.EventHandler(this.FrmReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataReportexsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Detalle_FacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_FacturaBindingSource;
        private dataReportexsd dataReportexsd;
        private System.Windows.Forms.BindingSource Reporte_Detalle_FacturaBindingSource;
        private dataReportexsdTableAdapters.Reporte_FacturaTableAdapter Reporte_FacturaTableAdapter;
        private dataReportexsdTableAdapters.Reporte_Detalle_FacturaTableAdapter Reporte_Detalle_FacturaTableAdapter;
    }
}