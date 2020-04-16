using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;

namespace Pizzeria_GUI
{
    public partial class FormPedidos : Form
    {
        FormPrincipal instanciaFormPrincipal;
        FormPedidos instanciaFormPedidos;

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

        //private void btnCargar_Click(object sender, EventArgs e)
        //{
        //    if (!(string.IsNullOrEmpty(comboBoxSelecClient.Text)) && !(string.IsNullOrEmpty(comboBoxTipoPizza.Text)) 
        //        && !(string.IsNullOrEmpty(numericUpDownCantidad.Text))
        //        && !(string.IsNullOrEmpty(checkedListBoxCoccion.Text)) && !(string.IsNullOrEmpty(checkSiNo.Text)))
        //    {
        //         if (checkSiNo.Visible == true && contadorCLICK == 0)
        //         {
        //            unCliente = new Cliente();
        //            instanciaFormPedidos = new FormPedidos(unCliente);
        //            instanciaFormPedidos.Show();
        //            this.Hide();
        //            DateTime horaIngreso = DateTime.Now;
        //             DateTime retiro = DateTime.Now.AddMinutes(30);
        //             unCliente.SetNombre(comboBoxSelecClient.Items.ToString());
        //             unaPizza = new Pizza(Convert.ToDecimal(numericUpDownCantidad.Text), comboBoxTipoPizza.Text, checkedListBoxCoccion.Text);
        //             if (unPedido + unaPizza)
        //             {
        //                 unPedido = unCliente;
        //                 unPedido = new Pedido(unCliente, Convert.ToBoolean(checkSiNo.Text), horaIngreso, retiro);
        //                 comboBoxTipoPizza.Text = "";
        //                 numericUpDownCantidad.Text = "";
        //                 checkedListBoxCoccion.Text = "";
        //                 checkSiNo.Visible = false;
        //                 lblPedidoError.Text = "";
        //                 contadorCLICK++;
        //             }
        //             else
        //             {
        //                 lblPedidoError.Text = "Sucecio un Error";
        //             }
        //         }
        //         else if (checkSiNo.Visible == false && contadorCLICK > 0 && contadorCLICK < 8)
        //         {

        //             if (!(string.IsNullOrEmpty(comboBoxTipoPizza.Text))
        //                 && !(string.IsNullOrEmpty(numericUpDownCantidad.Text))
        //                 && !(string.IsNullOrEmpty(checkedListBoxCoccion.Text)))
        //             {
        //                 unaPizza = new Pizza(Convert.ToDecimal(numericUpDownCantidad.Text), comboBoxTipoPizza.Text, checkedListBoxCoccion.Text);
        //                 if (unPedido + unaPizza)
        //                 {
        //                     comboBoxTipoPizza.Text = "";
        //                     numericUpDownCantidad.Text = "";
        //                     checkedListBoxCoccion.Text = "";
        //                     lblPedidoError.Text = "";
        //                     listBoxPedidos.Items.Add(unaPizza);
        //                     contadorCLICK++;
        //                 }
        //                 else
        //                 {
        //                     lblPedidoError.Text = "No hay lugar";
        //                 }
        //             }
        //         }else if (contadorCLICK == 8)
        //        {
        //            lblPedidoError.Text = "YA COMPLETO EL MAXIMO DE PEDIDOS";
        //        }
                
                
        //    }
        //    else
        //    {
        //        lblPedidoError.ForeColor = Color.DarkRed;
        //        lblPedidoError.Text = "DATOS INVALIDOS, CARGA TODO";
        //        lblPedidoError.Visible = true;
        //    }
        //}//fin Click

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            instanciaFormPrincipal = new FormPrincipal(unCliente);
            this.Show();
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
                        if (unPedido + unaPizza)
                        {
                            comboBoxTipoPizza.Text = "";
                            numericUpDownCantidad.Text = "";
                            checkedListBoxCoccion.Text = "";
                            lblPedidoError.Text = "";
                            listBoxPedidos.Items.Add(unaPizza);
                            contadorCLICK++;
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
                            listBoxPedidos.Items.Add(unaPizza);
                            contadorCLICK++;
                        }
                    }
                }else if (unCliente != null && !string.IsNullOrEmpty(comboBoxTipoPizza.Text)
                            && !string.IsNullOrEmpty(numericUpDownCantidad.Text)
                            && !(string.IsNullOrEmpty(checkSiNo.Text)) && contadorCLICK == 8)
                {
                        lblPedidoError.Text = "Alcanzo el Maximo de Pizzas.";
                }
                else
                    {
                        lblPedidoError.Text = "Faltan Datos del Pedido";
                    }
            }
            else
            {
                lblPedidoError.Text = "Faltan Datos del Cliente";
            }


            
        }
    }//
}//
