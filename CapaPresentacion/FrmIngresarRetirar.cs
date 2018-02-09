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
    public partial class FrmIngresarRetirar : Form
    {
        public int tipoMovimiento;
        public FrmIngresarRetirar(int tipoMovimientoCaja)
        {
            this.tipoMovimiento = tipoMovimientoCaja;
            InitializeComponent();
        }
        private void FrmIngresarRetirar_Load(object sender, EventArgs e)
        {
            if (tipoMovimiento==1)
            {
                btnTipoMovimiento.Image = Properties.Resources.money_1;
                btnTipoMovimiento.Text = "Ingresar";
            }
            else if (tipoMovimiento==2)
            {
                btnTipoMovimiento.Image = Properties.Resources.money;
                btnTipoMovimiento.Text = "Retirar";
            }
        }
    }
}
