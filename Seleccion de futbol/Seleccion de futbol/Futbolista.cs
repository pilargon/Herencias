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
        private bool entrenar=false;
        private bool jugarpartido=false;
        private bool viajar = false;

        public Futbolista()
        {

        }
        public Futbolista(int id, string nombre, string apellidos, int edad, int dorsal, string demarcacion) : base(id, nombre, apellidos, edad)
        {
            this.dorsal = dorsal;
            this.demarcacion = demarcacion;
        }

        public bool JugarPartido()
        {
            Console.WriteLine("El futbolista va a jugar el partido");
            return jugarpartido = true;
        }

        public bool Entrenar()
        {
            Console.WriteLine("El futbolista va a entrenar");
            return entrenar = true;
        }
        public bool Viajar()
        {
            Console.WriteLine("El futbolista va a viajar");
            return viajar = true;
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos() + "\nDorsal: " + dorsal + "\nDemarcacion: " + demarcacion+"\n";
        }
    }
}
