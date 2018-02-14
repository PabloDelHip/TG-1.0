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
    public partial class FrmHistorialObservaciones : Form
    {
        ClsHistorialObservaciones cls_HisObvservaciones = new ClsHistorialObservaciones();
        FrmReporteEntradas reporteObservaciones = new FrmReporteEntradas();
        public FrmHistorialObservaciones()
        {
            InitializeComponent();
        }
        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void validarCampos(object sender, EventArgs e)
        {
            if (txtUsuario.Text != null)
            {
                btnBuscarH.Enabled = true;
            }
            else
            {
                MessageBox.Show("No pueden estar los campos vacios para realizar la busqueda");
            }
        }

        private void btnBuscarH_Click(object sender, EventArgs e)
        {
            try
            {
                cls_HisObvservaciones.m_IdUsuario= Convert.ToInt32(txtUsuario.Text);
                cls_HisObvservaciones.m_FechaInicioBusquedaH = dtpInicioBusquedaH.Value;
                cls_HisObvservaciones.m_FechaFinBusquedaH = dtpFinBusquedaH.Value;
                DataTable dt = cls_HisObvservaciones.buscarHisObGenerales();
                dgvObGenerales.DataSource = dt;
                DataTable dt2 = cls_HisObvservaciones.buscarHisObCaja();
                dgvObCaja.DataSource = dt2;
                btnGenerarReporteH.Enabled = true;
                btnGenerarReporte2.Enabled = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnGenerarReporteH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea generar un reporte?", "Continuar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login.opcionReporte = 2;
                FrmReporteEntradas reporteEntradas = new FrmReporteEntradas();
                reporteEntradas.idSocio = Convert.ToInt32(txtUsuario.Text);
                reporteEntradas.fechaInicioBusqueda = dtpInicioBusquedaH.Value;
                reporteEntradas.fechaFinBusqueda = dtpFinBusquedaH.Value;
                reporteEntradas.ShowDialog();
            }
        }

        private void btnGenerarReporte2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea generar un reporte?", "Continuar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login.opcionReporte = 3;
                FrmReporteEntradas reporteEntradas = new FrmReporteEntradas();
                reporteEntradas.idSocio = Convert.ToInt32(txtUsuario.Text);
                reporteEntradas.fechaInicioBusqueda = dtpInicioBusquedaH.Value;
                reporteEntradas.fechaFinBusqueda = dtpFinBusquedaH.Value;
                reporteEntradas.ShowDialog();
            }
        }

        private void FrmHistorialObservaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
