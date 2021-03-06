﻿using System;
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
        FormUsuario instanciaUsuario;
        FormLogin instanciaLogin;

        List<Cliente> clientes;
        Queue<Pedido> pedidos;
        Usuario unUsuario;


        public FormPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.pedidos = new Queue<Pedido>();
            this.clientes = new List<Cliente>();
            unUsuario = usuario;
        }


        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listClientes.SelectedIndex != -1)
            {
                instanciaFormPedidos = new FormPedidos((Cliente)this.clientes[this.listClientes.SelectedIndex]);
                if (instanciaFormPedidos.ShowDialog() == DialogResult.OK)
                {
                    this.pedidos.Enqueue(instanciaFormPedidos.unPedido);
                    cargarPedidosPendiente();
                }
            }
            else
            {
                MessageBox.Show("Primero seleccione un cliente");
            }
        }

        private void cargarPedidosPendiente()
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

        private void cargarPedidosEntrega()
        {
            DateTime cambiar;

            this.dgEntrega.Rows.Clear();
            foreach (Pedido item in this.pedidos)
            {
                if (!(item is null))
                {
                    //if ( (item.horaIngreso ) >= (cambiar.))
                    //{
                    //    this.dgEntrega.Rows.Add(item.MostrarPedido());
                    //}
                    
                }
            }
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instanciaCliente = new FormCliente();
            if (instanciaCliente.ShowDialog() == DialogResult.OK)
            {
                this.clientes.Add(instanciaCliente.unCliente);
                //this.listClientes.Items.Add(instanciaCliente.unCliente);
                cargarClientes();
            }
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listClientes.SelectedIndex != -1)
            {
                instanciaCliente = new FormCliente((Cliente)this.clientes[this.listClientes.SelectedIndex]);
                if (instanciaCliente.ShowDialog() == DialogResult.OK)
                {
                    //this.clientes.Remove((Cliente)this.clientes[this.listClientes.SelectedIndex]);
                    //this.clientes.Add(instanciaCliente.unCliente);
                    //this.listClientes.Items.Add(instanciaCliente.unCliente);
                    cargarClientes();
                }
            }
            else
            {
                MessageBox.Show("Seleccione el Cliente que desea editar");
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_HoraActual.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;

            lb_FPUsuario.Text = "Bienvenido" + unUsuario.NombreUsuario;
        }

        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crear nueva instancia de formulario Usuario
            instanciaUsuario = new FormUsuario(unUsuario);
            if (instanciaUsuario.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se modificó la Contraseña");
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Desea Cerrar?", "Cerrar Sesion", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                instanciaLogin = new FormLogin();
                instanciaLogin.Show();
            }
        }





    }//
}//
