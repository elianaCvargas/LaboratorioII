using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2017
{
    public abstract class   Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre { 
            get { return this.nombre; } 
        }
        public string Apellido
        {
            get { return this.apellido; }
        }

        protected abstract string FichaTecnica();
        protected virtual string NombreCompleto()
        {
            return string.Format("{0} {1}", nombre, apellido);
         
        }
        



    }
}
