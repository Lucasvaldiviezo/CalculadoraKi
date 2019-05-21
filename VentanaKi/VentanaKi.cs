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


        private Jugador jugador;
        private Ki miKi;
        private bool cambiosAplicados = false;

        
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(cambiosAplicados)
            {
                jugador.KiPropio.CargarKi();
                txtAgiActual.Text = jugador.KiPropio.Agilidad.ToString();
                txtConActual.Text = jugador.KiPropio.Constitucion.ToString();
                txtDesActual.Text = jugador.KiPropio.Destreza.ToString();
                txtFueActual.Text = jugador.KiPropio.Fuerza.ToString();
                txtPodActual.Text = jugador.KiPropio.Poder.ToString();
                txtVolActual.Text = jugador.KiPropio.Voluntad.ToString();
            }else
            {
                MessageBox.Show("Debe cargar los datos y aplicar los cambios antes de Cargar Ki", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
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
                miKi = new Ki(totalKi, agiMaximo, conMaximo, desMaximo, fueMaximo, podMaximo, volMaximo, agi, con, des, fue, pod, vol);
                jugador = new Jugador(miKi, txtNombreJugador.Text);
                cambiosAplicados = true;
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
            if(cambiosAplicados)
            {
                Form ventanaPoderes = new VentanaPoderes(jugador);
                DialogResult result = ventanaPoderes.ShowDialog();

                if (result == DialogResult.OK)
                {
                    comboBoxPoderes.ResetText();
                    foreach (Poder p in jugador.Poderes)
                    {
                        comboBoxPoderes.Items.Add(p.Nombre);
                        comboBoxPoderes.SelectedText = p.Nombre;
                    }
                }
            }else
            {
                MessageBox.Show("Debe cargar los datos y aplicar los cambios antes de crear un poder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void comboBoxPoderes_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Poder p in jugador.Poderes)
            {
                if (p.Nombre == comboBoxPoderes.Text)
                {
                    richTextBoxDescripcion.Text = p.Descripcion;
                    txtCostoAgi.Text = p.CostoAgi.ToString();
                    txtCostoCon.Text = p.CostoCon.ToString();
                    txtCostoDes.Text = p.CostoDes.ToString();
                    txtCostoFue.Text = p.CostoFue.ToString();
                    txtCostoPod.Text = p.CostoPod.ToString();
                    txtCostoVol.Text = p.CostoVol.ToString();
                }
            }
        }
    }
}
