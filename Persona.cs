using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioDIConsesionaria.Modelo;

namespace EjercicioDIConsesionaria
{
    public class Persona
    {
        private readonly Consesionaria _consesionaria;
        public Persona(Consesionaria consesionaria)
        {
            _consesionaria = consesionaria;
        }

        public double ComprarVehiculo(Vehiculo vehiculo)
        {
            return _consesionaria.VenderVehiculo(vehiculo);
        }
    }
}
