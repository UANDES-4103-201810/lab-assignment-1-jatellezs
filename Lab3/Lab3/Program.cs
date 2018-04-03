using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Accesorio a1 = new Accesorio("GPS", 15000);
            Persona p1 = new Persona("19079901-8", true, 1);


            Console.WriteLine("Ingrese la opcion deseada: ");
            Console.WriteLine("(1) Agregar Sucursal");

            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Ingrese id de sucursal: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la direccion de sucursal: ");
                string direccion = Console.ReadLine();
                Sucursal s1 = new Sucursal(id, direccion);
            }
        }
    }
}
