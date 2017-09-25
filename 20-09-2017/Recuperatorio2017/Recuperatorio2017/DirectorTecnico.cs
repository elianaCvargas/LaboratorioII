using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2017
{
    public class DirectorTecnico: Persona
    {
        public DirectorTecnico(string nombre, string apellido)
            :base(nombre, apellido)
        { 
        
        }
        public override string FichaTecnica()
        {
            //string baseName = base.NombreCompleto();
            return string.Format("Capitan: {0}", base.NombreCompleto());
        }
        public string ToString()
        {
            return FichaTecnica();
        }






    }
}
