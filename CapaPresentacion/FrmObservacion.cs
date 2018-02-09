using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocios;

namespace CapaPresentacion
{
    public partial class FrmObservacion : Form
    {
        ClsObservaciones cls_observaciones = new ClsObservaciones();
        ClsObservacionesCaja cls_observaciones_caja = new ClsObservacionesCaja();
        ClsGeneral cls_generales = new ClsGeneral();
        public bool ObCaja;
        public FrmObservacion(bool obvCaja)
        {
            this.ObCaja = obvCaja;
        }
        public FrmObservacion()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList email = new ArrayList();
            email.Add("pablodelhip@gmail.com");
            if (ObCaja==false)
            {
                string bandera = "0";
                int i = 0;
                while (bandera == "0")
                {
                    string observaciones = txtTexto.Text;
                    string respuesta;
                    cls_observaciones.m_IdSocio = Login.idUsuario;
                    cls_observaciones.m_Observacion = observaciones;
                    cls_observaciones.m_Fecha = DateTime.Now;
                    respuesta = cls_observaciones.guardarObservacion();
                    if (respuesta != "0")
                    {
                        bandera = respuesta;
                        MessageBox.Show(respuesta);
                        cls_generales.EnviarCorreo(email, txtTexto.Text, "Observaciones", "");
                        this.Hide();
                        FrmMain main = new FrmMain();
                        main.ShowDialog();
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            else
            {
                if (MessageBox.Show("¿Guardar la observacion de caja y continuar?", "Continuar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cls_observaciones_caja.m_texto = txtTexto.Text;
                    cls_observaciones_caja.m_idUsuario = Login.idUsuario;
                    string respuesta2 = cls_observaciones_caja.agregarObservacion();
                    cls_generales.EnviarCorreo(email, txtTexto.Text, "Observaciones", "");
                    MessageBox.Show(respuesta2);
                    if (Login.cajaAbierta == false)
                    {
                        this.Hide();
                        FrmCorteEntrada abrir = new FrmCorteEntrada();
                        abrir.Show();
                    }
                    else
                    {
                        this.Hide();
                        FrmMain abrir = new FrmMain();
                        abrir.Show();
                    }
                }
            }
        }

        private void FrmObservacion_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
