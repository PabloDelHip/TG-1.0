using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class verReporte : Form
    {
        public verReporte(DataTable DT)
        {
            InitializeComponent();
            //Crear Objeto REPORTE
            CRTicketVenta RP = new CRTicketVenta();

            //Asignar datos al reporte
            RP.SetDataSource(DT);

            //Asignar reporte creado al visor de reportes
            RP.PrintToPrinter(1, false, 0, 0);
            //this.crystalReportViewer1.ReportSource = RP;
            
        }

        private void verReporte_Load(object sender, EventArgs e)
        {

        }
    }
}
