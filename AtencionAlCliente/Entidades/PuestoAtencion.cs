using Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Entidades
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
            :this()
        {
            this.puesto = puesto;
        }

        public static int NumeroActual {
            get { return PuestoAtencion.numeroActual+1; }           
        }

        public bool Atender(Cliente cliente)
        {
                Thread.Sleep(5000);
                return true;                        
        }

    }
}
