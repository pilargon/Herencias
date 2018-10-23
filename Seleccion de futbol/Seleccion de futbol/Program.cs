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

            Console.WriteLine("Menu\n" + "*****************\n" + "1)Alta participante\n" + "2)Baja participante\n" + "3)Mostrar datos seleccion\n" + "4)Preparar partido\n" + "5)Jugar partido\n" + "6)Salir\n");
            int respuesta = Convert.ToInt32(Console.ReadLine());

            switch (respuesta)
            {
                case 1://alta
                    Console.WriteLine("1)Crear entrenador\n" + "2)Crear masajista\n" + "3)Crear futbolista");
                    int respuestacrear = Convert.ToInt32(Console.ReadLine());
                    switch (respuestacrear)
                    {
                        case 1:
                            CrearEntrenador();
                            break;
                        case 2:
                            CrearMasajista();
                            break;
                        case 3:
                            CrearFutbolista();
                            break;
                    }
                    break;
                case 2://baja

                    BajaSeleccion();
                    break;

                case 3://mostrar datos

                    MostrarDatos();
                    break;
                case 4:

                    break;


            }






            //3.-Realiza una estructura de datos para almacenar a los miembros de una selección de futbol. 
            //Añade un entrenador, dos masajistas y 4 futbolistas. Mostrar los datos de todos los integrantes.
            /*SeleccionDeFutbol s1 = new SeleccionDeFutbol();*///he tenido que comentar porque suma 1 al contador.
            Entrenador e1 = new Entrenador(1, "Paco", "Peluca", 55, 123);
            Masajista m1 = new Masajista(2, "Pinky", "Winky", 43, 1, "Grado en Masajista");
            Masajista m2 = new Masajista(3, "Pan", "Chocolate", 25, 10, "Fp Masajes");
            Futbolista f1 = new Futbolista(4, "Juanito", "Calvicie", 20, 23, "defensa");
            Futbolista f2 = new Futbolista(5, "Pele", "de la Pelotillas", 22, 1, "portero");
            Futbolista f3 = new Futbolista(6, "Chino", "Cudeiro", 21, 10, "lateral");
            Futbolista f4 = new Futbolista(7, "Pocholo", "Toloco", 24, 12, "defensa");


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
                Console.WriteLine(e.MostrarDatos());
            }
            List<Masajista> listaMasajista = new List<Masajista>();
            listaMasajista.Add(m1);
            listaMasajista.Add(m2);
            foreach (Masajista e in listaMasajista)
            {
                Console.WriteLine(e.MostrarDatos());
            }
            List<Futbolista> listaFutbolista = new List<Futbolista>();
            listaFutbolista.Add(f1);
            listaFutbolista.Add(f2);
            listaFutbolista.Add(f3);
            listaFutbolista.Add(f4);
            foreach (Futbolista e in listaFutbolista)
            {
                Console.WriteLine(e.MostrarDatos());
            }

            foreach (Futbolista futbolista in listaFutbolista)
            {
                futbolista.Viajar();
                futbolista.Entrenar();
                break;
            }
            foreach (Entrenador entrenador in listaEntrenador)
            {
                entrenador.Viajar();
                entrenador.DirigirEntrenamiento();
                break;
            }
            foreach (Masajista masajista in listaMasajista)
            {
                masajista.Viajar();
                masajista.DarMasaje();
                break;
            }

            Console.WriteLine("El numero de integrantes es :" + e1.Contador());


            List<SeleccionDeFutbol> list1 = new List<SeleccionDeFutbol>()
            {
                e1,m1,m2,f1,f2,f3,f4
            };

            SeleccionPais g1 = new SeleccionPais();
            SeleccionPais g2 = new SeleccionPais();


            //g2.AñadirParticipantes(e1);
            //g2.AñadirParticipantes(m1);
            //g2.AñadirParticipantes(m2);
            //g2.AñadirParticipantes(f1);
            //g2.AñadirParticipantes(f2);
            //g2.AñadirParticipantes(f3);
            //g2.AñadirParticipantes(f4);


            g2.AñadirIntegrante(e1);
            g2.AñadirIntegrante(m1);
            g2.AñadirIntegrante(m2);
            g2.AñadirIntegrante(f1);
            g2.AñadirIntegrante(f2);
            g2.AñadirIntegrante(f3);
            g2.AñadirIntegrante(f4);

            g2.BajaSeleccion(e1);
            g2.MostrarDatosSeleccion();
            g2.PrepararPartido();
            g2.JugarPartido();
            foreach (SeleccionDeFutbol participante in g1.GetSeleccionPais())
            {
                Console.WriteLine(g2.GetType().Name.ToUpper());
                Console.WriteLine(g2.ToString());
                Console.WriteLine("**************************");
            }

            Console.WriteLine("Número de integrantes: " + g2.GetSeleccionPais().Count);

            Console.ReadLine();
        }

        public static Entrenador CrearEntrenador()
        {
            return new Entrenador();
        }
        public static Masajista CrearMasajista()
        {
            return new Masajista();
        }
        public static Futbolista CrearFutbolista()
        {
            return new Futbolista();
        }
        public static Masajista CrearMasajista(int id, string nombre, string apellido, int edad, int aniosExperiencia, string titulacion)
        {
            return new Masajista(id, nombre, apellido, edad, aniosExperiencia, titulacion);
        }
        public static Entrenador CrearEntrenador(int id, string nombre, string apellido, int edad, int idFederacion)
        {
            return new Entrenador(id, nombre, apellido, edad, idFederacion);
        }
        public static Futbolista CrearFutbolista(int id, string nombre, string apellido, int edad, int dorsal, string demarcacion)
        {
            return new Futbolista(id, nombre, apellido, edad, dorsal, demarcacion);
        }
        public static string MostrarDatos(int id, string nombre, string apellidos, int edad)
        {
            return ("Id: " + id + "\nNombre: " + nombre + "\nApellidos: " + apellidos + "\nEdad: " + edad);
        }





    }
}
