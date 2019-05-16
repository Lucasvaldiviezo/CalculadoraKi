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

        /*public Ki(double totalKi, double agiMaximo, double conMaximo, double desMaximo, double fueMaximo, double podMaximo, double volMaximo)
        {
            this.totalKi = totalKi;
            this.agiMaximo = agiMaximo;
            this.conMaximo = conMaximo;
            this.desMaximo = desMaximo;
            this.fueMaximo = fueMaximo;
            this.podMaximo = podMaximo;
            this.volMaximo = volMaximo;
        }*/
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

        public void CargarKi(double agi,double con, double des, double fue, double pod, double vol)
        {
            actualAgi += agi;
            actualCon += con;
            actualDes += des;
            actualFue += fue;
            actualPod += pod;
            actualVol += vol;
        }
        public void RestarKi(double agi, double con, double des, double fue, double pod, double vol)
        {
            actualAgi -= agi;
            actualCon -= con;
            actualDes -= des;
            actualFue -= fue;
            actualPod -= pod;
            actualVol -= vol;
        }
    }
}
