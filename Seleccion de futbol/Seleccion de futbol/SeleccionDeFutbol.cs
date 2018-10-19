using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion_de_futbol
{
    class SeleccionDeFutbol
    {
        private int id;
        private string nombre;
        private string apellidos;
        private int edad;
        private int contador;
        private bool viajar=false;
        private bool concentrarse=false;
        //2.-Añade un contador  a la clase padre que contabilice el número total de integrantes de la selección.

        public SeleccionDeFutbol(int id, string nombre, string apellidos, int edad, int contador)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.contador++;
        }
        public SeleccionDeFutbol()
        {
            contador++;
        }//constructor vacio
        public int GetId()
        {
            return id;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellidos()
        {
            return apellidos;
        }
        public int GetEdad()
        {
            return edad;
        }
        public int GetContador()
        {
            return contador;
        }
        public bool GetViajar()
        {
            return viajar=false;
        }
        public bool GetConcentrarse()
        {
            return concentrarse = false;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetViajar(bool viajar)
        {
            this.viajar = viajar;
        }
        public void SetConcentrarse(bool concentrarse)
        {
            this.concentrarse=concentrarse;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public void SetContador(int contador)
        {
            this.contador=contador;
        }

        public bool Concentrarse()
        {
            return concentrarse=true;
        }
        public bool Viajar()
        {
            return viajar=true;
        }

        public int Contador()
        {
            contador++;
            return contador;
        }
        public string MostrarDatos()
        {
            return "********************\nId: " + id + "\nNombre: " + nombre + "\nApellidos: " + apellidos + "\nEdad: " + edad + "\nContador: " + contador;
        }
    }










}
