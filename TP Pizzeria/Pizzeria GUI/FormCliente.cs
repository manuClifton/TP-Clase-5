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
    }
}
