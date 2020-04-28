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
    public partial class FormUsuario : Form
    {
        Usuario unUsuario;
        
        public FormUsuario()
        {
            InitializeComponent();
        }

        public FormUsuario(Usuario u):this()
        {
            unUsuario = new Usuario(u.Nombre, u.Apellido,u.Domicilio,u.Telefono,u.NombreUsuario,u.Pass);
        }

        private void btnCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            //Contraseña actual correcta
            if (unUsuario.Pass == txtPassActual.Text)
            {
                if (txtNuevaPass.Text == txtConfirmPass.Text)
                {
                    //unUsuario.Pass = txtNuevaPass.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Contraseña Actual Incorrecta. Rintente");
            }
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            lbl_NombreUsuario.Text = "Usuario: " + unUsuario.Nombre;
        }
    }
}
