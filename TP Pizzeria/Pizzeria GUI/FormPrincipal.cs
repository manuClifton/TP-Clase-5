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

        ///&Pedido unPedido;
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

            this.dgPendientes.Rows.Clear();
            foreach (Pedido item in this.pedidos)
            {
                if (!(item is null))
                {
                    this.dgPendientes.Rows.Add(item.MostrarPedido());
                }
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
                if (!(item is null))
                {
                    listClientes.Items.Add(item.MostrarCliente());
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_HoraActual.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (this.listClientes.SelectedIndex != -1)
            {
                instanciaCliente = new FormCliente((Cliente)this.clientes[this.listClientes.SelectedIndex]);
                if (instanciaCliente.ShowDialog() == DialogResult.OK)
                {
                    this.clientes.Remove((Cliente)this.clientes[this.listClientes.SelectedIndex]);
                    this.clientes.Add(instanciaCliente.unCliente);
                    //this.listClientes.Items.Add(instanciaCliente.unCliente);
                    cargarClientes();
                }
            }
            else
            {
                MessageBox.Show("Seleccione el Cliente que desea editar");
            }
        }
    }//
}//
