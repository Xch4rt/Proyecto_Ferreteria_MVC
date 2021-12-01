using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmReporteFactura : Form
    {
        public FrmReporteFactura()
        {
            InitializeComponent();
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataReportexsd.Reporte_Factura' Puede moverla o quitarla según sea necesario.
            this.Reporte_FacturaTableAdapter.Fill(this.dataReportexsd.Reporte_Factura,11);
            // TODO: esta línea de código carga datos en la tabla 'dataReportexsd.Reporte_Detalle_Factura' Puede moverla o quitarla según sea necesario.
            this.Reporte_Detalle_FacturaTableAdapter.Fill(this.dataReportexsd.Reporte_Detalle_Factura,11);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
