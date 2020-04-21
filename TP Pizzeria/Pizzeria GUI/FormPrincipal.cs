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
    public partial class FormPrincipal : Form
    {
        FormPedidos instanciaFormPedidos;
        FormCliente instanciaCliente;

        Pedido unPedido;
        List<Cliente> clientes;
        Queue<Pedido> pedidos;


        public FormPrincipal()
        {
            InitializeComponent();
            this.pedidos = new Queue<Pedido>();
            this.clientes = new List<Cliente>();
        }




         private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            if (this.listClientes.SelectedIndex != -1)
            {
                instanciaFormPedidos = new FormPedidos((Cliente)this.clientes[this.listClientes.SelectedIndex]);
                if (instanciaFormPedidos.ShowDialog() == DialogResult.OK)
                {
                    this.pedidos.Enqueue(instanciaFormPedidos.unPedido);
                    cargarPedidos();
                }
            }
            else
            {
                MessageBox.Show("Primero seleccione un cliente");
            }
            
        }

        private void cargarPedidos()
        {
            foreach (Pedido item in this.pedidos)
            {
                this.dgPendientes.Rows.Add(item.MostrarPedido());
            }
        }

        //private void CargarTabla()
        //{
        //    dgPendientes.Rows.Clear();
        //    int fila = 0;
        //    foreach (Pizza pizzaAux in unPedido.RetornarArrayPizzas())
        //    {
        //        if (!(pizzaAux is null))
        //        {
        //            fila = dgPendientes.Rows.Add();
        //            dgPendientes.Rows[fila].Cells[0].Value = pizzaAux.GetGusto();
        //            dgPendientes.Rows[fila].Cells[1].Value = pizzaAux.GetTipoCoccion();
        //            dgPendientes.Rows[fila].Cells[2].Value = pizzaAux.GetCantidadPizzas();
        //        }
        //    }
        //}



        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            instanciaCliente = new FormCliente();
            if (instanciaCliente.ShowDialog() == DialogResult.OK)
            {
                this.clientes.Add(instanciaCliente.unCliente);
                //this.listClientes.Items.Add(instanciaCliente.unCliente);
                cargarClientes();
            }
        }


        private void cargarClientes()
        {
            listClientes.Items.Clear();
            foreach (Cliente item in this.clientes)
            {
                listClientes.Items.Add(item.MostrarCliente());
            }
        }






    }//
}//
