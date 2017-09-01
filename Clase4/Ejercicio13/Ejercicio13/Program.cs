using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            string numBin;

            Console.Write("Ingrese un numero decimal: ");
            num = Convert.ToDouble(Console.ReadLine());

            numBin = Conversor.DecimalBinario(num);

            Console.WriteLine("El numero binario es: {0}", numBin);

            Console.Write("Ingrese un numero binario: ");
            numBin = Convert.ToString(Console.ReadLine());

            num = Conversor.BinarioDecimal(numBin);

            Console.WriteLine("El numero decimal es: {0}", num);

            Console.ReadKey();
        }
    }
}
