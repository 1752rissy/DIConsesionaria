using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioDIConsesionaria.Modelo;

namespace EjercicioDIConsesionaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Aseguradora aseguradora = new Aseguradora();
            Consesionaria consesionaria = new Consesionaria(aseguradora);
            Persona facu = new Persona(consesionaria);

            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Modelo = "Hilux";
            vehiculo.Patente = "AE 528 JS";
            vehiculo.Precio = 3528741;

            Console.WriteLine("costo del vehiculo adquirido "+ facu.ComprarVehiculo(vehiculo));

            Console.ReadLine();

            //Persona facu = new Persona();
        }
    }
}
