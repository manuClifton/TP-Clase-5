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

        public string Gusto
        {
            get
            {
                return this.gusto;
            }
            set
            {
                this.gusto = value;
            }
        }

        public string TipoCoccion
        {
            get
            {
                return this.tipoCoccion;
            }
            set
            {
                this.tipoCoccion = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return this.cantidad.ToString();
            }
            set
            {
                this.gusto = value;
            }
        }

        public string MostrarPizza()
        {
            return this.Gusto + this.TipoCoccion + this.Cantidad;
        }

        //public string GetGusto() {
        //    return this.gusto;
        //}
        //public string GetTipoCoccion()
        //{
        //    return this.tipoCoccion;
        //}
        //public string GetCantidadPizzas()
        //{
        //    return this.cantidad.ToString();
        //}

        //public string MostrarPizza()
        //{
        //    return GetGusto() + GetTipoCoccion() + GetCantidadPizzas();
        //}


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

            if ( !(a is null) )
            {
                return (a.gusto == b.gusto && a.tipoCoccion == b.tipoCoccion);
            }

            return false;
        }


        public static bool operator !=(Pizza a, Pizza b)
        {

            return !( a == b);
        }

        


    }//
}//

