using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Pizzeria_GUI
{
    public partial class FormLogin : Form
    {
        FormPrincipal instanciaFormPrincipal;

        public List<Usuario> usuarios;
        public Usuario usuario;

        public FormLogin()
        {
            InitializeComponent();
            //this.texAdmin.Text = "Admin";
            //this.textContraseña.Text = "admin123";
            usuarios = new List<Usuario>();

            usuario = new Usuario("Manuel", "Clifton", "San Juan 39", "1160313333", "Manu", "123", "1", EPuesto.AtencionPublico);
            usuarios.Add(usuario);
        }


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            bool esta = false;
            if (!(string.IsNullOrEmpty(txtUsuario.Text)) && !(string.IsNullOrEmpty(textContraseña.Text)))
            {
                for (int i = 0; i < usuarios.Count; i++)
                {
                    if(usuarios[i].NombreUsuario == txtUsuario.Text && usuarios[i].Pass == textContraseña.Text)
                    {
                        lblError.Visible = false;
                        lblError.Text = "";
                        instanciaFormPrincipal = new FormPrincipal(usuarios[i]);
                        instanciaFormPrincipal.Show();
                        this.Hide();
                        esta = true;
                        break;
                    }
                }
 
                if (!(esta))
                {
                    lblError.Visible = true;
                    lblError.Text = "Acceso denegado. Almenos uno de los datos es incorrecto";
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Campos no pueden ser vacios";
            }
        }






    }//
}//
