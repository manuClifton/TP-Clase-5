using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EPuesto
    {
        Cocina, Delibery, AtencionPublico
    }


    public class Usuario : Persona
    {

        private string nombreUsuario;
        private string pass;
        private string legajo;
        private EPuesto puesto;

        public Usuario(string nombre, string apellido, string domicilio, string telefono, string nombreUsuario, string pass, string legajo, EPuesto puesto)
             : this(nombre,apellido, domicilio, telefono, nombreUsuario,pass)
        {

            this.legajo = legajo;
            this.puesto = puesto;
        }
        public Usuario(string nombre, string apellido, string domicilio, string telefono,string nombreUsuario, string pass) : base(nombre, apellido, domicilio, telefono)
        {
            this.nombreUsuario = nombreUsuario;
            this.pass = pass;
        }


        public string NombreUsuario
        {
            get { return this.nombreUsuario; }
            set { this.nombreUsuario = value; }
        }
        public string Pass
        {
            get { return this.pass; }
            set { this.pass = value; }
        }

        public string Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        public EPuesto Puesto
        {
            get { return this.puesto; }
            set { this.puesto = value; }
        }

        public static bool operator ==(Usuario uno, Usuario dos)
        {
            if ( !(uno is null) )
            {
                return (uno.NombreUsuario == dos.NombreUsuario && uno.pass == dos.pass);
            }
            return false;
        }

        public static bool operator !=(Usuario uno, Usuario dos)
        {

            return !(uno == dos);
        }







    }//
}//
