using Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientesList;
        private string nombre;

        public Negocio()
        {
            clientesList = new Queue<Cliente>();
            caja = new PuestoAtencion(Puesto.Caja1);
           // caja = Puesto.Caja1;
        }
        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        public Cliente Cliente {
            
            get 
            {
                return this.clientesList.Dequeue();
                //Devuelve el primer elemento de la fila
            }
            set
            {
                if (this != value)
                {
                    bool a = this + value;                   
                }

            }
        }

        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            bool retorno = false;
            foreach (Cliente item in negocio.clientesList)
            {
                if (item == cliente)
                {
                    retorno = true;
                    break;
                }                
            }           
            return retorno;
        }
        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);
        }
        public static bool operator +(Negocio negocio, Cliente cliente)
        {
            if ((negocio != cliente))
            {
                negocio.clientesList.Enqueue(cliente);
                return true;
            }
            return false;
        }
        public static bool operator ~(Negocio negocio)
        {            
            return negocio.caja.Atender(negocio.Cliente);
        }
    }
}
