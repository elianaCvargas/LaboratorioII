using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double num)
        {
            string binario = "";
            int numero;
            
            numero = Convert.ToInt32(num);

            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }
                    numero = (int)numero / 2;
                }
            }
            else if (numero == 0)
            {
                binario = "0";
            }
            else
            {
                binario = "No se pudo convertir el numero. Ingrese solo numeros positivos";
            }

            return binario;
        }

        public static double BinarioDecimal(string num)
        {
            int exponente = num.Length - 1;
            int num_decimal = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (int.Parse(num.Substring(i, 1)) == 1)
                {
                    num_decimal = num_decimal + int.Parse(System.Math.Pow(2, double.Parse(exponente.ToString())).ToString());
                }
                exponente--;
            }
            return num_decimal;
        }
    }
}
