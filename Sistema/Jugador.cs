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


        public void AgregarPoder(Poder nuevoPoder)
        {
            poderes.Add(nuevoPoder);
        }



       

        
    }
}
