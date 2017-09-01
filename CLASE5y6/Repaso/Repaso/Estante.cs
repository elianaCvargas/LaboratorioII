using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
     
        private int ubicacionEstante;
        private Producto[] arrProductos;

        private Estante(int capacidad)
        {
            this.arrProductos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
           
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProducto()//devuelve todos los productos
        {
           
            return this.arrProductos; 
        }

        public  static string MostrarEstante(Estante obj)
        {
           

            string retorno = "";

            string ubicacion = Convert.ToString(obj.ubicacionEstante);

            retorno = "Estante: " + ubicacion + "\n";

            foreach(Producto element  in obj.arrProductos)
            {
                retorno = element.MostrarProducto(element);
            }

            return retorno;
         
        }

        public static bool operator ==(Producto prod, Estante est)
        {
            bool retorno = false;
            foreach (Producto element in est.arrProductos)
            {

                if (!Object.ReferenceEquals(element , null) && prod == element)
                {
                    
                    retorno = true;
                    break;
                }
                else {
                    retorno = false;
                }
            }
            return retorno;
        }

        public static bool operator !=(Producto prod, Estante est)
        {
            bool retorno = false;
            foreach (Producto element in est.arrProductos)
            {
                if (prod != element)
                {
                    retorno = true;
                    break;
                }
                else
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        public static bool operator +(Estante est, Producto prod)
        {
            bool retorno = false;
            int i;
            for (i = 0; i < est.arrProductos.Length; i++)
            {
                if (Object.ReferenceEquals(est.arrProductos[i], null))//devuelve true cuando  el  objeto esta vacio.
                {
                    if (prod == est)//si  el producto esta en el estante
                    {
                        return retorno;
                    }
                    else
                    {
                        est.arrProductos[i] = prod;
                        retorno = true;
                        return retorno;
                    }
                    
                }
            }   
            return retorno;
        }

        public static Estante operator -(Producto prod, Estante est)
        {
            //Estante retorno =  null;
            int i;
            for (i = 0; i < est.arrProductos.Length; i++)
            { 
                if (prod == est)
                {
                    est.arrProductos[i] = null;
                    return est;
                }
            }
            return est;
        }






    }
}
