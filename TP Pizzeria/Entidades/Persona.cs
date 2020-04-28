using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;

        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.domicilio = "";
            this.telefono = "";
        }
        public Persona(string nombre, string apellido, string domicilio, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Domicilio
        {
            get { return this.domicilio; }
            set { this.domicilio = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }











    }//
}//
