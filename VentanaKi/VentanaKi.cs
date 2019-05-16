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
        

        public Ki jugador = new Ki();

        private void btnCargar_Click(object sender, EventArgs e)
        {
        
            double agi, con, des, fue, pod, vol;
            if (txtAgi.Text != "")
            {
               agi = Convert.ToDouble(txtAgi.Text);
            }else
            {
               agi = 0;
            }
            if(txtCon.Text != "")
            {
                con = Convert.ToDouble(txtCon.Text);
            }else
            {
                con = 0;
            }
            if(txtDes.Text != "")
            {
                des = Convert.ToDouble(txtDes.Text);
            }else
            {
                des = 0; 
            }
            if(txtFue.Text != "")
            {
                fue = Convert.ToDouble(txtFue.Text);
            }else
            {
                fue = 0;
            }
            if(txtPod.Text != "")
            {
                pod = Convert.ToDouble(txtPod.Text);
            }else
            {
                pod = 0; 
            }
            if(txtVol.Text != "")
            {
                vol = Convert.ToDouble(txtVol.Text);
            }else
            {
                vol = 0;
            }
            jugador.CargarKi(agi, con, des, fue, pod, vol);
            txtAgiActual.Text = jugador.Agilidad.ToString();
            txtConActual.Text = jugador.Constitucion.ToString();
            txtDesActual.Text = jugador.Destreza.ToString();
            txtFueActual.Text = jugador.Fuerza.ToString();
            txtPodActual.Text = jugador.Poder.ToString();
            txtVolActual.Text = jugador.Voluntad.ToString();
           
        }

       
    }
}
