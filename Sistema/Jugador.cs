using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public class Jugador
    {
        private List<Poder> poderes;
        private Ki kiPropio;
        private string nombre;

        public Jugador(Ki nuevoKi, string nombre)
        {
            poderes = new List<Poder>();
            kiPropio = nuevoKi;
            this.nombre = nombre;

        }

        public List<Poder> Poderes
        {
            get { return poderes;  }
        }

        public Ki KiPropio
        {
            get { return kiPropio; }
        }

        public static Jugador operator +(Jugador jugador, Poder poder)
        {
            if(jugador != poder)
            {
                jugador.Poderes.Add(poder);
            }

            return jugador;
        }

        public static bool operator ==(Jugador jugador, Poder poder)
        {
            bool retorno = false;
            foreach(Poder p in jugador.Poderes)
            {
                if(p == poder)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public void ActivarPoder(string nombrePoder)
        {
            double costoKiTotal;
            foreach (Poder p in this.poderes)
            {
                if (nombrePoder == p.Nombre)
                {
                    costoKiTotal = p.CostoAgi + p.CostoCon + p.CostoDes + p.CostoFue + p.CostoPod + p.CostoVol;
                    KiPropio.RestarKi(p.CostoAgi, p.CostoCon, p.CostoDes, p.CostoFue, p.CostoPod, p.CostoVol,costoKiTotal);
                    break;
                }
            }
        }

        public string nombreUltimoPoder()
        {
            return Poderes.Last().Nombre;
        }

        public static bool operator !=(Jugador jugador, Poder poder)
        {
            return !(jugador == poder);
        }

        

    }
}
