using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioDIConsesionaria.Modelo;

namespace EjercicioDIConsesionaria
{
    public class Aseguradora
    {
        public string NombreAseguradora { get; set; }
        //private readonly Vehiculo _vehiculo;
        //public Aseguradora(Vehiculo vehiculo)
        //{
        //    _vehiculo = vehiculo;
        //}

        public double CalcularPoliza(Vehiculo vehiculo)
        {
            if (vehiculo.Modelo == "Hilux")
                return vehiculo.Precio * 0.25;
            else
                return 3698.85;
        }
    }
}
