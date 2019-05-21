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
            set { actualAgi = value;}
            get { return actualAgi; }
        }
        public double Constitucion
        {
            set { actualCon = value;}
            get { return actualCon; }
        }
        public double Destreza
        {
            set { actualDes = value;}
            get { return actualDes; }
        }
        public double Fuerza
        {
            set { actualFue = value;}
            get { return actualFue; }
        }
        public double Poder
        {
            set { actualPod = value;}
            get { return actualPod; }
        }
        public double Voluntad
        {
            set { actualVol = value; }
            get { return actualVol; }
        }

        public double TotalKi
        {
            set { totalKi = value; }
            get { return totalKi; }
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
        public void RestarKi(double costoAgi, double costoCon, double costoDes, double costoFue, double costoPod, double costoVol, double costoKiTotal)
        {
            if(ValidarResta(costoAgi,actualAgi,0))
            {
                actualAgi -= costoAgi;
            }else
            {
                actualAgi = 0;
            }
            if(ValidarResta(costoCon, actualCon, 0))
            {
                actualCon -= costoCon;
            }else
            {
                actualCon = 0;
            }
            if(ValidarResta(costoDes, actualDes, 0))
            {
                actualDes -= costoDes;
            }else
            {
                actualDes = 0;
            }
            if(ValidarResta(costoFue, actualFue, 0))
            {
                actualFue -= costoFue;
            }else
            {
                actualFue = 0;
            }
            if(ValidarResta(costoPod, actualPod, 0))
            {
                actualPod -= costoPod;
            }else
            {
                actualPod = 0;
            }
            if(ValidarResta(costoVol, actualVol, 0))
            {
                actualVol -= costoVol;
            }else
            {
                actualVol = 0;
            }
            if (ValidarResta(costoKiTotal, totalKi, 0))
            {
                totalKi -= costoKiTotal;
            }
            else
            {
                totalKi = 0;
            }

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

        public bool ValidarResta(double carga, double actual, double minimo)
        {
            bool retorno = false;
            if ((actual - carga) >= minimo)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
