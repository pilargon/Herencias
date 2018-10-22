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
        private bool viajar;
        private bool darMasaje;

        public Masajista()
        {

        }
        public Masajista(int id, string nombre, string apellidos, int edad, int aniosExperiencia, string titulacion)
            : base(id, nombre, apellidos, edad)
        {
            this.aniosExperiencia = aniosExperiencia;
            this.titulacion = titulacion;
        }
        public bool DarMasaje()
        {
            Console.WriteLine("El masajista va a dar masajes");
            return darMasaje=true;
        }

        public string MostrarDatosMasajista()
        { 
            return base.MostrarDatos() + "\nTitulacion: "+titulacion +"\nExperiencia: "+aniosExperiencia;
        }
        public bool Viajar()
        {
            Console.WriteLine("El masajista va a viajar");
            return viajar = true;
        }

    }
}
