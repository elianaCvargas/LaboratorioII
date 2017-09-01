using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    class NumeroBinario
    {
        
        private string numero;
        

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }



        public static string operator +(NumeroBinario a, NumeroDecimal b)
        {
            string retorno;
            double suma;
            double converDoubleA = Conversor.BinarioDecimal((string)a);
            suma = converDoubleA + (double)b;
            retorno = Conversor.DecimalBinario((double)suma);
            return retorno;
        }

        public static string operator -(NumeroBinario a, NumeroDecimal b)
        {
            string retorno;
            double suma;
            double converDoubleA = Conversor.BinarioDecimal((string)a);
            suma = converDoubleA - (double)b;
            retorno = Conversor.DecimalBinario((double)suma);
            return retorno;
        }

        public static bool operator ==(NumeroBinario a, NumeroDecimal b)
        {
            bool retorno =  false;
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

        //lepaso  un obj de MI tipo y  lo  convierto (o  habilito a convertir) a uno de tipo string (puede serint,  double,  float)
        public static explicit operator string(NumeroBinario a)
        {
            return a.numero;
        }
        //modo invertido  al  anterior, convierto  cualquier tipo de datos al  MIO
        public static implicit operator NumeroBinario(string a)
        {
            NumeroBinario obj = new NumeroBinario(a);
            return obj;
        }

       


    }
}
    