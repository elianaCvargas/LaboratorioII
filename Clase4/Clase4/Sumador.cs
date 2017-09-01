using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4
{
    class Sumador
    {
        private int cantidadSumas;
       

        public Sumador()
        {
            this.cantidadSumas = 0;
        }

        public Sumador(int valor)
        {
            this.cantidadSumas = valor;
        }

        public long Sumar(long a, long b)
        {
            long resultado;
            resultado = a + b;
            this.cantidadSumas ++;
            return resultado;
        
        }

        public string Sumar(string a, string b)
        {
            string resultado;
            resultado = a + b;
            this.cantidadSumas++;
            return resultado;

        }

        

     
        //Sobrecarga de operador (en  este caso,  suma)
        public static long operator+(Sumador a, int b)
        {
            long retorno = 0;
            retorno = a.cantidadSumas + b;
            return retorno;
        }
        //Sobrecarga de operador distinto  (!=)
        public static bool operator !=(Sumador a, Sumador b)
        {
            bool retorno = false;
            if (a.cantidadSumas != b.cantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }

        //conversion explicita del tipo  Sumador a int (?)
        public static explicit operator int (Sumador a)
        {
            return a.cantidadSumas; 
        }



        public int getCantSumas()
        {
            return this.cantidadSumas;
        }


    }
}
