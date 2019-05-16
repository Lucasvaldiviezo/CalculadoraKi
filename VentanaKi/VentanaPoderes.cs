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
    public partial class VentanaPoderes : Form
    {
        public VentanaPoderes()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre;
            string descripcion;
            double agi, con, des, fue, pod, vol;

            if(txtNombre.Text != "" && txtAgi.Text != "" && txtCon.Text != "" && txtDes.Text != "" && txtFue.Text != "" && txtPod.Text != "" && txtVol.Text != "")
            {
                nombre = txtNombre.Text;
                agi = Convert.ToDouble(txtAgi.Text);
                con = Convert.ToDouble(txtCon.Text);
                des = Convert.ToDouble(txtDes.Text);
                fue = Convert.ToDouble(txtFue.Text);
                pod = Convert.ToDouble(txtPod.Text);
                vol = Convert.ToDouble(txtVol.Text);
                descripcion = richTextBoxDescripcion.Text; 
                Poder nuevoPoder = new Poder(nombre, descripcion, agi, con, des, fue, pod, vol);
                VentanaKi(nuevoPoder);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
