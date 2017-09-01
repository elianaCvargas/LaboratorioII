using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }


        public static double operator +(NumeroBinario a, NumeroDecimal b)
        {
            double suma;
         
            double converDoubleA = Conversor.BinarioDecimal((string)a);

            suma = converDoubleA + (double)b;
            return suma;
        }

        public static double operator -(NumeroBinario a, NumeroDecimal b)
        {
            double resta;
            double converDoubleA = Conversor.BinarioDecimal((string)a);
            resta = converDoubleA + (double)b;
            return resta;
        }

        public static bool operator ==(NumeroBinario a, NumeroDecimal b)
        {
            bool retorno = false;
            string decimalABin = Conversor.DecimalBinario((double)b);
            if ((string)a == decimalABin)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(NumeroBinario a, NumeroDecimal b)
        {
            bool retorno = false;
            string decimalABin = Conversor.DecimalBinario((double)b);
            if ((string)a != decimalABin)
            {
                retorno = true;
            }
            return retorno;
        }

        //pasamos numero decimal a doble,  esta sentencia habilita que podamos convertir nuestro  tiupo  de datos a otro.
        public static explicit operator double(NumeroDecimal a)
        {
            return a.numero;
        }


      

    }
}
