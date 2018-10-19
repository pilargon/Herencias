using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_de_futbol
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.-Realiza una estructura de datos para almacenar a los miembros de una selección de futbol. 
            //Añade un entrenador, dos masajistas y 4 futbolistas. Mostrar los datos de todos los integrantes.
            Entrenador e1 = new Entrenador(1, "Paco", "Peluca", 55,0,123);
            Masajista m1 = new Masajista(2, "Pinky", "Winky", 43,0, 1, "Grado en Masajista");
            Masajista m2 = new Masajista(3, "Pan", "Chocolate", 25,0, 10, "Fp Masajes");
            Futbolista f1 = new Futbolista(4, "Juanito", "Calvicie", 20,0, 23, "defensa");
            Futbolista f2 = new Futbolista(5, "Pele", "de la Pelotillas", 22,0, 1, "portero");
            Futbolista f3 = new Futbolista(6, "Chino", "Cudeiro", 21,0, 10, "lateral");
            Futbolista f4 = new Futbolista(7, "Pocholo", "Toloco", 24,0, 12, "defensa");

            //ESTO ES OTRA FORMA DE HACERLO,PERO NOS PIDEN POR LISTAS.
            //Console.WriteLine(e1.MostrarDatosEntrenador()); 
            //Console.WriteLine(m1.MostrarDatosMasajista());
            //Console.WriteLine(m2.MostrarDatosMasajista());
            //Console.WriteLine(f1.MostrarDatosFutbolista());
            //Console.WriteLine(f2.MostrarDatosFutbolista());
            //Console.WriteLine(f3.MostrarDatosFutbolista());
            //Console.WriteLine(f4.MostrarDatosFutbolista());

            List<Entrenador> listaEntrenador = new List<Entrenador>();
            listaEntrenador.Add(e1);
            foreach (Entrenador e in listaEntrenador)
            {
                Console.WriteLine(e.MostrarDatosEntrenador());
            }
            List<Masajista> listaMasajista = new List<Masajista>();
            listaMasajista.Add(m1);
            listaMasajista.Add(m2);          
            foreach (Masajista e in listaMasajista)
            {
                Console.WriteLine(e.MostrarDatosMasajista());
            }
            List<Futbolista> listaFutbolista = new List<Futbolista>();
            listaFutbolista.Add(f1);
            listaFutbolista.Add(f2);
            listaFutbolista.Add(f3);
            listaFutbolista.Add(f4);
            foreach (Futbolista e in listaFutbolista)
            {
                Console.WriteLine(e.MostrarDatosFutbolista());
            }

            Console.WriteLine("Vamos a viajar a Londres? S/N");
            string respuesta = Console.ReadLine();

            if(respuesta.ToUpper()=="S")
            {
               return viajar= true;
            }
            else
            {
                return false;
            }



            Console.ReadLine();
        }
        public static string MostrarDatos(int id, string nombre, string apellidos, int edad)
        {
            return ("Id: " + id + "\nNombre: " + nombre + "\nApellidos: " + apellidos + "\nEdad: " + edad);
        }

        


    }
}
