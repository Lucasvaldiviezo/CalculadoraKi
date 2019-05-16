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


        private Ki jugador;
        private Poder nuevoPoder;

        
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
            if (txtAgi.Text != "" && txtCon.Text != "" && txtDes.Text != "" && txtFue.Text != "" && txtPod.Text != "" && txtVol.Text != "" && txtKiTotal.Text != "" 
                && txtAgiMaximo.Text != "" && txtConMaximo.Text != "" && txtDesMaximo.Text != "" && txtFueMaximo.Text != "" && txtPodMaximo.Text != "" && txtVolMaximo.Text != "")
            {
                agi = Convert.ToDouble(txtAgi.Text);
                con = Convert.ToDouble(txtCon.Text);
                des = Convert.ToDouble(txtDes.Text);
                fue = Convert.ToDouble(txtFue.Text);
                pod = Convert.ToDouble(txtPod.Text);
                vol = Convert.ToDouble(txtVol.Text);
                totalKi = Convert.ToDouble(txtKiTotal.Text);
                agiMaximo = Convert.ToDouble(txtAgiMaximo.Text);
                conMaximo = Convert.ToDouble(txtConMaximo.Text);
                desMaximo = Convert.ToDouble(txtDesMaximo.Text);
                fueMaximo = Convert.ToDouble(txtFueMaximo.Text);
                podMaximo = Convert.ToDouble(txtPodMaximo.Text);
                volMaximo = Convert.ToDouble(txtVolMaximo.Text);
                jugador = new Ki(totalKi, agiMaximo, conMaximo, desMaximo, fueMaximo, podMaximo, volMaximo, agi, con, des, fue, pod, vol);
                MessageBox.Show("Las Stats estan aplicadas", "Cambios Aplicados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No deje ningun campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            //Cargando Stats de Maximo        
            
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form ventanaPoderes = new VentanaPoderes();
            DialogResult result = ventanaPoderes.ShowDialog();
        }
    }
}
