using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Empresa : Cliente
    {
        public bool Autorizacion;

        public Empresa(bool miAutorizacion, string miRut, int miId)
            : base (miId, miRut)
        {
            miAutorizacion = Autorizacion;
        }

        public bool getmiAutorizacion
        {
            get { return Autorizacion; }
        }

    }
}
