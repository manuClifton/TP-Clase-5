using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pizza
    {
        private decimal cantidad;
        private string gusto;
        private string tipoCoccion;

        public Pizza(decimal cantidad, string gusto, string tipoCoccion)
        {
            this.cantidad = cantidad;
            this.gusto = gusto;
            this.tipoCoccion = tipoCoccion;
        }

        public string GetGusto() {
            return this.gusto;
        }
        public string GetTipoCoccion()
        {
            return this.tipoCoccion;
        }
        public string GetCantidadPizzas()
        {
            return this.cantidad.ToString();
        }

        public string MostrarPizza()
        {
            return "Gusto: "+GetGusto() + " Cocion:s " + GetTipoCoccion() + " Cantidad: " + GetCantidadPizzas();
        }

        public static bool operator +(Pizza uno, Pizza dos)
        {
            bool agrego = false;

            if (uno == dos)
            {
                //uno.cantidad = uno.cantidad + dos.cantidad;
                uno.cantidad += dos.cantidad;
                agrego = true;
            }
            return agrego;
        }

        public static bool operator ==(Pizza a, Pizza b)
        {
            //bool igual = false;
            //if (a != null && a.gusto == b.gusto && a.tipoCoccion == b.tipoCoccion)
            //{
            //    igual = true;
            //}
            //return igual;
            return (a.gusto == b.gusto && a.tipoCoccion == b.tipoCoccion);
        }


        public static bool operator !=(Pizza a, Pizza b)
        {
            //bool igual = true;
            //if (a != null && a.gusto == b.gusto && a.tipoCoccion == b.tipoCoccion)
            //{
            //    igual = false;
            //}
            //return igual;
            return !( a.gusto == b.gusto && a.tipoCoccion == b.tipoCoccion);
        }

        


    }//
}//

