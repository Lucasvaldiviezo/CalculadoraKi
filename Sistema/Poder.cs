using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public class Poder
    {
        private string nombre;
        private string descripcion;
        private double costoAgi, costoCon, costoDes, costoFue, costoPod, costoVol;

        public Poder(string nombre, double costoAgi, double costoCon, double costoDes, double costoFue, double costoPod, double costoVol)
        {
            this.nombre = nombre;
            this.costoAgi = costoAgi;
            this.costoCon = costoCon;
            this.costoDes = costoDes;
            this.costoFue = costoFue;
            this.costoPod = costoPod;
            this.costoVol = costoVol;
        }

        public Poder(string nombre,string descripcion, double costoAgi, double costoCon, double costoDes, double costoFue, double costoPod, double costoVol) : this(nombre,costoAgi,costoCon,costoDes,costoFue,costoPod,costoVol)
        {
            this.descripcion = descripcion;
        }

        public double CostoAgi
        {
            get { return costoAgi; }
        }
        public double CostoCon
        {
            get { return costoCon; }
        }
        public double CostoDes
        {
            get { return costoDes; }
        }
        public double CostoFue
        {
            get { return costoFue; }
        }
        public double CostoPod
        {
            get { return costoPod; }
        }
        public double CostoVol
        {
            get { return costoVol; }
        }

        public string Nombre
        {
            get { return nombre; }
        }
        public string Descripcion
        {
            get { return descripcion; }
        }

    }
}
