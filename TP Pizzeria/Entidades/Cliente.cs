﻿using System;
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

        public Cliente(string nombre, string apellido) :this(nombre)
        {
            this.apellido = apellido;
        }

        public Cliente(string nombre, string apellido, string domicilio) : this(nombre, apellido)
        {
            this.domicilio = domicilio;
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

        public string MostrarCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.nombre} {this.apellido} {this.domicilio}");
            return sb.ToString();
           // return this.nombre.ToString()+" "+this.apellido.ToString()+" "+this.domicilio.ToString();
        }


    }//
}//
