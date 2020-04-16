using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        private bool envio;
        private DateTime horaIngreso;
        private DateTime horaRetira;
        private Pizza[] pizzas;
        private Cliente client;


        private Pedido(Cliente cli)
        {
            this.client = cli;
            this.pizzas = new Pizza[8];
        }

        public Pedido(Cliente cli, bool envio, DateTime ingreso, DateTime retiro):this(cli)
        {
            this.envio = envio;
            this.horaIngreso = ingreso;
            this.horaRetira = retiro;
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
                    break;
                  }         
            }

            return false;
        }



        public Pizza[] RetornarArrayPizzas()
        {
            return this.pizzas;
        }









    }//
}//
