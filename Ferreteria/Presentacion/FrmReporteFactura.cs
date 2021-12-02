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
        int idOrden = 0;

        public FrmReporteFactura(int idOrden)
        {
            InitializeComponent();
            this.idOrden = idOrden;
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataReportexsd.Reporte_Factura' Puede moverla o quitarla según sea necesario.
            this.Reporte_FacturaTableAdapter.Fill(this.dataReportexsd.Reporte_Factura,idOrden);
            // TODO: esta línea de código carga datos en la tabla 'dataReportexsd.Reporte_Detalle_Factura' Puede moverla o quitarla según sea necesario.
            this.Reporte_Detalle_FacturaTableAdapter.Fill(this.dataReportexsd.Reporte_Detalle_Factura,idOrden);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
