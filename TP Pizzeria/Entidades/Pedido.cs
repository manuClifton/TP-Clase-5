using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public bool envio;
        public DateTime horaIngreso;
        public DateTime horaRetira;
        public Pizza[] pizzas;
        private Cliente client;


        //public Pizza this[indice]
        //{

        //}

        private Pedido(Cliente cli)
        {
            this.client = cli;
            this.pizzas = new Pizza[8];
        }



        public static implicit operator Pedido(Cliente c)
         {
            return new Pedido(c);
         }


        public static bool operator +(Pedido e, Pizza p)
        {
           

            for (int i = 0; i < e.pizzas.Length; i++)
            {
                if (e.pizzas[i] + p)
                {
                    return true;
                }
            }

            for (int i = 0; i < e.pizzas.Length; i++)
            {
                 if (e.pizzas[i] is null)
                  {
                    e.pizzas[i] = p;
                    return true;
                  }         
            }

            return false;
        }

        public static bool operator -(Pedido e, Pizza p)
        {

            for (int i = 0; i < e.pizzas.Length; i++)
            {
                if ( !(e.pizzas[i] is null) && e.pizzas[i] == p )
                {
                    e.pizzas[i] = null;
                    return true;
                }
            }

            return false;
        }


        public string MostrarPedido()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.horaIngreso.ToString("hh:mm")} {this.client.GetNombre()} {this.GetGusto()} ");
            return sb.ToString();
        }


        public string GetGusto()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Pizza item in this.pizzas)
            {
                if (!(item is null))
                {
                    sb.Append($"{item.GetGusto()}({item.GetCantidadPizzas()})");

                }

            }
            return sb.ToString();

        }









    }//
}//
