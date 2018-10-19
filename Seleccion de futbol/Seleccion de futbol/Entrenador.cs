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

        public Entrenador()
        {

        }
        public Entrenador(int id, string nombre, string apellidos, int edad,int contador,int idFederacion)
            : base(id, nombre, apellidos, edad,contador)
        {
            this.idFederacion = idFederacion;
        }

        public string MostrarDatosEntrenador()
        {
            return base.MostrarDatos() + "\nId Federacion: "+idFederacion;
        }

        public bool DirigirPartido()
        {
            if(DirigirEntrenamiento()==true)
            {
                Console.WriteLine("El entrenador va a dirigir el Partido");
            }
            return true;
        }
        public bool DirigirEntrenamiento()
        {
            if (Viajar() == true)
            {
                Console.WriteLine("El entrenador va a dirigir el Entrenamiento");
            }
            return true;
        }
    }
}
