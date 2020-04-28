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
            unCliente = new Cliente(cli.Nombre, cli.Apellido, cli.Domicilio, cli.Telefono );
        }



        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if ( !(String.IsNullOrEmpty(txtNombreAlta.Text)) &&
                 !(String.IsNullOrEmpty(txtApellidoAlta.Text)) &&
                 !(String.IsNullOrEmpty(txtDomicilioAlta.Text)) &&
                 !(String.IsNullOrEmpty(txtTelefonoAlta.Text))
                 )
            {
                if(unCliente is null)
                {
                    unCliente = new Cliente(this.txtNombreAlta.Text, this.txtApellidoAlta.Text, this.txtDomicilioAlta.Text,
                   this.txtTelefonoAlta.Text);

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    unCliente.Nombre = txtNombreAlta.Text;
                    unCliente.Apellido = txtApellidoAlta.Text;
                    unCliente.Domicilio = txtDomicilioAlta.Text;
                    unCliente.Telefono = txtTelefonoAlta.Text;
                    this.DialogResult = DialogResult.OK;
                }
               
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
                txtNombreAlta.Text = unCliente.Nombre;
                txtApellidoAlta.Text = unCliente.Apellido;
                txtDomicilioAlta.Text = unCliente.Domicilio;
                txtTelefonoAlta.Text = unCliente.Telefono;

                btnCrearUsuario.Text = "Editar Usuario";
            }
        }
    }
}
