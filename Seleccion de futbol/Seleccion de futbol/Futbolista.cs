using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_de_futbol
{
    class Futbolista : SeleccionDeFutbol
    {
        private int dorsal;
        private string demarcacion;

        public Futbolista()
        {

        }
        public Futbolista(int id, string nombre, string apellidos, int edad,int contador, int dorsal, string demarcacion) : base(id, nombre, apellidos, edad, contador)
        {
            this.dorsal = dorsal;
            this.demarcacion = demarcacion;
        }

        public bool JugarPartido()
        {
            if(Entrenar()==true)
            {
                Console.WriteLine("El futbolista va a jugar");
            }
            else
            {
                Console.WriteLine("El futbolista no va a jugar");
            }
            return true;
        }

        public bool Entrenar()
        {
            if(Viajar()==true)
            {
                Console.WriteLine("El futbolista va a entrenar");
            }
            return true;
        }

        public string MostrarDatosFutbolista()
        {
            return base.MostrarDatos() + "\nDorsal: " + dorsal + "\nDemarcacion: " + demarcacion;
        }
    }
}
