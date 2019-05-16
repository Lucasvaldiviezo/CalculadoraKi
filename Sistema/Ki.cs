using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public class Ki
    {
        private double actualAgi, actualCon, actualDes, actualFue, actualPod, actualVol;
        private double totalKi;
        private double agiMaximo, conMaximo, desMaximo, fueMaximo, podMaximo, volMaximo;
        private double agiCarga, conCarga, desCarga, fueCarga, podCarga, volCarga;

        public Ki(double totalKi, double agiMaximo, double conMaximo, double desMaximo, double fueMaximo, double podMaximo, double volMaximo,
                  double agiCarga, double conCarga, double desCarga, double fueCarga, double podCarga, double volCarga)
        {
            this.totalKi = totalKi;
            this.agiMaximo = agiMaximo;
            this.conMaximo = conMaximo;
            this.desMaximo = desMaximo;
            this.fueMaximo = fueMaximo;
            this.podMaximo = podMaximo;
            this.volMaximo = volMaximo;
            this.agiCarga = agiCarga;
            this.conCarga = conCarga;
            this.desCarga = desCarga;
            this.fueCarga = fueCarga;
            this.podCarga = podCarga;
            this.volCarga = volCarga;
        }
        public double Agilidad
        {
            get { return actualAgi; }
        }
        public double Constitucion
        {
            get { return actualCon; }
        }
        public double Destreza
        {
            get { return actualDes; }
        }
        public double Fuerza
        {
            get { return actualFue; }
        }
        public double Poder
        {
            get { return actualPod; }
        }
        public double Voluntad
        {
            get { return actualVol; }
        }

        public void CargarKi()
        {
            if(ValidarCarga(agiCarga,actualAgi,agiMaximo))
            {
                actualAgi += agiCarga;
            }else
            {
                actualAgi = agiMaximo;
            }
            if(ValidarCarga(conCarga,actualCon,conMaximo))
            {
                actualCon += conCarga;
            }else
            {
                actualCon = conMaximo;
            }
            if(ValidarCarga(desCarga,actualDes,desMaximo))
            {
                actualDes += desCarga;
            }else
            {
                actualDes = desMaximo;
            }
            if(ValidarCarga(fueCarga,actualFue,fueMaximo))
            {
                actualFue += fueCarga;
            }else
            {
                actualFue = fueMaximo;
            }
            if(ValidarCarga(podCarga,actualPod,podMaximo))
            {
                actualPod += podCarga;
            }else
            {
                actualPod = podMaximo;
            }
            if(ValidarCarga(volCarga,actualVol,volMaximo))
            {
                actualVol += volCarga;
            }else
            {
                actualVol = volMaximo;
            }   
        }
        public void RestarKi()
        {
            actualAgi -= agiCarga;
            actualCon -= conCarga;
            actualDes -= desCarga;
            actualFue -= fueCarga;
            actualPod -= podCarga;
            actualVol -= volCarga;
        }

        public bool ValidarCarga(double carga,double actual, double maximo)
        {
            bool retorno = false;
            if((actual + carga) <= maximo)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
