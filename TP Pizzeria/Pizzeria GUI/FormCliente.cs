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
    public partial class FormCliente : Form
    {
        public Cliente unCliente;

        public FormCliente()
        {
            InitializeComponent();

        }

        public FormCliente(Cliente cli):this()
        {
            unCliente = new Cliente(cli.GetNombre(), cli.GetApellido(), cli.GetDomicilio() );
        }



        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if ( !(String.IsNullOrEmpty(txtNombreAlta.Text)) &&
                 !(String.IsNullOrEmpty(txtApellidoAlta.Text)) &&
                 !(String.IsNullOrEmpty(txtDomicilioAlta.Text)))
            {
                unCliente = new Cliente(this.txtNombreAlta.Text ,this.txtApellidoAlta.Text,this.txtDomicilioAlta.Text);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Todos los datos son obligatorios");
            }
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            if ( !(unCliente is null) )
            {
                txtNombreAlta.Text = unCliente.GetNombre();
                txtApellidoAlta.Text = unCliente.GetApellido();
                txtDomicilioAlta.Text = unCliente.GetDomicilio();

                btnCrearUsuario.Text = "Editar Usuario";
            }
        }
    }
}
