using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema;

namespace VentanaKi
{
    public partial class VentanaKi : Form
    {
        
        public VentanaKi()
        {
            InitializeComponent();     
        }


        public Ki jugador;

        private void btnCargar_Click(object sender, EventArgs e)
        {
        
           
            jugador.CargarKi();
            txtAgiActual.Text = jugador.Agilidad.ToString();
            txtConActual.Text = jugador.Constitucion.ToString();
            txtDesActual.Text = jugador.Destreza.ToString();
            txtFueActual.Text = jugador.Fuerza.ToString();
            txtPodActual.Text = jugador.Poder.ToString();
            txtVolActual.Text = jugador.Voluntad.ToString();
           
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            double agi, con, des, fue, pod, vol;
            double totalKi;
            double agiMaximo, conMaximo, desMaximo, fueMaximo, podMaximo, volMaximo;
            //Cargando Stats de Carga
            #region statscarga
            if (txtAgi.Text != "")
            {
                agi = Convert.ToDouble(txtAgi.Text);
            }
            else
            {
                agi = 0;
            }
            if (txtCon.Text != "")
            {
                con = Convert.ToDouble(txtCon.Text);
            }
            else
            {
                con = 0;
            }
            if (txtDes.Text != "")
            {
                des = Convert.ToDouble(txtDes.Text);
            }
            else
            {
                des = 0;
            }
            if (txtFue.Text != "")
            {
                fue = Convert.ToDouble(txtFue.Text);
            }
            else
            {
                fue = 0;
            }
            if (txtPod.Text != "")
            {
                pod = Convert.ToDouble(txtPod.Text);
            }
            else
            {
                pod = 0;
            }
            if (txtVol.Text != "")
            {
                vol = Convert.ToDouble(txtVol.Text);
            }
            else
            {
                vol = 0;
            }
            #endregion
            //Cargando Stats de Maximo
            #region maximos
            if (txtKiTotal.Text != "")
            {
                totalKi = Convert.ToDouble(txtKiTotal.Text);
            }else
            {
                totalKi = 0;
            }
            if(txtAgiMaximo.Text != "")
            {
                agiMaximo = Convert.ToDouble(txtAgiMaximo.Text);
            }else
            {
                agiMaximo = 0;
            }
            if (txtConMaximo.Text != "")
            {
                conMaximo = Convert.ToDouble(txtConMaximo.Text);
            }
            else
            {
                conMaximo = 0;
            }
            if (txtDesMaximo.Text != "")
            {
                desMaximo = Convert.ToDouble(txtDesMaximo.Text);
            }
            else
            {
                desMaximo = 0;
            }
            if (txtFueMaximo.Text != "")
            {
                fueMaximo = Convert.ToDouble(txtFueMaximo.Text);
            }
            else
            {
                fueMaximo = 0;
            }
            if(txtPodMaximo.Text != "")
            {
                podMaximo = Convert.ToDouble(txtPodMaximo.Text);
            }else
            {
                podMaximo = 0;
            }
            if (txtVolMaximo.Text != "")
            {
                volMaximo = Convert.ToDouble(txtVolMaximo.Text);
            }
            else
            {
                volMaximo = 0;
            }
            #endregion
            jugador = new Ki(totalKi,agiMaximo,conMaximo,desMaximo,fueMaximo,podMaximo,volMaximo,agi,con,des,fue,pod,vol);
            MessageBox.Show("Las Stats estan aplicadas", "Cambios Aplicados", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}
