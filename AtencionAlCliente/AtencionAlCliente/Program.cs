using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    class Program
    {
        static void Main(string[] args)
        {

            bool retorno = false;
            Console.WriteLine(retorno);
            while (!retorno)
            {
                Thread.Sleep(5000);
                retorno = true;
            }

            Console.WriteLine(retorno);
            Console.ReadKey();
        }
    }
}
