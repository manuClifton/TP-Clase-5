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

        public string MostrarPedido()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.client} {this.horaIngreso} {this.RetornarArrayPizzas()}");
            return sb.ToString();
        }


        public Pizza[] RetornarArrayPizzas()
        {
            return this.pizzas;
        }









    }//
}//
