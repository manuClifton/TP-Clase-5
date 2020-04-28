using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {

        public Cliente(string nombre, string apellido, string domicilio, string telefono)
            :base(nombre, apellido, domicilio, telefono)
        {

        }



        public string MostrarCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Nombre} {this.Apellido} {this.Domicilio} {this.Telefono}");
            return sb.ToString();
        }


    }//
}//
