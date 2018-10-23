using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_de_futbol
{
    class SeleccionPais : SeleccionDeFutbol
    {
        private string nombrePais = "Japon";
        private int participantes;
        private int topeParticipantes = 30;
        private int topeMasajistas = 4;
        private int topeEntrenador = 2;
        //private int contador;

        private List<SeleccionDeFutbol> seleccionPais;

        public SeleccionPais()
        {
            seleccionPais = new List<SeleccionDeFutbol>();
        }
        public SeleccionPais(SeleccionDeFutbol seleccionado, string nombre)
        {
            this.nombrePais = nombre;
            seleccionPais = new List<SeleccionDeFutbol>();
            seleccionPais.Add(seleccionado);
        }
        public SeleccionPais(string nombrePais, int participantes)
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
        public void AñadirParticipantes(SeleccionDeFutbol participante)
        {
            seleccionPais.Add(participante);
        }
        public List<SeleccionDeFutbol> GetSeleccionPais()
        {
            return seleccionPais;
        }
        private static int numeroMasajistas, numeroFutbolistas, numeroEntrenadores;

        public void AñadirIntegrante(SeleccionDeFutbol c)
        {
            //Si el método MeterVehiculo nos devuelve true, añadiremos el vehículo
            if (MeterIntegrante(c))
            {
                //Si el objeto que queremos meter es un Taxi, le añadimos uno al contador de taxis.
                if (c.GetType().Name == "Entrenador")
                {
                    numeroEntrenadores++;
                }
                //Si el objeto que queremos meter es un Autobus, le añadimos uno al contador de autobuses.
                else if (c.GetType().Name == "Masajista")
                {
                    numeroMasajistas++;
                }
                else if (c.GetType().Name == "Futbolista")
                {
                    numeroFutbolistas++;
                }
                //Como hemos verificado que se puede meter, lo metemos
                Console.WriteLine("Integrante del tipo " + c.GetType().Name + " añadido.");
                seleccionPais.Add(c);
            }
        }

        public bool MeterIntegrante(SeleccionDeFutbol c)
        {
            //Primero compruebo que el garaje no este lleno, el tope es de 6 vehiculos
            if (seleccionPais.Count < 30)
            {
                //si el tipo de vehiculo que quiero meter es un bus y no hay mas buses en el garaje, se puede merter (return true) 
                if (c.GetType().Name == "Entrenador" && numeroEntrenadores < 4)
                {
                    return true;
                }
                //si el tipo de vehiculo que quiero meter es un taxi y no hay mas taxis en el garaje, se puede merter (return true) 
                else if (c.GetType().Name == "Masajista" && numeroMasajistas < 2)
                {
                    return true;
                }
                //en el caso de cochesimple podrás meter todos los que quieras
                else if (c.GetType().Name == "Futbolista")
                {
                    return true;
                }
                Console.WriteLine("No caben más " + c.GetType().Name + "s en la seleccion");
                Console.ReadLine();
                return false;
            }
            Console.WriteLine("No caben más " + c.GetType().Name + "s en la seleccion");
            Console.ReadLine();
            return false;
        }

        public bool BajaSeleccion(SeleccionDeFutbol c)
        {
            if (/*seleccionPais.IndexOf(c)!=-1 && */c.GetType().Name == "Entrenador" && numeroEntrenadores > 0)
            {
                numeroEntrenadores--;
                seleccionPais.Remove(c);
                Console.WriteLine("Se ha echado al entrenador");
                return true;
            }
            else if (/*seleccionPais.IndexOf(c) != -1 && */c.GetType().Name == "Masajista" && numeroMasajistas > 0)
            {
                numeroMasajistas--;
                seleccionPais.Remove(c);
                Console.WriteLine("Se ha echado al masajista");
                return true;
            }
            else if (/*seleccionPais.IndexOf(c) != -1 && */c.GetType().Name == "Futbolista" && numeroFutbolistas > 0)
            {
                numeroFutbolistas--;
                seleccionPais.Remove(c);
                Console.WriteLine("Se ha echado al futbolista");
                return true;
            }
            else
            {
                Console.WriteLine("No hay ningun " + c.GetType().Name + "s en la seleccion");
                return false;
            }
        }

        //MostrarDatosSelección(): Muestra el nombre del país, el número de integrantes y sus datos
        public void MostrarDatosSeleccion()
        {
            Console.WriteLine("***********" + "\nNombre del pais: " + nombrePais);
            Console.WriteLine("Numero de integrantes: " + (numeroEntrenadores + numeroFutbolistas + numeroMasajistas) + "\nEntrenadores:" + numeroEntrenadores + "\nFutbolistas:" + numeroFutbolistas + "\nMasajistas:" + numeroMasajistas);
            foreach (SeleccionDeFutbol miembros in seleccionPais)
            {
                Console.WriteLine("\nDatos de los integrantes: " + "\n***********" + miembros.MostrarDatos());
            }

        }
       
        public void PrepararPartido()
        {
            Console.WriteLine("La seleccion va a viajar a la sede\n**********************");

            foreach (SeleccionDeFutbol gente in seleccionPais)
            {               
                if (gente.GetType().Name == "Entrenador")
                {
                    Console.WriteLine(gente.GetNombre() + " " + gente.GetApellidos() + " que es entrenador,se concentra y dirige entrenamiento");
                }
                if (gente.GetType().Name == "Masajista")
                {
                    Console.WriteLine(gente.GetNombre() + " " + gente.GetApellidos() + " que es masajista,se concentra y da masajes");
                }
                if (gente.GetType().Name == "Futbolista")
                {
                    Console.WriteLine(gente.GetNombre() + " " + gente.GetApellidos() + " que es futbolista,se concentra y entrena");
                }
            }
        }

        public void JugarPartido()
        {
            Console.WriteLine("\nLa seleccion va a jugar\n**********************");

            foreach (SeleccionDeFutbol gente in seleccionPais)
            {
                if (gente.GetType().Name == "Entrenador")
                {
                    Console.WriteLine(gente.GetNombre() + " " + gente.GetApellidos() + " que es entrenador,dirige el partido");
                }
                if (gente.GetType().Name == "Masajista")
                {
                    Console.WriteLine(gente.GetNombre() + " " + gente.GetApellidos() + " que es masajista,da masajes");
                }
                if (gente.GetType().Name == "Futbolista")
                {
                    Console.WriteLine(gente.GetNombre() + " " + gente.GetApellidos() + " que es futbolista,juega el partido");
                }
            }
        }





    }




}
