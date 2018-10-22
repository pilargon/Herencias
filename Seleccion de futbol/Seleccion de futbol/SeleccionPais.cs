using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_de_futbol
{
    class SeleccionPais : SeleccionDeFutbol
    {
        private string nombrePais=nombre;
        private int participantes;
        private int topeParticipantes = 30;
        private int topeMasajistas = 4;
        private int topeEntrenador = 2;
        //private int contador;

        private List<SeleccionDeFutbol> seleccionPais;

        public SeleccionPais()
        {

        }
        public SeleccionPais(string nombrePais,int participantes)
        {
            this.nombrePais = nombrePais;
            this.participantes = participantes;
            seleccionPais = new List<SeleccionDeFutbol>();
        }
        public SeleccionPais(string nombrePais, int participantes, List<SeleccionDeFutbol> seleccionPais)
        {
            this.nombrePais = nombrePais;
            this.participantes = participantes;
            this.seleccionPais = seleccionPais;
        }
        public void AñadirParticipantes(SeleccionDeFutbol e1, SeleccionDeFutbol m1, SeleccionDeFutbol m2, SeleccionDeFutbol f1, SeleccionDeFutbol f2, SeleccionDeFutbol f3, SeleccionDeFutbol f4)
        {
            seleccionPais.Add(e1);
            seleccionPais.Add(m1);
            seleccionPais.Add(m2);
            seleccionPais.Add(f1);
            seleccionPais.Add(f2);
            seleccionPais.Add(f3);
            seleccionPais.Add(f4);
        }
        public List<SeleccionDeFutbol> GetSeleccionPais()
        {
            return seleccionPais;
        }

        //MostrarDatosSelección(): Muestra el nombre del país, el número de integrantes y sus datos

        public string MostrarDatosSeleccion()
        {
            return "Nombre del pais: " + nombrePais + "\nNumero de integrantes: " + base.Contador() + "\nDatos de los integrantes: " + base.MostrarDatos();
        }


    }
}
