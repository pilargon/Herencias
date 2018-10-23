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
        static int contador=0;
        private bool viajar=false;
        private bool concentrarse=false;
        //2.-Añade un contador  a la clase padre que contabilice el número total de integrantes de la selección.

        public SeleccionDeFutbol(int id, string nombre, string apellidos, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            contador++;
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
            return contador;
        }
       
        public virtual string MostrarDatos()
        {
            return "********************\nId: " + id + "\nNombre: " + nombre + "\nApellidos: " + apellidos + "\nEdad: " + edad ;
        }
        




    }










}
