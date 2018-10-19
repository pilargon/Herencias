using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //CocheSimple cs1 = new CocheSimple("Ferrari","Testa Rosa", 120);
            Taxi t1 = new Taxi("Fiat", "Punto", 120, "abc");
            Console.WriteLine(t1.GetMarca());
            t1.SetMarca("Stilo");
            Console.WriteLine(t1.GetMarca());
            Console.ReadLine();
        }
    }
}