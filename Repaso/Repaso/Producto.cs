using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto( string marca, string codigoBarra, float precio)
        {
            this.codigoDeBarra = codigoBarra;
            this.marca = marca;
            this.precio = precio;
        }

        //public string GetMarca
        //{ get { return this.marca; } }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        //public float  GetPrecio
        //{ get { return this.precio; } }

        public static string MostrarProducto(Producto p) 
        {
            return String.Format("Codigo de Barra: {0}\n Marca: {1}\n Precio: {2}\n", p.codigoDeBarra, p.marca, p.precio);
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator !=(Producto p, string marca)
        {
            if (p.marca == marca)
                return true;
            return false;
        }

        public static bool operator ==(Producto p, string marca)
        {
            return !(p.marca != marca);
        }

        public static bool operator ==(Producto p1, Producto p2 )
        {
            if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                return true;
            return false;                           
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
        }





        
    }
}
