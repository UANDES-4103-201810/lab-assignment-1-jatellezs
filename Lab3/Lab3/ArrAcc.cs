using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class ArrAcc : Arriendo
    {
        Accesorio accesorio;

        public ArrAcc(Accesorio miAccesorio, Cliente miCliente, Vehiculo miVehiculo, int miCosto)
            : base (miCliente, miVehiculo, miCosto)
        {
            miAccesorio = accesorio;
        }

        public override bool VArriendo()
        {

        }
    }
}
