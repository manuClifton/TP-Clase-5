using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Entidades;

namespace Pizzeria_GUI
{
    public partial class FormPedidos : Form
    {
        public Pedido unPedido;



        public FormPedidos(Cliente unCliente)
        {
            InitializeComponent();
            unPedido = unCliente;
        }



        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {

            // Validar
            if (this.listPizzas.SelectedIndex != -1)
            {
               this.unPedido.horaIngreso = DateTime.Now;
               this.unPedido.envio = checkEnvio.Checked;

               this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Complete los datos que faltan");
            }
            
        }

        private void btnAgregarPizza_Click(object sender, EventArgs e)
        {
            if ( !(String.IsNullOrEmpty(cmbGusto.Text)) &&
                 !(String.IsNullOrEmpty(cmbCoccion.Text)) &&
                 numCantidad.Value != 0  )
            {
                if (this.unPedido + new Pizza(this.numCantidad.Value,this.cmbGusto.Text,this.cmbCoccion.Text))
                {
                    CargarPizzas();
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos");
            }
        }

        private void CargarPizzas()
        {
            this.listPizzas.Items.Clear();

            foreach (Pizza item in unPedido.pizzas)
            {
                this.listPizzas.Items.Add(item.MostrarPizza());
            }

        }






    }//
}//
