using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2017
{
    class Jugador: Persona
    {
        private bool esCapitan;
        private int numero;

        public Jugador(string nombre, string apellido)
            :this(nombre, apellido,0,  false)
        {
             
        }
        public Jugador(string nombre, string apellido, int numero, bool capitan)
            : base(nombre, apellido)
        {
            this.numero = numero;
            this.esCapitan = capitan;
        }


        public bool EsCapitan {
            get { return this.esCapitan; }
            set { this.esCapitan = value; }
        }
        public int Numero { 
            get{ return this.numero;}
            set { this.numero = value; }
        }
           

        public override string FichaTecnica()
        {
            string nombreApellido = NombreCompleto();
            string esCap = " capitan del equipo";
            string camiseta = " camiseta numero: ";
                      
            if (EsCapitan == true)
            {
                return string.Format("{0} {1}, {2} {3}", nombreApellido, esCap, camiseta, Numero);//posible error
            }
            return string.Format("{0} {1}, {2}", nombreApellido, camiseta, Numero);
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            bool retorno = false;
            if (jugador1.Nombre == jugador2.Nombre && jugador1.Apellido == jugador2.Apellido && jugador1.Numero == jugador2.Numero)
            {            
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }


        public static explicit operator int(Jugador jugador)
        {
            return jugador.Numero;
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }
        public override bool Equals(object a)
        {
            if (a is Jugador)
            {
                if ((Jugador)a == this)
                {
                    return true;
                }
            }
            
            return false;
        }


    
    }
}
