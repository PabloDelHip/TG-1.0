using CapaLogicaNegocios;
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
    public partial class FrmReporteEntradas : Form
    {
        public int idSocio;
        public DateTime fechaInicioBusqueda;
        public DateTime fechaFinBusqueda;
        public FrmReporteEntradas()
        {
            InitializeComponent();
        }

        private void FrmReporteEntradas_Load(object sender, EventArgs e)
        {
     
        }

        private void FrmReporteEntradas_Load_1(object sender, EventArgs e)
        {
            switch (Login.opcionReporte)
            {
                case 1:
                    CREntradas reporteEntradas = new CREntradas();
                    reporteEntradas.SetParameterValue("@idSocio", idSocio);
                    reporteEntradas.SetParameterValue("@FechaInicioBusqueda", fechaInicioBusqueda);
                    reporteEntradas.SetParameterValue("@FechaFinBusqueda", fechaFinBusqueda);
                    CRVreporteEntradas.ReportSource = reporteEntradas;
                    break;
                case 2:
                    CRHisObGenerales reporteHisObGenerales = new CRHisObGenerales();
                    reporteHisObGenerales.SetParameterValue("@idSocio", idSocio);
                    reporteHisObGenerales.SetParameterValue("@FechaInicioBusqueda", fechaInicioBusqueda);
                    reporteHisObGenerales.SetParameterValue("@FechaFinBusqueda", fechaFinBusqueda);
                    CRVreporteEntradas.ReportSource = reporteHisObGenerales;
                    break;
                case 3:
                    CRHisObCaja reporteHisObCaja = new CRHisObCaja();
                    reporteHisObCaja.SetParameterValue("@idSocio", idSocio);
                    reporteHisObCaja.SetParameterValue("@FechaInicioBusqueda", fechaInicioBusqueda);
                    reporteHisObCaja.SetParameterValue("@FechaFinBusqueda", fechaFinBusqueda);
                    CRVreporteEntradas.ReportSource = reporteHisObCaja;
                    break;
                case 4:
                    CRVentas reporteVentas = new CRVentas();
                    reporteVentas.SetParameterValue("@FechaInicioBusqueda", fechaInicioBusqueda);
                    reporteVentas.SetParameterValue("@FechaFinBusqueda", fechaFinBusqueda);
                    CRVreporteEntradas.ReportSource = reporteVentas;
                    break;
                default:
                    break;
            }

        }

        private void CRVreporteEntradas_Load(object sender, EventArgs e)
        {

        }
    }
}
