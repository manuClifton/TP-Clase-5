using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Entidades;

namespace Pizzeria_GUI
{
    public enum Gustos
    {
        Muzzarela,
        Fugaceta,
        Calabresa,
        Especial,
        Anana,
        Napolitana
    }

    public enum Coccion
    {
        A_la_Piedra = 1,
        Media_Mazza 
    }

    public partial class FormPedidos : Form
    {
        public Pedido unPedido;
        public Pizza unaPizza;

        int cantidadPizzas = 0;

        public FormPedidos(Cliente unCliente)
        {
            InitializeComponent();
            unPedido = unCliente;
        }



        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {

            // Validar
            if (this.unPedido.pizzas.Length != 0)
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
                unaPizza = new Pizza(this.numCantidad.Value, this.cmbGusto.Text, this.cmbCoccion.Text);
                cantidadPizzas += int.Parse(unaPizza.Cantidad);
                if (cantidadPizzas <= 8 && this.unPedido + unaPizza  )
                {

                     CargarPizzas();
                }
                else
                {
                    MessageBox.Show("Maximo de Pizzas por pedido es 8");
                    cantidadPizzas -= int.Parse(unaPizza.Cantidad);
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
                if ( !(item is null) )
                {
                    this.listPizzas.Items.Add(item.MostrarPizza());
                }
            }

        }

        private void listPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listPizzas.Items.Remove(listPizzas.SelectedIndex);
            //sacar la pizza del pedido
            if (this.unPedido - unaPizza)
            {
                CargarPizzas();
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            cmbGusto.DataSource = Enum.GetNames(typeof (Gustos));
            cmbCoccion.DataSource = Enum.GetNames(typeof (Coccion));
        }
    }//
}//
