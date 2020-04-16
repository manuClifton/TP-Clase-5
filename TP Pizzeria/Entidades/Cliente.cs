using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string apellido;
        private string domicilio;
        private string nombre;

        public Cliente()
        {
            this.nombre = "Sin datos";
            this.domicilio = "Sin datos";
            this.apellido = "Sin datos";
        }

        public Cliente(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Cliente(string nombre, string domicilio):this(nombre)
        {
            this.domicilio = domicilio;
        }

        public Cliente(string nombre, string domicilio,string apellido) : this(nombre, domicilio)
        {
            this.apellido = apellido;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetDireccion(string domicilio)
        {
            this.domicilio = domicilio;
        }
        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }


    }//
}//
