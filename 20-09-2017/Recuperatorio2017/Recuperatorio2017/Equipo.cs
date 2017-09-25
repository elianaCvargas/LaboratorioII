using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2017
{
    enum Deportes { 
        
    }
    class Equipo
    {
        private Deportes deporte;
        private DirectorTecnico dt;
        List<Jugador> jugadores = new List<Jugador>();
        private string nombre;

        public Deportes Deporte {
            set { this.Deporte = value;  }
        }





    }
}
