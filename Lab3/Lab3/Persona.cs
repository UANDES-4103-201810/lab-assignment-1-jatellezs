using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Persona : Cliente
    {
        public bool licencia;

        public Persona(string miRut, bool miLicencia, int miId)
            : base (miId, miRut)
        {
            miLicencia = licencia;
        }

        public bool getmiLicencia
        {
            get { return licencia; }
        }
    }
}
