using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_de_futbol
{
    class Masajista:SeleccionDeFutbol
    {
        private string titulacion;
        private int aniosExperiencia;

        public Masajista()
        {

        }
        public Masajista(int id, string nombre, string apellidos, int edad,int contador, int aniosExperiencia, string titulacion)
            : base(id, nombre, apellidos, edad,contador)
        {
            this.aniosExperiencia = aniosExperiencia;
            this.titulacion = titulacion;
        }
        public bool DarMasaje()
        {
            if (Viajar() == true)
            {
                Console.WriteLine("El masajista va a dar masajes");
            }
            return true;
        }

        public string MostrarDatosMasajista()
        { 
            return base.MostrarDatos() + "\nTitulacion: "+titulacion +"\nExperiencia: "+aniosExperiencia;
        }

    }
}
