using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria_GUI
{
    public partial class FormLogin : Form
    {
        FormPrincipal instanciaFormPrincipal;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(texAdmin.Text)) && !(string.IsNullOrEmpty(textContraseña.Text)))
            {
                if (texAdmin.Text == "Admin" && textContraseña.Text == "admin123")
                {
                    lblError.Visible = false;
                    lblError.Text = "";
                    instanciaFormPrincipal = new FormPrincipal();
                    instanciaFormPrincipal.Show();
                    this.Hide();
                }
                else
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
