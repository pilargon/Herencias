using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_de_futbol
{
    class Entrenador:SeleccionDeFutbol
    {
        private int idFederacion;
        private bool dirigirEntrenamiento;
        private bool viajar;
        private bool dirigirPartido;

        public Entrenador()
        {

        }
        public Entrenador(int id, string nombre, string apellidos, int edad,int idFederacion)
            : base(id, nombre, apellidos, edad)
        {
            this.idFederacion = idFederacion;
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos() + "\nId Federacion: "+idFederacion;
        }

        public bool DirigirPartido()
        {            
            Console.WriteLine("El entrenador va a dirigir el Partido");
            return dirigirPartido=true;
        }
        public bool DirigirEntrenamiento()
        {
            Console.WriteLine("El entrenador va a dirigir el entrenamiento");
            return dirigirEntrenamiento = true;
        }
        public bool Viajar()
        {
            Console.WriteLine("El entrenador va a viajar");
            return viajar = true;
        }
    }
}
