using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Sucursal
    {
        int id;
        string direccion;

        public Sucursal(int miId, string miDireccion)
        {
            miId = id;
            miDireccion = direccion;
        }

        public void AgregarSucursal(int id, string direccion)
        {
            Sucursal s1 = new Sucursal(id, direccion);
        }
    }
}
