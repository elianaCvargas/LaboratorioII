using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            string numBin;
           // NumeroBinario numBin1 = new NumeroBinario();


            Console.Write("Ingrese un numero decimal: ");
            num = Convert.ToDouble(Console.ReadLine());

            numBin = Conversor.DecimalBinario(num);

            Console.WriteLine("El numero binario es: {0}", numBin);

            Console.Write("Ingrese un numero binario: ");
            numBin = Convert.ToString(Console.ReadLine());

            num = Conversor.BinarioDecimal(numBin);

            Console.WriteLine("El numero decimal es: {0}", num);


            NumeroBinario objBinario = "1001";
            //NumeroDecimal objDecimal = 9;

            string injh= (string)objBinario;







            Console.ReadKey();
        }
    }
}

