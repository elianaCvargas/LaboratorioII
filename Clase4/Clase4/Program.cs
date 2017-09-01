using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable; 
           
            Sumador suma1 = new Sumador();
            variable = (int)suma1;

            Sumador suma2 = new Sumador();
            Sumador sumaConValor = new Sumador(5);

            //suma1.Sumar(5,5);
            Console.WriteLine("Constructor predefinido en 0, valor: {0}", suma1.getCantSumas());
            Console.ReadKey();

            Console.WriteLine("Suma de enteros");
            Console.WriteLine(suma1.Sumar(5, 2));
            Console.WriteLine("Constructor Suma enteros");
            Console.WriteLine(suma1.getCantSumas());
            Console.ReadKey();

            Console.WriteLine("Suma de strings");
            Console.WriteLine(suma2.Sumar("4", "5"));

            Console.WriteLine("Constructor inicializado");
            Console.WriteLine(sumaConValor.Sumar(5, 6));
            Console.WriteLine(sumaConValor.Sumar(5, 7));
            Console.WriteLine("cantidad de sumas con contructor inicializado");
            Console.WriteLine(sumaConValor.getCantSumas());


            Console.ReadKey();
        }
    }
}
