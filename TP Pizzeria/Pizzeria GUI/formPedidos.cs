using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;

namespace Pizzeria_GUI
{
    public partial class FormPedidos : Form
    {
        FormPrincipal instanciaFormPrincipal;

        Pedido unPedido;

        Cliente unCliente;

        Pizza unaPizza;

        int contadorCLICK = 0;

        public FormPedidos()
        {
            InitializeComponent();
        }

        public FormPedidos(Cliente unCliente) :this()
        {
            unCliente = new Cliente();
        }


        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            instanciaFormPrincipal = new FormPrincipal(unCliente);
            instanciaFormPrincipal.Show();
            this.Hide();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            if ( !(string.IsNullOrEmpty(textPedido_Nombre.Text))
                && !(string.IsNullOrEmpty(textPedido_Apellido.Text))
                && !(string.IsNullOrEmpty(textPedido_Domicilio.Text)) )
            {
                if (unCliente == null)
                {
                    unCliente = new Cliente(textPedido_Nombre.Text, textPedido_Domicilio.Text, textPedido_Apellido.Text);
                }
               
                if (unCliente != null && !string.IsNullOrEmpty(comboBoxTipoPizza.Text)
                    && !string.IsNullOrEmpty(numericUpDownCantidad.Text)
                    && !(string.IsNullOrEmpty(checkSiNo.Text))  && contadorCLICK < 8)
                {
                    if (unPedido ==  null)
                    {
                        unaPizza = new Pizza(Convert.ToDecimal(numericUpDownCantidad.Text), comboBoxTipoPizza.Text, checkedListBoxCoccion.Text);
                        unPedido = new Pedido(unCliente, checkSiNo.CheckOnClick, DateTime.Now, DateTime.Now.AddMinutes(25));
                        if (unPedido + unaPizza == true)
                        {
                            comboBoxTipoPizza.Text = "";
                            numericUpDownCantidad.Text = "";
                            checkedListBoxCoccion.Text = "";
                            checkSiNo.Visible = false;
                            lblPedidoError.Text = "";
                            lblPedidoError.Visible = false;
                            listBoxPedidos.Items.Add(unaPizza);
                            contadorCLICK++;
                        }
                        else
                        {
                            lblPedidoError.Text = "Error al sumar";
                        }
                    }
                    else
                    {
                        unaPizza = new Pizza(Convert.ToDecimal(numericUpDownCantidad.Text), comboBoxTipoPizza.Text, checkedListBoxCoccion.Text);
                        if (unPedido + unaPizza)
                        {
                            comboBoxTipoPizza.Text = "";
                            numericUpDownCantidad.Text = "";
                            checkedListBoxCoccion.Text = "";
                            lblPedidoError.Text = "";
                            lblPedidoError.Visible = false;
                            listBoxPedidos.Items.Add(unaPizza);
                            contadorCLICK++;
                        }
                    }
                }else if (unCliente != null && !string.IsNullOrEmpty(comboBoxTipoPizza.Text)
                            && !string.IsNullOrEmpty(numericUpDownCantidad.Text)
                            && !(string.IsNullOrEmpty(checkSiNo.Text)) && contadorCLICK == 8)
                {
                        lblPedidoError.Text = "Alcanzo el Maximo de Pizzas.";
                    lblPedidoError.Visible = true;
                }
                else
                    {
                        lblPedidoError.Text = "Faltan Datos del Pedido";
                    lblPedidoError.Visible = true;
                }
            }
            else
            {
                lblPedidoError.Text = "Faltan Datos del Cliente";
                lblPedidoError.Visible = true;
            }


            
        }
    }//
}//
