using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string marca;
        private float precio;
        private string codigoDeBarra;

        public Producto(string marca, string codigoBarra, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigoDeBarra = codigoBarra;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public string MostrarProducto(Producto prod)
        {
            string retorno = " ";
            string marca = prod.marca;
            string precio = Convert.ToString(prod.precio);
            string codBarra = prod.codigoDeBarra;

            retorno = "Marca: " + marca +" - " + "Precio: " + precio + " - " + "Codigo de Barra: " + codBarra;

            return retorno; 

            //Console.WriteLine("Datos del producto:\n1.Marca: {0}\n2.Precio: {1}\n3.Condigo de Barra: {2}", prod.marca, prod.precio, prod.codigoDeBarra);
        }

        public static bool operator ==(Producto a, Producto b)
        {
            bool retorno = false;
            if ((string)a.codigoDeBarra == (string)b.codigoDeBarra)
            {
                if ((string)a.marca == (string)b.marca)
                { 
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Producto a, Producto b)
        {
            bool retorno = false;
            if ((string)a.codigoDeBarra != (string)b.codigoDeBarra)
            {
                if ((string)a.marca != (string)b.marca)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator ==(Producto a, String b)
        {
            bool retorno = false;
            if ((string)a.marca == b)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Producto a, String b)
        {
            bool retorno = false;
            if ((string)a.marca != b)
            {
                retorno = true;
            }
            return retorno;
        }

        public static explicit operator string(Producto a)
        {
            return a.codigoDeBarra;
        }

        

       



    }
}
