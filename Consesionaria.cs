using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioDIConsesionaria.Modelo;

namespace EjercicioDIConsesionaria
{
    public class Consesionaria
    {
        private readonly Aseguradora _aseguradora;

        public Consesionaria(Aseguradora aseguradora)
        {
            _aseguradora = aseguradora;
        }


        public double VenderVehiculo(Vehiculo vehiculo)
        {
            double precio = vehiculo.Precio + _aseguradora.CalcularPoliza(vehiculo);
            return precio;
        }


       

    }
}
