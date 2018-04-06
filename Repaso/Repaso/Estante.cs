using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        
        private Producto[] listaProductos;
        private int ubicacionEstante;

        public Estante(int capacidad)
            
        {
            listaProductos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion)
            :this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProducto {
            get { return this.listaProductos; } 
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            for(int i =0; i< e.listaProductos.Length; i++)
            {
              sb.Append(   Producto.MostrarProducto(e.listaProductos[i]));
            }
            return String.Format("Estante ubicacion: {0}\n Producto: {1}\n", e.ubicacionEstante, sb.ToString());
        }

        public static bool operator !=(Producto p, Estante e)
        {
            bool retorno = false;
            for (int i = 0; i < e.listaProductos.Length; i++)
            {
                if (!(Object.ReferenceEquals(e.listaProductos[i], null)))
                {
                    if (p != e.listaProductos[i])
                        retorno = true;
                    return retorno = false;
                }
                
            }
            return retorno;

        }

        public static bool operator ==(Producto p, Estante e)
        { 
            return !(p != e);
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            for (int i = 0; i < e.listaProductos.Length; i++)
            {
                if (Object.ReferenceEquals(e.listaProductos[i], null) && p != e)
                {
                    e.listaProductos[i] = p;
                    retorno = true;
                }
                retorno = false;
            }
            return retorno;
        }

        public static bool operator -(Estante e, Producto p)
        { 
            return !(e + p);
        }


    }
}
