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
        FormPrincipal instanciaFormPrincipal;

        FormPedidos instanciaFormPedidos;

        Pedido unPedido;
        Pedido[] pedidos;


        public FormPrincipal()
        {
            InitializeComponent();
        }



        public FormPrincipal(Cliente unCliente) :this()
        {
            unPedido = unCliente;
        }




        //private void agregarAutoToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    instanciaFormPedidos = new FormPedidos()
        //    frm_auto.ShowDialog();
        //    //this.Hide();

        //    if (frm_auto.DialogResult == DialogResult.OK)
        //    {
        //        MessageBox.Show("El auto fue agregado satisfactoriamente",
        //                                     "Confirmacion",
        //                                     MessageBoxButtons.OK,
        //                                     MessageBoxIcon.Information);
        //    }
        //    else if (frm_auto.DialogResult == DialogResult.No)
        //    {

        //        MessageBox.Show("Error. El auto ya existe. \nCompruebe los datos e intente nuevamente",
        //                        "ERROR",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //    }
        //    else if (frm_auto.DialogResult == DialogResult.Abort)
        //    {
        //        MessageBox.Show("Error. No hay más espacio disponible en el estacionamiento",
        //                                "ERROR",
        //                                MessageBoxButtons.OK,
        //                                MessageBoxIcon.Warning);
        //    }
        //    this.CargarTabla();
        //}


         private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            instanciaFormPedidos = new FormPedidos();
            instanciaFormPedidos.Show();
            this.Hide();
        }



        private void CargarTabla()
        {
            dataGrid_ListaPedidos.Rows.Clear();
            int fila = 0;
            foreach (Pizza pizzaAux in unPedido.RetornarArrayPizzas())
            {
                if (!(pizzaAux is null))
                {
                    fila = dataGrid_ListaPedidos.Rows.Add();
                    dataGrid_ListaPedidos.Rows[fila].Cells[0].Value = pizzaAux.GetGusto();
                    dataGrid_ListaPedidos.Rows[fila].Cells[1].Value = pizzaAux.GetTipoCoccion();
                    dataGrid_ListaPedidos.Rows[fila].Cells[2].Value = pizzaAux.GetCantidadPizzas();
                }
            }
        }

      
    }
}
